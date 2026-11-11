using System;
using System.Collections.Generic;
using Core;
using UnityEngine;

public class BossPlayerCheckpoint : MonoBehaviour
{
	public BossIslands BossIslands;

	public FinalBoss Boss;

	private GolfBallController currentController;

	private Vector3 nextEndPointPosition;

	private List<BossIslandPart> islands;

	private List<BossIslandPart> toBeRemoved = new List<BossIslandPart>();

	private Transform currentCheckpoint;

	private void Awake()
	{
		islands = new List<BossIslandPart>();
		Boss.OnStageStarted = (Action<BossStage>)Delegate.Combine(Boss.OnStageStarted, new Action<BossStage>(OnStageStarted));
		BossIslands.OnNewIslandSpawned = (Action<BossIslandPart>)Delegate.Combine(BossIslands.OnNewIslandSpawned, new Action<BossIslandPart>(NewIslandSpawned));
	}

	private void NewIslandSpawned(BossIslandPart bossIslandPart)
	{
		islands.Add(bossIslandPart);
	}

	private void OnStageStarted(BossStage bossStage)
	{
		currentController = bossStage.Egg.PlayerController;
		if (islands.Count >= 1)
		{
			currentController.CheckpointHit(islands[0].EndPoint.position, Quaternion.identity);
		}
	}

	private void Update()
	{
		if (currentController == null)
		{
			return;
		}
		for (int i = 0; i < islands.Count; i++)
		{
			if (currentController.transform.position.z > islands[i].EndPoint.position.z)
			{
				currentController.CheckpointHit(islands[i].EndPoint.position + Vector3.up * 10f, Quaternion.identity);
				toBeRemoved.Add(islands[i]);
				currentCheckpoint = islands[i].EndPoint;
			}
			else if (currentController.transform.position.z < islands[i].EndPoint.position.z)
			{
				break;
			}
		}
		for (int num = toBeRemoved.Count - 1; num >= 0; num--)
		{
			BossIslandPart bossIslandPart = toBeRemoved[num];
			if (islands.Contains(bossIslandPart))
			{
				islands.Remove(bossIslandPart);
			}
			else if (currentController.transform.position.z - bossIslandPart.EndPoint.position.z > 200f && currentCheckpoint != bossIslandPart.EndPoint)
			{
				toBeRemoved.Remove(bossIslandPart);
				BossIslands.DestroyPart(bossIslandPart);
			}
		}
	}
}
