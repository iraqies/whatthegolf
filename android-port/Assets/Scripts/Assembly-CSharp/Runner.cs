using System;
using System.Collections.Generic;
using Cinemachine;
using UnityEngine;

public class Runner : MonoBehaviour, IMovingKinematicTarget
{
	public enum RunDirection
	{
		Forward = 1,
		Backward = -1
	}

	public enum TrackLoopType
	{
		Loop = 0,
		PingPong = 1,
		Stop = 2
	}

	public enum RunnerState
	{
		Idle = 0,
		Running = 1,
		Turning = 2,
		Ragdoll = 3
	}

	[SerializeField]
	private bool addRunVelocityOnCollapse;

	[SerializeField]
	private LayerMask unbalanceCollisionLayerMask = -1;

	[SerializeField]
	private float unbalanceVelocitySqrMag = 2f;

	[SerializeField]
	private float incomingForceMultiplier = 1f;

	[SerializeField]
	private bool teleportToOppositeOnLoop;

	[SerializeField]
	private TrackLoopType trackLoopType;

	[SerializeField]
	private RunnerState state = RunnerState.Running;

	[SerializeField]
	private RunDirection runDirection = RunDirection.Forward;

	[SerializeField]
	private float speed = 5f;

	[SerializeField]
	private float turnDegreesPerSecond = 360f;

	[SerializeField]
	private float startOffset;

	[SerializeField]
	private Vector3 laneOffset;

	[SerializeField]
	private Rigidbody root;

	[SerializeField]
	private Rigidbody collisionDetection;

	[SerializeField]
	private List<Rigidbody> blackListRigidbodies;

	[SerializeField]
	private Animator animator;

	[SerializeField]
	private CinemachineSmoothPath path;

	[SerializeField]
	private bool placeAtOffset;

	[SerializeField]
	private bool drawTangent;

	private float rawDistance;

	private float standardDistance;

	private bool didTeleport;

	private Rigidbody runnerRigidbody;

	private List<Rigidbody> limbs;

	private Collider mainCollider;

	private RunDirection lastRunDirection;

	private RunnerState prevState;

	public Action<RunnerState> OnChangeState;

	private Vector3 forward;

	private Vector3 right;

	private Vector3 up;

	private Vector3 splinePosition;

	private Vector3 splineTangent;

	private Quaternion splineOrientation;

	public Rigidbody Root => root;

	public List<Rigidbody> Limbs => limbs;

	public Vector3 Position => runnerRigidbody != null ? runnerRigidbody.position : transform.position;

	public Vector3 Velocity { get; private set; }

	private void Awake()
	{
		runnerRigidbody = GetComponent<Rigidbody>();
		mainCollider = GetComponent<Collider>();
		limbs = new List<Rigidbody>();
		if (root != null)
		{
			Rigidbody[] childRigids = root.GetComponentsInChildren<Rigidbody>();
			for (int i = 0; i < childRigids.Length; i++)
			{
				if (childRigids[i] != runnerRigidbody && (blackListRigidbodies == null || !blackListRigidbodies.Contains(childRigids[i])))
				{
					limbs.Add(childRigids[i]);
				}
			}
		}
		RagdollSetActiveStatus(false);
		rawDistance = NormalizedToTrack(startOffset);
		SetPositions(rawDistance);
		if (runnerRigidbody != null)
		{
			runnerRigidbody.position = GetRunnerPosition();
			runnerRigidbody.rotation = GetRunnerRotation();
		}
	}

	private float NormalizedToTrack(float t)
	{
		if (path == null)
		{
			return t;
		}
		return Mathf.Clamp01(t) * path.PathLength;
	}

	private void OnValidate()
	{
		if (placeAtOffset && path != null)
		{
			rawDistance = NormalizedToTrack(startOffset);
			SetPositions(rawDistance);
			transform.position = GetRunnerPosition();
			transform.rotation = GetRunnerRotation();
		}
	}

	public void SetRunState(RunnerState newState)
	{
		if (state == newState)
		{
			return;
		}
		prevState = state;
		state = newState;
		if (animator != null)
		{
			animator.enabled = state != RunnerState.Ragdoll;
		}
		if (state == RunnerState.Ragdoll)
		{
			RagdollSetActiveStatus(true);
		}
		OnChangeState?.Invoke(state);
	}

	private void SetPositions(float distance)
	{
		if (path == null)
		{
			splinePosition = transform.position;
			splineOrientation = transform.rotation;
			forward = transform.forward;
			right = transform.right;
			up = transform.up;
			return;
		}
		standardDistance = path.FromPathNativeUnits(distance, CinemachinePathBase.PositionUnits.Distance);
		splinePosition = path.EvaluatePositionAtUnit(standardDistance, CinemachinePathBase.PositionUnits.PathUnits);
		splineTangent = path.EvaluateTangentAtUnit(standardDistance, CinemachinePathBase.PositionUnits.PathUnits);
		splineOrientation = path.EvaluateOrientationAtUnit(standardDistance, CinemachinePathBase.PositionUnits.PathUnits);
		forward = splineOrientation * Vector3.forward;
		right = splineOrientation * Vector3.right;
		up = splineOrientation * Vector3.up;
	}

	private Vector3 GetRunnerPosition()
	{
		return splinePosition + right * laneOffset.x + up * laneOffset.y + forward * laneOffset.z;
	}

	private Quaternion GetRunnerRotation()
	{
		if (runDirection == RunDirection.Backward)
		{
			return splineOrientation * Quaternion.Euler(0f, 180f, 0f);
		}
		return splineOrientation;
	}

	private void FixedUpdate()
	{
		if (state != RunnerState.Running || path == null)
		{
			Velocity = Vector3.zero;
			return;
		}
		Vector3 prevPos = Position;
		rawDistance += (float)runDirection * speed * Time.fixedDeltaTime;
		HandleLooping();
		SetPositions(rawDistance);
		Vector3 nextPos = GetRunnerPosition();
		Quaternion nextRot = GetRunnerRotation();
		if (runnerRigidbody != null && runnerRigidbody.isKinematic)
		{
			runnerRigidbody.MovePosition(nextPos);
			runnerRigidbody.MoveRotation(nextRot);
		}
		else
		{
			transform.position = nextPos;
			transform.rotation = nextRot;
		}
		if (Time.fixedDeltaTime > 0.0001f)
		{
			Velocity = (nextPos - prevPos) / Time.fixedDeltaTime;
		}
	}

	private bool HandleLooping()
	{
		if (path == null || path.PathLength <= 0.001f)
		{
			return false;
		}
		float len = path.PathLength;
		if (rawDistance > len || rawDistance < 0f)
		{
			switch (trackLoopType)
			{
			case TrackLoopType.Loop:
				rawDistance = Mathf.Repeat(rawDistance, len);
				return true;
			case TrackLoopType.PingPong:
				rawDistance = Mathf.Clamp(rawDistance, 0f, len);
				runDirection = runDirection == RunDirection.Forward ? RunDirection.Backward : RunDirection.Forward;
				return true;
			case TrackLoopType.Stop:
				rawDistance = Mathf.Clamp(rawDistance, 0f, len);
				SetRunState(RunnerState.Idle);
				return true;
			}
		}
		return false;
	}

	private void OnCollisionEnter(Collision collision)
	{
		if (state == RunnerState.Ragdoll || collision == null)
		{
			return;
		}
		if (((1 << collision.gameObject.layer) & unbalanceCollisionLayerMask) != 0 && collision.relativeVelocity.sqrMagnitude >= unbalanceVelocitySqrMag)
		{
			SetRunState(RunnerState.Ragdoll);
			if (limbs != null)
			{
				Vector3 hitImpulse = -collision.relativeVelocity * incomingForceMultiplier;
				for (int i = 0; i < limbs.Count; i++)
				{
					if (limbs[i] != null)
					{
						limbs[i].AddForce((addRunVelocityOnCollapse ? Velocity : Vector3.zero) + hitImpulse * 0.25f, ForceMode.VelocityChange);
					}
				}
			}
		}
	}

	public void RagdollSetActiveStatus(bool status)
	{
		if (mainCollider != null)
		{
			mainCollider.enabled = !status;
		}
		if (limbs == null)
		{
			return;
		}
		for (int i = 0; i < limbs.Count; i++)
		{
			Rigidbody rb = limbs[i];
			if (rb != null)
			{
				rb.isKinematic = !status;
				Collider c = rb.GetComponent<Collider>();
				if (c != null)
				{
					c.enabled = status;
				}
			}
		}
	}

	private void OnDrawGizmos()
	{
	}
}
