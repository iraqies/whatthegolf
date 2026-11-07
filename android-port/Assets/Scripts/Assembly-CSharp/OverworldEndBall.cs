using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Utility;

public class OverworldEndBall : OverworldBall2D
{
	public List<Renderer> sprites;

	public float shootInterval;

	public int maxShots;

	public float backMoveForceSpeed;

	public float shootSpeed;

	public Rigidbody2D spitPrefab;

	public float RequiredDistanceForHittingFlags;

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
	}

	protected override void Controller_OnAimUpdate(Vector3 dir, bool onlyLine)
	{
	}

	private void ShootBullet(Vector3 dir)
	{
	}

	private void OnEnable()
	{
	}

	protected override void Controller_OnAimStart()
	{
	}

	protected override void Shooter_OnShoot(Vector3 dir)
	{
	}

	public override void OnShoot(Vector3 boost)
	{
	}

	protected override void Controller_OnCancel()
	{
	}

	private void StartJetpack()
	{
	}

	private void StopJetpack()
	{
	}

	public void Die()
	{
	}

	private IEnumerator DeathRoutine()
	{
		return null;
	}

	public override void OnHiddenByTransition()
	{
	}
}
