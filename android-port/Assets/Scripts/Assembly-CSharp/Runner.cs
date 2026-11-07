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
	private LayerMask unbalanceCollisionLayerMask;

	[SerializeField]
	private float unbalanceVelocitySqrMag;

	[SerializeField]
	private float incomingForceMultiplier;

	[SerializeField]
	private bool teleportToOppositeOnLoop;

	[SerializeField]
	private TrackLoopType trackLoopType;

	[SerializeField]
	private RunnerState state;

	[SerializeField]
	private RunDirection runDirection;

	[SerializeField]
	private float speed;

	[SerializeField]
	private float turnDegreesPerSecond;

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

	public Rigidbody Root => null;

	public List<Rigidbody> Limbs => null;

	public Vector3 Position => default;

	public Vector3 Velocity { get; private set; }

	private void Awake()
	{
	}

	private float NormalizedToTrack(float t)
	{
		return 0f;
	}

	private void OnValidate()
	{
	}

	public void SetRunState(RunnerState newState)
	{
	}

	private void SetPositions(float distance)
	{
	}

	private Vector3 GetRunnerPosition()
	{
		return default;
	}

	private Quaternion GetRunnerRotation()
	{
		return default;
	}

	private void FixedUpdate()
	{
	}

	private bool HandleLooping()
	{
		return false;
	}

	private void OnCollisionEnter(Collision collision)
	{
	}

	public void RagdollSetActiveStatus(bool status)
	{
	}

	private void OnDrawGizmos()
	{
	}
}
