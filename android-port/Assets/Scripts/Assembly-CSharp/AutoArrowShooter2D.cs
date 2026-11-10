using System.Collections.Generic;
using Audio;
using Core;
using UnityEngine;
using Utility;

public class AutoArrowShooter2D : MonoBehaviour
{
	public Animator Animator;

	public Transform ArcherTorso;

	public float ShootForce = 10f;

	public float ShootInterval = 2f;

	public Transform ArrowStart;

	public Arrow2D ArrowTemplate;

	public List<Vector2> ShootDirections;

	public Vector2 ShotRandomnessRange;

	public int MaxNumberOfActiveArrows = 20;

	private ObjectPool<Arrow2D> arrowPool;

	private float timer;

	private Vector2 nextShotDirection;

	private Quaternion lastRot;

	private List<Arrow2D> spawnedArrows;

	public ClipSettingsCollection ShootSFX;

	private void Start()
	{
		spawnedArrows = new List<Arrow2D>(MaxNumberOfActiveArrows);
		if (ArrowTemplate != null)
		{
			arrowPool = new ObjectPool<Arrow2D>(ArrowTemplate.gameObject, MaxNumberOfActiveArrows, delegate(GameObject a)
			{
				if (a == null)
					return;
				Arrow2D arrow = a.GetComponent<Arrow2D>();
				if (arrow != null)
				{
					arrow.OnHitGoal += OnHitGoal;
					arrow.OnReset += delegate
					{
						arrowPool?.Release(a, true);
					};
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

		if (ShootDirections != null && ShootDirections.Count > 0)
		{
			nextShotDirection = ShootDirections[0];
			if (ArcherTorso != null)
			{
				Vector3 pos = ArcherTorso.position;
				Vector3 target = new Vector3(pos.x + ShootDirections[0].x, pos.y + ShootDirections[0].y, pos.z);
				float angle = Mathf.Atan2(target.y - pos.y, target.x - pos.x) * 57.29578f + 90f;
				ArcherTorso.rotation = Quaternion.AngleAxis(angle, Vector3.forward);
			}
		}
	}

	private void Update()
	{
		timer += Time.deltaTime;
		if (timer < ShootInterval)
		{
			if (ArcherTorso != null)
			{
				Vector3 pos = ArcherTorso.position;
				float angle = Mathf.Atan2(nextShotDirection.y, nextShotDirection.x) * 57.29578f + 90f;
				Quaternion targetRot = Quaternion.AngleAxis(angle, Vector3.forward);
				float t = (ShootInterval > 0f) ? Mathf.SmoothStep(0f, 1f, timer / ShootInterval) : 1f;
				ArcherTorso.rotation = Quaternion.Lerp(lastRot, targetRot, t);
			}
			return;
		}

		if (ArcherTorso != null)
		{
			float angle = Mathf.Atan2(nextShotDirection.y, nextShotDirection.x) * 57.29578f + 90f;
			ArcherTorso.rotation = Quaternion.AngleAxis(angle, Vector3.forward);
		}

		float randAngle = Random.Range(ShotRandomnessRange.x, ShotRandomnessRange.y);
		Vector3 boost = Quaternion.AngleAxis(randAngle, Vector2.up) * new Vector3(nextShotDirection.x, nextShotDirection.y, 0f);
		Shoot(boost);
		timer = 0f;

		if (ShootDirections != null && ShootDirections.Count > 0)
		{
			nextShotDirection = ShootDirections[Random.Range(0, ShootDirections.Count)];
		}
		if (ArcherTorso != null)
		{
			lastRot = ArcherTorso.rotation;
		}
	}

	private void OnHitGoal()
	{
		if (Level.Instance != null && Level.Instance.Goal != null)
		{
			Level.Instance.Goal.Complete();
		}
	}

	public void Shoot(Vector3 boost)
	{
		Arrow2D arrow = SpawnNewArrow();
		if (arrow == null)
			return;

		if (arrow.Rigidbody != null)
		{
			arrow.Rigidbody.isKinematic = false;
		}
		if (ArrowStart != null)
		{
			arrow.transform.position = ArrowStart.position;
		}
		float angle = Mathf.Atan2(boost.y, boost.x) * 57.29578f;
		arrow.transform.rotation = Quaternion.AngleAxis(angle, Vector3.forward);
		if (arrow.Rigidbody != null)
		{
			arrow.Rigidbody.velocity = new Vector2(boost.x * ShootForce, boost.y * ShootForce);
			arrow.Rigidbody.angularVelocity = 0f;
		}
		if (Animator != null)
		{
			Animator.SetTrigger("Shoot");
		}
		if (ShootSFX != null)
		{
			ShootSFX.Play(base.transform.position, 1f, 1f);
		}
	}

	private Arrow2D SpawnNewArrow()
	{
		if (spawnedArrows != null && spawnedArrows.Count >= MaxNumberOfActiveArrows && spawnedArrows.Count > 0)
		{
			Arrow2D oldest = spawnedArrows[0];
			spawnedArrows.RemoveAt(0);
			if (oldest != null && arrowPool != null)
			{
				arrowPool.Release(oldest.gameObject, true);
			}
		}

		if (arrowPool == null)
			return null;

		GameObject go = arrowPool.Retrieve(Vector3.zero, Quaternion.identity, null);
		if (go == null)
			return null;

		Arrow2D newArrow = go.GetComponent<Arrow2D>();
		if (newArrow == null)
			return null;

		if (!newArrow.Initialized)
		{
			newArrow.OnHitGoal += OnHitGoal;
			newArrow.OnReset += delegate
			{
				if (newArrow != null && arrowPool != null)
				{
					arrowPool.Release(newArrow.gameObject, true);
				}
			};
			newArrow.Initialized = true;
		}
		spawnedArrows?.Add(newArrow);
		return newArrow;
	}
}
