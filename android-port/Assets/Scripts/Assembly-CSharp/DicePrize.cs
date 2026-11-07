using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class DicePrize : MonoBehaviour
{
	[SerializeField]
	private List<GameObject> Prefabs;

	[SerializeField]
	private List<Transform> DiceSides;

	[SerializeField]
	private Rigidbody rb;

	[SerializeField]
	private Transform spawnPosition;

	[SerializeField]
	private ParticleSystem poof;

	private List<GameObject> Spawned;

	[SerializeField]
	private float waitBetweenSpawn;

	[SerializeField]
	private float randomPos;

	[SerializeField]
	private UnityEvent OnSpawn;

	public static Vector3 RandomPointInBounds(Bounds bounds)
	{
		return default;
	}

	public void StartCheck()
	{
	}

	private IEnumerator WaitForDiceZeroVelocity()
	{
		return null;
	}

	private void CheckDiceValue()
	{
	}

	private void Spawn(int num)
	{
	}

	private IEnumerator SpawnCR(int num)
	{
		return null;
	}
}
