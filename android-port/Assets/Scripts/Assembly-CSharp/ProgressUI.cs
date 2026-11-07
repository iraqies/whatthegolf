using System;
using System.Collections;
using System.Collections.Generic;
using Audio;
using Core;
using UnityEngine;

public class ProgressUI : MonoBehaviour
{
	[Serializable]
	public class PlayerPointsContainer
	{
		public LobbySpawnPoint.SpawnPointPositions Side;

		public ProgressUIPlayerPoints PlayerPoints;
	}

	public MultiplayerLobby Lobby;

	public Animator Animator;

	public ProgressUICharacters Characters;

	public List<ProgressUIMap> Maps;

	public GameObject MapContainer;

	public List<PlayerPointsContainer> PlayerPoints;

	public Camera UICamera;

	public Canvas CrownCanvas;

	public ClipSettingsCollection CrownClaimedClip;

	private Vector3 from;

	private Transform target;

	private float moveTimer;

	private Vector3 refVel;

	private float waitTime;

	private ProgressUIMap selectedMap;

	private int lastFlag;

	private bool moveCharacters;

	private MultiplayerConfiguration.PlayerInfo winner;

	private Dictionary<LobbySpawnPoint.SpawnPointPositions, ProgressUIPlayerPoints> playerPoints;

	private void Awake()
	{
	}

	private void SetCrownCanvasEnabled(bool value)
	{
	}

	private void SetMapContainerActive(bool value)
	{
	}

	private void UpdateCamera()
	{
	}

	public void Initialize()
	{
	}

	private void OnLevelWinnerFound(List<MultiplayerConfiguration.PlayerInfo> players, MultiplayerConfiguration.PlayerInfo winner)
	{
	}

	public IEnumerator WinningRoutine(List<MultiplayerConfiguration.PlayerInfo> players, MultiplayerConfiguration.PlayerInfo winner)
	{
		return null;
	}

	public IEnumerator PlayerWonArenaRoutine(List<MultiplayerConfiguration.PlayerInfo> players, MultiplayerConfiguration.PlayerInfo winner)
	{
		return null;
	}

	private void OnLevelAboutToLoad()
	{
	}

	public void SetupBeforeRoutine(int index, List<LevelData> levels, List<MultiplayerConfiguration.PlayerInfo> players, MultiplayerPlayList.MatchTypes matchType)
	{
	}

	public void HideBehindArenaSequence()
	{
	}

	public void InitiateVista(List<MultiplayerConfiguration.PlayerInfo> players)
	{
	}

	public void StartVistaSequence()
	{
	}

	public void DisableVista()
	{
	}

	public void InitForArena()
	{
	}

	public void HideBehindTransition()
	{
	}

	public void HideAndReset()
	{
	}

	public void FinalLevelLoaded(List<MultiplayerConfiguration.PlayerInfo> players)
	{
	}

	private IEnumerator DelayedMaximize(float delay, bool value, MultiplayerConfiguration.PlayerInfo player)
	{
		return null;
	}

	private IEnumerator ShowPoints(MultiplayerConfiguration.PlayerInfo player, float initialDelay)
	{
		return null;
	}

	private void PlayerHealthChanged(MultiplayerConfiguration.PlayerInfo playerHit, int health)
	{
	}

	public IEnumerator OnProgress(int index, List<MultiplayerConfiguration.PlayerInfo> players, MultiplayerConfiguration.PlayerInfo lastWinner, MultiplayerPlayList.MatchTypes matchType)
	{
		return null;
	}

	public void ToggleMaximize(bool value, MultiplayerConfiguration.PlayerInfo player)
	{
	}

	public IEnumerator ConvertStrokesToPoints(List<MultiplayerConfiguration.PlayerInfo> players, MultiplayerConfiguration.PlayerInfo winner, MultiplayerPlayList.MatchTypes matchType, bool instant = false)
	{
		return null;
	}
}
