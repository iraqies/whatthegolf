using System.Collections;
using Arena;
using Audio;
using Cinemachine;
using Core;
using RootMotion.Demos;
using RootMotion.Dynamics;
using UnityEngine;

public class HandBallController : UserControlThirdPerson
{
	public HandBallObject StartTarget;

	public Animator CameraController;

	public GolfBallController Controller;

	public CharacterPuppet Puppet;

	public float MaxDistanceWhenAiming = 2f;

	public float ChargeSpeed = 8f;

	public float ShootForce = 18f;

	public float ShootUpForce = 5f;

	public CinemachineCameraShake Shaker;

	public FreezeTimescale TimeFreezer;

	public ParticleSystem SpeedParticles;

	public ClipSettingsCollection ShootClip;

	private HandBallObject currentHeld;

	private Vector3 aimDir;

	private bool shooting;

	private bool shotConnected;

	private float ignoreBallTimer;

	private CinemachineStateDrivenCamera cinemachineCam;

	[SerializeField]
	private float ingnoreBallAfterShotTime = 0.5f;

	[SerializeField]
	private Animator animator;

	[SerializeField]
	private float golfSwingPrepareTime = 0.15f;

	[SerializeField]
	private float golfSwingHitTime = 0.25f;

	[SerializeField]
	private float golferAimSideOffset = 0.5f;

	[SerializeField]
	private float propExtraPushForce = 5f;

	private float sphereCastRadius = 0.5f;

	private float sphereCastDist = 1.5f;

	private string animParamIsGolfSwinging = "IsGolfSwinging";

	private string animParamIsGolfSwingBlend = "GolfSwingBlend";

	private string staticObstacleLayer = "Default";

	private int obstacleLayerMask = -1;

	private float lastNotGolfSwingingTime;

	private PuppetMaster puppetMaster;

	public float maxRunTime = 3f;

	private float runTime;

	protected override void Start()
	{
		base.Start();
		if (Controller == null)
		{
			Controller = GetComponent<GolfBallController>();
		}
		if (Controller != null)
		{
			Controller.OnShoot += OnShoot;
			Controller.OnAimUpdate += OnAimUpdate;
		}
		if (StartTarget != null)
		{
			HoldBall(StartTarget);
		}
	}

	public void OnShoot(Vector3 boost)
	{
		if (!shooting)
		{
			StartCoroutine(ShootRoutine(boost));
		}
	}

	private IEnumerator ShootRoutine(Vector3 boost)
	{
		shooting = true;
		aimDir = new Vector3(boost.x, 0f, boost.z);
		if (animator != null && !string.IsNullOrEmpty(animParamIsGolfSwinging))
		{
			animator.SetBool(animParamIsGolfSwinging, true);
		}
		yield return new WaitForSeconds(Mathf.Max(0.05f, golfSwingPrepareTime));
		if (currentHeld != null)
		{
			currentHeld.PrepareForShot();
			currentHeld.Throw(aimDir * ShootForce + Vector3.up * ShootUpForce);
			currentHeld = null;
			ignoreBallTimer = Time.time + ingnoreBallAfterShotTime;
		}
		if (ShootClip != null)
		{
			ShootClip.Play(null, transform.position, 1f, 1f);
		}
		if (SpeedParticles != null)
		{
			SpeedParticles.Play();
		}
		yield return new WaitForSeconds(Mathf.Max(0.1f, golfSwingHitTime));
		if (animator != null && !string.IsNullOrEmpty(animParamIsGolfSwinging))
		{
			animator.SetBool(animParamIsGolfSwinging, false);
		}
		shooting = false;
	}

	public void OnAimUpdate(Vector3 boost, bool onlyAimArrow)
	{
		if (boost.sqrMagnitude > 0.001f)
		{
			aimDir = new Vector3(boost.x, 0f, boost.z).normalized;
		}
	}

	protected override void Update()
	{
		if (shooting)
		{
			state.move = Vector3.zero;
			state.jump = false;
			return;
		}
		if (currentHeld == null && StartTarget != null)
		{
			Vector3 toBall = StartTarget.transform.position - transform.position;
			toBall.y = 0f;
			if (toBall.sqrMagnitude > 0.25f)
			{
				state.move = toBall.normalized;
				state.lookPos = StartTarget.transform.position;
			}
			else
			{
				state.move = Vector3.zero;
			}
		}
		else
		{
			state.move = aimDir;
			if (aimDir.sqrMagnitude > 0.001f)
			{
				state.lookPos = transform.position + aimDir * 10f;
			}
		}
	}

	private void OnCollisionEnter(Collision other)
	{
		if (currentHeld != null || Time.time < ignoreBallTimer || other == null)
		{
			return;
		}
		HandBallObject hb = other.gameObject.GetComponentInParent<HandBallObject>();
		if (hb != null)
		{
			HoldBall(hb);
		}
	}

	private void HoldBall(HandBallObject handball)
	{
		if (handball == null)
		{
			return;
		}
		currentHeld = handball;
		Rigidbody rb = GetComponent<Rigidbody>();
		if (rb != null)
		{
			handball.AddJointTo(rb, handball.RightHold != null ? handball.RightHold : transform);
		}
	}

	private void OnDrawGizmos()
	{
	}
}
