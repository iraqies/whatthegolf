using System;
using System.Collections;
using System.Collections.Generic;
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

	public WinConditions WinCondition;

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
		}
		[CompilerGenerated]
		remove
		{
		}
	}

	public void SetupLevel(MultiplayerConfiguration config)
	{
	}

	public void RequestNewBallForPlayer(int playerIndex, GolfBallController oldController)
	{
	}

	private IEnumerator TimeCounter()
	{
		return null;
	}

	private void SetupBaseMultiplayer()
	{
	}

	private void SetupAvatarAudio()
	{
	}

	private void SetupUsingExisting()
	{
	}

	private GolfBallController SetControllerForPlayer(MultiplayerConfiguration.PlayerInfo player, GameObject go)
	{
		return null;
	}

	private void OnGoalProgress(int playerIndex, string arg2)
	{
	}

	private IEnumerator LateInit()
	{
		return null;
	}

	private IEnumerator CountdownRoutine()
	{
		return null;
	}

	public List<GolfBallController> GetAllControllers()
	{
		return null;
	}
}
