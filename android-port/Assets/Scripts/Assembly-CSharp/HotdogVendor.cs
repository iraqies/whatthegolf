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

	public float spawnForce = 14f;

	public int spawnCountPerCollision = 10;

	public float spawnInterval = 0.3f;

	public float impactThreshold = 5f;

	public RandomAudioClips spawnClips;

	public Action<GolfBallController> OnHotdogSpawned;

	public GolfBallController player;

	private float nextSpawn;

	private void Start()
	{
		if (hotdogStand != null)
		{
			hotdogStand.OnCollisionEnterTrigger -= HotdogStand_OnCollisionEnterTrigger;
			hotdogStand.OnCollisionEnterTrigger += HotdogStand_OnCollisionEnterTrigger;
		}
	}

	private void HotdogStand_OnCollisionEnterTrigger(Rigidbody obj)
	{
		if (obj == null)
			return;
		var ctrl = obj.gameObject.GetComponentInChildren<GolfBallController>() ?? obj.gameObject.GetComponentInParent<GolfBallController>();
		if (ctrl != null && Time.time > nextSpawn)
		{
			nextSpawn = Time.time + spawnInterval;
			StartCoroutine(SpawnHotdogs(ctrl));
		}
	}

	public void CallSpawnHotdogs()
	{
		if (Time.time > nextSpawn)
		{
			nextSpawn = Time.time + spawnInterval;
			StartCoroutine(SpawnHotdogs(player));
		}
	}

	private void OnTriggerEnter(Collider other)
	{
		if (other == null)
			return;
		var ctrl = other.GetComponent<GolfBallController>() ?? other.GetComponentInParent<GolfBallController>() ?? other.GetComponentInChildren<GolfBallController>();
		if (ctrl != null && Time.time > nextSpawn)
		{
			nextSpawn = Time.time + spawnInterval;
			StartCoroutine(SpawnHotdogs(ctrl));
		}
	}

	private void OnCollisionEnter(Collision collision)
	{
		if (collision == null || collision.gameObject == null)
			return;
		var ctrl = collision.gameObject.GetComponentInChildren<GolfBallController>() ?? collision.gameObject.GetComponentInParent<GolfBallController>();
		if (ctrl != null && Time.time > nextSpawn)
		{
			nextSpawn = Time.time + spawnInterval;
			StartCoroutine(SpawnHotdogs(ctrl));
		}
	}

	private IEnumerator SpawnHotdogs(GolfBallController controller)
	{
		int count = Mathf.Max(1, spawnCountPerCollision);
		var wait = new WaitForSeconds(0.25f / count);
		for (int i = 0; i < count; i++)
		{
			if (spawnPositions != null && hotdogPrefab != null)
			{
				Rigidbody hd = UnityEngine.Object.Instantiate(hotdogPrefab, spawnPositions.position, UnityEngine.Random.rotation);
				if (hd != null)
				{
					Vector3 fwd = spawnPositions.forward * (spawnForce * UnityEngine.Random.Range(0.7f, 1f));
					Vector3 rand = UnityEngine.Random.onUnitSphere * 8f;
					hd.velocity = fwd + rand + Vector3.up * 2f;
					hd.angularVelocity = UnityEngine.Random.insideUnitSphere * 55f;
				}
				if (spawnClips != null)
					spawnClips.PlayRandomClip(spawnPositions);
				OnHotdogSpawned?.Invoke(controller);
			}
			yield return wait;
		}
	}
}
