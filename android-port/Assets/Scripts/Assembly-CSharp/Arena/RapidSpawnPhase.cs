using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Arena
{
	public class RapidSpawnPhase : RockSpawnerPhase
	{
		[SerializeField]
		private ArenaDroppable rockPrefab;

		[SerializeField]
		private float arenaRadius;

		[SerializeField]
		private float cellSize;

		[SerializeField]
		private int minSpawnPerTick;

		[SerializeField]
		private int maxSpawnPerTick;

		[SerializeField]
		private float spawnInterval;

		[SerializeField]
		private float gridCooldownTime;

		public int positionCount;

		public int onCooldownCount;

		private List<Vector2> allValidPositions;

		private List<Vector3> spawnPositions;

		private HashSet<KeyValuePair<ArenaDroppableRock, float>> gridCooldown;

		private WaitForSeconds _wait;

		public override bool IsSpawning { get; set; }

		private void Start()
		{
		}

		public override IEnumerator SpawnCoroutine()
		{
			return null;
		}

		private void CheckCooldowns()
		{
		}

		private void CreateGrid()
		{
		}

		private void OnDrawGizmosSelected()
		{
		}
	}
}
