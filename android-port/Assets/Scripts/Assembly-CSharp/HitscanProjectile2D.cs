using System;
using System.Collections;
using Audio;
using UnityEngine;

public class HitscanProjectile2D : SuperGolfBullet
{
	public float Force = 10f;

	public float TrailOffset = 5f;

	public float distance = 100f;

	public LayerMask hitMask;

	public bool CanShootFlag = true;

	public ClipSettingsCollection _ricochetSounds;

	public ClipSettingsCollection shootSounds;

	private float lifetimeTimer;

	private ParticleSystem particles;

	private int bouncesLeft;

	private int bouncesDone;

	private TrailRenderer projectileTrail;

	protected override void Awake()
	{
		base.Awake();
		particles = GetComponentInChildren<ParticleSystem>();
		projectileTrail = GetComponent<TrailRenderer>();
	}

	protected override void OnEnable()
	{
		if (distance > 100f)
		{
			distance = 100f;
		}
		lifetimeTimer = 0f;
		bouncesLeft = Bounces;
		bouncesDone = 0;
		if (projectileTrail != null)
		{
			projectileTrail.widthMultiplier = 1f;
		}
		StartCoroutine(LaunchProjectile());
	}

	private IEnumerator LaunchProjectile()
	{
		if (shootSounds != null)
		{
			shootSounds.Play(base.transform.position);
		}
		if (bouncesLeft <= 0)
		{
			yield return null;
			CheckProjectilePath(base.transform.position, base.transform.forward);
			yield break;
		}
		while (bouncesLeft >= 0)
		{
			yield return null;
			CheckProjectilePath(base.transform.position, base.transform.forward);
			yield return null;
		}
	}

	private void CheckProjectilePath(Vector3 origin, Vector3 direction)
	{
		float volumeMod = ((Bounces >= 1) ? (1f - (float)bouncesDone / (float)Bounces) : 1f);
		bouncesLeft--;
		Vector2 origin2 = new Vector2(origin.x + direction.x * 0.1f, origin.y + direction.y * 0.1f);
		Vector2 direction2 = new Vector2(direction.x, direction.y);
		RaycastHit2D raycastHit2D = Physics2D.Raycast(origin2, direction2, distance, hitMask);
		if (raycastHit2D.transform != null)
		{
			if (_ricochetSounds != null)
			{
				_ricochetSounds.Play(raycastHit2D.point, volumeMod);
			}
			if (raycastHit2D.rigidbody != null)
			{
				IHitscanTarget[] components = raycastHit2D.transform.gameObject.GetComponents<IHitscanTarget>();
				if (components != null && components.Length != 0)
				{
					Action<IHitscanTarget> action = null;
					for (int i = 0; i < components.Length; i++)
					{
						IHitscanTarget hitscanTarget = components[i];
						if (hitscanTarget != null)
						{
							Action<IHitscanTarget> onHitscanTriggered = hitscanTarget.OnHitscanTriggered;
							if (onHitscanTriggered != null)
							{
								action = onHitscanTriggered;
								action(hitscanTarget);
							}
							hitscanTarget.TriggerHitscan(raycastHit2D.point);
						}
					}
				}
				if (!raycastHit2D.rigidbody.isKinematic)
				{
					raycastHit2D.rigidbody.AddForceAtPosition(-raycastHit2D.normal * Force, raycastHit2D.point, ForceMode2D.Impulse);
				}
				if (CanShootFlag)
				{
					GolfGoal component = raycastHit2D.rigidbody.GetComponent<GolfGoal>();
					if (component != null)
					{
						component.Complete(0.2f);
					}
				}
			}
			bouncesDone++;
			base.transform.position = raycastHit2D.point;
			Vector2 vector = Vector2.Reflect(direction2, raycastHit2D.normal);
			base.transform.rotation = Quaternion.LookRotation(new Vector3(vector.x, vector.y, 0f));
			if (particles != null)
			{
				particles.transform.rotation = Quaternion.LookRotation(raycastHit2D.normal);
				particles.Play();
			}
		}
		else
		{
			base.transform.position = origin + direction * distance;
			bouncesLeft = -1;
		}
	}

	protected override void Update()
	{
		lifetimeTimer += Time.deltaTime;
		if (lifetimeTimer > LifeTime)
		{
			KillBullet(Vector3.zero);
		}
		if (projectileTrail != null && projectileTrail.time > 0f)
		{
			projectileTrail.widthMultiplier = Mathf.Clamp01(1f - lifetimeTimer / projectileTrail.time);
		}
	}

	protected override void KillBullet(Vector3 point)
	{
		if (pool != null)
		{
			pool.Release(base.gameObject, true);
		}
	}

	public override void SetSpeed(float speedMod)
	{
	}
}
