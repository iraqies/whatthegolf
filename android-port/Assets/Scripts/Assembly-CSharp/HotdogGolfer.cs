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
		if (Controller != null)
		{
			Controller.enabled = true;
			Controller.ArrowPosition = ArrowPosition;
			Controller.MaxAimDistance = 1f;
		}
		Winstate = true;
	}

	protected override void Start()
	{
		base.Start();
		if (Controller != null)
		{
			Controller.OnShoot += OnShoot;
			Controller.OnAimUpdate += OnAimUpdate;
			Controller.enabled = true;
		}
		LayerMask.GetMask(staticObstacleLayer);
		StartRunning();
	}

	private void StartRunning()
	{
		if (puppetMaster != null)
		{
			puppetMaster.mode = PuppetMaster.Mode.Active;
		}
		if (Puppet != null)
		{
			Puppet.propMuscle.mode = Muscle.Mode.Animated;
		}
		state.lookPos = base.transform.forward;
		if (animator != null)
		{
			animator.SetBool(animParamIsGolfSwinging, false);
		}
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
			if (puppetMaster != null)
			{
				puppetMaster.mode = PuppetMaster.Mode.Active;
			}
			if (Puppet != null)
			{
				Puppet.propMuscle.mode = Muscle.Mode.Animated;
			}
			if (TargetPosition != null)
			{
				state.lookPos = TargetPosition.position;
			}
			OnReadyToShoot();
		}
	}

	private void RunTowards()
	{
		if (TargetPosition != null)
		{
			Vector3 normalized = (TargetPosition.transform.position - base.transform.position).normalized;
			state.move = Vector3.ProjectOnPlane(normalized, base.transform.up);
			state.lookPos = TargetPosition.position;
			if (Vector3.Distance(base.transform.position, TargetPosition.position) < 1f)
			{
				OnReadyToShoot();
			}
		}
	}

	private void OnReadyToShoot()
	{
		golfingState = GolfingState.READY_TO_SHOOT;
		if (Controller != null)
		{
			Controller.StopAiming();
		}
		SpawnNewGolfableBall();
		aimDir = Vector3.zero;
		state.move = Vector3.zero;
		if (currentBall != null && Controller != null)
		{
			Controller.ArrowPosition = currentBall.transform;
			Controller.MaxAimDistance = 0.3f;
		}
	}

	private void ReadyToShoot()
	{
		Vector3 vector = Vector3.zero;
		if (aimDir != Vector3.zero)
		{
			Vector3 vector2 = Vector3.Cross(base.transform.up, aimDir);
			if (puppetMaster != null)
			{
				puppetMaster.mode = PuppetMaster.Mode.Active;
			}
			if (currentBall != null)
			{
				Vector3 position = currentBall.transform.position;
				Vector3 normalized = aimDir.normalized;
				Vector3 vector3 = position - normalized * MaxDistanceWhenAiming - vector2 * golferAimSideOffset;
				vector = Vector3.ProjectOnPlane(vector3 - base.transform.position, base.transform.up);
			}
			if (Puppet != null)
			{
				Puppet.propMuscle.mode = Muscle.Mode.Kinematic;
			}
			state.lookPos = base.transform.position + vector2;
			if (vector.magnitude < distanceGoodEnough)
			{
				if (animator != null)
				{
					animator.SetBool(animParamIsGolfSwinging, true);
				}
				float num = Mathf.Clamp(Time.time - lastNotGolfSwingingTime, 0f, 0.5f);
				if (animator != null)
				{
					animator.SetFloat(animParamIsGolfSwingBlend, 0.5f - num);
				}
				if (puppetMaster != null)
				{
					puppetMaster.mode = PuppetMaster.Mode.Kinematic;
				}
				if (Puppet != null)
				{
					Puppet.propMuscle.mode = Muscle.Mode.Kinematic;
				}
				vector = Vector3.zero;
			}
			else
			{
				if (puppetMaster != null)
				{
					puppetMaster.mode = PuppetMaster.Mode.Active;
				}
				if (animator != null)
				{
					animator.SetBool(animParamIsGolfSwinging, false);
					animator.SetFloat(animParamIsGolfSwingBlend, 0.5f);
				}
				lastNotGolfSwingingTime = Time.time;
			}
		}
		else
		{
			vector = Vector3.zero;
			if (puppetMaster != null)
			{
				puppetMaster.mode = PuppetMaster.Mode.Kinematic;
			}
			if (Puppet != null)
			{
				Puppet.propMuscle.mode = Muscle.Mode.Kinematic;
			}
			if (animator != null)
			{
				animator.SetBool(animParamIsGolfSwinging, true);
				animator.SetFloat(animParamIsGolfSwingBlend, 0.5f);
			}
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
		if (Controller != null)
		{
			Controller.StopAiming();
			Controller.enabled = false;
		}
		yield return new WaitForSeconds(0.1f);
		if (puppetMaster != null)
		{
			puppetMaster.mode = PuppetMaster.Mode.Kinematic;
		}
		if (animator != null)
		{
			animator.SetBool(animParamIsGolfSwinging, true);
		}
		yield return StartCoroutine(pTween.To(0.2f, 0f, 1f, delegate(float t)
		{
			if (animator != null)
			{
				animator.SetFloat(animParamIsGolfSwingBlend, t);
			}
		}, TimeScale.Type.Normal, false));
		SetBallActive(true);
		if (currentBall != null)
		{
			Rigidbody componentInChildren = currentBall.GetComponentInChildren<Rigidbody>();
			if (componentInChildren != null)
			{
				componentInChildren.AddForce(boost * ShootForce + Vector3.up * ShootUpForce);
			}
		}
		aimDir = Vector3.zero;
		if (animator != null)
		{
			animator.SetBool(animParamIsGolfSwinging, false);
		}
		if (Controller != null)
		{
			Controller.enabled = true;
		}
		yield return new WaitForSeconds(0.4f);
		OnReadyToShoot();
	}

	public void OnAimUpdate(Vector3 boost, bool onlyAimArrow)
	{
		if (Puppet != null && Puppet.characterAnimation != null && !Puppet.characterAnimation.animationGrounded)
		{
			return;
		}
		aimDir = boost;
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
		if (HotdogGolfBall != null && SpawnPosition != null)
		{
			currentBall = Object.Instantiate(HotdogGolfBall.gameObject, SpawnPosition.position, SpawnPosition.rotation);
			SetBallActive(false);
		}
	}

	private void SetBallActive(bool active)
	{
		if (currentBall != null)
		{
			Rigidbody componentInChildren = currentBall.GetComponentInChildren<Rigidbody>();
			Collider componentInChildren2 = currentBall.GetComponentInChildren<Collider>();
			if (componentInChildren2 != null)
			{
				componentInChildren2.enabled = active;
			}
			if (componentInChildren != null)
			{
				componentInChildren.isKinematic = !active;
				componentInChildren.useGravity = active;
			}
		}
	}

	private void OnDrawGizmos()
	{
		Gizmos.color = Color.magenta;
		Gizmos.DrawWireSphere(base.transform.position + Vector3.up * 0.5f, sphereCastRadius);
		if (TargetPosition != null)
		{
			Gizmos.DrawLine(TargetPosition.position, base.transform.position);
		}
	}
}
