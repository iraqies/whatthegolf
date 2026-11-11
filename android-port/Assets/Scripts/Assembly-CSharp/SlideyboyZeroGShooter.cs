using System;
using System.Collections;
using Core;
using UnityEngine;

public class SlideyboyZeroGShooter : GolfBall2DShooterBase
{
	[SerializeField]
	public float minShootVelocity = 5f;

	public float fullShootVelocity = 25f;

	[SerializeField]
	public float pitch;

	[SerializeField]
	protected float spin;

	public float MaxVelocity = 25f;

	public float MinInAirVelocity = 1f;

	public float MinGroundVelocity = 2f;

	public float SlideBrake = 0.2f;

	public float groundedDrag = 5f;

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
		base.Awake();
		if (rigidbodyC != null)
		{
			origDrag = rigidbodyC.drag;
		}
	}

	private IEnumerator Start()
	{
		yield return null;
		if (GolfBallController != null && GolfBallController.shootArrow != null)
		{
			GolfBallController.shootArrow.clampAimVector = true;
		}
	}

	public override void OnShoot(Vector3 boost)
	{
		didShoot = true;
		lastShootTime = Time.time;
		base.OnShoot(boost);
		currentDirection = boost;
		StandardShoot(boost, pitch, minShootVelocity, fullShootVelocity, spin);
	}

	private void OnDrawGizmos()
	{
		Gizmos.DrawWireSphere(base.transform.position, SphereCastRadius);
	}

	protected override void FixedUpdate()
	{
		base.FixedUpdate();
		if (rigidbodyC == null)
		{
			return;
		}
		bool flag = lastCollisionStay + 0.05f < Time.time;
		if (IsInAir && !flag)
		{
			float num = Vector3.Dot(lastNormal, lastVelocity.normalized);
			if (Mathf.Abs(num) > 0.1f)
			{
				float num2 = 1f - Mathf.Clamp01(Mathf.Abs(num));
				float num3 = Mathf.Lerp(1f, SlideBrake, num2);
				Vector3 vector = Vector3.ProjectOnPlane(lastVelocity, lastNormal).normalized * lastVelocity.magnitude * num3;
				rigidbodyC.velocity = vector;
			}
			else
			{
				rigidbodyC.velocity = lastVelocity;
			}
		}
		IsInAir = flag;
		if (didShoot && lastShootTime + 0.05f < Time.time)
		{
			IsInAir = true;
			didShoot = false;
		}
		if (currentDirection.x != 0f && LookTransform != null)
		{
			Quaternion to = Quaternion.Euler(0f, Mathf.Sign(currentDirection.x) * 90f, 0f);
			LookTransform.localRotation = Quaternion.RotateTowards(LookTransform.localRotation, to, Time.deltaTime * RotateSpeed);
		}
		if (Animator != null)
		{
			Animator.SetBool("IsGrounded", !IsInAir);
			Animator.SetFloat("SlideSpeed", Mathf.Abs(rigidbodyC.velocity.x));
		}
		if (GolfBallController != null)
		{
			GolfBallController.BlockShooting = BlockShootingInAir && IsInAir;
		}
		if (RunParticles != null)
		{
			if (!IsInAir)
			{
				RunParticles.Play();
			}
			else
			{
				RunParticles.Stop();
			}
		}
		rigidbodyC.drag = (IsInAir ? origDrag : groundedDrag);
		Vector2 velocity = rigidbodyC.velocity;
		float magnitude = velocity.magnitude;
		if (magnitude > MaxVelocity)
		{
			rigidbodyC.velocity = velocity.normalized * MaxVelocity;
		}
		else if (IsInAir)
		{
			if (magnitude < MinInAirVelocity)
			{
				rigidbodyC.velocity = velocity.normalized * MinInAirVelocity;
			}
		}
		else if (magnitude < MinGroundVelocity)
		{
			rigidbodyC.velocity = velocity.normalized * MinGroundVelocity;
		}
		if (IsInAir)
		{
			lastVelocity = rigidbodyC.velocity;
		}
	}

	private void OnCollisionEnter2D(Collision2D collision)
	{
		if (collision != null && collision.contacts != null && collision.contacts.Length != 0)
		{
			lastCollisionStay = Time.time;
			lastNormal = collision.contacts[0].normal;
		}
	}

	private void OnCollisionStay2D(Collision2D collision)
	{
		if (collision != null && collision.contacts != null && collision.contacts.Length != 0)
		{
			lastCollisionStay = Time.time;
			lastNormal = collision.contacts[0].normal;
		}
	}
}
