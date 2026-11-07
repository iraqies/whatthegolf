using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class ThanksgivingPrize : MonoBehaviour
{
	[SerializeField]
	private List<GameObject> Prefabs;

	[SerializeField]
	private List<ParticleSystem> poofParticles;

	[SerializeField]
	private Transform spawnPosition;

	[SerializeField]
	private float waitBetweenSpawn;

	[SerializeField]
	private float randomPos;

	[SerializeField]
	private UnityEvent OnSpawn;

	public void Spawn(int num)
	{
	}

	private IEnumerator SpawnCR(int num)
	{
		return null;
	}
}
