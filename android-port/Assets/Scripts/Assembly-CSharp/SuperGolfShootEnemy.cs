using System;
using System.Collections;
using System.Collections.Generic;
using Audio.Rumble;
using Chronos;
using UnityEngine;
using UnityEngine.AI;

public class SuperGolfShootEnemy : MonoBehaviour
{
	public Transform Target;

	public ParticleSystem DeathParticles;

	public ParticleSystem SpawnParticles;

	public Vector2 SpawnInterval;

	public int Health;

	public bool LookAtTarget;

	public List<AudioClip> DeathClips;

	public List<RumbleEventAsset> DeathRumbles;

	public SuperGolfGun EquippedGun;

	public Transform GunHand;

	public Vector2 ShootInterval;

	public bool RequireLOS;

	public float ShootingRange;

	public Vector3 UnequippedGunRotation;

	public Vector3 EquippedGunRotation;

	public float FirstShotTime;

	public bool ChaseEnemy;

	public float StopDistance;

	public float AlertDistance;

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

	private float predictionRatio;

	private float bulletSpeed;

	private float layerWeightChange;

	private float avgTargetVelocityMagnitude;

	private float capsuleRadius;

	private bool gameWon;

	private SuperGolfShooter playerShooter;

	private ObjectShatter objectShatter;

	private void Awake()
	{
	}

	private void Start()
	{
	}

	private void Update()
	{
	}

	private void ToggleRenderers(bool state)
	{
	}

	private IEnumerator SpawnDelay()
	{
		return null;
	}

	public void Kill()
	{
	}

	public void Kill(Vector3 direction)
	{
	}

	private void OnDestroy()
	{
	}

	private void OnDrawGizmosSelected()
	{
	}

	private void OnDrawGizmos()
	{
	}

	private void OnDisable()
	{
	}
}
