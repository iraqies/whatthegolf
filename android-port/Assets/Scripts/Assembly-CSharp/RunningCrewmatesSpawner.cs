using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RunningCrewmatesSpawner : MonoBehaviour
{
	[Serializable]
	public class SpawnPos
	{
		public Transform spawnTransform;

		public GameObject bossPrefab;
	}

	[Serializable]
	public class Wave
	{
		public List<GameObject> m_prefabsToSpawn;

		public List<int> m_spawnOrderList;

		public float delayBetweenSpawns;

		public float finalDelay;
	}

	[SerializeField]
	private float startDelay;

	public List<SpawnPos> spawnPositionsList;

	[SerializeField]
	private List<Transform> targetsForCrewmates;

	[SerializeField]
	private List<Wave> m_waves;

	private Coroutine enemyWaves;

	private void Start()
	{
	}

	private IEnumerator SpawnDelay(float delay)
	{
		return null;
	}

	private IEnumerator SpawnWaves()
	{
		return null;
	}
}
