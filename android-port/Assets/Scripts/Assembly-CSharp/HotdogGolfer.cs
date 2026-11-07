using System.Collections;
using Audio;
using Core;
using RootMotion.Demos;
using RootMotion.Dynamics;
using UnityEngine;

public class HotdogGolfer : UserControlThirdPerson
{
	private enum GolfingState
	{
		RUNNING = 0,
		HOLD = 1,
		RUN_TOWARDS = 2,
		READY_TO_SHOOT = 3,
		SHOOTING = 4
	}

	[SerializeField]
	private GameObject HotdogGolfBall;

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

	[SerializeField]
	private Transform TargetPosition;

	[SerializeField]
	private Transform SpawnPosition;

	public float ShootForce;

	public float ShootUpForce;

	[SerializeField]
	private GolfBallController Controller;

	public CharacterPuppet Puppet;

	[SerializeField]
	private Transform ArrowPosition;

	public float MaxDistanceWhenAiming;

	public float sphereCastDist;

	private float lastNotGolfSwingingTime;

	public ClipSettingsCollection ShootClip;

	private Vector3 aimDir;

	private float sphereCastRadius;

	private string animParamIsGolfSwinging;

	private string animParamIsGolfSwingBlend;

	private string staticObstacleLayer;

	[SerializeField]
	private PuppetMaster puppetMaster;

	private GolfingState golfingState;

	private GameObject currentBall;

	private bool Winstate;

	public float distanceGoodEnough;

	public void SetToFreeRunning()
	{
	}

	protected override void Start()
	{
	}

	private void StartRunning()
	{
	}

	private void FreeRunning()
	{
	}

	public void GotToGreen()
	{
	}

	private void RunTowards()
	{
	}

	private void OnReadyToShoot()
	{
	}

	private void ReadyToShoot()
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

	private void SpawnNewGolfableBall()
	{
	}

	private void SetBallActive(bool active)
	{
	}

	private void OnDrawGizmos()
	{
	}
}
