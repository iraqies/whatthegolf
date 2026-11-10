using System;
using System.Collections.Generic;
using Chronos;
using UnityEngine;
using Utility;

public class SuperGolfBullet : MonoBehaviour
{
	public ObjectPool<GameObject> BulletPool;

	public float MoveSpeed = 10f;

	public float LifeTime = 10f;

	public ParticleSystem BulletDeathParticles;

	public Collider collider;

	public int Bounces;

	public bool KillOnImpact = true;

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
		originalMoveSpeed = MoveSpeed;
		rigidBody = GetComponent<Rigidbody>();
		timeline = GetComponent<Timeline>();
		trail = GetComponentInChildren<TrailRenderer>();
		if (trail != null)
		{
			trailTime = trail.time;
		}
	}

	protected virtual void OnEnable()
	{
		if (rigidBody != null)
		{
			rigidBody.angularVelocity = Vector3.zero;
			rigidBody.velocity = base.transform.forward * MoveSpeed;
		}
		currentLifeTime = LifeTime;
		direction = base.transform.forward;
	}

	public virtual void SetSpeed(float speedMod)
	{
		MoveSpeed = speedMod * originalMoveSpeed;
		if (rigidBody != null)
		{
			rigidBody.angularVelocity = Vector3.zero;
			rigidBody.velocity = base.transform.forward * MoveSpeed;
		}
	}

	protected virtual void Update()
	{
		if (timeline != null)
		{
			currentLifeTime -= timeline.deltaTime;
			if (trail != null)
			{
				trail.time = Mathf.Lerp(trail.time, trailTime / timeline.timeScale, timeline.deltaTime);
			}
		}
		else
		{
			currentLifeTime -= Time.deltaTime;
		}
		if (currentLifeTime <= 0f)
		{
			KillBullet(base.transform.position);
		}
	}

	private void OnCollisionEnter(Collision other)
	{
		if (other == null || other.gameObject == null)
		{
			return;
		}
		if (other.gameObject.tag == "CarAgent")
		{
			SuperGolfShootEnemy componentInChildren = other.gameObject.GetComponentInChildren<SuperGolfShootEnemy>();
			if (componentInChildren != null)
			{
				componentInChildren.Health--;
				if (componentInChildren.Health <= 0)
				{
					componentInChildren.DeathRotation = Quaternion.LookRotation(base.transform.forward);
					componentInChildren.Kill(direction);
				}
			}
		}
		else if (other.transform != null && other.transform.CompareTag("Player") && currentLifeTime < LifeTime)
		{
			SuperGolfShooter componentInChildren2 = other.gameObject.GetComponentInChildren<SuperGolfShooter>();
			if (componentInChildren2 != null)
			{
				componentInChildren2.Kill();
				KillBullet(componentInChildren2.transform.position);
				return;
			}
		}
		if (other.gameObject.layer == LayerMask.NameToLayer("IgnoreGolfBall"))
		{
			return;
		}
		if (Bounces > 0)
		{
			Bounces--;
			ContactPoint[] contacts = other.contacts;
			if (contacts != null && contacts.Length > 0)
			{
				base.transform.forward = Vector3.Reflect(direction, contacts[0].normal).normalized;
			}
			if (rigidBody != null)
			{
				rigidBody.angularVelocity = Vector3.zero;
				rigidBody.velocity = base.transform.forward * MoveSpeed;
			}
			currentLifeTime = LifeTime;
			direction = base.transform.forward;
		}
		else if (KillOnImpact)
		{
			ContactPoint[] contacts2 = other.contacts;
			if (contacts2 != null && contacts2.Length > 0)
			{
				KillBullet(contacts2[0].point);
			}
		}
	}

	private void OnTriggerEnter(Collider other)
	{
		if (previousOwnerCollider == other || other == null)
		{
			return;
		}
		if (other.CompareTag("OutOfBounds") || other.CompareTag("OutOfBoundsReset"))
		{
			KillBullet(base.transform.position);
		}
		else if (other.CompareTag("Player") && currentLifeTime < LifeTime)
		{
			SuperGolfShooter componentInParent = other.gameObject.GetComponentInParent<SuperGolfShooter>();
			if (componentInParent != null)
			{
				componentInParent.Kill();
				KillBullet(componentInParent.transform.position);
			}
		}
	}

	protected virtual void KillBullet(Vector3 point)
	{
		if (rigidBody != null)
		{
			rigidBody.velocity = Vector3.zero;
			rigidBody.angularVelocity = Vector3.zero;
		}
		if (trail != null)
		{
			TrailRenderer trailRenderer = UnityEngine.Object.Instantiate(trail, base.transform);
			trail.transform.SetParent(null);
			trail.autodestruct = true;
			trail = trailRenderer;
			if (trail != null)
			{
				trail.Clear();
			}
		}
		if (BulletDeathParticles != null)
		{
			BulletDeathParticles.transform.position = point;
			BulletDeathParticles.transform.rotation = Quaternion.LookRotation(-base.transform.forward);
			BulletDeathParticles.Emit(100);
		}
		if (BulletPool != null)
		{
			BulletPool.Return(base.gameObject, true);
		}
		OnBulletDeath?.Invoke(this);
	}
}
