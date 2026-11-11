using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Utility;

namespace Arena
{
	public class RapidSpawnPhase : RockSpawnerPhase
	{
		[SerializeField]
		private ArenaDroppable rockPrefab;

		[SerializeField]
		private float arenaRadius = 45f;

		[SerializeField]
		private float cellSize = 2f;

		[SerializeField]
		private int minSpawnPerTick = 4;

		[SerializeField]
		private int maxSpawnPerTick = 8;

		[SerializeField]
		private float spawnInterval = 0.25f;

		[SerializeField]
		private float gridCooldownTime = 9f;

		public int positionCount;

		public int onCooldownCount;

		private List<Vector2> allValidPositions;

		private List<Vector3> spawnPositions;

		private HashSet<KeyValuePair<ArenaDroppableRock, float>> gridCooldown;

		private WaitForSeconds _wait;

		public override bool IsSpawning { get; set; }

		private void Start()
		{
			CreateGrid();
			spawnPositions = new List<Vector3>();
			gridCooldown = new HashSet<KeyValuePair<ArenaDroppableRock, float>>();
			foreach (Vector2 allValidPosition in allValidPositions)
			{
				spawnPositions.Add(new Vector3(allValidPosition.x, allValidPosition.y, 0f));
			}
			base.RockPool = new ObjectPool<ArenaDroppableRock>(rockPrefab.gameObject, allValidPositions.Count - 100);
			_wait = new WaitForSeconds(spawnInterval);
		}

		public override IEnumerator SpawnCoroutine()
		{
			IsSpawning = true;
			while (IsSpawning)
			{
				CheckCooldowns();
				int count = Random.Range(minSpawnPerTick, maxSpawnPerTick);
				for (int i = 0; i < count; i++)
				{
					int index = Random.Range(0, spawnPositions.Count);
					Vector3 vector = spawnPositions[index];
					onCooldownCount = gridCooldown.Count;
					spawnPositions.RemoveAt(index);
					if (base.RockPool.Retrieve(new Vector3(vector.x, base.transform.position.y, vector.y), default(Quaternion)).TryGetComponent<ArenaDroppableRock>(out var component))
					{
						component.GridPosition = new Vector2(vector.x, vector.y);
						gridCooldown.Add(new KeyValuePair<ArenaDroppableRock, float>(component, Time.time + gridCooldownTime));
					}
					yield return null;
				}
				yield return new WaitForSeconds(spawnInterval);
			}
		}

		private void CheckCooldowns()
		{
			if (gridCooldown.Count < 1)
			{
				return;
			}
			float time = Time.time;
			HashSet<KeyValuePair<ArenaDroppableRock, float>> hashSet = new HashSet<KeyValuePair<ArenaDroppableRock, float>>();
			foreach (KeyValuePair<ArenaDroppableRock, float> item in gridCooldown)
			{
				if (time >= item.Value)
				{
					spawnPositions.Add(new Vector3(item.Key.GridPosition.x, item.Key.GridPosition.y, 0f));
					hashSet.Add(item);
				}
			}
			foreach (KeyValuePair<ArenaDroppableRock, float> item2 in hashSet)
			{
				base.RockPool.Release(item2.Key.gameObject);
				gridCooldown.Remove(item2);
			}
		}

		private void CreateGrid()
		{
			allValidPositions = new List<Vector2>();
			float x = base.transform.position.x;
			float z = base.transform.position.z;
			Mathf.CeilToInt(arenaRadius + arenaRadius);
			for (float num = 0f - arenaRadius; num <= arenaRadius; num += cellSize)
			{
				for (float num2 = 0f - arenaRadius; num2 <= arenaRadius; num2 += cellSize)
				{
					Vector2 vector = new Vector2(x + num, z + num2);
					if (Vector2.Distance(vector, new Vector2(x, z)) <= arenaRadius)
					{
						allValidPositions.Add(vector);
					}
				}
			}
			positionCount = allValidPositions.Count;
		}

		private void OnDrawGizmosSelected()
		{
			if (gridCooldown != null)
			{
				foreach (KeyValuePair<ArenaDroppableRock, float> item in gridCooldown)
				{
					Vector2 gridPosition = item.Key.GridPosition;
					Gizmos.color = Color.red;
					Gizmos.DrawCube(new Vector3(gridPosition.x, base.transform.position.y, gridPosition.y), Vector3.one);
				}
			}
			if (allValidPositions != null && !Application.isPlaying)
			{
				foreach (Vector2 allValidPosition in allValidPositions)
				{
					Gizmos.DrawCube(new Vector3(allValidPosition.x, base.transform.position.y, allValidPosition.y), Vector3.one);
				}
			}
		}
	}
}
