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

	public int Amount = 1;

	public int ShotsLeft = 1;

	public float Spread;

	public float TimeSpread;

	public ParticleSystem ShootParticles;

	public List<AudioClip> ShootClips;

	public ClipSettingsCollection sfxOnShoot;

	public bool CanBePickedUp = true;

	public Collider collider;

	public FollowTransform follow;

	public bool StopRigidbodyOnPickup = true;

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
		if (!initialized)
		{
			follow = GetComponent<FollowTransform>();
			collider = GetComponent<Collider>();
			rigidbody = GetComponent<Rigidbody>();
			laser = GetComponent<LaserSight>();
			timeline = GetComponent<Timeline>();
			flash = GetComponentInChildren<Light>();
			initialized = true;
		}
	}

	private void Start()
	{
		if (BulletPrefab != null)
		{
			bulletPool = new ObjectPool<GameObject>(BulletPrefab, 10, null);
		}
		ToggleLaser(false);
	}

	public void SetOwner(GolfBallController owner)
	{
		if (laser != null)
		{
			laser.SetOwner(owner);
		}
	}

	public virtual void Equip(Transform hand, bool followRotation, Collider shooterCollider = null)
	{
		if (!initialized)
		{
			Awake();
		}
		if (flash != null)
		{
			flash.intensity = 0f;
		}
		if (follow != null)
		{
			follow.Target = hand;
			follow.FollowRotation = followRotation;
		}
		if (collider != null)
		{
			collider.enabled = hand == null;
		}
		if (ToggleKinematicOnPickup && timeline != null && timeline.rigidbody != null && collider != null)
		{
			timeline.rigidbody.isKinematic = !collider.enabled;
		}
		if (LockYOnPickup && rigidbody != null)
		{
			rigidbody.constraints = RigidbodyConstraints.FreezePositionY;
		}
		if (hand == null)
		{
			ThrowGun(shooterCollider);
		}
	}

	public virtual bool IsEquipped()
	{
		if (follow != null && follow.Target != null)
		{
			return true;
		}
		if (explodeOnImpact)
		{
			return true;
		}
		return !CanBePickedUp;
	}

	public void Shoot(Collider shooterCollider, Vector3 direction, Action onFinishedShooting = null)
	{
		if (ShootParticles != null)
		{
			ShootParticles.Emit(150);
		}
		if (flash != null)
		{
			StartCoroutine(Flash());
		}
		StartCoroutine(StartShooting(shooterCollider, direction, onFinishedShooting));
		if (sfxOnShoot != null && sfxOnShoot.Count >= 1)
		{
			if (AudioManager.Instance != null)
			{
				sfxOnShoot.Play(AudioManager.Instance.sfx, Vector3.zero, 0f);
			}
		}
		else if (ShootClips != null && ShootClips.Count >= 1 && AudioManager.Instance != null && AudioManager.Instance.sfx != null)
		{
			AudioManager.Instance.sfx.Play(ShootClips, delegate(AudioSource t)
			{
				if (t != null)
				{
					t.transform.position = base.transform.position;
					t.volume = 0.25f;
				}
			}, true, false, 0f);
		}
	}

	protected virtual IEnumerator StartShooting(Collider shooterCollider, Vector3 direction, Action onFinishedShooting = null)
	{
		if (BulletSpawnPoint != null)
		{
			int layerMask = 1 << LayerMask.NameToLayer("Ground");
			if (!Physics.Linecast(base.transform.position, BulletSpawnPoint.position + direction * 3f, layerMask))
			{
				ShotsLeft--;
				for (int i = 0; i < Amount; i++)
				{
					float y = ((float)i + (float)Amount * -0.5f) * Spread;
					Vector3 forward = Quaternion.Euler(0f, y, 0f) * direction;
					if (bulletPool == null)
					{
						yield break;
					}
					GameObject gameObject = bulletPool.Get(BulletSpawnPoint.position, Quaternion.LookRotation(forward, Vector3.up));
					if (gameObject != null)
					{
						SuperGolfBullet componentInChildren = gameObject.GetComponentInChildren<SuperGolfBullet>();
						if (componentInChildren != null)
						{
							componentInChildren.BulletPool = bulletPool;
							if (componentInChildren.previousOwnerCollider != null && componentInChildren.collider != null)
							{
								Physics.IgnoreCollision(componentInChildren.collider, componentInChildren.previousOwnerCollider, false);
							}
							if (componentInChildren.collider != null)
							{
								if (shooterCollider != null)
								{
									Physics.IgnoreCollision(componentInChildren.collider, shooterCollider, true);
								}
								if (collider != null)
								{
									Physics.IgnoreCollision(componentInChildren.collider, collider);
								}
							}
							componentInChildren.previousOwnerCollider = shooterCollider;
						}
						gameObject.SetActive(true);
					}
					if (TimeSpread > 0f && timeline != null)
					{
						yield return timeline.WaitForSeconds(TimeSpread);
					}
				}
			}
		}
		onFinishedShooting?.Invoke();
	}

	protected virtual void OnCollisionEnter(Collision other)
	{
		if (explodeOnImpact && other != null && other.gameObject != null)
		{
			_ = other.gameObject.layer;
			LayerMask.NameToLayer("Ground");
		}
	}

	public virtual void DestroyGun(Collider shooterCollider = null)
	{
		ToggleLaser(false);
		base.gameObject.SetActive(false);
	}

	public virtual void ThrowGun(Collider shooterCollider)
	{
		if (follow != null)
		{
			follow.Target = null;
		}
		if (shooterCollider != null && collider != null)
		{
			Physics.IgnoreCollision(collider, shooterCollider, true);
		}
		_ = UnityEngine.Random.insideUnitCircle.normalized;
		Vector3 forward = base.transform.forward;
		base.transform.rotation = Quaternion.identity;
		AddForce(Vector3.ClampMagnitude(new Vector3(forward.x * 5f, 10f, forward.z * 5f), 5f));
		StartCoroutine(pTween.To(1f, delegate
		{
		}).Then(delegate
		{
			if (shooterCollider != null && collider != null)
			{
				Physics.IgnoreCollision(collider, shooterCollider, false);
			}
		}));
	}

	public void AddForce(Vector3 force)
	{
		if (timeline != null && timeline.rigidbody != null)
		{
			timeline.rigidbody.velocity = force;
			timeline.rigidbody.angularVelocity = force;
		}
	}

	public void ToggleLaser(bool state)
	{
		if (laser != null)
		{
			laser.enabled = state;
		}
	}

	private IEnumerator Flash()
	{
		float minIntensity = 0.1f;
		float time = 0.2f;
		if (flash != null)
		{
			flash.intensity = 0.2f;
		}
		while (flash != null && flash.intensity > minIntensity)
		{
			flash.intensity = Mathf.PingPong(time, 3f);
			if (timeline != null)
			{
				time += timeline.deltaTime * 30f;
			}
			yield return null;
		}
		if (flash != null)
		{
			flash.intensity = 0f;
		}
	}
}
