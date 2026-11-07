using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BossObjectSpawner : MonoBehaviour
{
	public Transform SpawnOriginPosition;

	public List<GameObject> ObjectsToSpawn;

	public Vector2 AmountToSpawn;

	public Vector2 SpawnPositionRangeX;

	public float SpawnForce;

	public Vector2 SpawnIntervalRange;

	public float InitialDelay;

	public ParticleSystem RiseParticles;

	public BossStage BossStage;

	public Vector2 ScaleModRange;

	public int MaxSpawns;

	private float spawnTimer;

	private int currentSpawns;

	private void Awake()
	{
	}

	private void Start()
	{
	}

	private void Update()
	{
	}

	private void SpawnNew()
	{
	}

	private IEnumerator RiseRoutine(GameObject go)
	{
		return null;
	}
}
