using System;
using System.Collections;
using Core;
using UnityEngine;

public class SlideyboyZeroGShooter : GolfBall2DShooterBase
{
	[SerializeField]
	public float minShootVelocity;

	public float fullShootVelocity;

	[SerializeField]
	public float pitch;

	[SerializeField]
	protected float spin;

	public float MaxVelocity;

	public float MinInAirVelocity;

	public float MinGroundVelocity;

	public float SlideBrake;

	public float groundedDrag;

	public Action OnLevelReset;

	public float KillAddForce;

	public Transform LookTransform;

	public float RotateSpeed;

	public LayerMask GroundLayer;

	public float GroundCheckDist;

	public float HelperCheckDist;

	public float ExtraHorizontalForceTime;

	public float HelperForce;

	public bool BlockShootingInAir;

	public ParticleSystem RunParticles;

	public float SphereCastRadius;

	public Animator Animator;

	private bool resetting;

	private Vector3 currentDirection;

	private float applyForceTimer;

	private float origDrag;

	private bool IsInAir;

	private Vector2 lastVelocity;

	private float lastCollisionStay;

	private Vector3 lastNormal;

	private bool didShoot;

	private float lastShootTime;

	protected override void Awake()
	{
	}

	private IEnumerator Start()
	{
		return null;
	}

	public override void OnShoot(Vector3 boost)
	{
	}

	private void OnDrawGizmos()
	{
	}

	protected override void FixedUpdate()
	{
	}

	private void OnCollisionEnter2D(Collision2D collision)
	{
	}

	private void OnCollisionStay2D(Collision2D collision)
	{
	}
}
