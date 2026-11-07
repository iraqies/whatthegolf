using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CameraStack;
using Cinemachine;
using UnityEngine;

public class BossStage : MonoBehaviour
{
	public BossPlayerEgg Egg;

	[SerializeField]
	private CameraBehaviorPerspective cameraBehaviour;

	[SerializeField]
	private CameraBehaviorPerspective cameraBehaviourMobile;

	[SerializeField]
	private CinemachineVirtualCamera virtualCameraBehaviour;

	[SerializeField]
	private CinemachineVirtualCamera virtualCameraBehaviourMobile;

	public float gravity;

	public float wheelParticlesGravityMultiplier;

	public bool MoveStageToBoss;

	public List<BossIslandPart> StageIslands;

	public int IslandsToPrepare;

	public float InitialDistanceBuffer;

	public bool GoNearNextEndPointOnStart;

	public bool InitCamera;

	public float DelayCameraBehaviourBlendTime;

	public float AimTimeScale;

	public float UpSpeed;

	public float DownSpeed;

	public bool ShowVisualEffect;

	public BossStageMusic music;

	public bool ScreenFaceForwardOnStageStart;

	[CompilerGenerated]
	private Action<IEnumerator> m_OnChallengeIntro;

	[CompilerGenerated]
	private Action m_OnChallengeBegin;

	[CompilerGenerated]
	private Action m_OnChallengeEnd;

	[CompilerGenerated]
	private Action m_OnChallengeUpdate;

	public bool OnlySpawnOneIsland;

	public string CameraTriggerName;

	private Vector3 goalPosition;

	public event Action<IEnumerator> OnChallengeIntro
	{
		[CompilerGenerated]
		add
		{
		}
		[CompilerGenerated]
		remove
		{
		}
	}

	public event Action OnChallengeBegin
	{
		[CompilerGenerated]
		add
		{
		}
		[CompilerGenerated]
		remove
		{
		}
	}

	public event Action OnChallengeEnd
	{
		[CompilerGenerated]
		add
		{
		}
		[CompilerGenerated]
		remove
		{
		}
	}

	public event Action OnChallengeUpdate
	{
		[CompilerGenerated]
		add
		{
		}
		[CompilerGenerated]
		remove
		{
		}
	}

	public void SetupBeforePlay(Vector3 lastGoalPosition)
	{
	}

	public IEnumerator Play(BossStageSpawnPlayer eggSpawner)
	{
		return null;
	}

	public Vector3 GetGoalPosition()
	{
		return default;
	}

	public CameraBehaviorPerspective GetCameraBehaviour()
	{
		return null;
	}

	public CinemachineVirtualCamera GetVirtualCameraBehaviour()
	{
		return null;
	}
}
