using System;
using System.Collections.Generic;
using Chronos;
using UnityEngine;
using Utility;

public class SuperGolfBullet : MonoBehaviour
{
	public ObjectPool<GameObject> BulletPool;

	public float MoveSpeed;

	public float LifeTime;

	public ParticleSystem BulletDeathParticles;

	public Collider collider;

	public int Bounces;

	public bool KillOnImpact;

	public Collider previousOwnerCollider;

	public List<Collider> previousOwnerColliders;

	public Action<SuperGolfBullet> OnBulletDeath;

	private float currentLifeTime;

	private Rigidbody rigidBody;

	private Timeline timeline;

	private float originalMoveSpeed;

	private Vector3 direction;

	private float trailTime;

	protected TrailRenderer trail;

	protected virtual void Awake()
	{
	}

	protected virtual void OnEnable()
	{
	}

	public virtual void SetSpeed(float speedMod)
	{
	}

	protected virtual void Update()
	{
	}

	private void OnCollisionEnter(Collision other)
	{
	}

	private void OnTriggerEnter(Collider other)
	{
	}

	protected virtual void KillBullet(Vector3 point)
	{
	}
}
