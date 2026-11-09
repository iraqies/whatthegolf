using System.Collections;
using Audio;
using Core;
using UnityEngine;

public class BeachBallWithAvatarController : GolfBallShooterBase
{
	public float RollSpeed;

	public float ForceSpeed;

	public float ShootSpeed;

	public Animator Animator;

	public float AnimatorRotateSpeed;

	public float AnimatorOffset;

	public float AnimationSpeedMod;

	public SphereCollider BallCollider;

	public float MaxSpeed;

	public bool AddForcesInFixedUpdate;

	public bool SetAnimationSpeed;

	public bool CanDash;

	public float DashTime;

	public ParticleSystem DashParticles;

	public float TimeToInflate;

	public Vector2 InflateScaleRange;

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
	}

	public override void OnAimUpdate(Vector3 boost, bool onlyAimArrow)
	{
	}

	public void OnExplode()
	{
	}

	public void ExplosionLock()
	{
	}

	public override void OnCancel()
	{
	}

	protected override void FixedUpdate()
	{
	base.FixedUpdate();
	}

	private void StopDashing()
	{
	}

	public void OnCollision(Collision collision)
	{
	}

	private IEnumerator BallInflationSoundRoutine()
	{
		return null;
	}

	private IEnumerator RemoveExplosionLock()
	{
		return null;
	}

	public override void OnShoot(Vector3 boost)
	{
	base.OnShoot(boost);
		StandardShoot(boost, 15f, 5f, (ShootSpeed > 0f ? ShootSpeed : 22f), 5f);
	}
}
