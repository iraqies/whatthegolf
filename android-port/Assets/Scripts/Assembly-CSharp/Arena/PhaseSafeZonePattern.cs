using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Arena
{
	public class PhaseSafeZonePattern : RockSpawnerPhase
	{
		[SerializeField]
		private ArenaDroppable rockPrefab;

		[SerializeField]
		private ArenaDroppable[] otherRandomSpawn;

		[SerializeField]
		private int randomInterval = 5;

		[SerializeField]
		private float arenaRadius = 15f;

		[SerializeField]
		private float durationToMaxDifficulty = 60f;

		[SerializeField]
		private float minSafeZoneRadius = 3f;

		[SerializeField]
		private float maxSafeZoneRadius = 8f;

		[SerializeField]
		private int minSpawnAmount = 3;

		[SerializeField]
		private int maxSpawnAmount = 10;

		[SerializeField]
		private float minSpawnDelay = 1.5f;

		[SerializeField]
		private float maxSpawnDelay = 3.5f;

		[SerializeField]
		private float cellSize = 2.5f;

		public int positionCount;

		public int lastValidPositionCount;

		private int playerCount;

		private float _timeAtStart;

		private float _safeZoneRadius;

		private int lastRandomSpawnObject;

		private int _spawnAmount;

		private int _waveCount;

		private List<Vector2> gridPositions;

		private List<Vector2> validPositions;

		private int middleSpawn;

		public override bool IsSpawning { get; set; }

		public float GetDifficultyValue()
		{
			if (durationToMaxDifficulty <= 0.01f)
			{
				return 1f;
			}
			return Mathf.Clamp01((Time.time - _timeAtStart) / durationToMaxDifficulty);
		}

		private void Awake()
		{
			CreateGrid();
		}

		private void CreateGrid()
		{
			gridPositions = new List<Vector2>();
			validPositions = new List<Vector2>();
			float step = Mathf.Max(1f, cellSize);
			for (float x = -arenaRadius; x <= arenaRadius; x += step)
			{
				for (float y = -arenaRadius; y <= arenaRadius; y += step)
				{
					Vector2 pt = new Vector2(x, y);
					if (pt.magnitude <= arenaRadius)
					{
						gridPositions.Add(pt);
					}
				}
			}
			positionCount = gridPositions.Count;
		}

		public override IEnumerator SpawnCoroutine()
		{
			_timeAtStart = Time.time;
			IsSpawning = true;
			while (IsSpawning)
			{
				float diff = GetDifficultyValue();
				_safeZoneRadius = Mathf.Lerp(maxSafeZoneRadius, minSafeZoneRadius, diff);
				_spawnAmount = Mathf.RoundToInt(Mathf.Lerp(minSpawnAmount, maxSpawnAmount, diff));
				CurrentSafeSpots = GetSafeSpots();
				yield return StartCoroutine(SpawnWave());
				float delay = Mathf.Lerp(maxSpawnDelay, minSpawnDelay, diff);
				yield return new WaitForSeconds(Mathf.Max(0.5f, delay));
			}
		}

		private Vector2[] GetSafeSpots()
		{
			Vector2 rand = Random.insideUnitCircle * Mathf.Max(0f, arenaRadius - _safeZoneRadius);
			return new Vector2[1] { rand };
		}

		private List<Vector2> GetValidSpots()
		{
			if (gridPositions == null)
			{
				CreateGrid();
			}
			validPositions.Clear();
			for (int i = 0; i < gridPositions.Count; i++)
			{
				Vector2 pt = gridPositions[i];
				bool inSafe = false;
				if (CurrentSafeSpots != null)
				{
					for (int j = 0; j < CurrentSafeSpots.Length; j++)
					{
						if (Vector2.Distance(pt, CurrentSafeSpots[j]) < _safeZoneRadius)
						{
							inSafe = true;
							break;
						}
					}
				}
				if (!inSafe)
				{
					validPositions.Add(pt);
				}
			}
			lastValidPositionCount = validPositions.Count;
			return validPositions;
		}

		private IEnumerator SpawnWave()
		{
			_waveCount++;
			List<Vector2> spots = GetValidSpots();
			if (spots == null || spots.Count == 0 || rockPrefab == null)
			{
				yield break;
			}
			int count = Mathf.Min(_spawnAmount, spots.Count);
			for (int i = 0; i < count; i++)
			{
				int idx = Random.Range(0, spots.Count);
				Vector2 pt = spots[idx];
				spots.RemoveAt(idx);
				Vector3 worldPos = transform.position + new Vector3(pt.x, 20f, pt.y);
				ArenaDroppable spawned = RockPool != null ? RockPool.Get(worldPos, Quaternion.identity)?.GetComponent<ArenaDroppable>() : Object.Instantiate(rockPrefab, worldPos, Quaternion.identity);
				if (spawned != null)
				{
					spawned.GridPosition = pt;
					spawned.gameObject.SetActive(true);
					spawned.PlaySwoosh();
				}
				yield return new WaitForSeconds(0.05f);
			}
		}

		private void OnDrawGizmosSelected()
		{
		}
	}
}
