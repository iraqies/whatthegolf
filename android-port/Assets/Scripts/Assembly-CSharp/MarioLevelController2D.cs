using System;
using Core;
using UnityEngine;

public class MarioLevelController2D : GolfBall2DShooterBase
{
	[SerializeField]
	public float minShootVelocity = 5f;

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

	public bool BlockShootingInAir = true;

	public ParticleSystem RunParticles;

	public float SphereCastRadius = 0.5f;

	public Animator Animator;

	public Vector3 ExtraBoostDir = Vector3.zero;

	public bool NoDragInAir;

	public bool CanWallJump;

	public LayerMask WallLayers;

	public float ChangeDragSpeed = 1f;

	public float wallDrag = 10f;

	private bool resetting;

	private Vector3 currentDirection;

	private float applyForceTimer;

	private float dragTarget;

	private float origDrag;

	protected override void Awake()
	{
		base.Awake();
		if (rigid != null)
		{
			dragTarget = rigid.drag;
			origDrag = rigid.drag;
		}
	}

	public override void OnShoot(Vector3 boost)
	{
		float magnitude = boost.magnitude;
		boost = (boost + ExtraBoostDir).normalized * magnitude;
		if (CanWallJump)
		{
			BlockShootingInAir = true;
			if (rigid != null)
			{
				rigid.drag = origDrag;
			}
			dragTarget = origDrag;
		}
		base.OnShoot(boost);
		currentDirection = boost;
		CheckIfNeedHelp(true);
		StandardShoot(boost, pitch, minShootVelocity, fullShootVelocity, spin);
	}

	protected override void FixedUpdate()
	{
		base.FixedUpdate();
		if (currentDirection.x != 0f && LookTransform != null)
		{
			Quaternion to = Quaternion.Euler(0f, Mathf.Sign(currentDirection.x) * 90f, 0f);
			LookTransform.localRotation = Quaternion.RotateTowards(LookTransform.localRotation, to, RotateSpeed * Time.deltaTime);
		}
		CheckIfNeedHelp(false);
		if (applyForceTimer > 0f && rigid != null && base.transform.InverseTransformDirection(rigid.velocity).y >= 0f)
		{
			applyForceTimer -= Time.unscaledDeltaTime;
			rigid.AddForce(new Vector2(currentDirection.x * HelperForce, 0f), ForceMode2D.Impulse);
		}
		bool flag = IsGrounded();
		if (Controller != null)
		{
			Controller.BlockAiming = BlockShootingInAir && !flag;
		}
		if (CanWallJump && rigid != null)
		{
			rigid.drag = Mathf.MoveTowards(rigid.drag, dragTarget, ChangeDragSpeed * Time.deltaTime);
		}
		if (RunParticles != null)
		{
			if (flag || (rigid != null && Math.Abs(rigid.drag - wallDrag) < 1f))
			{
				RunParticles.Play();
			}
			else
			{
				RunParticles.Stop();
			}
		}
		if (NoDragInAir && rigid != null)
		{
			rigid.drag = (flag ? origDrag : 0f);
		}
	}

	private void CheckIfNeedHelp(bool ignoreGrounded = false)
	{
		if ((ignoreGrounded || !IsGrounded()) && rigid != null && LookTransform != null)
		{
			Vector2 direction = LookTransform.forward;
			if ((bool)Physics2D.Raycast(rigid.position + Vector2.up * 0.4f, direction, HelperCheckDist, GroundLayer) || (bool)Physics2D.Raycast(rigid.position - Vector2.up * 0.4f, direction, HelperCheckDist, GroundLayer) || (bool)Physics2D.Raycast(rigid.position, direction, HelperCheckDist, GroundLayer))
			{
				applyForceTimer = ExtraHorizontalForceTime;
			}
		}
	}

	private bool IsGrounded()
	{
		if (rigid == null)
		{
			return false;
		}
		Vector2 vector = base.transform.right * 0.4f;
		bool flag = Physics2D.Raycast(rigid.position - vector, -Vector2.up, GroundCheckDist, GroundLayer);
		bool flag2 = Physics2D.Raycast(rigid.position + vector, -Vector2.up, GroundCheckDist, GroundLayer);
		bool flag3 = Physics2D.CircleCast(rigid.position + Vector2.up, SphereCastRadius, -Vector2.up, GroundCheckDist, GroundLayer);
		return flag || flag2 || flag3;
	}

	private void OnCollisionEnter(Collision c)
	{
		if (resetting || c == null || c.gameObject.layer != LayerMask.NameToLayer("NPC"))
		{
			return;
		}
		MarioGoolfba component = c.gameObject.GetComponent<MarioGoolfba>();
		if (!(component != null) || component.isDead || c.collider == null)
		{
			return;
		}
		float y = c.collider.bounds.max.y;
		float y2 = c.collider.bounds.size.y;
		if (base.transform.position.y > y - y2 * 0.25f)
		{
			component.Kill();
			if (rigid != null)
			{
				Vector2 normalized = rigid.velocity.normalized;
				Vector3 vector = Vector3.Reflect(new Vector3(normalized.x, normalized.y, 0f), Vector3.up);
				rigid.velocity = new Vector2(vector.x, vector.y) * KillAddForce;
			}
		}
		else
		{
			resetting = true;
			if (Controller != null)
			{
				Controller.OutOfBounds(Controller.Is2D ? "OUCH" : "", Controller.Is2D ? 0.4f : 0f);
			}
		}
	}

	private void OnCollisionStay2D(Collision2D c)
	{
		if (!CanWallJump || c == null || (int)WallLayers != ((int)WallLayers | (1 << c.gameObject.layer)) || c.contacts == null || c.contacts.Length == 0 || rigid == null)
		{
			return;
		}
		Vector2 normal = c.contacts[0].normal;
		if (rigid.velocity.y < 0f && (Vector3.Distance(new Vector3(normal.x, normal.y, 0f), Vector3.right) < 0.1f || Vector3.Distance(new Vector3(normal.x, normal.y, 0f), -Vector3.right) < 0.1f))
		{
			BlockShootingInAir = false;
			dragTarget = wallDrag;
			if (Animator != null)
			{
				Animator.SetBool("IsWallClimping", true);
			}
		}
		else
		{
			BlockShootingInAir = true;
			dragTarget = origDrag;
			if (Animator != null)
			{
				Animator.SetBool("IsWallClimping", false);
			}
		}
	}

	private void OnCollisionExit2D(Collision2D c)
	{
		if (CanWallJump && c != null && (int)WallLayers == ((int)WallLayers | (1 << c.gameObject.layer)))
		{
			BlockShootingInAir = true;
			dragTarget = origDrag;
			if (Animator != null)
			{
				Animator.SetBool("IsWallClimping", false);
			}
		}
	}

	public void ForceOutOfBounds()
	{
	}
}
