using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Utility;

public class OverworldEndBall : OverworldBall2D
{
	public List<Renderer> sprites;

	public float shootInterval;

	public int maxShots = 100;

	public float backMoveForceSpeed = 10f;

	public float shootSpeed = 10f;

	public Rigidbody2D spitPrefab;

	public float RequiredDistanceForHittingFlags = 2f;

	public AudioSource jetpackAudioSource;

	private float distanceMovedSinceHitFlag;

	private Vector3 lastPos;

	private float timeSinceLastShot;

	private ObjectPool<Rigidbody2D> pool;

	private Queue<Rigidbody2D> spawnedSpit;

	public AudioClip sfxSpit;

	private bool isDead;

	private SaveEvents save;

	public ParticleSystem[] JetpackParticles;

	public Animator[] FireAnimators;

	protected override void Awake()
	{
		base.Awake();
		save = GetComponent<SaveEvents>();
		spawnedSpit = new Queue<Rigidbody2D>(maxShots);
		if (spitPrefab != null)
		{
			pool = new ObjectPool<Rigidbody2D>(spitPrefab.gameObject, maxShots);
		}
	}

	protected override void Controller_OnAimUpdate(Vector3 dir, bool onlyLine)
	{
		base.Controller_OnAimUpdate(dir, onlyLine);
		if (onlyLine)
		{
			return;
		}
		distanceMovedSinceHitFlag += Vector3.Distance(base.transform.position, lastPos);
		lastPos = base.transform.position;
		if (!canHitFlags && distanceMovedSinceHitFlag >= RequiredDistanceForHittingFlags)
		{
			canHitFlags = true;
			distanceMovedSinceHitFlag = 0f;
		}
		timeSinceLastShot += Time.deltaTime;
		if (timeSinceLastShot > shootInterval)
		{
			timeSinceLastShot = 0f;
		}
		if (rigid != null)
		{
			Vector3 normalized = dir.normalized;
			rigid.AddForce(new Vector2(normalized.x * Time.deltaTime * backMoveForceSpeed, normalized.y * Time.deltaTime * backMoveForceSpeed));
		}
	}

	private void ShootBullet(Vector3 dir)
	{
		if (pool == null)
		{
			return;
		}
		GameObject gameObject = pool.Retrieve(base.transform.position, Quaternion.identity, base.transform);
		if (gameObject == null)
		{
			return;
		}
		Rigidbody2D component = gameObject.GetComponent<Rigidbody2D>();
		spawnedSpit.Enqueue(component);
		if (component != null)
		{
			component.velocity = new Vector2(dir.x * shootSpeed, dir.y * shootSpeed);
		}
		if (spawnedSpit.Count > maxShots)
		{
			Rigidbody2D rigidbody2D = spawnedSpit.Dequeue();
			if (rigidbody2D != null)
			{
				pool.Release(rigidbody2D.gameObject, true);
			}
		}
	}

	private void OnEnable()
	{
		if (spawnedSpit == null || pool == null)
		{
			return;
		}
		while (spawnedSpit.Count > 0)
		{
			Rigidbody2D rigidbody2D = spawnedSpit.Dequeue();
			if (rigidbody2D != null)
			{
				pool.Release(rigidbody2D.gameObject, true);
			}
		}
	}

	protected override void Controller_OnAimStart()
	{
		base.Controller_OnAimStart();
		distanceMovedSinceHitFlag = 0f;
		StartJetpack();
	}

	protected override void Shooter_OnShoot(Vector3 dir)
	{
		StopJetpack();
	}

	public override void OnShoot(Vector3 boost)
	{
	}

	protected override void Controller_OnCancel()
	{
		base.Controller_OnCancel();
		StopJetpack();
	}

	private void StartJetpack()
	{
		if (jetpackAudioSource != null)
		{
			jetpackAudioSource.Play();
		}
		if (FireAnimators != null && FireAnimators.Length > 0)
		{
			if (FireAnimators[0] != null)
			{
				FireAnimators[0].SetBool("IsJetpackOn", true);
			}
			if (FireAnimators.Length > 1 && FireAnimators[1] != null)
			{
				FireAnimators[1].SetBool("IsJetpackOn", true);
			}
		}
		if (JetpackParticles != null && JetpackParticles.Length > 0)
		{
			if (JetpackParticles[0] != null)
			{
				JetpackParticles[0].Play();
			}
			if (JetpackParticles.Length > 1 && JetpackParticles[1] != null)
			{
				JetpackParticles[1].Play();
			}
		}
	}

	private void StopJetpack()
	{
		if (jetpackAudioSource != null)
		{
			jetpackAudioSource.Stop();
		}
		if (FireAnimators != null && FireAnimators.Length > 0)
		{
			if (FireAnimators[0] != null)
			{
				FireAnimators[0].SetBool("IsJetpackOn", false);
			}
			if (FireAnimators.Length > 1 && FireAnimators[1] != null)
			{
				FireAnimators[1].SetBool("IsJetpackOn", false);
			}
		}
		if (JetpackParticles != null && JetpackParticles.Length > 0)
		{
			if (JetpackParticles[0] != null)
			{
				JetpackParticles[0].Stop();
			}
			if (JetpackParticles.Length > 1 && JetpackParticles[1] != null)
			{
				JetpackParticles[1].Stop();
			}
		}
	}

	public void Die()
	{
		if (!isDead)
		{
			StartCoroutine(DeathRoutine());
		}
	}

	private IEnumerator DeathRoutine()
	{
		isDead = true;
		Death();
		if (sprites != null)
		{
			foreach (Renderer sprite in sprites)
			{
				if (sprite != null)
				{
					sprite.enabled = false;
				}
			}
		}
		if (rigidBody != null)
		{
			rigidBody.isKinematic = true;
		}
		if (rigid != null)
		{
			rigid.velocity = Vector2.zero;
			rigid.angularVelocity = 0f;
		}
		if (rigidBody != null)
		{
			rigidBody.velocity = Vector2.zero;
			rigidBody.angularVelocity = 0f;
		}
		yield return null;
	}

	public override void OnHiddenByTransition()
	{
		if (save != null)
		{
			base.transform.position = save.lastSavePosition;
			if (rigidBody != null)
			{
				rigidBody.MovePosition(save.lastSavePosition);
			}
		}
		if (rigidBody != null)
		{
			rigidBody.isKinematic = false;
		}
		if (rigid != null)
		{
			rigid.velocity = Vector2.zero;
			rigid.angularVelocity = 0f;
		}
		if (rigidBody != null)
		{
			rigidBody.velocity = Vector2.zero;
			rigidBody.angularVelocity = 0f;
		}
		if (sprites != null)
		{
			foreach (Renderer sprite in sprites)
			{
				if (sprite != null)
				{
					sprite.enabled = true;
				}
			}
		}
		isDead = false;
	}
}
