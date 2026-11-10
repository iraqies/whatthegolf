using System;
using System.Collections;
using System.Collections.Generic;
using Audio;
using Core;
using RootMotion.Demos;
using RootMotion.Dynamics;
using UnityEngine;

public class PuppetControllerWithShoot : UserControlThirdPerson
{
	[SerializeField]
	private bool CanJump = true;

	[SerializeField]
	private GolfBallController Controller;

	[SerializeField]
	private float JumpTime = 0.25f;

	[SerializeField]
	private CharacterPuppet m_CharacterPuppet;

	[SerializeField]
	private float BlockTime = 0.35f;

	[SerializeField]
	private AnimationCurve AnimSpeedMultiplierCurve;

	[SerializeField]
	private ClipSettingsCollection ShootClip;

	[SerializeField]
	private CharacterAnimationThirdPerson characterAnimation;

	private Vector3 AimDirection;

	private float JumpTimer;

	private float BlockTimer;

	[SerializeField]
	private Animator m_Animator;

	[SerializeField]
	private PuppetMaster m_PuppetMaster;

	private const string animParamIsGolfSwinging = "IsGolfSwinging";

	private bool Shooting;

	[SerializeField]
	private Rigidbody Root;

	[SerializeField]
	private Rigidbody ThrowablePrefab;

	[SerializeField]
	private float ThrowSpeedBoost = 15f;

	[SerializeField]
	private float ExplosionForce = 10f;

	[SerializeField]
	private Vector3 AdditionalShootForce;

	[SerializeField]
	private Transform BallShootPosition;

	[SerializeField]
	private Transform BallAimPosition;

	[SerializeField]
	private float PunchEasingAmplitude = 1f;

	[SerializeField]
	private Vector3 EndScaleOfThrowable = Vector3.one;

	[SerializeField]
	private Vector2 DisappearTime = new Vector2(2f, 4f);

	[SerializeField]
	private List<SnowBallTargetBehaviour> Targets;

	private int CollapsedTargets;

	[SerializeField]
	private int TargetsToHit = 1;

	private Rigidbody ThrowablePrefabInstance;

	private bool isDead;

	public bool HasBeenShooting { get; set; }

	public bool HasShoot { get; private set; }

	protected override void Start()
	{
		base.Start();
		if (Controller == null)
		{
			Controller = GetComponent<GolfBallController>();
		}
		if (Controller != null)
		{
			Controller.OnAimStart += OnAimStart;
			Controller.OnBallShot += OnShoot;
			Controller.OnBallAiming += OnAimUpdate;
		}
		if (Targets != null)
		{
			for (int i = 0; i < Targets.Count; i++)
			{
				if (Targets[i] != null)
				{
					Targets[i].OnCollapsed += OnTargetCollapsed;
				}
			}
		}
	}

	public void SwapToShooting()
	{
		Shooting = true;
		HasBeenShooting = true;
		if (m_Animator != null)
		{
			m_Animator.SetBool(animParamIsGolfSwinging, true);
		}
		GetNewThrowable();
	}

	private IEnumerator ActionAfter(Action a, float delay)
	{
		yield return new WaitForSeconds(delay);
		a?.Invoke();
	}

	private void OnTargetCollapsed(SnowBallTargetBehaviour target)
	{
		CollapsedTargets++;
		if (CollapsedTargets >= Mathf.Max(1, TargetsToHit))
		{
			Flag flag = UnityEngine.Object.FindObjectOfType<Flag>();
			if (flag != null)
			{
				flag.TouchFlag(true);
			}
		}
	}

	private void OnTriggerEnter(Collider collision)
	{
		if (collision != null && collision.CompareTag("ShooterTrigger"))
		{
			SwapToShooting();
		}
	}

	public void SwapToRunning()
	{
		Shooting = false;
		if (m_Animator != null)
		{
			m_Animator.SetBool(animParamIsGolfSwinging, false);
		}
	}

	public void OnAimStart()
	{
		if (Shooting && ThrowablePrefabInstance == null)
		{
			GetNewThrowable();
		}
	}

	public void OnShoot(Vector3 boost)
	{
		if (isDead || Time.time < BlockTimer)
		{
			return;
		}
		BlockTimer = Time.time + BlockTime;
		HasShoot = true;
		if (ShootClip != null)
		{
			ShootClip.Play(null, transform.position, 1f, 1f);
		}
		if (Shooting && ThrowablePrefab != null)
		{
			if (ThrowablePrefabInstance == null)
			{
				GetNewThrowable();
			}
			if (ThrowablePrefabInstance != null)
			{
				ThrowablePrefabInstance.transform.SetParent(null);
				ThrowablePrefabInstance.isKinematic = false;
				ThrowablePrefabInstance.velocity = boost * ThrowSpeedBoost + AdditionalShootForce;
				ThrowablePrefabInstance = null;
			}
		}
		else
		{
			AimDirection = boost.normalized;
			if (CanJump)
			{
				JumpTimer = JumpTime;
			}
		}
	}

	public void OnAimUpdate(Vector3 boost, bool onlyAimArrow)
	{
		if (boost.sqrMagnitude > 0.001f)
		{
			AimDirection = new Vector3(boost.x, 0f, boost.z).normalized;
		}
	}

	public void Kill()
	{
		if (isDead)
		{
			return;
		}
		isDead = true;
		if (m_PuppetMaster != null)
		{
			m_PuppetMaster.state = PuppetMaster.State.Dead;
		}
	}

	protected override void Update()
	{
		if (isDead)
		{
			state.move = Vector3.zero;
			state.jump = false;
			return;
		}
		if (Shooting)
		{
			state.move = Vector3.zero;
			state.jump = false;
			if (AimDirection.sqrMagnitude > 0.001f)
			{
				state.lookPos = transform.position + AimDirection * 10f;
			}
		}
		else
		{
			state.move = AimDirection;
			if (JumpTimer > 0f)
			{
				JumpTimer -= Time.deltaTime;
				state.jump = true;
			}
			else
			{
				state.jump = false;
			}
			if (AimDirection.sqrMagnitude > 0.001f)
			{
				state.lookPos = transform.position + AimDirection * 10f;
			}
		}
	}

	private void GetNewThrowable()
	{
		if (ThrowablePrefab == null)
		{
			return;
		}
		Transform parentTrans = BallAimPosition != null ? BallAimPosition : (BallShootPosition != null ? BallShootPosition : transform);
		ThrowablePrefabInstance = UnityEngine.Object.Instantiate(ThrowablePrefab, parentTrans.position, parentTrans.rotation, parentTrans);
		ThrowablePrefabInstance.gameObject.SetActive(true);
		ThrowablePrefabInstance.isKinematic = true;
	}
}
