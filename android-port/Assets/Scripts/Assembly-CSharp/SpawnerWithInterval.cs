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
	private float spawnInterval;

	[SerializeField]
	private bool isSpawning;

	private ObjectPool<OutOfBoundsTrigger> pool;

	private List<Rigidbody> barrels;

	private IEnumerator Start()
	{
		return null;
	}

	private void Explosion_OnExplode(Collider obj, ExplosionBarrel barrel)
	{
	}

	private void Barrel_OnOutOfBounds(OutOfBoundsTrigger barrel)
	{
	}

	private IEnumerator DelayedActivate(ExplosionBarrel barrel)
	{
		return null;
	}

	private IEnumerator DelayedRelease(OutOfBoundsTrigger barrel)
	{
		return null;
	}
}
