using System;
using System.Collections;
using System.Collections.Generic;
using Core;
using UnityEngine;
using Utility;

public class ArrowShooter : GolfBallShooterBase
{
	public Animator Animator;

	public Transform ArcherTorso;

	public float ShootForce = 10f;

	public Transform ArrowStart;

	public Arrow3D ArrowTemplate;

	public int ArrowCount = 1;

	public bool isUsingRandomOffset;

	private ObjectPool<Arrow3D> arrowPool;

	public List<Collider> ignoredColliders;

	private Collider[] ownColliders;

	private string aimAnimParamName = "Aim";

	private string shootAnimParamName = "ShootPower";

	public event Action<Arrow3D> OnShootArrow;

	private void Start()
	{
		ownColliders = GetComponentsInChildren<Collider>();
		if (ArrowTemplate != null)
		{
			arrowPool = new ObjectPool<Arrow3D>(ArrowTemplate.gameObject, 40, delegate(GameObject a)
			{
				if (a != null)
				{
					InitializeArrow(a.GetComponent<Arrow3D>());
				}
			});
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
		Vector3 norm = boost.normalized;
		float angle = Mathf.Atan2(norm.y, norm.x) * 57.29578f;
		if (ArcherTorso != null)
		{
			Vector3 upVec = Quaternion.AngleAxis(angle, base.transform.forward) * base.transform.up;
			ArcherTorso.rotation = Quaternion.LookRotation(ArcherTorso.forward, upVec);
		}
		if (Animator != null)
		{
			Animator.SetFloat(aimAnimParamName, boost.magnitude);
		}
	}

	public override void OnShoot(Vector3 boost)
	{
		base.OnShoot(boost);
		if (Animator != null)
		{
			Animator.SetFloat(shootAnimParamName, boost.magnitude);
			Animator.SetFloat(aimAnimParamName, 0f);
			Animator.SetTrigger("Shoot");
		}
		if (base.gameObject.activeInHierarchy && base.enabled)
		{
			StartCoroutine(ShootArrows(boost));
		}
	}

	private IEnumerator ShootArrows(Vector3 boost)
	{
		int c = ArrowCount;
		for (int i = 0; i < c; i++)
		{
			Arrow3D arrow = SpawnNewArrow();
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
				if (boost != Vector3.zero)
				{
					arrow.transform.rotation = Quaternion.LookRotation(boost, Vector3.up);
				}
				float mag = boost.magnitude;
				if (isUsingRandomOffset)
				{
					boost.y *= 1f + UnityEngine.Random.Range(-0.2f, 0.2f);
					boost.x *= 1f + UnityEngine.Random.Range(0f, 0.2f);
				}
				boost = boost.normalized * mag;
				if (arrow.Rigidbody != null)
				{
					arrow.Rigidbody.velocity = boost * ShootForce;
					arrow.Rigidbody.angularVelocity = Vector3.zero;
				}
			}
			yield return null;
		}
	}

	private Arrow3D SpawnNewArrow()
	{
		if (arrowPool == null)
			return null;

		GameObject go = arrowPool.Retrieve(Vector3.zero, Quaternion.identity, null);
		if (go == null)
			return null;

		Arrow3D arrow = go.GetComponent<Arrow3D>();
		if (arrow != null && !arrow.Initialized)
		{
			InitializeArrow(arrow);
		}
		return arrow;
	}

	private void InitializeArrow(Arrow3D newArrow)
	{
		if (newArrow == null)
			return;

		if (newArrow.Colliders != null)
		{
			foreach (Collider arrowCol in newArrow.Colliders)
			{
				if (arrowCol == null)
					continue;
				if (ignoredColliders != null)
				{
					foreach (Collider ignored in ignoredColliders)
					{
						if (ignored != null)
						{
							Physics.IgnoreCollision(ignored, arrowCol, true);
						}
					}
				}
				if (ownColliders != null)
				{
					for (int i = 0; i < ownColliders.Length; i++)
					{
						if (ownColliders[i] != null)
						{
							Physics.IgnoreCollision(ownColliders[i], arrowCol, true);
						}
					}
				}
			}
		}

		newArrow.OnHitGoal += OnHitGoal;
		newArrow.Initialized = true;
	}
}
