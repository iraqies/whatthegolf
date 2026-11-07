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

	private List<BossIslandPart> toBeRemoved;

	private Transform currentCheckpoint;

	private void Awake()
	{
	}

	private void NewIslandSpawned(BossIslandPart bossIslandPart)
	{
	}

	private void OnStageStarted(BossStage bossStage)
	{
	}

	private void Update()
	{
	}
}
