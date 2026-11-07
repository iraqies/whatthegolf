using System;
using System.Collections.Generic;
using Chronos;
using Core;
using UnityEngine;

public class SoccerPlayer : MonoBehaviour
{
	public List<Rigidbody> balls;

	public bool KickTarget;

	public float KickForce;

	public float kickRange;

	public float speed;

	public Vector2 RandomSpeedModRange;

	public float reactDistance;

	public float stopDistance;

	public List<AudioClip> sfxKick;

	public float rotateSpeed;

	public bool lookAlongVelocity;

	public bool AvoidEdges;

	public float MaxRunTime;

	public bool MoveOnlyWhenGrounded;

	public float PlayerBlockTime;

	private Vector3 startPosition;

	private Quaternion startRotation;

	private Rigidbody rigid;

	private float nextHit;

	private Collider col;

	private float waitTime;

	private bool targetIsTouching;

	public Action onKick;

	private float runningTime;

	private bool didRunTooMuch;

	private LaserSentryTarget laserSentryTarget;

	private Rigidbody currentTarget;

	private Timeline timeline;

	private bool timelineFound;

	private float FixedDeltaTime => 0f;

	private float DeltaTime => 0f;

	public Vector3 Velocity
	{
		get
		{
			return default;
		}
		set
		{
		}
	}

	public Vector3 AngularVelocity
	{
		get
		{
			return default;
		}
		set
		{
		}
	}

	public float Drag
	{
		get
		{
			return 0f;
		}
		set
		{
		}
	}

	public float AngularDrag
	{
		get
		{
			return 0f;
		}
		set
		{
		}
	}

	public float LocalTime => 0f;

	public bool IsKinematic
	{
		get
		{
			return false;
		}
		set
		{
		}
	}

	private void Awake()
	{
	}

	private void OnMultiplayerSetup(MultiplayerLevelInfo info)
	{
	}

	private void Start()
	{
	}

	public void AddBallTarget(Rigidbody ball)
	{
	}

	public void AddBallTarget(GolfBallController controller)
	{
	}

	private void LaserSentryTarget_OnLasered()
	{
	}

	private void OnCollisionEnter(Collision collision)
	{
	}

	private void OnCollisionExit(Collision collision)
	{
	}

	private void DoKick(Rigidbody other)
	{
	}

	private void FixedUpdate()
	{
	}

	public Rigidbody GetRigid()
	{
		return null;
	}

	private void AddForceAtPosition(Vector3 force, Vector3 position, ForceMode forceMode)
	{
	}

	private void AddForce(Vector3 force, ForceMode forceMode = ForceMode.Force)
	{
	}

	private void OnDrawGizmosSelected()
	{
	}
}
