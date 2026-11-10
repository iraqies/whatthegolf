using System;
using System.Collections;
using System.Collections.Generic;
using Audio;
using Audio.Rumble;
using Chronos;
using Core;
using UnityEngine;
using UnityEngine.AI;

public class SuperGolfShootEnemy : MonoBehaviour
{
	public Transform Target;

	public ParticleSystem DeathParticles;

	public ParticleSystem SpawnParticles;

	public Vector2 SpawnInterval;

	public int Health = 1;

	public bool LookAtTarget = true;

	public List<AudioClip> DeathClips;

	public List<RumbleEventAsset> DeathRumbles;

	public SuperGolfGun EquippedGun;

	public Transform GunHand;

	public Vector2 ShootInterval;

	public bool RequireLOS = true;

	public float ShootingRange = 100f;

	public Vector3 UnequippedGunRotation = new Vector3(90f, 180f, 0f);

	public Vector3 EquippedGunRotation = new Vector3(-90f, -90f, -1f);

	public float FirstShotTime;

	public bool ChaseEnemy;

	public float StopDistance;

	public float AlertDistance = 500f;

	public Quaternion DeathRotation;

	public Action<SuperGolfShootEnemy> OnDeath;

	private Timeline timeline;

	private float shootTimer;

	private float spawnTime;

	private NavMeshAgent agent;

	private Renderer[] renderers;

	private Light light;

	private Collider collider;

	private float startLightIntensity;

	private bool hasSpawned;

	private Rigidbody targetRigidbody;

	private Animator animator;

	private float predictionRatio = 1f;

	private float bulletSpeed = 20f;

	private float layerWeightChange;

	private float avgTargetVelocityMagnitude;

	private float capsuleRadius;

	private bool gameWon;

	private SuperGolfShooter playerShooter;

	private ObjectShatter objectShatter;

	private void Awake()
	{
		timeline = GetComponent<Timeline>();
		renderers = GetComponentsInChildren<Renderer>();
		agent = GetComponent<NavMeshAgent>();
		light = GetComponent<Light>();
		collider = GetComponentInChildren<Collider>();
		animator = GetComponentInChildren<Animator>();
		if (Target != null)
		{
			targetRigidbody = Target.GetComponentInParent<Rigidbody>();
		}
		CapsuleCollider componentInChildren = GetComponentInChildren<CapsuleCollider>();
		if (componentInChildren != null)
		{
			capsuleRadius = componentInChildren.radius;
		}
		objectShatter = GetComponentInChildren<ObjectShatter>();
	}

	private void Start()
	{
		if (EquippedGun != null)
		{
			EquippedGun = UnityEngine.Object.Instantiate(EquippedGun);
			if (EquippedGun != null)
			{
				EquippedGun.Equip(GunHand, true, null);
				if (Target != null && Vector3.Distance(base.transform.position, Target.position) > ShootingRange)
				{
					if (EquippedGun.follow != null)
					{
						EquippedGun.follow.RotationOffset = UnequippedGunRotation;
					}
					layerWeightChange = 0f;
					if (animator != null)
					{
						animator.SetLayerWeight(1, 0f);
					}
				}
				else
				{
					if (EquippedGun.follow != null)
					{
						EquippedGun.follow.RotationOffset = EquippedGunRotation;
					}
					layerWeightChange = 1f;
					if (animator != null)
					{
						animator.SetLayerWeight(1, 1f);
					}
				}
				if (EquippedGun.follow != null)
				{
					EquippedGun.follow.ManualFollowUpdate();
				}
			}
		}
		if (Target == null && EquippedGun != null)
		{
			GameObject gameObject = new GameObject("Target");
			Target = gameObject.transform;
			if (EquippedGun.BulletSpawnPoint != null)
			{
				Target.SetParent(EquippedGun.BulletSpawnPoint);
			}
			Target.localRotation = Quaternion.identity;
			Target.localPosition = new Vector3(0f, 0f, 1f);
		}
		if (Target != null && Target.CompareTag("Player"))
		{
			playerShooter = Target.GetComponent<SuperGolfShooter>();
		}
		if (FirstShotTime >= 0f)
		{
			shootTimer = FirstShotTime;
		}
		else
		{
			shootTimer = UnityEngine.Random.Range(ShootInterval.x, ShootInterval.y);
		}
		spawnTime = UnityEngine.Random.Range(SpawnInterval.x, SpawnInterval.y);
		if (light != null)
		{
			startLightIntensity = light.intensity;
			light.intensity = 0f;
		}
		if (agent != null)
		{
			agent.stoppingDistance = StopDistance;
		}
		if ((SpawnInterval - Vector2.zero).sqrMagnitude < 1E-10f)
		{
			if (renderers != null)
			{
				for (int i = 0; i < renderers.Length; i++)
				{
					if (renderers[i] != null)
					{
						renderers[i].enabled = true;
					}
				}
			}
			hasSpawned = true;
		}
		else if (renderers != null)
		{
			for (int j = 0; j < renderers.Length; j++)
			{
				if (renderers[j] != null)
				{
					renderers[j].enabled = false;
				}
			}
		}
		if (Level.Instance != null)
		{
			Level.Instance.OnComplete += delegate
			{
				gameWon = true;
			};
		}
	}

	private void Update()
	{
		if (targetRigidbody != null)
		{
			float magnitude = targetRigidbody.GetRelativePointVelocity(targetRigidbody.position).magnitude;
			avgTargetVelocityMagnitude = Mathf.Sqrt(magnitude * (targetRigidbody.drag - targetRigidbody.angularDrag));
		}
		if (spawnTime > 0f)
		{
			if (timeline != null)
			{
				spawnTime -= timeline.deltaTime;
			}
			if (spawnTime <= 0f)
			{
				if (SpawnParticles != null)
				{
					SpawnParticles.transform.position = base.transform.position;
					SpawnParticles.Emit(100);
					StartCoroutine(SpawnDelay());
				}
				else
				{
					if (renderers != null)
					{
						for (int i = 0; i < renderers.Length; i++)
						{
							if (renderers[i] != null)
							{
								renderers[i].enabled = true;
							}
						}
					}
					hasSpawned = true;
				}
			}
			return;
		}
		if (!hasSpawned || Target == null)
		{
			return;
		}
		if (LookAtTarget)
		{
			base.transform.LookAt(new Vector3(Target.position.x, base.transform.position.y, Target.position.z));
		}
		Vector3 vector = ((targetRigidbody != null) ? (targetRigidbody.velocity.normalized * avgTargetVelocityMagnitude) : Vector3.zero);
		float num = Vector3.Distance(base.transform.position, Target.position + vector);
		Vector3 vector2 = Target.position + vector * predictionRatio * (num * 0.5f / bulletSpeed);
		Debug.DrawLine(base.transform.position, vector2, Color.red);
		if (Target.CompareTag("Player") && playerShooter != null && playerShooter.IsDead)
		{
			gameWon = true;
		}
		if (EquippedGun != null && Vector3.Distance(base.transform.position, Target.position) <= ShootingRange && !gameWon)
		{
			if (EquippedGun.follow != null)
			{
				EquippedGun.follow.RotationOffset = EquippedGunRotation;
			}
			if (timeline != null)
			{
				layerWeightChange = Mathf.Min(1f, layerWeightChange + timeline.deltaTime * 3f);
				if (animator != null)
				{
					animator.SetLayerWeight(1, layerWeightChange);
				}
				shootTimer -= timeline.deltaTime * Time.timeScale;
			}
			if (layerWeightChange >= 1f && shootTimer <= 0f)
			{
				int layerMask = 1 << LayerMask.NameToLayer("Ground");
				if (!RequireLOS || !Physics.Linecast(base.transform.position, vector2, layerMask))
				{
					Debug.DrawLine(vector2, vector2 + Vector3.up, Color.red);
					if (EquippedGun != null && EquippedGun.BulletSpawnPoint != null)
					{
						Vector3 position = EquippedGun.BulletSpawnPoint.position;
						Vector3 normalized = (new Vector3(vector2.x, position.y, vector2.z) - EquippedGun.BulletSpawnPoint.position).normalized;
						EquippedGun.Shoot(collider, normalized, null);
						if (animator != null)
						{
							animator.SetTrigger("Shoot");
						}
					}
					shootTimer = UnityEngine.Random.Range(ShootInterval.x, ShootInterval.y);
				}
			}
		}
		else
		{
			if (EquippedGun != null && EquippedGun.follow != null)
			{
				EquippedGun.follow.RotationOffset = UnequippedGunRotation;
			}
			if (timeline != null)
			{
				layerWeightChange = Mathf.Max(0f, layerWeightChange - timeline.deltaTime * 3f);
				if (animator != null)
				{
					animator.SetLayerWeight(1, layerWeightChange);
				}
			}
		}
		if (!ChaseEnemy || agent == null)
		{
			return;
		}
		if (Vector3.Distance(Target.position, base.transform.position) > AlertDistance)
		{
			agent.isStopped = true;
			return;
		}
		agent.isStopped = false;
		int layerMask2 = 1 << LayerMask.NameToLayer("Ground");
		if (Physics.SphereCast(base.transform.position, capsuleRadius, Target.position - base.transform.position, out var hitInfo, float.PositiveInfinity, layerMask2))
		{
			agent.stoppingDistance = Vector3.Distance(Target.position, base.transform.position) - hitInfo.distance + capsuleRadius;
		}
		else
		{
			agent.stoppingDistance = StopDistance;
		}
		agent.SetDestination(Target.position);
	}

	private void ToggleRenderers(bool state)
	{
		if (renderers == null)
		{
			return;
		}
		for (int i = 0; i < renderers.Length; i++)
		{
			if (renderers[i] != null)
			{
				renderers[i].enabled = state;
			}
		}
	}

	private IEnumerator SpawnDelay()
	{
		float timer = 0f;
		while (SpawnParticles != null && timer <= SpawnParticles.main.startLifetime.constant * 0.5f)
		{
			yield return null;
			if (timeline != null)
			{
				timer += timeline.deltaTime;
			}
		}
		ToggleRenderers(true);
		timer = 0f;
		while (SpawnParticles != null && timer <= SpawnParticles.main.startLifetime.constant * 0.5f)
		{
			yield return null;
			if (timeline != null)
			{
				timer += timeline.deltaTime;
			}
			if (light != null)
			{
				light.intensity = Mathf.Lerp(0f, startLightIntensity, timer / (SpawnParticles.main.startLifetime.constant * 0.5f));
			}
		}
		hasSpawned = true;
	}

	public void Kill()
	{
		Kill(Vector3.zero);
	}

	public void Kill(Vector3 direction)
	{
		if (collider != null)
		{
			collider.enabled = false;
		}
		if (EquippedGun != null)
		{
			EquippedGun.transform.position = base.transform.position;
			EquippedGun.Equip(null, true, collider);
		}
		EquippedGun = null;
		ChaseEnemy = false;
		if (collider != null && objectShatter != null)
		{
			objectShatter.Shatter(collider.bounds.center - direction, 5f, 4f, 0f, ForceMode.Impulse);
		}
		if (DeathClips != null && DeathClips.Count >= 1 && AudioManager.Instance != null && AudioManager.Instance.sfx != null)
		{
			AudioManager.Instance.sfx.Play(DeathClips, delegate(AudioSource t)
			{
				if (t != null)
				{
					t.transform.position = base.transform.position;
					t.volume = 0.3f;
				}
			}, true, false, 0f);
		}
		if (DeathRumbles != null)
		{
			DeathRumbles.PlayOnAllControllers(1f);
		}
		OnDeath?.Invoke(this);
		UnityEngine.Object.Destroy(base.gameObject);
	}

	private void OnDestroy()
	{
		_ = DeathParticles != null;
	}

	private void OnDrawGizmosSelected()
	{
		if (EquippedGun != null)
		{
			Gizmos.DrawWireSphere(base.transform.position, ShootingRange);
		}
		else if (ChaseEnemy)
		{
			Gizmos.DrawWireSphere(base.transform.position, AlertDistance);
		}
	}

	private void OnDrawGizmos()
	{
		_ = EquippedGun != null;
	}

	private void OnDisable()
	{
		if (EquippedGun != null)
		{
			EquippedGun.gameObject.SetActive(false);
		}
	}
}
