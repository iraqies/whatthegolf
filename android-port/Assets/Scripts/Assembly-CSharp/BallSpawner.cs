using System.Collections;
using System.Collections.Generic;
using Audio;
using UnityEngine;

public class BallSpawner : MonoBehaviour
{
	public float FirstSpawnDelay;

	public GameObject StikboldPrefab;

	public float SpawnRange;

	public ClipSettingsCollection sfxOnSpawn;

	public float ChangeToSpawn;

	public int MaxSpawns;

	public Collider BoundsCollider;

	private int spawns;

	private List<GameObject> spawnedBalls;

	private IEnumerator Start()
	{
		return null;
	}

	public void SpawnNewBall()
	{
	}

	private GameObject SpawnBall()
	{
		return null;
	}

	public void PlaySpawnSFX()
	{
	}

	public List<GameObject> GetBalls()
	{
		return null;
	}

	private void OnDrawGizmosSelected()
	{
	}
}
