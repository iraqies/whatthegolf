using System;
using System.Collections;
using Audio;
using Core;
using UnityEngine;

public class HotdogVendor : MonoBehaviour
{
	public CollisionEvents hotdogStand;

	public Rigidbody hotdogPrefab;

	public Transform spawnPositions;

	public float spawnForce;

	public int spawnCountPerCollision;

	public float spawnInterval;

	public float impactThreshold;

	public RandomAudioClips spawnClips;

	public Action<GolfBallController> OnHotdogSpawned;

	public GolfBallController player;

	private float nextSpawn;

	private void Start()
	{
	}

	private void HotdogStand_OnCollisionEnterTrigger(Rigidbody obj)
	{
	}

	public void CallSpawnHotdogs()
	{
	}

	private void OnTriggerEnter(Collider other)
	{
	}

	private void OnCollisionEnter(Collision collision)
	{
	}

	private IEnumerator SpawnHotdogs(GolfBallController controller)
	{
		return null;
	}
}
