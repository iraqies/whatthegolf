using System.Collections;
using Audio;
using UnityEngine;

public class HitscanProjectile : SuperGolfBullet
{
	public float Force = 15f;

	public float TrailOffset = 0.5f;

	public RandomAudioClips ricochetSounds;

	private float lifetimeTimer;

	private ParticleSystem particles;

	protected override void Awake()
	{
		base.Awake();
		particles = GetComponentInChildren<ParticleSystem>();
	}

	protected override void OnEnable()
	{
		lifetimeTimer = LifeTime;
		if (Physics.Raycast(transform.position, transform.forward, out RaycastHit hit, 100f))
		{
			if (trail != null)
			{
				trail.Clear();
				StartCoroutine(NextFrameMoveTrail(hit));
			}
			if (hit.collider != null)
			{
				SuperGolfShootEnemy enemy = hit.collider.GetComponentInParent<SuperGolfShootEnemy>();
				if (enemy != null)
				{
					enemy.Health--;
					if (enemy.Health <= 0)
					{
						enemy.DeathRotation = Quaternion.LookRotation(transform.forward);
						enemy.Kill(transform.forward);
					}
				}
				else if (hit.collider.CompareTag("Player"))
				{
					SuperGolfShooter shooter = hit.collider.GetComponentInParent<SuperGolfShooter>();
					if (shooter != null)
					{
						shooter.Kill();
					}
				}
				else if (hit.rigidbody != null)
				{
					hit.rigidbody.AddForceAtPosition(transform.forward * Force, hit.point, ForceMode.Impulse);
				}
			}
			if (ricochetSounds != null && AudioManager.Instance != null && AudioManager.Instance.shortEffects != null)
			{
				AudioManager.Instance.shortEffects.PlayRandomClip(ricochetSounds);
			}
			if (BulletDeathParticles != null)
			{
				BulletDeathParticles.transform.position = hit.point;
				BulletDeathParticles.transform.rotation = Quaternion.LookRotation(hit.normal);
				BulletDeathParticles.Emit(25);
			}
		}
	}

	private IEnumerator NextFrameMoveTrail(RaycastHit hit)
	{
		yield return null;
		if (trail != null)
		{
			trail.transform.position = hit.point - transform.forward * TrailOffset;
		}
	}

	protected override void Update()
	{
		lifetimeTimer -= Time.deltaTime;
		if (lifetimeTimer <= 0f)
		{
			KillBullet(transform.position);
		}
	}

	protected override void KillBullet(Vector3 point)
	{
		if (trail != null)
		{
			trail.transform.localPosition = Vector3.zero;
			trail.Clear();
		}
		if (BulletPool != null)
		{
			BulletPool.Return(gameObject, true);
		}
		else
		{
			gameObject.SetActive(false);
		}
		OnBulletDeath?.Invoke(this);
	}

	public override void SetSpeed(float speedMod)
	{
	}
}
