using System.Collections.Generic;
using Audio;
using UnityEngine;

public class HotdogSpawner : MonoBehaviour
{
	public CollisionEvents hotdogStand;

	public Rigidbody hotdogPrefab;

	public Transform spawnPositions;

	public float spawnForce;

	public int spawnCountPerCollision;

	public float spawnInterval;

	public float impactThreshold;

	public RandomAudioClips spawnClips;

	public int maxAmount;

	private float nextSpawn;

	private float time;

	private List<GameObject> hotdogs;

	private void Start()
	{
	}

	private void Update()
	{
	}
}
