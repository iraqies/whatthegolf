using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using CameraStack;
using Core;
using UnityEngine;

public class MultiplayerLevelInfo : MonoBehaviour
{
	public enum ListDistributionMethodEnum
	{
		EveryoneUsesTheSame = 0,
		OneListForEachPlayer = 1,
		OneListForEachPlayerOrdered = 2
	}

	[Serializable]
	public class ControllerSetup
	{
		public List<GameObject> Controllers;

		public CameraManager Camera;

		public PlayerColors.AvatarIDs AvailableFor;
	}

	public enum PlayerDistributionTypeEnum
	{
		Identical = 0,
		Different = 1
	}

	public enum SpawnTypes
	{
		SpawnNewControllers = 0,
		UseCurrentControllers = 1
	}

	public enum GameTypes
	{
		Strokes = 0,
		Time = 1
	}

	public enum SplitScreenTypeEnum
	{
		VerticalSplit = 0,
		HorizontalSplit = 1
	}

	public enum WinConditions
	{
		AllPlayersHitGoal = 0,
		OnePlayerHitsGoal = 1
	}

	public enum ResetEvents
	{
		Reset = 0,
		Respawn = 1
	}

	public ListDistributionMethodEnum ListDistributionMethod;

	public List<ControllerSetup> Setups;

	public int LoseStrokePenalty;

	public PlayerDistributionTypeEnum DistributionType;

	public SpawnTypes SpawnType;

	public bool HasSplitScreen;

	public List<GameObject> Controllers;

	public List<GameObject> SinglePlayerControllers;

	public bool SpawnAtControllerPosition;

	public SplitScreenTypeEnum SplitScreenType;

	public List<Transform> SpawnPoints;

	public List<GameObject> ObjectsToDisable;

	public List<GameObject> ObjectsToEnable;

	public WinConditions WinCondition = WinConditions.OnePlayerHitsGoal;

	public ResetEvents ResetEvent;

	public GameTypes GameType;

	public bool CullOpponentArrow;

	public CameraManager OverrideCamera;

	public bool UseSpawnPointRotation;

	private MultiplayerConfiguration config;

	private StrokeCounter strokeCounter;

	private bool firstPlayerFinished;

	[CompilerGenerated]
	private Action<GolfBallController> m_onPlayerSpawned;

	public event Action<GolfBallController> onPlayerSpawned
	{
		[CompilerGenerated]
		add
		{
			m_onPlayerSpawned = (Action<GolfBallController>)Delegate.Combine(m_onPlayerSpawned, value);
		}
		[CompilerGenerated]
		remove
		{
			m_onPlayerSpawned = (Action<GolfBallController>)Delegate.Remove(m_onPlayerSpawned, value);
		}
	}

	public void SetupLevel(MultiplayerConfiguration config)
	{
		this.config = config;
		if (config != null && config.Players != null)
		{
			for (int i = 0; i < config.Players.Count; i++)
			{
				MultiplayerConfiguration.PlayerInfo p = config.Players[i];
				if (p != null)
				{
					p.Reset();
					p.TimeSpent?.Start();
				}
			}
		}
		SetupUsingExisting();
		SetupBaseMultiplayer();
		SetupAvatarAudio();
	}

	public void RequestNewBallForPlayer(int playerIndex, GolfBallController oldController)
	{
		if (config == null)
		{
			return;
		}
		MultiplayerConfiguration.PlayerInfo player = config.GetPlayerWithIndex(playerIndex);
		if (player == null || player.BallToSpawn == null)
		{
			return;
		}
		GameObject go = UnityEngine.Object.Instantiate(player.BallToSpawn);
		if (SpawnAtControllerPosition && player.BallToSpawn != null)
		{
			go.transform.position = player.BallToSpawn.transform.position;
		}
		else if (SpawnPoints != null && playerIndex >= 0 && playerIndex < SpawnPoints.Count && SpawnPoints[playerIndex] != null)
		{
			go.transform.position = SpawnPoints[playerIndex].position;
		}
		if (player.BallToSpawn != null)
		{
			go.transform.rotation = player.BallToSpawn.transform.rotation;
		}
		GolfBallController ctrl = SetControllerForPlayer(player, go);
		if (player.Cam != null && ctrl != null)
		{
			if (player.Cam.CurrentCameraBehavior is CBFollow follow)
			{
				follow.FollowTarget = go.transform;
			}
			ctrl.mainCamera = player.Cam.MainCamera;
		}
		if (strokeCounter != null && ctrl != null && player.Avatar != null)
		{
			strokeCounter.SubscribePlayerToStrokeCounter(ctrl, player.Avatar.StrokeCounterColor);
		}
		if (oldController != null && ctrl != null)
		{
			ctrl.NumberOfStrokes = oldController.NumberOfStrokes;
		}
		m_onPlayerSpawned?.Invoke(ctrl);
	}

	private IEnumerator TimeCounter()
	{
		bool done = false;
		if (Level.Instance != null)
		{
			Level.Instance.OnComplete += _ => done = true;
		}
		while (!done)
		{
			if (config != null && config.Players != null)
			{
				for (int i = 0; i < config.Players.Count; i++)
				{
					MultiplayerConfiguration.PlayerInfo p = config.Players[i];
					if (p != null && p.Controllers != null)
					{
						for (int j = 0; j < p.Controllers.Count; j++)
						{
							if (p.Controllers[j] != null && p.Controllers[j].gameObject.activeSelf)
							{
								p.Controllers[j].CountShot();
							}
						}
					}
				}
			}
			yield return new WaitForSecondsRealtime(1f);
		}
	}

	private void SetupBaseMultiplayer()
	{
		GolfGoal[] goals = UnityEngine.Object.FindObjectsOfType<GolfGoal>();
		if (goals != null)
		{
			for (int i = 0; i < goals.Length; i++)
			{
				if (goals[i] != null)
				{
					goals[i].OnGoalProgress += OnGoalProgress;
				}
			}
		}
		if (ObjectsToEnable != null)
		{
			for (int i = 0; i < ObjectsToEnable.Count; i++)
			{
				if (ObjectsToEnable[i] != null)
				{
					ObjectsToEnable[i].SetActive(true);
				}
			}
		}
	}

	private void SetupAvatarAudio()
	{
		if (config == null || config.Players == null)
		{
			return;
		}
		for (int i = 0; i < config.Players.Count; i++)
		{
			MultiplayerConfiguration.PlayerInfo p = config.Players[i];
			if (p == null || p.ControllerContainer == null)
			{
				continue;
			}
			for (int j = 0; j < p.ControllerContainer.Count; j++)
			{
				GameObject go = p.ControllerContainer[j];
				if (go == null)
				{
					continue;
				}
				AudioSource[] sources = go.GetComponentsInChildren<AudioSource>();
				if (sources != null)
				{
					for (int k = 0; k < sources.Length; k++)
					{
						if (sources[k] != null)
						{
							sources[k].bypassEffects = true;
							sources[k].spatialBlend = 0.2f;
						}
					}
				}
			}
		}
	}

	private void SetupUsingExisting()
	{
		if (ObjectsToDisable != null)
		{
			for (int i = 0; i < ObjectsToDisable.Count; i++)
			{
				if (ObjectsToDisable[i] != null)
				{
					ObjectsToDisable[i].SetActive(false);
				}
			}
		}
		if (config == null || config.Players == null || Setups == null || Setups.Count == 0)
		{
			return;
		}
		for (int i = 0; i < config.Players.Count; i++)
		{
			MultiplayerConfiguration.PlayerInfo player = config.Players[i];
			if (player == null)
			{
				continue;
			}
			ControllerSetup setup = Setups[i % Setups.Count];
			if (setup == null)
			{
				continue;
			}
			if (setup.Camera != null)
			{
				setup.Camera.gameObject.SetActive(true);
				player.Cam = setup.Camera;
				setup.Camera.SetCurrentBehaviour();
			}
			else if (OverrideCamera != null)
			{
				OverrideCamera.gameObject.SetActive(true);
				player.Cam = OverrideCamera;
			}
			else
			{
				player.Cam = CameraManager.Instance;
			}
			player.ControllerContainer = new List<GameObject>();
			if (setup.Controllers != null && setup.Controllers.Count > 0)
			{
				for (int j = 0; j < setup.Controllers.Count; j++)
				{
					GameObject ctrlObj = setup.Controllers[j];
					if (ctrlObj == null)
					{
						continue;
					}
					if (SpawnType == SpawnTypes.SpawnNewControllers)
					{
						ctrlObj = UnityEngine.Object.Instantiate(ctrlObj);
					}
					if (!SpawnAtControllerPosition && SpawnPoints != null && i < SpawnPoints.Count && SpawnPoints[i] != null)
					{
						ctrlObj.transform.position = SpawnPoints[i].position;
						if (UseSpawnPointRotation)
						{
							ctrlObj.transform.rotation = SpawnPoints[i].rotation;
						}
					}
					SetControllerForPlayer(player, ctrlObj);
					player.BallToSpawn = setup.Controllers[0];
					player.ControllerContainer.Add(ctrlObj);
				}
			}
		}
		StartCoroutine(LateInit());
	}

	private GolfBallController SetControllerForPlayer(MultiplayerConfiguration.PlayerInfo player, GameObject go)
	{
		if (player == null || go == null)
		{
			return null;
		}
		int pIdx = player.InputIndex;
		GolfBallController ctrl = go.GetComponentInChildren<GolfBallController>();
		if (ctrl != null)
		{
			ctrl.SetPlayer(pIdx);
		}
		go.SetActive(true);
		go.name = go.name + "_" + pIdx;
		if (player.Controllers != null && ctrl != null)
		{
			player.Controllers.Add(ctrl);
		}
		SetMaterialColorToPlayerColor[] colorSetters = go.GetComponentsInChildren<SetMaterialColorToPlayerColor>(true);
		if (colorSetters != null)
		{
			for (int i = 0; i < colorSetters.Length; i++)
			{
				if (colorSetters[i] != null)
				{
					colorSetters[i].UpdateMaterials(player.Avatar);
				}
			}
		}
		ToggleObjectBasedOnAvatarSelected[] toggles = go.GetComponentsInChildren<ToggleObjectBasedOnAvatarSelected>(true);
		if (toggles != null)
		{
			for (int i = 0; i < toggles.Length; i++)
			{
				if (toggles[i] != null)
				{
					toggles[i].UpdateBasedOnAvatar(player);
				}
			}
		}
		return ctrl;
	}

	private void OnGoalProgress(int playerIndex, string arg2)
	{
		if (config == null)
		{
			return;
		}
		MultiplayerConfiguration.PlayerInfo player = config.GetPlayerWithIndex(playerIndex);
		if (player != null)
		{
			player.TimeSpent?.Stop();
			player.FinishedCurrentLevel = true;
			if (!firstPlayerFinished)
			{
				player.OnPlayerFinishedLevel?.Invoke(player);
				firstPlayerFinished = true;
			}
			if (WinCondition == WinConditions.OnePlayerHitsGoal || config.Players.All(p => p == null || p.FinishedCurrentLevel))
			{
				if (Level.Instance != null)
				{
					Level.Instance.Complete(null, null, null, false);
				}
			}
		}
	}

	private IEnumerator LateInit()
	{
		yield return null;
		strokeCounter = UnityEngine.Object.FindObjectOfType<StrokeCounter>();
		if (config != null && config.Players != null)
		{
			for (int i = 0; i < config.Players.Count; i++)
			{
				MultiplayerConfiguration.PlayerInfo p = config.Players[i];
				if (p == null || p.Controllers == null)
				{
					continue;
				}
				for (int j = 0; j < p.Controllers.Count; j++)
				{
					GolfBallController ctrl = p.Controllers[j];
					if (ctrl != null && strokeCounter != null)
					{
						strokeCounter.TogglePlayer(p.InputIndex, true, i);
						if (p.Avatar != null)
						{
							strokeCounter.SubscribePlayerToStrokeCounter(ctrl, p.Avatar.StrokeCounterColor);
						}
					}
					if (ctrl != null && p.Cam != null)
					{
						ctrl.mainCamera = p.Cam.MainCamera;
					}
				}
			}
		}
		if (GameType == GameTypes.Time)
		{
			StartCoroutine(TimeCounter());
		}
	}

	private IEnumerator CountdownRoutine()
	{
		TimeControl tc = UnityEngine.Object.FindObjectOfType<TimeControl>();
		if (tc != null)
		{
			yield return StartCoroutine(pTween.ToRealTime(0.5f, 0f, 1f, t =>
			{
				if (tc != null)
				{
					tc.SetNewAimTimeScale(Mathf.Lerp(0.1f, 1f, TweenFunctions.EaseIn(t)));
				}
			}));
		}
	}

	public List<GolfBallController> GetAllControllers()
	{
		List<GolfBallController> list = new List<GolfBallController>();
		if (config != null && config.Players != null)
		{
			for (int i = 0; i < config.Players.Count; i++)
			{
				if (config.Players[i] != null && config.Players[i].Controllers != null)
				{
					list.AddRange(config.Players[i].Controllers);
				}
			}
		}
		return list;
	}
}
