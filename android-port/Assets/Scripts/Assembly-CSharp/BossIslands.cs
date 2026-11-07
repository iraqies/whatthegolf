using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Utility;

public class BossIslands : MonoBehaviour
{
	public FinalBoss FinalBoss;

	public Transform BossCar;

	public float DistanceFromNextPointBeforeNewSpawn;

	public Transform NextEndPoint;

	public int IslandsToPrepare;

	public Action<BossIslandPart> OnNewIslandSpawned;

	public Action<BossIslandPart> OnIslandDestroyed;

	private ObjectPool<BossIslandPart> islandPool;

	private bool hasPool;

	private BossStage currentStage;

	private void Awake()
	{
	}

	private void OnStageStarted(BossStage bossStage)
	{
	}

	private void Update()
	{
	}

	private IEnumerator GrowPiece(Transform piece)
	{
		return null;
	}

	public Vector3 GetNextEndPoint()
	{
		return default;
	}

	public void DestroyPart(BossIslandPart part)
	{
	}

	public List<BossIslandPart> GetSpawnedParts()
	{
		return null;
	}
}
