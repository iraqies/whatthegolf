using System;
using System.Collections.Generic;
using Audio;
using Chronos;
using Core;
using UnityEngine;

public class SuperGolfShooter : GolfBallShooterExperimental
{
	public float SmashVelocity;

	public GlobalClock GlobalClock;

	public float MinTimeScale;

	public SuperGolfGun EquippedGun;

	public bool IsShooting;

	public Vector3 WeaponPositionOffset;

	public List<AudioClip> WeaponPickupClips;

	public ClipSettingsCollection sfxOnPickup;

	public AudioClip deathClip;

	public bool RestartGameWhenDead;

	public bool useSlowShot;

	public float slowShootPct;

	public GameObject Model;

	public bool RotatePlayerOnAim;

	public bool SpeedAffectsTime;

	public bool CanDie;

	public bool KnockbackWhenShooting;

	public Action<SuperGolfShooter> OnDeath;

	public Action<SuperGolfGun, Vector3> OnPlayerShot;

	public Action<SuperGolfGun> OnWeaponPickUp;

	public bool RotateGunWithPlayer;

	public float KillEquipBlockTime;

	public float SphereCastRadius;

	public float MaxDistance;

	public bool IsDead;

	private Collider collider;

	private Vector3 velocityLastFrame;

	private float currentAmbientTimescale;

	private float extraTime;

	private ObjectShatter objectShatter;

	private Vector3 lastBoost;

	private float killEquipBlockTimer;

	protected override void Awake()
	{
		base.Awake();
	}

	private void Start()
	{
	}

	private void Instance_OnGoal(Level.CompletedState s)
	{
	}

	protected override void FixedUpdate()
	{
		base.FixedUpdate();
	}

	public override void OnShoot(Vector3 boost)
	{
		base.OnShoot(boost);
	}

	public override void OnAimUpdate(Vector3 boost, bool onlyAimArrow)
	{
	}

	public void SetExtraTime(float time)
	{
	}

	public void StopAiming()
	{
	}

	private void OnTriggerEnter(Collider other)
	{
	}

	private void OnCollisionEnter(Collision other)
	{
	}

	public void Kill()
	{
	}
}
