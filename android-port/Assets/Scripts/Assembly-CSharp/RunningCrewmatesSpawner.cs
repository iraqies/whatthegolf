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
		StartCoroutine(SpawnDelay(startDelay));
	}

	private IEnumerator SpawnDelay(float delay)
	{
		yield return new WaitForSeconds(delay);
		enemyWaves = StartCoroutine(SpawnWaves());
	}

	private IEnumerator SpawnWaves()
	{
		int spawnCount = 13;
		int totalSpawns = 0;
		if (m_waves == null)
		{
			yield break;
		}
		for (int j = 0; j < m_waves.Count; j++)
		{
			Wave wave = m_waves[j];
			if (wave == null || wave.m_spawnOrderList == null)
			{
				continue;
			}
			for (int i = 0; i < wave.m_spawnOrderList.Count; i++)
			{
				int num = wave.m_spawnOrderList[i];
				if (num != -1 && spawnPositionsList != null && num >= 0 && num < spawnPositionsList.Count && spawnPositionsList[num] != null)
				{
					SpawnPos spawnPos = spawnPositionsList[num];
					if (spawnPos.bossPrefab != null)
					{
						if (spawnPos.spawnTransform != null)
						{
							GameObject gameObject = UnityEngine.Object.Instantiate(spawnPos.bossPrefab, spawnPos.spawnTransform.position, spawnPos.spawnTransform.rotation);
							AddForce componentInChildren = gameObject.GetComponentInChildren<AddForce>();
							if (componentInChildren != null && targetsForCrewmates != null && targetsForCrewmates.Count > 1)
							{
								componentInChildren.target = targetsForCrewmates[1];
							}
						}
					}
					else if (wave.m_prefabsToSpawn != null && wave.m_prefabsToSpawn.Count > 0 && spawnPos.spawnTransform != null)
					{
						int index = UnityEngine.Random.Range(0, wave.m_prefabsToSpawn.Count);
						if (wave.m_prefabsToSpawn[index] != null)
						{
							GameObject gameObject2 = UnityEngine.Object.Instantiate(wave.m_prefabsToSpawn[index], spawnPos.spawnTransform.position, spawnPos.spawnTransform.rotation);
							AddForce componentInChildren2 = gameObject2.GetComponentInChildren<AddForce>();
							if (componentInChildren2 != null && targetsForCrewmates != null && num < targetsForCrewmates.Count)
							{
								componentInChildren2.target = targetsForCrewmates[num];
							}
						}
					}
				}
				yield return new WaitForSeconds(wave.delayBetweenSpawns);
				spawnCount++;
				float in_value = ((totalSpawns > 0) ? Mathf.Min((float)spawnCount / (float)totalSpawns, 1f) : 1f);
				AkSoundEngine.SetRTPCValue(AK.GAME_PARAMETERS.RTPC_DistanceToGoal, in_value, null);
			}
			yield return new WaitForSeconds(wave.finalDelay);
		}
	}
}
