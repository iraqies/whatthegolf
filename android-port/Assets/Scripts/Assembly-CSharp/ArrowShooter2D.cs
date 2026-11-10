using System;
using System.Collections;
using Core;
using UnityEngine;
using Utility;

public class ArrowShooter2D : GolfBall2DShooterBase
{
	public Animator Animator;

	public Transform ArcherTorso;

	public float ShootForce = 10f;

	public Transform ArrowStart;

	public Arrow2D ArrowTemplate;

	public int ArrowCount = 1;

	public bool isUsingRandomOffset;

	private ObjectPool<Arrow2D> arrowPool;

	public event Action<Arrow2D> OnShootArrow;

	private void Start()
	{
		if (ArrowTemplate != null)
		{
			arrowPool = new ObjectPool<Arrow2D>(ArrowTemplate.gameObject, 40, delegate(GameObject a)
			{
				if (a == null)
					return;
				Arrow2D arrow = a.GetComponent<Arrow2D>();
				if (arrow != null)
				{
					arrow.OnHitGoal += OnHitGoal;
					arrow.Initialized = true;
				}
			});
		}

		Collider2D[] ownColliders = GetComponentsInChildren<Collider2D>();
		if (ownColliders != null && arrowPool != null)
		{
			for (int i = 0; i < ownColliders.Length; i++)
			{
				foreach (Arrow2D arrow in arrowPool)
				{
					if (arrow != null && arrow.Collider != null && ownColliders[i] != null)
					{
						Physics2D.IgnoreCollision(ownColliders[i], arrow.Collider);
					}
				}
			}
		}
	}

	private void OnHitGoal()
	{
		if (Level.Instance != null && !Level.Instance.IsMultiplayer && Level.Instance.Goal != null)
		{
			Level.Instance.Goal.Complete();
		}
	}

	public override void OnAimUpdate(Vector3 boost, bool onlyAimArrow)
	{
		boost.Normalize();
		if (ArcherTorso != null)
		{
			float angle = Mathf.Atan2(boost.y, boost.x) * 57.29578f + 90f;
			ArcherTorso.rotation = Quaternion.AngleAxis(angle, Vector3.forward);
		}
	}

	public override void OnShoot(Vector3 boost)
	{
		base.OnShoot(boost);
		if (Animator != null)
		{
			Animator.SetTrigger("Shoot");
		}
		if (base.gameObject.activeInHierarchy)
		{
			StartCoroutine(ShootArrows(boost));
		}
	}

	private IEnumerator ShootArrows(Vector3 boost)
	{
		int c = ArrowCount;
		for (int i = 0; i < c; i++)
		{
			Arrow2D arrow = SpawnNewArrow();
			this.OnShootArrow?.Invoke(arrow);
			if (arrow != null)
			{
				if (arrow.Rigidbody != null)
				{
					arrow.Rigidbody.isKinematic = false;
				}
				if (ArrowStart != null)
				{
					arrow.transform.position = ArrowStart.position;
				}
				if (isUsingRandomOffset)
				{
					arrow.transform.position += UnityEngine.Random.insideUnitSphere;
				}
				float angle = Mathf.Atan2(boost.y, boost.x) * 57.29578f;
				arrow.transform.rotation = Quaternion.AngleAxis(angle, Vector3.forward);
				float mag = boost.magnitude;
				if (isUsingRandomOffset)
				{
					boost.y *= 1f + UnityEngine.Random.Range(-0.2f, 0.2f);
					boost.x *= 1f + UnityEngine.Random.Range(0f, 0.2f);
				}
				boost = boost.normalized * mag;
				if (arrow.Rigidbody != null)
				{
					arrow.Rigidbody.velocity = new Vector2(boost.x * ShootForce, boost.y * ShootForce);
					arrow.Rigidbody.angularVelocity = 0f;
				}
			}
			yield return null;
		}
	}

	private Arrow2D SpawnNewArrow()
	{
		if (arrowPool == null)
			return null;

		GameObject go = arrowPool.Retrieve(Vector3.zero, Quaternion.identity, null);
		if (go == null)
			return null;

		Arrow2D arrow = go.GetComponent<Arrow2D>();
		if (arrow != null && !arrow.Initialized)
		{
			arrow.OnHitGoal += OnHitGoal;
			arrow.Initialized = true;
		}
		return arrow;
	}
}
