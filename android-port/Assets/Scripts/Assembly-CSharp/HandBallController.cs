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

	public float MaxDistanceWhenAiming;

	public float ChargeSpeed;

	public float ShootForce;

	public float ShootUpForce;

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
	private float ingnoreBallAfterShotTime;

	[SerializeField]
	private Animator animator;

	[SerializeField]
	private float golfSwingPrepareTime;

	[SerializeField]
	private float golfSwingHitTime;

	[SerializeField]
	private float golferAimSideOffset;

	[SerializeField]
	private float propExtraPushForce;

	private float sphereCastRadius;

	private float sphereCastDist;

	private string animParamIsGolfSwinging;

	private string animParamIsGolfSwingBlend;

	private string staticObstacleLayer;

	private int obstacleLayerMask;

	private float lastNotGolfSwingingTime;

	private PuppetMaster puppetMaster;

	public float maxRunTime;

	private float runTime;

	protected override void Start()
	{
	}

	public void OnShoot(Vector3 boost)
	{
	}

	private IEnumerator ShootRoutine(Vector3 boost)
	{
		return null;
	}

	public void OnAimUpdate(Vector3 boost, bool onlyAimArrow)
	{
	}

	protected override void Update()
	{
	}

	private void OnCollisionEnter(Collision other)
	{
	}

	private void HoldBall(HandBallObject handball)
	{
	}

	private void OnDrawGizmos()
	{
	}
}
