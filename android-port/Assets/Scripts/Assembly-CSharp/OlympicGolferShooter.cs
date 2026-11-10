using System.Collections;
using System.Collections.Generic;
using CameraStack;
using Cinemachine;
using Core;
using RootMotion.Dynamics;
using UnityEngine;

public class OlympicGolferShooter : GolfBallShooterBase
{
	[SerializeField]
	private Animator golfAnimator;

	[SerializeField]
	private bool playShootRoutine = true;

	[SerializeField]
	private Rigidbody hips;

	[SerializeField]
	private PuppetCarLikeController shooter;

	[SerializeField]
	private PuppetMaster puppet;

	[SerializeField]
	private Animator cameraController;

	[SerializeField]
	private CinemachineVirtualCamera cinemachineCamera;

	private CinemachineBasicMultiChannelPerlin cameraShaker;

	[SerializeField]
	private float amplitudeGain;

	[SerializeField]
	private float frequencyGain;

	[SerializeField]
	private AudioSource ScreamSource;

	[SerializeField]
	private float screamVolumeChangeSpeed = 5f;

	[SerializeField]
	private BehaviourPuppet puppetBehaviour;

	[SerializeField]
	private List<AudioClip> loseBalanceSfx;

	[SerializeField]
	private AudioSource loseBalanceSfxSource;

	[SerializeField]
	private float collisionExtraPushForce = 3f;

	[SerializeField]
	private float getUpPushRadius = 3f;

	[SerializeField]
	private float getUpPushPower = 30f;

	private bool hasCollapsed;

	private bool isCollapsing;

	public CBFollow followCamera;

	private Vector3 targetBlend;

	private float velRef;

	private float targetScreamVolume = 1f;

	private string blendParamName = "Blend";

	private Collider[] colliders = new Collider[20];

	[SerializeField]
	private CapsuleCollider collider;

	[SerializeField]
	private LayerMask extraPushLayers;

	[SerializeField]
	private float extraPushAreaScaleFactor = 1.1f;

	protected override void Awake()
	{
		base.Awake();
		if (followCamera == null && CameraManager.Instance != null)
		{
			followCamera = CameraManager.Instance.GetComponent<CBFollow>();
		}
	}

	private void Start()
	{
		if (puppetBehaviour != null && puppetBehaviour.onLoseBalance.unityEvent != null)
		{
			puppetBehaviour.onLoseBalance.unityEvent.AddListener(HandlePuppetLoseBalance);
		}
		if (cinemachineCamera != null)
		{
			cameraShaker = cinemachineCamera.GetCinemachineComponent<CinemachineBasicMultiChannelPerlin>();
		}
	}

	public void HandlePuppetLoseBalance()
	{
		if (ScreamSource != null)
			ScreamSource.Stop();
		hasCollapsed = false;
		isCollapsing = false;
		if (GolfBallController != null)
			GolfBallController.AffectsTimeScale = false;
		if (loseBalanceSfx != null && loseBalanceSfx.Count > 0 && loseBalanceSfxSource != null)
		{
			int idx = UnityEngine.Random.Range(0, loseBalanceSfx.Count);
			loseBalanceSfxSource.clip = loseBalanceSfx[idx];
			loseBalanceSfxSource.Play();
		}
		if (cameraShaker != null)
		{
			cameraShaker.m_AmplitudeGain = 0f;
			cameraShaker.m_FrequencyGain = 0f;
		}
	}

	private void Update()
	{
		if (hasCollapsed || isCollapsing)
			return;

		if (golfAnimator != null)
		{
			float curBlend = golfAnimator.GetFloat(blendParamName);
			float damped = Mathf.SmoothDamp(curBlend, targetBlend.magnitude, ref velRef, 0.2f, float.PositiveInfinity, Time.unscaledDeltaTime);
			golfAnimator.SetFloat("Blend", Mathf.Min(0.9f, damped));
		}

		if (GolfBallController != null && GolfBallController.GetIsCharging(0))
		{
			if (GolfBallController.GetPlayerAxisDirection(false, "AimHorizontal", "AimVertical").magnitude == 0f)
			{
				targetBlend = Vector3.zero;
			}
		}
	}

	public override void OnAimUpdate(Vector3 boost, bool onlyAimArrow)
	{
		base.OnAimUpdate(boost, onlyAimArrow);
		if (!onlyAimArrow && !hasCollapsed)
			targetBlend = boost;
	}

	public override void OnCancel()
	{
		base.OnCancel();
		if (!hasCollapsed)
			targetBlend = Vector3.zero;
	}

	public override void OnShoot(Vector3 boost)
	{
		if (isCollapsing)
			return;
		base.OnShoot(boost);
		if (!hasCollapsed)
			StartCoroutine(ShootRoutine(boost));
		if (ScreamSource != null && !ScreamSource.isPlaying)
			ScreamSource.Play();
		if (cameraShaker != null)
		{
			cameraShaker.m_AmplitudeGain = amplitudeGain;
			cameraShaker.m_FrequencyGain = frequencyGain;
		}
	}

	private IEnumerator ShootRoutine(Vector3 boost)
	{
		isCollapsing = true;
		yield return StartCoroutine(PlayShootSequence(boost));
		if (cameraController != null)
			cameraController.SetTrigger("Follow");
		if (ScreamSource != null)
			ScreamSource.Play();
		if (golfAnimator != null)
			golfAnimator.SetTrigger("Shoot");
		if (puppet != null && puppet.behaviours != null)
		{
			foreach (BehaviourBase b in puppet.behaviours)
			{
				if (b is BehaviourPuppet bp && bp.masterProps != null)
				{
					bp.masterProps.normalMode = 0;
				}
			}
		}
		if (shooter != null)
		{
			shooter.enabled = true;
			shooter.OnShoot(boost);
		}
	}

	private IEnumerator PlayShootSequence(Vector3 boost)
	{
		float startVal = (golfAnimator != null) ? Mathf.Min(0.9f, golfAnimator.GetFloat("Blend")) : 0f;
		if (playShootRoutine)
		{
			yield return StartCoroutine(pTween.To(0.1f, t =>
			{
				if (golfAnimator != null)
					golfAnimator.SetFloat("Blend", Mathf.Lerp(startVal, 1f, t));
			}));
		}
		hasCollapsed = true;
		isCollapsing = false;
		if (followCamera != null && hips != null)
			followCamera.FollowTarget = hips.transform;
		if (GolfBallController != null)
			GolfBallController.ArrowPosition = transform;
	}

	private new void FixedUpdate()
	{
		if (!hasCollapsed && !isCollapsing)
			return;
		if (collider == null)
			return;

		Vector3 dirVec = (collider.direction == 0) ? Vector3.right : ((collider.direction == 1) ? Vector3.up : Vector3.forward);
		float halfLen = (collider.height * 0.5f - collider.radius) * extraPushAreaScaleFactor;
		Vector3 p0 = collider.transform.TransformPoint(collider.center + dirVec * halfLen);
		Vector3 p1 = collider.transform.TransformPoint(collider.center - dirVec * halfLen);
		float scaleAlong = Vector3.Dot(dirVec, collider.transform.localScale);
		float rad = collider.radius * scaleAlong * extraPushAreaScaleFactor;

		int count = Physics.OverlapCapsuleNonAlloc(p0, p1, rad, colliders, extraPushLayers);
		for (int i = 0; i < count; i++)
		{
			Collider col = colliders[i];
			if (col != null && col.attachedRigidbody != null)
			{
				col.attachedRigidbody.AddForce(transform.forward * collisionExtraPushForce, ForceMode.VelocityChange);
			}
		}
	}

	public void GetUpPush()
	{
		Collider[] hits = new Collider[100];
		int count = Physics.OverlapSphereNonAlloc(transform.position, getUpPushRadius, hits, extraPushLayers);
		for (int i = 0; i < count; i++)
		{
			Collider col = hits[i];
			if (col != null && col.attachedRigidbody != null)
			{
				col.attachedRigidbody.AddExplosionForce(getUpPushPower, transform.position, getUpPushRadius, 3f);
			}
		}
	}
}
