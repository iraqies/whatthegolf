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
	private bool playShootRoutine;

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
	private float screamVolumeChangeSpeed;

	[SerializeField]
	private BehaviourPuppet puppetBehaviour;

	[SerializeField]
	private List<AudioClip> loseBalanceSfx;

	[SerializeField]
	private AudioSource loseBalanceSfxSource;

	[SerializeField]
	private float collisionExtraPushForce;

	[SerializeField]
	private float getUpPushRadius;

	[SerializeField]
	private float getUpPushPower;

	private bool hasCollapsed;

	private bool isCollapsing;

	public CBFollow followCamera;

	private Vector3 targetBlend;

	private float velRef;

	private float targetScreamVolume;

	private string blendParamName;

	private Collider[] colliders;

	[SerializeField]
	private CapsuleCollider collider;

	[SerializeField]
	private LayerMask extraPushLayers;

	[SerializeField]
	private float extraPushAreaScaleFactor;

	protected override void Awake()
	{
	}

	private void Start()
	{
	}

	public void HandlePuppetLoseBalance()
	{
	}

	private void Update()
	{
	}

	public override void OnAimUpdate(Vector3 boost, bool onlyAimArrow)
	{
	}

	public override void OnCancel()
	{
	}

	public override void OnShoot(Vector3 boost)
	{
	}

	private IEnumerator ShootRoutine(Vector3 boost)
	{
		return null;
	}

	private IEnumerator PlayShootSequence(Vector3 boost)
	{
		return null;
	}

	private new void FixedUpdate()
	{
	}

	public void GetUpPush()
	{
	}
}
