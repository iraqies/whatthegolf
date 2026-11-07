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
	}

	public bool GetIslandPoolForStage(BossStage stage, out ObjectPool<BossIslandPart> pool)
	{
		pool = null;
		return false;
	}

	public IEnumerator PlayRoutine()
	{
		return null;
	}

	private IEnumerator WaitLockRoutine(GolfBallController controller)
	{
		return null;
	}

	public List<BossIslandPart> GetAllActiveIslands()
	{
		return null;
	}
}
