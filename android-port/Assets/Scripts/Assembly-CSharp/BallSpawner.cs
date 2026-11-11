using System.Collections;
using System.Collections.Generic;
using Audio;
using UnityEngine;

public class BallSpawner : MonoBehaviour
{
	public float FirstSpawnDelay = 1f;

	public GameObject StikboldPrefab;

	public float SpawnRange = 3f;

	public ClipSettingsCollection sfxOnSpawn;

	public float ChangeToSpawn = 0.5f;

	public int MaxSpawns = 5;

	public Collider BoundsCollider;

	private int spawns;

	private List<GameObject> spawnedBalls = new List<GameObject>();

	private IEnumerator Start()
	{
		spawnedBalls = new List<GameObject>();
		yield return new WaitForSeconds(FirstSpawnDelay);
		SpawnBall();
	}

	public void SpawnNewBall()
	{
		if (spawns < MaxSpawns && Random.value <= ChangeToSpawn)
		{
			SpawnBall();
		}
	}

	private GameObject SpawnBall()
	{
		if (StikboldPrefab == null)
		{
			return null;
		}
		Vector2 rnd = Random.insideUnitCircle * SpawnRange;
		Vector3 spawnPos = transform.position + new Vector3(rnd.x, 0f, rnd.y);
		GameObject go = Object.Instantiate(StikboldPrefab, spawnPos, Quaternion.identity, transform.parent);
		PlaySpawnSFX();
		spawns++;
		if (spawnedBalls == null)
		{
			spawnedBalls = new List<GameObject>();
		}
		spawnedBalls.Add(go);
		return go;
	}

	public void PlaySpawnSFX()
	{
		if (sfxOnSpawn != null)
		{
			sfxOnSpawn.Play(null, transform.position, 1f, 1f);
		}
	}

	public List<GameObject> GetBalls()
	{
		if (spawnedBalls == null)
		{
			return new List<GameObject>();
		}
		for (int i = spawnedBalls.Count - 1; i >= 0; i--)
		{
			GameObject ball = spawnedBalls[i];
			if (ball == null || (BoundsCollider != null && !BoundsCollider.bounds.Contains(ball.transform.position)))
			{
				if (ball != null)
				{
					Object.Destroy(ball);
				}
				spawnedBalls.RemoveAt(i);
				spawns = Mathf.Max(0, spawns - 1);
			}
		}
		if (spawnedBalls.Count == 0)
		{
			SpawnBall();
		}
		return spawnedBalls;
	}

	private void OnDrawGizmosSelected()
	{
	}
}
