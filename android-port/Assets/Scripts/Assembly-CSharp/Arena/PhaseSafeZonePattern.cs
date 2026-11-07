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
		private int randomInterval;

		[SerializeField]
		private float arenaRadius;

		[SerializeField]
		private float durationToMaxDifficulty;

		[SerializeField]
		private float minSafeZoneRadius;

		[SerializeField]
		private float maxSafeZoneRadius;

		[SerializeField]
		private int minSpawnAmount;

		[SerializeField]
		private int maxSpawnAmount;

		[SerializeField]
		private float minSpawnDelay;

		[SerializeField]
		private float maxSpawnDelay;

		[SerializeField]
		private float cellSize;

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
			return 0f;
		}

		private void Awake()
		{
		}

		private void CreateGrid()
		{
		}

		public override IEnumerator SpawnCoroutine()
		{
			return null;
		}

		private Vector2[] GetSafeSpots()
		{
			return null;
		}

		private List<Vector2> GetValidSpots()
		{
			return null;
		}

		private IEnumerator SpawnWave()
		{
			return null;
		}

		private void OnDrawGizmosSelected()
		{
		}
	}
}
