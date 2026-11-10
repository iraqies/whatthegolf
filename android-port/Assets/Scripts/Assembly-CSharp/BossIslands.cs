using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Utility;

public class BossIslands : MonoBehaviour
{
	public FinalBoss FinalBoss;

	public Transform BossCar;

	public float DistanceFromNextPointBeforeNewSpawn = 30f;

	public Transform NextEndPoint;

	public int IslandsToPrepare = 2;

	public Action<BossIslandPart> OnNewIslandSpawned;

	public Action<BossIslandPart> OnIslandDestroyed;

	private ObjectPool<BossIslandPart> islandPool;

	private bool hasPool;

	private BossStage currentStage;

	private List<BossIslandPart> spawnedParts = new List<BossIslandPart>();

	private void Awake()
	{
		if (FinalBoss == null)
		{
			FinalBoss = GetComponentInParent<FinalBoss>();
		}
		if (FinalBoss != null)
		{
			FinalBoss.OnStageStarted += OnStageStarted;
		}
	}

	private void OnStageStarted(BossStage bossStage)
	{
		currentStage = bossStage;
		hasPool = FinalBoss != null && FinalBoss.GetIslandPoolForStage(bossStage, out islandPool);
	}

	private void Update()
	{
		if (!hasPool || islandPool == null || BossCar == null || NextEndPoint == null)
		{
			return;
		}
		if (Vector3.Distance(BossCar.position, NextEndPoint.position) <= DistanceFromNextPointBeforeNewSpawn)
		{
			BossIslandPart nextPart = islandPool.Get(NextEndPoint.position, NextEndPoint.rotation);
			if (nextPart != null)
			{
				nextPart.OwnerPool = islandPool;
				nextPart.gameObject.SetActive(true);
				spawnedParts.Add(nextPart);
				if (nextPart.EndPoint != null)
				{
					NextEndPoint = nextPart.EndPoint;
				}
				StartCoroutine(GrowPiece(nextPart.transform));
				OnNewIslandSpawned?.Invoke(nextPart);
			}
		}
	}

	private IEnumerator GrowPiece(Transform piece)
	{
		if (piece == null)
		{
			yield break;
		}
		Vector3 targetScale = piece.localScale;
		float t = 0f;
		while (t < 0.35f && piece != null)
		{
			t += Time.deltaTime;
			piece.localScale = Vector3.Lerp(Vector3.zero, targetScale, t / 0.35f);
			yield return null;
		}
		if (piece != null)
		{
			piece.localScale = targetScale;
		}
	}

	public Vector3 GetNextEndPoint()
	{
		return NextEndPoint != null ? NextEndPoint.position : transform.position;
	}

	public void DestroyPart(BossIslandPart part)
	{
		if (part == null)
		{
			return;
		}
		spawnedParts.Remove(part);
		OnIslandDestroyed?.Invoke(part);
		if (part.OwnerPool != null)
		{
			part.OwnerPool.Release(part);
		}
		else
		{
			part.gameObject.SetActive(false);
		}
	}

	public List<BossIslandPart> GetSpawnedParts()
	{
		return spawnedParts;
	}
}
