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

	public float gravity = -9.81f;

	public float wheelParticlesGravityMultiplier = 1f;

	public bool MoveStageToBoss;

	public List<BossIslandPart> StageIslands;

	public int IslandsToPrepare = 2;

	public float InitialDistanceBuffer = 10f;

	public bool GoNearNextEndPointOnStart;

	public bool InitCamera = true;

	public float DelayCameraBehaviourBlendTime;

	public float AimTimeScale = 0.2f;

	public float UpSpeed = 5f;

	public float DownSpeed = 5f;

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
			m_OnChallengeIntro = (Action<IEnumerator>)Delegate.Combine(m_OnChallengeIntro, value);
		}
		[CompilerGenerated]
		remove
		{
			m_OnChallengeIntro = (Action<IEnumerator>)Delegate.Remove(m_OnChallengeIntro, value);
		}
	}

	public event Action OnChallengeBegin
	{
		[CompilerGenerated]
		add
		{
			m_OnChallengeBegin = (Action)Delegate.Combine(m_OnChallengeBegin, value);
		}
		[CompilerGenerated]
		remove
		{
			m_OnChallengeBegin = (Action)Delegate.Remove(m_OnChallengeBegin, value);
		}
	}

	public event Action OnChallengeEnd
	{
		[CompilerGenerated]
		add
		{
			m_OnChallengeEnd = (Action)Delegate.Combine(m_OnChallengeEnd, value);
		}
		[CompilerGenerated]
		remove
		{
			m_OnChallengeEnd = (Action)Delegate.Remove(m_OnChallengeEnd, value);
		}
	}

	public event Action OnChallengeUpdate
	{
		[CompilerGenerated]
		add
		{
			m_OnChallengeUpdate = (Action)Delegate.Combine(m_OnChallengeUpdate, value);
		}
		[CompilerGenerated]
		remove
		{
			m_OnChallengeUpdate = (Action)Delegate.Remove(m_OnChallengeUpdate, value);
		}
	}

	public void SetupBeforePlay(Vector3 lastGoalPosition)
	{
		if (MoveStageToBoss)
		{
			transform.position = lastGoalPosition;
		}
		goalPosition = transform.position;
	}

	public IEnumerator Play(BossStageSpawnPlayer eggSpawner)
	{
		gameObject.SetActive(true);
		if (eggSpawner != null && Egg != null)
		{
			yield return StartCoroutine(eggSpawner.SpawnPlayer(Egg));
		}
		m_OnChallengeBegin?.Invoke();
		GolfGoal stageGoal = GetComponentInChildren<GolfGoal>(true);
		bool stageDone = false;
		if (stageGoal != null)
		{
			stageGoal.OnComplete += _ =>
			{
				goalPosition = stageGoal.transform.position;
				stageDone = true;
			};
			while (!stageDone)
			{
				m_OnChallengeUpdate?.Invoke();
				yield return null;
			}
		}
		m_OnChallengeEnd?.Invoke();
	}

	public Vector3 GetGoalPosition()
	{
		return goalPosition;
	}

	public CameraBehaviorPerspective GetCameraBehaviour()
	{
		if (Application.isMobilePlatform && cameraBehaviourMobile != null)
		{
			return cameraBehaviourMobile;
		}
		return cameraBehaviour != null ? cameraBehaviour : cameraBehaviourMobile;
	}

	public CinemachineVirtualCamera GetVirtualCameraBehaviour()
	{
		if (Application.isMobilePlatform && virtualCameraBehaviourMobile != null)
		{
			return virtualCameraBehaviourMobile;
		}
		return virtualCameraBehaviour != null ? virtualCameraBehaviour : virtualCameraBehaviourMobile;
	}
}
