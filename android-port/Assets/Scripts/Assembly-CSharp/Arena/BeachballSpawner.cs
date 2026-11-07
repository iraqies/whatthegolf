using UnityEngine;

namespace Arena
{
	public class BeachballSpawner : MonoBehaviour
	{
		[SerializeField]
		private GameObject ballPrefab;

		[SerializeField]
		private GameObject rockPrefab;

		[SerializeField]
		private int spawnRockInterval;

		[SerializeField]
		private int maxToSpawn;

		[SerializeField]
		private float radius;

		[SerializeField]
		private MinMax randomInterval;

		[SerializeField]
		private MinMax randomSizeMultiplier;

		private int spawnCount;

		private float nextSpawnTime;

		private void Update()
		{
		}

		private void Spawn()
		{
		}
	}
}
