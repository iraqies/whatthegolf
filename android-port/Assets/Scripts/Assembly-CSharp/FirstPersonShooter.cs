using System;
using System.Runtime.CompilerServices;
using Audio;
using Core;
using UnityEngine;
using Utility;

public class FirstPersonShooter : GolfBallShooterExperimental
{
	public float SmashVelocity;

	public float SleepVelocity;

	public float ShootInterval;

	public GameObject Bullet;

	public bool CanShoot;

	public bool BulletIsParticles;

	public float ParticlesVelocity;

	public RandomAudioClips ShootSounds;

	public bool BlockFromController;

	public bool SyncCooldowns;

	[CompilerGenerated]
	private Action<Vector3> m_OnActualShoot;

	private ObjectPool<GameObject> bulletPool;

	private Collider collider;

	private float shootTimer;

	private ParticleSystem bulletParticles;

	private TimeControl _timeControll;

	public event Action<Vector3> OnActualShoot
	{
		[CompilerGenerated]
		add
		{
		}
		[CompilerGenerated]
		remove
		{
		}
	}

	private void Start()
	{
	}

	private void Update()
	{
	}

	private void Shoot(Vector3 boost)
	{
	}

	private void TryShoot(Vector3 boost)
	{
	}

	private void OnCollisionEnter(Collision other)
	{
	}
}
