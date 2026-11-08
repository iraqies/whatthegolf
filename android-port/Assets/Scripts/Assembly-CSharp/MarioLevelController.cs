using System;
using Core;
using UnityEngine;

public class MarioLevelController : GolfBallShooterBase
{
	[SerializeField]
	public float fullShootVelocity;

	[SerializeField]
	public float pitch;

	[SerializeField]
	protected float spin;

	public Action OnLevelReset;

	public float KillAddForce;

	public Transform LookTransform;

	public float RotateSpeed;

	public LayerMask GroundLayer;

	public float GroundCheckDist;

	public float HelperCheckDist;

	public float ExtraHorizontalForceTime;

	public float HelperForce;

	public Vector3 Up;

	public bool BlockShootingInAir;

	public ParticleSystem RunParticles;

	public float SphereCastRadius;

	public Animator Animator;

	public Vector3 ExtraBoostDir;

	public bool CanWallJump;

	public LayerMask WallLayers;

	public float ChangeDragSpeed;

	public float wallDrag;

	public bool useWalkingHelper;

	private bool resetting;

	private Vector3 currentDirection;

	private float applyForceTimer;

	private float dragTarget;

	private float origDrag;

	private Vector3 lastFrameVelocity;

	private float forcingGroundedFor;

	protected override void Awake()
	{
	base.Awake();
	}

	public override void OnShoot(Vector3 boost)
	{
	StandardShoot(boost, 20f, 18f, 5f);
	}

	protected override void FixedUpdate()
	{
	base.FixedUpdate();
	}

	private void CheckIfNeedHelp(bool ignoreGrounded = false)
	{
	}

	public Vector3 GetVelocityLastFrame()
	{
		return default;
	}

	public void ForceGroundedForSeconds(float secs)
	{
	}

	private bool IsGrounded()
	{
		return false;
	}

	private void OnCollisionEnter(Collision c)
	{
	}

	private void OnCollisionStay(Collision c)
	{
	}

	private void OnCollisionExit(Collision c)
	{
	}

	public void ForceOutOfBounds()
	{
	}
}
