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
	private float golfSwingPrepareTime = 0.5f;

	[SerializeField]
	private float golfSwingHitTime = 0.5f;

	[SerializeField]
	private float golferAimSideOffset = 1f;

	[SerializeField]
	private float propExtraPushForce = 10f;

	[SerializeField]
	private Transform TargetPosition;

	[SerializeField]
	private Transform SpawnPosition;

	public float ShootForce = 10f;

	public float ShootUpForce = 1f;

	[SerializeField]
	private GolfBallController Controller;

	public CharacterPuppet Puppet;

	[SerializeField]
	private Transform ArrowPosition;

	public float MaxDistanceWhenAiming = 0.5f;

	public float sphereCastDist = 1f;

	private float lastNotGolfSwingingTime;

	public ClipSettingsCollection ShootClip;

	private Vector3 aimDir;

	private float sphereCastRadius = 0.25f;

	private string animParamIsGolfSwinging = "IsGolfSwinging";

	private string animParamIsGolfSwingBlend = "GolfSwingBlend";

	private string staticObstacleLayer = "TransparentFX";

	[SerializeField]
	private PuppetMaster puppetMaster;

	private GolfingState golfingState;

	private GameObject currentBall;

	private bool Winstate;

	public float distanceGoodEnough = 1f;

	public void SetToFreeRunning()
	{
		StartRunning();
		Controller.enabled = true;
		Controller.ArrowPosition = ArrowPosition;
		Controller.Scale = 1f;
		Winstate = true;
	}

	protected override void Start()
	{
		base.Start();
		Controller.OnShoot += OnShoot;
		Controller.OnAimUpdate += OnAimUpdate;
		Controller.enabled = true;
		LayerMask.GetMask(staticObstacleLayer);
		StartRunning();
	}

	private void StartRunning()
	{
		puppetMaster.mode = PuppetMaster.Mode.Active;
		Puppet.moveMode = CharacterThirdPerson.MoveMode.Directional;
		state.lookPos = base.transform.forward;
		animator.SetBool(animParamIsGolfSwinging, value: false);
		golfingState = GolfingState.RUNNING;
	}

	private void FreeRunning()
	{
		state.move = aimDir;
	}

	public void GotToGreen()
	{
		if (golfingState == GolfingState.RUNNING && !Winstate)
		{
			puppetMaster.mode = PuppetMaster.Mode.Active;
			Puppet.moveMode = CharacterThirdPerson.MoveMode.Directional;
			state.lookPos = TargetPosition.position;
			OnReadyToShoot();
		}
	}

	private void RunTowards()
	{
		Vector3 normalized = (TargetPosition.transform.position - base.transform.position).normalized;
		state.move = Vector3.ProjectOnPlane(normalized, base.transform.up);
		state.lookPos = TargetPosition.position;
		if (Vector3.Distance(base.transform.position, TargetPosition.position) < 1f)
		{
			OnReadyToShoot();
		}
	}

	private void OnReadyToShoot()
	{
		golfingState = GolfingState.READY_TO_SHOOT;
		Controller.StopAiming();
		SpawnNewGolfableBall();
		aimDir = Vector3.zero;
		state.move = Vector3.zero;
		Controller.ArrowPosition = currentBall.transform;
		Controller.Scale = 0.3f;
	}

	private void ReadyToShoot()
	{
		Vector3 vector = Vector3.zero;
		if (aimDir != Vector3.zero)
		{
			Vector3 vector2 = Vector3.Cross(base.transform.up, aimDir);
			puppetMaster.mode = PuppetMaster.Mode.Active;
			Vector3 position = currentBall.transform.position;
			Vector3 normalized = aimDir.normalized;
			Vector3 vector3 = position - normalized * MaxDistanceWhenAiming - vector2 * golferAimSideOffset;
			vector = Vector3.ProjectOnPlane(vector3 - base.transform.position, base.transform.up);
			Puppet.moveMode = CharacterThirdPerson.MoveMode.Strafe;
			state.lookPos = base.transform.position + vector2;
			if (vector.magnitude < distanceGoodEnough)
			{
				animator.SetBool(animParamIsGolfSwinging, value: true);
				float num = Mathf.Clamp(Time.time - lastNotGolfSwingingTime, 0f, 0.5f);
				animator.SetFloat(animParamIsGolfSwingBlend, 0.5f - num);
				puppetMaster.mode = PuppetMaster.Mode.Kinematic;
				Puppet.moveMode = CharacterThirdPerson.MoveMode.Strafe;
				vector = Vector3.zero;
			}
			else
			{
				puppetMaster.mode = PuppetMaster.Mode.Active;
				animator.SetBool(animParamIsGolfSwinging, value: false);
				animator.SetFloat(animParamIsGolfSwingBlend, 0.5f);
				lastNotGolfSwingingTime = Time.time;
			}
		}
		else
		{
			vector = Vector3.zero;
			puppetMaster.mode = PuppetMaster.Mode.Kinematic;
			Puppet.moveMode = CharacterThirdPerson.MoveMode.Strafe;
			animator.SetBool(animParamIsGolfSwinging, value: true);
			animator.SetFloat(animParamIsGolfSwingBlend, 0.5f);
		}
		state.move = vector;
	}

	public void OnShoot(Vector3 boost)
	{
		if (golfingState == GolfingState.READY_TO_SHOOT)
		{
			StartCoroutine(ShootRoutine(boost));
		}
		aimDir = Vector3.zero;
	}

	private IEnumerator ShootRoutine(Vector3 boost)
	{
		golfingState = GolfingState.SHOOTING;
		Controller.StopAiming();
		Controller.enabled = false;
		yield return new WaitForSeconds(0.1f);
		puppetMaster.mode = PuppetMaster.Mode.Kinematic;
		animator.SetBool(animParamIsGolfSwinging, value: true);
		yield return StartCoroutine(pTween.To(0.2f, 0f, 1f, delegate(float t)
		{
			animator.SetFloat(animParamIsGolfSwingBlend, t);
		}, pTween.TimeMode.Normal, useFixedUpdate: false));
		SetBallActive(active: true);
		Rigidbody component = currentBall.GetComponent<Rigidbody>();
		if (component != null)
		{
			component.AddForce(boost * ShootForce + Vector3.up * ShootUpForce);
		}
		aimDir = Vector3.zero;
		animator.SetBool(animParamIsGolfSwinging, value: false);
		Controller.enabled = true;
		yield return new WaitForSeconds(0.4f);
		OnReadyToShoot();
	}

	public void OnAimUpdate(Vector3 boost, bool onlyAimArrow)
	{
		if (Puppet.puppet.state == BehaviourPuppet.State.Puppet)
		{
			aimDir = boost;
		}
	}

	protected override void Update()
	{
		switch (golfingState)
		{
		case GolfingState.RUNNING:
			state.move = aimDir;
			break;
		case GolfingState.RUN_TOWARDS:
			RunTowards();
			break;
		case GolfingState.READY_TO_SHOOT:
			ReadyToShoot();
			break;
		default:
			state.move = Vector3.zero;
			break;
		}
	}

	private void SpawnNewGolfableBall()
	{
		currentBall = Object.Instantiate(HotdogGolfBall.gameObject, SpawnPosition.position, SpawnPosition.rotation);
		SetBallActive(active: false);
	}

	private void SetBallActive(bool active)
	{
		Rigidbody component = currentBall.GetComponent<Rigidbody>();
		currentBall.GetComponent<Collider>().enabled = active;
		component.isKinematic = !active;
		component.useGravity = active;
	}

	private void OnDrawGizmos()
	{
		Gizmos.color = Color.magenta;
		Gizmos.DrawWireSphere(base.transform.position + Vector3.up * 0.5f, sphereCastRadius);
		Gizmos.DrawLine(TargetPosition.position, base.transform.position);
	}
}
