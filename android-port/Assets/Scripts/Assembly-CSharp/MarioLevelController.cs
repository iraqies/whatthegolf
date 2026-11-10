using System;
using Core;
using UnityEngine;

public class MarioLevelController : GolfBallShooterBase
{
	[SerializeField]
	public float fullShootVelocity = 25f;

	[SerializeField]
	public float pitch;

	[SerializeField]
	protected float spin;

	public Action OnLevelReset;

	public float KillAddForce = 5f;

	public Transform LookTransform;

	public float RotateSpeed = 100f;

	public LayerMask GroundLayer;

	public float GroundCheckDist = 1f;

	public float HelperCheckDist = 1f;

	public float ExtraHorizontalForceTime = 0.5f;

	public float HelperForce = 2f;

	public Vector3 Up = new Vector3(0f, 1f, 0f);

	public bool BlockShootingInAir = true;

	public ParticleSystem RunParticles;

	public float SphereCastRadius = 0.5f;

	public Animator Animator;

	public Vector3 ExtraBoostDir = Vector3.zero;

	public bool CanWallJump;

	public LayerMask WallLayers;

	public float ChangeDragSpeed = 1f;

	public float wallDrag = 10f;

	public bool useWalkingHelper = true;

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
		if (rb != null)
		{
			dragTarget = rb.drag;
			origDrag = rb.drag;
		}
	}

	public override void OnShoot(Vector3 boost)
	{
		float mag = boost.magnitude;
		boost = (boost + ExtraBoostDir).normalized * mag;
		if (CanWallJump)
		{
			BlockShootingInAir = true;
			if (rb != null)
			{
				rb.drag = origDrag;
			}
			dragTarget = origDrag;
		}
		base.OnShoot(boost);
		currentDirection = boost;
		CheckIfNeedHelp(true);
		if (IsGrounded() && useWalkingHelper && Vector3.Angle(boost, Vector3.up) > 80f)
		{
			boost *= 0.75f;
		}
		StandardShoot(boost, pitch, 0f, (fullShootVelocity > 0f) ? fullShootVelocity : 25f, spin);
	}

	protected override void FixedUpdate()
	{
		if (forcingGroundedFor > 0f)
		{
			forcingGroundedFor -= Time.deltaTime;
		}
		base.FixedUpdate();
		if (currentDirection.x != 0f && LookTransform != null)
		{
			Quaternion targetRot = Quaternion.Euler(0f, Mathf.Sign(currentDirection.x) * 90f, 0f);
			LookTransform.localRotation = Quaternion.RotateTowards(LookTransform.localRotation, targetRot, Time.deltaTime * RotateSpeed);
		}
		CheckIfNeedHelp(false);
		if (applyForceTimer > 0f && rb != null)
		{
			Vector3 localVel = base.transform.InverseTransformDirection(rb.velocity);
			if (localVel.y >= 0f)
			{
				applyForceTimer -= Time.unscaledDeltaTime;
				rb.AddForce(new Vector3(currentDirection.x * HelperForce, 0f, 0f), ForceMode.VelocityChange);
			}
		}
		if (GolfBallController != null)
		{
			GolfBallController.BlockShooting = BlockShootingInAir && !IsGrounded();
		}
		if (CanWallJump && rb != null)
		{
			rb.drag = Mathf.MoveTowards(rb.drag, dragTarget, Time.deltaTime * ChangeDragSpeed);
		}
		if (RunParticles != null && rb != null)
		{
			if (IsGrounded())
			{
				RunParticles.Play();
			}
			else if (Mathf.Abs(rb.drag - wallDrag) >= 1f)
			{
				RunParticles.Stop();
			}
			else
			{
				RunParticles.Play();
			}
		}
		if (rb != null)
		{
			lastFrameVelocity = rb.velocity;
		}
	}

	private void CheckIfNeedHelp(bool ignoreGrounded = false)
	{
		if ((!ignoreGrounded && IsGrounded()) || rb == null || LookTransform == null)
		{
			return;
		}
		Vector3 pos = rb.position;
		Vector3 fwd = LookTransform.forward;
		if (Physics.Raycast(pos + Up * 0.4f, fwd, HelperCheckDist, GroundLayer) || Physics.Raycast(pos - Up * 0.4f, fwd, HelperCheckDist, GroundLayer) || Physics.Raycast(pos, fwd, HelperCheckDist, GroundLayer))
		{
			applyForceTimer = ExtraHorizontalForceTime;
		}
	}

	public Vector3 GetVelocityLastFrame()
	{
		return lastFrameVelocity;
	}

	public void ForceGroundedForSeconds(float secs)
	{
		forcingGroundedFor = secs;
	}

	private bool IsGrounded()
	{
		if (forcingGroundedFor > 0f)
		{
			return true;
		}
		if (rb == null)
		{
			return false;
		}
		Vector3 pos = rb.position;
		Vector3 rightOffset = base.transform.right * 0.4f;
		bool leftHit = Physics.Raycast(pos - rightOffset, -Up, GroundCheckDist, GroundLayer);
		bool rightHit = Physics.Raycast(pos + rightOffset, -Up, GroundCheckDist, GroundLayer);
		Ray ray = new Ray(pos + Up, -Up);
		bool sphereHit = Physics.SphereCast(ray, SphereCastRadius, GroundCheckDist, GroundLayer);
		return leftHit || rightHit || sphereHit;
	}

	private void OnCollisionEnter(Collision c)
	{
		if (resetting || c == null || c.gameObject.layer != LayerMask.NameToLayer("Enemy"))
		{
			return;
		}
		MarioGoolfba goomba = c.gameObject.GetComponent<MarioGoolfba>();
		if (goomba == null || goomba.IsDead)
		{
			return;
		}
		float topThreshold = c.collider.bounds.max.y - c.collider.bounds.size.y * 0.25f;
		if (base.transform.position.y > topThreshold)
		{
			goomba.Kill();
			if (rb != null)
			{
				rb.velocity = Vector3.Reflect(rb.velocity.normalized, Vector3.up) * KillAddForce;
			}
		}
		else
		{
			resetting = true;
			if (GolfBallController != null)
			{
				GolfBallController.OutOfBounds(GolfBallController.isPlayer ? "Player" : "Other", GolfBallController.isPlayer ? 0.4f : 0f);
			}
		}
	}

	private void OnCollisionStay(Collision c)
	{
		if (!CanWallJump || c == null || rb == null)
		{
			return;
		}
		int mask = WallLayers;
		if (mask != (mask | (1 << c.gameObject.layer)) || c.contacts == null || c.contacts.Length == 0)
		{
			return;
		}
		Vector3 normal = c.contacts[0].normal;
		if (rb.velocity.y < 0f && (Vector3.Distance(normal, Vector3.right) < 0.1f || Vector3.Distance(normal, -Vector3.right) < 0.1f))
		{
			BlockShootingInAir = false;
			dragTarget = wallDrag;
			if (Animator != null)
			{
				Animator.SetBool("WallSlide", true);
			}
		}
		else
		{
			BlockShootingInAir = true;
			dragTarget = origDrag;
			if (Animator != null)
			{
				Animator.SetBool("WallSlide", false);
			}
		}
	}

	private void OnCollisionExit(Collision c)
	{
		if (!CanWallJump || c == null)
		{
			return;
		}
		int mask = WallLayers;
		if (mask == (mask | (1 << c.gameObject.layer)))
		{
			BlockShootingInAir = true;
			dragTarget = origDrag;
			if (Animator != null)
			{
				Animator.SetBool("WallSlide", false);
			}
		}
	}

	public void ForceOutOfBounds()
	{
	}
}
