using System;
using Core;
using UnityEngine;
using Utility;

public class SpitShooter2D : GolfBall2DShooterBase
{
	public Transform HeadTransform;

	public float ShootForce = 10f;

	public Transform ShootOriginTransform;

	public Spit2D SpitTemplate;

	private ObjectPool<Spit2D> spitPool;

	private void Start()
	{
		if (SpitTemplate != null)
		{
			spitPool = new ObjectPool<Spit2D>(SpitTemplate.gameObject, 10, s =>
			{
				if (s != null)
				{
					Spit2D spit = s.GetComponent<Spit2D>();
					if (spit != null)
					{
						spit.OnHitGoal = (Action)Delegate.Combine(spit.OnHitGoal, new Action(OnHitGoal));
						spit.Initialized = true;
					}
				}
			});
		}

		Collider2D[] myCols = GetComponentsInChildren<Collider2D>();
		if (myCols != null && spitPool != null)
		{
			for (int i = 0; i < myCols.Length; i++)
			{
				foreach (Spit2D spit in spitPool)
				{
					if (spit != null && spit.Collider != null && myCols[i] != null)
					{
						Physics2D.IgnoreCollision(myCols[i], spit.Collider);
					}
				}
			}
		}

		if (Level.Instance != null && Level.Instance.Ball != null)
		{
			Level.Instance.Ball.OnAimUpdate += BallOnOnAimUpdate;
		}
	}

	private void BallOnOnAimUpdate(Vector3 vector3, bool b)
	{
		if (HeadTransform == null)
			return;
		Vector3 target = HeadTransform.position + new Vector3(vector3.x, vector3.y, 0f);
		Vector3 diff = target - HeadTransform.position;
		float angle = Mathf.Atan2(diff.y, diff.x) * 57.29578f + 90f;
		HeadTransform.rotation = Quaternion.AngleAxis(angle, Vector3.forward);
	}

	private void OnHitGoal()
	{
		if (Level.Instance != null && Level.Instance.Goal != null)
		{
			Level.Instance.Goal.Complete();
		}
	}

	public override void OnShoot(Vector3 boost)
	{
		Spit2D spit = SpawnNewArrow();
		base.OnShoot(boost);
		if (spit == null)
			return;
		if (spit.Rigidbody != null)
			spit.Rigidbody.isKinematic = false;
		if (ShootOriginTransform != null)
			spit.transform.position = ShootOriginTransform.position;
		float angle = Mathf.Atan2(boost.y, boost.x) * 57.29578f;
		spit.transform.rotation = Quaternion.AngleAxis(angle, Vector3.forward);
		if (spit.Rigidbody != null)
		{
			spit.Rigidbody.velocity = new Vector2(boost.x * ShootForce, boost.y * ShootForce);
			spit.Rigidbody.angularVelocity = 0f;
		}
	}

	private Spit2D SpawnNewArrow()
	{
		if (spitPool == null)
			return null;
		GameObject go = spitPool.Get();
		if (go == null)
			return null;
		Spit2D spit = go.GetComponent<Spit2D>();
		if (spit != null && !spit.Initialized)
		{
			spit.OnHitGoal = (Action)Delegate.Combine(spit.OnHitGoal, new Action(OnHitGoal));
			spit.Initialized = true;
		}
		return spit;
	}
}
