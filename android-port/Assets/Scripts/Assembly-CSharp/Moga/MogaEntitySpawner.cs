using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Moga
{
	public class MogaEntitySpawner : MonoBehaviour
	{
		public float SpawnInterval;

		public int EntitiesSpawned;

		public Transform SpawnOrigin;

		public List<Transform> SpawnPosition;

		public GameObject SpawnEntityPrefab;

		public int TeamIndex;

		private float spawnTimer;

		private void Awake()
		{
		}

		private void Update()
		{
		}

		private IEnumerator SpawnEntities()
		{
			return null;
		}
	}
}
