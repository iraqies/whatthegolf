using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Moga
{
	public class MogaEntitySpawner : MonoBehaviour
	{
		public float SpawnInterval = 5f;

		public int EntitiesSpawned = 3;

		public Transform SpawnOrigin;

		public List<Transform> SpawnPosition;

		public GameObject SpawnEntityPrefab;

		public int TeamIndex;

		private float spawnTimer;

		private void Awake()
		{
			spawnTimer = SpawnInterval;
		}

		private void Update()
		{
			spawnTimer += Time.deltaTime;
			if (spawnTimer >= SpawnInterval)
			{
				StartCoroutine(SpawnEntities());
				spawnTimer = 0f;
			}
		}

		private IEnumerator SpawnEntities()
		{
			if (SpawnEntityPrefab == null || SpawnPosition == null || SpawnPosition.Count == 0)
			{
				yield break;
			}
			for (int i = 0; i < EntitiesSpawned; i++)
			{
				int idx = i % SpawnPosition.Count;
				Transform sp = SpawnPosition[idx];
				if (sp == null)
				{
					continue;
				}
				Vector3 origin = SpawnOrigin != null ? SpawnOrigin.position : sp.position;
				GameObject go = Object.Instantiate(SpawnEntityPrefab, origin, Quaternion.identity);
				MogaEntity entity = go.GetComponent<MogaEntity>();
				if (entity != null)
				{
					entity.TeamIndex = TeamIndex;
				}
				Vector3 targetPos = sp.position;
				StartCoroutine(pTween.To(0.4f, 0f, 1f, t =>
				{
					if (go != null)
					{
						Vector3 p = Vector3.Lerp(origin, targetPos, Mathf.SmoothStep(0f, 1f, t));
						p.y += Mathf.PingPong(t * 2f, 1f);
						go.transform.position = p;
					}
				}).Then(() =>
				{
					if (entity != null)
					{
						entity.StartEntity();
					}
				}));
				yield return new WaitForSeconds(0.15f);
			}
		}
	}
}
