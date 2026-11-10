using System;
using System.Collections;
using System.Collections.Generic;
using CameraStack;
using Core;
using UnityEngine;
using Utility;

public class FinalBoss : MonoBehaviour
{
	public FinalBossStages stages;

	public FinalBossStages testStages;

	public bool UseTestStages;

	public CameraBehaviorPerspective introCamera;

	public CBBlend cameraBlend;

	public Gravity gravity;

	public BossStageSpawnPlayer PlayerSpawner;

	public Rigidbody BossRigid;

	public Action<BossStage> OnStageInitiating;

	public Action<BossStage> OnStageStarted;

	public Action<BossStage> OnStageEnding;

	public Animator BossCarAnimator;

	public Animator BossCarBaseAnimator;

	public Animator BossCarBreakingAnimator;

	public BossSHMUP ShmupStage;

	public BossFrogKingInside FrogInsides;

	public FrogKingLastStage LastStage;

	public GameObject FrogKingInside;

	public Animator CameraStageAnimator;

	public GameObject CamerasMobile;

	public GameObject CamerasStandalone;

	private Vector3 lastGoalPosition;

	private TimeControl timeControl;

	private BossIslands bossIslands;

	private bool waitLock;

	private Dictionary<BossStage, ObjectPool<BossIslandPart>> islandPool;

	public ParticleSystem[] WheelSystems;

	private void Awake()
	{
		bossIslands = GetComponentInChildren<BossIslands>();
		islandPool = new Dictionary<BossStage, ObjectPool<BossIslandPart>>();
		FinalBossStages activeList = UseTestStages && testStages != null && testStages.Count > 0 ? testStages : stages;
		if (activeList != null)
		{
			for (int i = 0; i < activeList.Count; i++)
			{
				BossStage s = activeList[i];
				if (s != null && s.StageIslands != null && s.StageIslands.Count > 0 && s.StageIslands[0] != null)
				{
					islandPool[s] = new ObjectPool<BossIslandPart>(s.StageIslands[0], Mathf.Max(2, s.IslandsToPrepare));
				}
			}
		}
	}

	private void Start()
	{
		StartCoroutine(PlayRoutine());
	}

	public bool GetIslandPoolForStage(BossStage stage, out ObjectPool<BossIslandPart> pool)
	{
		if (islandPool != null && stage != null && islandPool.TryGetValue(stage, out pool))
		{
			return pool != null;
		}
		pool = null;
		return false;
	}

	public IEnumerator PlayRoutine()
	{
		lastGoalPosition = BossRigid != null ? BossRigid.position : transform.position;
		FinalBossStages activeList = UseTestStages && testStages != null && testStages.Count > 0 ? testStages : stages;
		if (activeList != null)
		{
			for (int i = 0; i < activeList.Count; i++)
			{
				BossStage stage = activeList[i];
				if (stage == null)
				{
					continue;
				}
				OnStageInitiating?.Invoke(stage);
				stage.SetupBeforePlay(lastGoalPosition);
				OnStageStarted?.Invoke(stage);
				yield return StartCoroutine(stage.Play(PlayerSpawner));
				lastGoalPosition = stage.GetGoalPosition();
				OnStageEnding?.Invoke(stage);
			}
		}
		if (ShmupStage != null)
		{
			ShmupStage.gameObject.SetActive(true);
			yield return StartCoroutine(ShmupStage.StageRoutine());
		}
		if (FrogInsides != null)
		{
			if (FrogKingInside != null)
			{
				FrogKingInside.SetActive(true);
			}
			FrogInsides.gameObject.SetActive(true);
			yield return StartCoroutine(FrogInsides.PlayRoutine());
		}
		if (LastStage != null)
		{
			LastStage.gameObject.SetActive(true);
			yield return StartCoroutine(LastStage.PlayRoutine());
		}
	}

	private IEnumerator WaitLockRoutine(GolfBallController controller)
	{
		waitLock = true;
		while (waitLock)
		{
			yield return null;
		}
	}

	public List<BossIslandPart> GetAllActiveIslands()
	{
		if (bossIslands != null)
		{
			return bossIslands.GetSpawnedParts();
		}
		return new List<BossIslandPart>();
	}
}
