using System.Collections;
using Audio;
using Core;
using UnityEngine;

public class BeachBallWithAvatarController : GolfBallShooterBase
{
	public float RollSpeed = 1f;

	public float ForceSpeed = 1f;

	public float ShootSpeed = 2f;

	public Animator Animator;

	public float AnimatorRotateSpeed = 10f;

	public float AnimatorOffset = 0.5f;

	public float AnimationSpeedMod = 1f;

	public SphereCollider BallCollider;

	public float MaxSpeed = 50f;

	public bool AddForcesInFixedUpdate;

	public bool SetAnimationSpeed;

	public bool CanDash = true;

	public float DashTime = 0.5f;

	public ParticleSystem DashParticles;

	public float TimeToInflate = 3f;

	public Vector2 InflateScaleRange = new Vector2(4f, 8.2f);

	public AnimationCurve inflationCurve;

	public GameObject DashSphere;

	public bool UseVelocityAsInflationTimer;

	public ClipSettingsCollection ReadyToDash;

	public ClipSettingsCollection DashSound;

	private bool dashing;

	private bool dashExplosionLock;

	private float explosionY;

	private Vector3 dashDirection;

	private float dashTimer;

	private Vector3 preDashVelocity;

	private Vector3 preDashScale;

	private float inflateTimer;

	private Vector3 currentBoost;

	private Vector3 lastPos;

	private void Start()
	{
		if (rigid != null)
		{
			lastPos = rigid.position;
		}
	}

	public override void OnAimUpdate(Vector3 boost, bool onlyAimArrow)
	{
		if (onlyAimArrow || dashing)
		{
			return;
		}
		currentBoost = boost;
		if (!AddForcesInFixedUpdate && rigid != null)
		{
			Vector3 normalized = new Vector3(boost.z, 0f, 0f - boost.x).normalized;
			rigid.AddTorque(normalized * RollSpeed, ForceMode.Force);
			rigid.AddForce(boost.normalized * ForceSpeed, ForceMode.Force);
		}
	}

	public void OnExplode()
	{
		if (dashing)
		{
			StopDashing();
			dashExplosionLock = true;
			StartCoroutine(RemoveExplosionLock());
		}
	}

	public void ExplosionLock()
	{
		dashExplosionLock = true;
		StartCoroutine(RemoveExplosionLock());
	}

	public override void OnCancel()
	{
		currentBoost = Vector3.zero;
	}

	protected override void FixedUpdate()
	{
		if (AddForcesInFixedUpdate && currentBoost.magnitude > 0f && rigid != null)
		{
			Vector3 normalized = new Vector3(currentBoost.z, 0f, 0f - currentBoost.x).normalized;
			rigid.AddTorque(normalized * RollSpeed, ForceMode.Force);
			rigid.AddForce(currentBoost.normalized * ForceSpeed, ForceMode.Force);
		}
		if (Animator != null && BallCollider != null && rigid != null)
		{
			Animator.transform.position = BallCollider.transform.position + Vector3.up * (BallCollider.radius * rigid.transform.localScale.y + AnimatorOffset);
			float magnitude = rigid.velocity.magnitude;
			Animator.SetFloat("MoveSpeed", magnitude * AnimationSpeedMod);
			if (SetAnimationSpeed)
			{
				Animator.SetFloat("AnimationSpeed", magnitude * AnimationSpeedMod * 0.5f);
			}
			if (magnitude > 0f)
			{
				Vector3 normalized2 = new Vector3(rigid.velocity.x, 0f, rigid.velocity.z).normalized;
				if (normalized2 != Vector3.zero)
				{
					Animator.transform.rotation = Quaternion.RotateTowards(Animator.transform.rotation, Quaternion.LookRotation(normalized2, Vector3.up), AnimatorRotateSpeed * Time.deltaTime);
				}
			}
		}
		if (!dashing && rigid != null)
		{
			float magnitude2 = rigid.velocity.magnitude;
			if (magnitude2 > MaxSpeed)
			{
				Vector3 normalized3 = rigid.velocity.normalized;
				Vector3 normalized4 = ((currentBoost.magnitude > 0f) ? currentBoost.normalized : rigid.velocity.normalized);
				Vector3 vector = normalized3 * MaxSpeed * 1.6f;
				Vector3 vector2 = Vector3.MoveTowards(rigid.velocity, normalized4 * MaxSpeed, Time.deltaTime * 30f);
				rigid.velocity = new Vector3(Mathf.Min(vector2.x, vector.x), Mathf.Min(vector2.y, vector.y), Mathf.Min(vector2.z, vector.z));
			}
		}
		if (dashing && rigid != null)
		{
			rigid.velocity = dashDirection * ShootSpeed * Time.deltaTime;
			dashTimer -= Time.deltaTime;
			if (dashTimer <= 0f)
			{
				StopDashing();
			}
		}
		float num = inflateTimer;
		if (!UseVelocityAsInflationTimer)
		{
			inflateTimer -= Time.deltaTime;
		}
		if (inflateTimer > 0f)
		{
			if (rigid != null && inflationCurve != null)
			{
				float t = inflationCurve.Evaluate(1f - inflateTimer / TimeToInflate);
				rigid.transform.localScale = Vector3.one * Mathf.LerpUnclamped(InflateScaleRange.x, InflateScaleRange.y, t);
			}
		}
		else
		{
			if (num > 0f)
			{
				StartCoroutine(BallInflationSoundRoutine());
			}
			if (dashing)
			{
				if (rigid != null)
				{
					float a = (UseVelocityAsInflationTimer ? preDashScale.y : InflateScaleRange.y);
					float num2 = Mathf.Lerp(a, InflateScaleRange.x, 1f - dashTimer / DashTime);
					rigid.transform.localScale = Vector3.one * num2;
				}
			}
			else if (rigid != null)
			{
				Vector3 localScale = rigid.transform.localScale;
				Vector3 target = Vector3.one * InflateScaleRange.y;
				float maxDistanceDelta = (UseVelocityAsInflationTimer ? (Vector3.Distance(lastPos, rigid.position) / TimeToInflate) : (Time.deltaTime * 3f));
				Vector3 localScale2 = Vector3.MoveTowards(localScale, target, maxDistanceDelta);
				if (!float.IsNaN(localScale2.x))
				{
					rigid.transform.localScale = localScale2;
				}
			}
		}
		if (rigid != null)
		{
			lastPos = rigid.position;
		}
	}

	private void StopDashing()
	{
		dashing = false;
		if (DashParticles != null)
		{
			DashParticles.Stop();
		}
		if (rigid != null)
		{
			rigid.velocity = dashDirection * preDashVelocity.magnitude;
		}
		inflateTimer = (UseVelocityAsInflationTimer ? 0f : TimeToInflate);
	}

	public void OnCollision(Collision collision)
	{
	}

	private IEnumerator BallInflationSoundRoutine()
	{
		yield return new WaitForSecondsRealtime(0.02f);
		if (ReadyToDash != null)
		{
			ReadyToDash.Play(null, base.transform.position, 1f, 1f);
		}
	}

	private IEnumerator RemoveExplosionLock()
	{
		yield return new WaitForSecondsRealtime(1f);
		dashExplosionLock = false;
	}

	public override void OnShoot(Vector3 boost)
	{
		currentBoost = Vector3.zero;
		if (CanDash && inflateTimer <= 0f && !dashing && !dashExplosionLock)
		{
			dashing = true;
			dashDirection = boost.normalized;
			dashTimer = DashTime;
			if (DashParticles != null)
			{
				DashParticles.Play();
			}
			if (rigid != null)
			{
				preDashVelocity = rigid.velocity;
				preDashScale = rigid.transform.localScale;
			}
			if (DashSound != null)
			{
				DashSound.Play(null, base.transform.position, 1f, 1f);
			}
		}
	}
}
