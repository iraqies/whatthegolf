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
	private bool CanJump;

	[SerializeField]
	private GolfBallController Controller;

	[SerializeField]
	private float JumpTime;

	[SerializeField]
	private CharacterPuppet m_CharacterPuppet;

	[SerializeField]
	private float BlockTime;

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
	private float ThrowSpeedBoost;

	[SerializeField]
	private float ExplosionForce;

	[SerializeField]
	private Vector3 AdditionalShootForce;

	[SerializeField]
	private Transform BallShootPosition;

	[SerializeField]
	private Transform BallAimPosition;

	[SerializeField]
	private float PunchEasingAmplitude;

	[SerializeField]
	private Vector3 EndScaleOfThrowable;

	[SerializeField]
	private Vector2 DisappearTime;

	[SerializeField]
	private List<SnowBallTargetBehaviour> Targets;

	private int CollapsedTargets;

	[SerializeField]
	private int TargetsToHit;

	private Rigidbody ThrowablePrefabInstance;

	private bool isDead;

	public bool HasBeenShooting { get; set; }

	public bool HasShoot { get; private set; }

	protected override void Start()
	{
	}

	public void SwapToShooting()
	{
	}

	private IEnumerator ActionAfter(Action a, float delay)
	{
		return null;
	}

	private void OnTargetCollapsed(SnowBallTargetBehaviour target)
	{
	}

	private void OnTriggerEnter(Collider collision)
	{
	}

	public void SwapToRunning()
	{
	}

	public void OnAimStart()
	{
	}

	public void OnShoot(Vector3 boost)
	{
	}

	public void OnAimUpdate(Vector3 boost, bool onlyAimArrow)
	{
	}

	public void Kill()
	{
	}

	protected override void Update()
	{
	}

	private void GetNewThrowable()
	{
	}
}
