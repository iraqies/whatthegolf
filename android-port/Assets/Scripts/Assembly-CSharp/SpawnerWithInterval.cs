using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Utility;

public class SpawnerWithInterval : MonoBehaviour
{
	[SerializeField]
	private OutOfBoundsTrigger prefab;

	[SerializeField]
	private Transform spawnLocation;

	[SerializeField]
	private float spawnInterval = 2f;

	[SerializeField]
	private bool isSpawning = true;

	private ObjectPool<OutOfBoundsTrigger> pool;

	private List<Rigidbody> barrels = new List<Rigidbody>();

	private IEnumerator Start()
	{
		barrels = new List<Rigidbody>();
		if (prefab != null)
		{
			pool = new ObjectPool<OutOfBoundsTrigger>(prefab.gameObject, 10);
		}
		while (isSpawning)
		{
			if (pool != null && spawnLocation != null)
			{
				GameObject go = pool.Get(spawnLocation.position, spawnLocation.rotation);
				if (go != null)
				{
					go.SetActive(true);
					OutOfBoundsTrigger oob = go.GetComponent<OutOfBoundsTrigger>();
					Rigidbody rb = go.GetComponent<Rigidbody>();
					if (rb != null)
					{
						rb.velocity = Vector3.zero;
						rb.angularVelocity = Vector3.zero;
						rb.constraints = RigidbodyConstraints.FreezeRotation;
						barrels.Add(rb);
					}
					if (oob != null)
					{
						oob.Reset();
						oob.OnOutOfBounds += Barrel_OnOutOfBounds;
					}
					ExplosionBarrel eb = go.GetComponent<ExplosionBarrel>();
					if (eb != null)
					{
						eb.Reset();
						eb.canExplode = false;
						eb.OnExplode += Explosion_OnExplode;
						StartCoroutine(DelayedActivate(eb));
					}
				}
			}
			yield return new WaitForSeconds(spawnInterval);
		}
	}

	private void Explosion_OnExplode(Collider obj, ExplosionBarrel barrel)
	{
		if (barrel != null)
		{
			barrel.OnExplode -= Explosion_OnExplode;
		}
	}

	private void Barrel_OnOutOfBounds(OutOfBoundsTrigger barrel)
	{
		if (barrel != null)
		{
			barrel.OnOutOfBounds -= Barrel_OnOutOfBounds;
			StartCoroutine(DelayedRelease(barrel));
		}
	}

	private IEnumerator DelayedActivate(ExplosionBarrel barrel)
	{
		yield return new WaitForSeconds(0.5f);
		if (barrel != null)
		{
			barrel.canExplode = true;
			Rigidbody rb = barrel.GetComponent<Rigidbody>();
			if (rb != null)
			{
				rb.constraints = RigidbodyConstraints.None;
			}
		}
	}

	private IEnumerator DelayedRelease(OutOfBoundsTrigger barrel)
	{
		if (barrel == null)
		{
			yield break;
		}
		ExplosionBarrel eb = barrel.GetComponent<ExplosionBarrel>();
		if (eb != null)
		{
			eb.OnExplode -= Explosion_OnExplode;
			eb.canExplode = true;
			yield return new WaitForSeconds(0.25f);
			if (eb != null)
			{
				eb.Explode(null);
			}
		}
		yield return new WaitForSeconds(1f);
		if (barrel != null)
		{
			Rigidbody rb = barrel.GetComponent<Rigidbody>();
			if (rb != null)
			{
				barrels.Remove(rb);
			}
			if (pool != null)
			{
				pool.Release(barrel.gameObject);
			}
			else
			{
				barrel.gameObject.SetActive(false);
			}
		}
	}
}
