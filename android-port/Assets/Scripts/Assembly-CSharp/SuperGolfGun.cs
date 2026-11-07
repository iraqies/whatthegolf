using System;
using System.Collections;
using System.Collections.Generic;
using Audio;
using Chronos;
using Core;
using UnityEngine;
using Utility;

public class SuperGolfGun : MonoBehaviour
{
	public GameObject BulletPrefab;

	public Transform BulletSpawnPoint;

	public int Amount;

	public int ShotsLeft;

	public float Spread;

	public float TimeSpread;

	public ParticleSystem ShootParticles;

	public List<AudioClip> ShootClips;

	public ClipSettingsCollection sfxOnShoot;

	public bool CanBePickedUp;

	public Collider collider;

	public FollowTransform follow;

	public bool StopRigidbodyOnPickup;

	public bool ToggleKinematicOnPickup;

	public bool LockYOnPickup;

	private ObjectPool<GameObject> bulletPool;

	private bool explodeOnImpact;

	private LaserSight laser;

	private Light flash;

	private bool initialized;

	protected Timeline timeline;

	protected Rigidbody rigidbody;

	private void Awake()
	{
	}

	private void Start()
	{
	}

	public void SetOwner(GolfBallController owner)
	{
	}

	public virtual void Equip(Transform hand, bool followRotation, Collider shooterCollider = null)
	{
	}

	public virtual bool IsEquipped()
	{
		return false;
	}

	public void Shoot(Collider shooterCollider, Vector3 direction, Action onFinishedShooting = null)
	{
	}

	protected virtual IEnumerator StartShooting(Collider shooterCollider, Vector3 direction, Action onFinishedShooting = null)
	{
		return null;
	}

	protected virtual void OnCollisionEnter(Collision other)
	{
	}

	public virtual void DestroyGun(Collider shooterCollider = null)
	{
	}

	public virtual void ThrowGun(Collider shooterCollider)
	{
	}

	public void AddForce(Vector3 force)
	{
	}

	public void ToggleLaser(bool state)
	{
	}

	private IEnumerator Flash()
	{
		return null;
	}
}
