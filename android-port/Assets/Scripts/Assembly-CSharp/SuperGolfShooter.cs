using System;
using System.Collections.Generic;
using Audio;
using CameraStack;
using Chronos;
using Core;
using UnityEngine;

public class SuperGolfShooter : GolfBallShooterExperimental
{
	public float SmashVelocity = 5f;

	public GlobalClock GlobalClock;

	public float MinTimeScale = 0.05f;

	public SuperGolfGun EquippedGun;

	public bool IsShooting;

	public Vector3 WeaponPositionOffset;

	public List<AudioClip> WeaponPickupClips;

	public ClipSettingsCollection sfxOnPickup;

	public AudioClip deathClip;

	public bool RestartGameWhenDead = true;

	public bool useSlowShot;

	public float slowShootPct;

	public GameObject Model;

	public bool RotatePlayerOnAim;

	public bool SpeedAffectsTime = true;

	public bool CanDie = true;

	public bool KnockbackWhenShooting;

	public Action<SuperGolfShooter> OnDeath;

	public Action<SuperGolfShooter> OnPlayerDied
	{
		get => OnDeath;
		set => OnDeath = value;
	}

	public Action<SuperGolfShooter> OnPlayerHit;

	public Action<SuperGolfGun, Vector3> OnPlayerShot;

	public Action<SuperGolfGun> OnWeaponPickUp;

	public bool RotateGunWithPlayer;

	public float KillEquipBlockTime;

	public float SphereCastRadius = 1.4f;

	public float MaxDistance = 5f;

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
		collider = GetComponent<Collider>();
		extraTime = 1f;
		objectShatter = GetComponentInChildren<ObjectShatter>();
	}

	private void Start()
	{
		if (Level.Instance != null)
		{
			Level.Instance.OnComplete += Instance_OnGoal;
		}
	}

	private void Instance_OnGoal(Level.CompletedState s)
	{
		IsDead = true;
	}

	protected override void FixedUpdate()
	{
		base.FixedUpdate();
		if (IsDead)
		{
			if (GlobalClock != null)
			{
				GlobalClock.localTimeScale = 1f;
			}
			return;
		}
		if (rigid != null)
		{
			velocityLastFrame = rigid.velocity;
		}
		if (SpeedAffectsTime && rigid != null)
		{
			extraTime = Mathf.Clamp(extraTime - Time.deltaTime, 0f, 10f);
			float num = Mathf.Clamp01(Mathf.Max(Mathf.Lerp(0f, 1f, rigid.velocity.magnitude / fullShootVelocity) + extraTime, MinTimeScale));
			if (GlobalClock != null)
			{
				GlobalClock.localTimeScale = (float)Math.Round(num, 3);
			}
			if (Timekeeper.instance != null)
			{
				Clock clock = Timekeeper.instance.Clock("Ambience");
				if (clock != null)
				{
					float target = rigid.velocity.magnitude / (fullShootVelocity / 3f);
					currentAmbientTimescale = Mathf.MoveTowards(currentAmbientTimescale, target, Time.deltaTime * 0.5f);
					clock.localTimeScale = Mathf.Lerp(0.2f, 2f, currentAmbientTimescale);
				}
			}
		}
		if (GolfBallController != null)
		{
			if (EquippedGun != null)
			{
				GolfBallController.affectTime = false;
			}
			else if (rigid != null)
			{
				Ray ray = new Ray(rigid.position + Vector3.up, Vector3.down);
				int num2 = LayerMask.NameToLayer("Ground");
				int num3 = LayerMask.NameToLayer("Default");
				int layerMask = (1 << num2) | (1 << num3);
				if (Physics.SphereCast(ray, SphereCastRadius, MaxDistance, layerMask))
				{
					GolfBallController.affectTime = false;
				}
				else
				{
					GolfBallController.affectTime = true;
				}
			}
			if (EquippedGun != null && EquippedGun.StopRigidbodyOnPickup && rigid != null)
			{
				rigid.velocity *= 0.4f;
			}
		}
		if (RotateGunWithPlayer && EquippedGun != null && GolfBallController != null && !GolfBallController.isAiming)
		{
			EquippedGun.transform.rotation = Quaternion.LookRotation(base.transform.forward);
		}
		if (killEquipBlockTimer > 0f)
		{
			killEquipBlockTimer -= Time.deltaTime;
		}
	}

	public override void OnShoot(Vector3 boost)
	{
		if (EquippedGun == null || IsShooting)
		{
			OnPlayerShot?.Invoke(null, boost);
			Vector3 vector = ((rigid != null) ? rigid.velocity : Vector3.zero);
			base.OnShoot(boost);
			if (useSlowShot && rigid != null)
			{
				Debug.Log("Using slow speed: " + slowShootPct);
				rigid.velocity = rigid.velocity * slowShootPct + vector * (1f - slowShootPct);
			}
			return;
		}
		OnPlayerShot?.Invoke(EquippedGun, boost);
		extraTime = 0.3f;
		IsShooting = true;
		if (CameraManager.Instance != null)
		{
			CameraManager.Instance.Shake(0.2f, 10f, 1f);
		}
		Vector3 normalized = boost.normalized;
		EquippedGun.Shoot(collider, normalized, delegate
		{
			if (EquippedGun != null && EquippedGun.ShotsLeft <= 0)
			{
				if (collider != null && EquippedGun.collider != null)
				{
					Physics.IgnoreCollision(collider, EquippedGun.collider, true);
				}
				EquippedGun.DestroyGun(null);
				EquippedGun = null;
				if (GolfBallController != null && GolfBallController.shootArrow != null)
				{
					GolfBallController.shootArrow.transform.localScale = Vector3.one;
				}
			}
			IsShooting = false;
		});
		if (KnockbackWhenShooting)
		{
			base.OnShoot(boost * -0.5f);
		}
	}

	public override void OnAimUpdate(Vector3 boost, bool onlyAimArrow)
	{
		if (EquippedGun != null)
		{
			EquippedGun.transform.rotation = Quaternion.LookRotation(boost);
			EquippedGun.ToggleLaser(boost.magnitude >= 0.1f);
		}
		if (RotatePlayerOnAim)
		{
			base.transform.rotation = Quaternion.LookRotation(boost);
		}
		lastBoost = boost;
	}

	public void SetExtraTime(float time)
	{
		extraTime = time;
	}

	public void StopAiming()
	{
		if (EquippedGun != null)
		{
			EquippedGun.ToggleLaser(false);
		}
	}

	private void OnTriggerEnter(Collider other)
	{
		if (other != null && other.CompareTag("ShieldWeakness"))
		{
			Kill();
		}
	}

	private void OnCollisionEnter(Collision other)
	{
		if (other == null || other.gameObject == null)
		{
			return;
		}
		SuperGolfShootEnemy componentInChildren = other.gameObject.GetComponentInChildren<SuperGolfShootEnemy>();
		SuperGolfGun componentInChildren2 = other.gameObject.GetComponentInChildren<SuperGolfGun>();
		if (componentInChildren2 != null && !componentInChildren2.IsEquipped() && EquippedGun == null && killEquipBlockTimer <= 0f)
		{
			if (sfxOnPickup != null && sfxOnPickup.Count >= 1)
			{
				sfxOnPickup.Play(null, base.transform.position, 1f, 1f);
			}
			else if (WeaponPickupClips != null && WeaponPickupClips.Count >= 1 && AudioManager.Instance != null && AudioManager.Instance.sfx != null)
			{
				AudioManager.Instance.sfx.Play(WeaponPickupClips, delegate(AudioSource t)
				{
					if (t != null)
					{
						t.transform.position = base.transform.position;
					}
				}, true, false, 0f);
			}
			EquippedGun = componentInChildren2;
			componentInChildren2.transform.rotation = Quaternion.identity;
			componentInChildren2.SetOwner(GolfBallController);
			if (componentInChildren2.follow != null)
			{
				componentInChildren2.follow.PositionOffset = WeaponPositionOffset;
			}
			componentInChildren2.Equip(base.transform, false, null);
			EquippedGun.ToggleLaser(true);
			if (GolfBallController != null && GolfBallController.shootArrow != null)
			{
				GolfBallController.shootArrow.transform.localScale = Vector3.zero;
			}
			OnWeaponPickUp?.Invoke(componentInChildren2);
			return;
		}
		if (componentInChildren != null)
		{
			if (rigid != null && (rigid.velocity.magnitude >= SmashVelocity || Vector3.Dot(other.transform.forward, rigid.velocity) > 0f))
			{
				SuperGolfShootEnemy componentInChildren3 = other.gameObject.GetComponentInChildren<SuperGolfShootEnemy>();
				ContactPoint[] contacts = other.contacts;
				if (contacts != null && contacts.Length > 0 && componentInChildren3 != null)
				{
					Vector3 normalized = (contacts[0].point - base.transform.position).normalized;
					componentInChildren3.Kill(normalized);
				}
				rigid.velocity = velocityLastFrame;
			}
			else
			{
				Kill();
			}
		}
		else if ((bool)other.gameObject.GetComponentInChildren<SuperGolfShooter>())
		{
			Kill();
		}
	}

	public void Kill()
	{
		OnDeath?.Invoke(this);
		if (KillEquipBlockTime > 0f)
		{
			killEquipBlockTimer = KillEquipBlockTime;
		}
		if (!CanDie || IsDead)
		{
			return;
		}
		if (AudioManager.Instance != null && AudioManager.Instance.sfx != null && deathClip != null)
		{
			AudioManager.Instance.sfx.Play(deathClip, delegate(AudioSource s)
			{
				if (s != null)
				{
					s.volume = 0.35f;
				}
			}, false, 0f);
		}
		IsDead = true;
		if (rigid != null)
		{
			rigid.collisionDetectionMode = CollisionDetectionMode.ContinuousSpeculative;
			rigid.isKinematic = true;
		}
		if (collider != null)
		{
			collider.enabled = false;
		}
		if (Model != null)
		{
			Model.SetActive(false);
		}
		if (collider != null && objectShatter != null)
		{
			objectShatter.Shatter(collider.bounds.center, 30f, 2f, 1f, ForceMode.Impulse);
		}
		if (EquippedGun != null)
		{
			EquippedGun.ThrowGun(collider);
		}
		if (GolfBallController != null)
		{
			GolfBallController.StopAiming();
			GolfBallController.enabled = false;
		}
		if (RestartGameWhenDead)
		{
			float startTimeScale = ((GlobalClock != null) ? GlobalClock.localTimeScale : 1f);
			StartCoroutine(pTween.To(1.75f, delegate(float t)
			{
				if (GlobalClock != null)
				{
					GlobalClock.localTimeScale = Mathf.Lerp(startTimeScale, 1f, TweenFunctions.EaseIn(t));
				}
				if (Timekeeper.instance != null)
				{
					Clock clock = Timekeeper.instance.Clock("Ambience");
					if (clock != null && GlobalClock != null)
					{
						clock.localTimeScale = GlobalClock.localTimeScale;
					}
				}
			}).Then(delegate
			{
				if (Level.Instance != null)
				{
					Level.Instance.Fail(true, true, null, 0f, true, "");
				}
			}));
		}
		else if (Level.Instance != null && Level.Instance.Goal != null && GolfBallController != null)
		{
			int num = GolfBallController.PlayerID + 1;
			Level.Instance.Goal.TriggerGoal("Player " + num + " lost!");
		}
	}
}
