using System;
using System.Collections;
using Core;
using UnityEngine;
using Utility;

public class JavelinShooter : GolfBall2DShooterBase
{
	private Action<Javelin> m_OnShootJavelin;

	public float ShootForce = 10f;

	public Transform javelinStart;

	public Javelin javelinTemplate;

	public int javelinCount = 1;

	public bool isUsingRandomOffset;

	private ObjectPool<Javelin> javelinPool;

	public GolfBallController horseController;

	private GolfBallController catController;

	public event Action<Javelin> OnShootJavelin
	{
		add
		{
			m_OnShootJavelin = (Action<Javelin>)Delegate.Combine(m_OnShootJavelin, value);
		}
		remove
		{
			m_OnShootJavelin = (Action<Javelin>)Delegate.Remove(m_OnShootJavelin, value);
		}
	}

	private void Start()
	{
		if (javelinTemplate != null)
		{
			javelinPool = new ObjectPool<Javelin>(javelinTemplate.gameObject, 40, a =>
			{
				if (a != null)
				{
					Javelin jav = a.GetComponent<Javelin>();
					if (jav != null)
					{
						jav.OnHitGoal = (Action)Delegate.Combine(jav.OnHitGoal, new Action(OnHitGoal));
						jav.Initialized = true;
					}
				}
			});
		}

		Collider[] myCols = GetComponentsInChildren<Collider>();
		if (myCols != null && javelinPool != null && javelinPool.avalable != null)
		{
			for (int i = 0; i < myCols.Length; i++)
			{
				foreach (GameObject obj in javelinPool.avalable)
				{
					if (obj != null)
					{
						Javelin jav = obj.GetComponent<Javelin>();
						if (jav != null && jav.Collider != null && myCols[i] != null)
						{
							Physics.IgnoreCollision(myCols[i], jav.Collider);
						}
					}
				}
			}
		}

		catController = GetComponent<GolfBallController>();
	}

	private void OnHitGoal()
	{
		if (Level.Instance != null && !Level.Instance.IsMultiplayer && Level.Instance.Goal != null)
		{
			Level.Instance.Goal.Complete();
		}
	}

	public override void OnShoot(Vector3 boost)
	{
		base.OnShoot(boost);
		if (gameObject.activeInHierarchy)
		{
			StartCoroutine(ShootJavelins(boost));
		}
		if (catController != null)
			catController.enabled = false;
		if (horseController != null)
			horseController.enabled = true;
	}

	private IEnumerator ShootJavelins(Vector3 boost)
	{
		int count = javelinCount;
		for (int i = 0; i < count; i++)
		{
			Javelin jav = SpawnNewJavelin();
			m_OnShootJavelin?.Invoke(jav);
			if (jav != null)
			{
				if (jav.Rigidbody != null)
					jav.Rigidbody.isKinematic = false;
				if (javelinStart != null)
					jav.transform.position = javelinStart.position;
				if (isUsingRandomOffset)
					jav.transform.position += UnityEngine.Random.insideUnitSphere;
				float angle = Mathf.Atan2(boost.y, boost.x) * 57.29578f;
				jav.transform.rotation = Quaternion.AngleAxis(angle, Vector3.forward);
				float mag = boost.magnitude;
				if (isUsingRandomOffset)
				{
					boost.y *= 1f + UnityEngine.Random.Range(-0.2f, 0.2f);
					boost.x *= 1f + UnityEngine.Random.Range(0f, 0.2f);
				}
				boost = boost.normalized * mag;
				if (jav.Rigidbody != null)
				{
					jav.Rigidbody.velocity = boost * ShootForce;
					jav.Rigidbody.angularVelocity = Vector3.zero;
				}
			}
			yield return null;
		}
	}

	private Javelin SpawnNewJavelin()
	{
		if (javelinPool == null)
			return null;
		GameObject go = javelinPool.Get();
		if (go == null)
			return null;
		Javelin jav = go.GetComponent<Javelin>();
		if (jav != null && !jav.Initialized)
		{
			jav.OnHitGoal = (Action)Delegate.Combine(jav.OnHitGoal, new Action(OnHitGoal));
			jav.Initialized = true;
		}
		return jav;
	}
}
