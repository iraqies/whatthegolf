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
		Initialize();
	}

	private void SetCrownCanvasEnabled(bool value)
	{
		if (CrownCanvas != null)
		{
			CrownCanvas.enabled = value;
		}
	}

	private void SetMapContainerActive(bool value)
	{
		if (MapContainer != null)
		{
			MapContainer.SetActive(value);
		}
	}

	private void UpdateCamera()
	{
		if (UICamera != null && target != null)
		{
			UICamera.transform.position = Vector3.SmoothDamp(UICamera.transform.position, target.position, ref refVel, 0.35f);
		}
	}

	public void Initialize()
	{
		if (playerPoints == null)
		{
			playerPoints = new Dictionary<LobbySpawnPoint.SpawnPointPositions, ProgressUIPlayerPoints>();
			if (PlayerPoints != null)
			{
				for (int i = 0; i < PlayerPoints.Count; i++)
				{
					if (PlayerPoints[i] != null && PlayerPoints[i].PlayerPoints != null)
					{
						playerPoints[PlayerPoints[i].Side] = PlayerPoints[i].PlayerPoints;
					}
				}
			}
		}
		if (Characters != null)
		{
			Characters.Initialize();
		}
	}

	private void OnLevelWinnerFound(List<MultiplayerConfiguration.PlayerInfo> players, MultiplayerConfiguration.PlayerInfo winner)
	{
		this.winner = winner;
	}

	public IEnumerator WinningRoutine(List<MultiplayerConfiguration.PlayerInfo> players, MultiplayerConfiguration.PlayerInfo winner)
	{
		SetMapContainerActive(true);
		SetCrownCanvasEnabled(true);
		if (winner != null && Characters != null && winner.Avatar != null)
		{
			yield return StartCoroutine(Characters.DoWinPose(winner.Avatar.AvatarID));
		}
		yield return new WaitForSeconds(1f);
	}

	public IEnumerator PlayerWonArenaRoutine(List<MultiplayerConfiguration.PlayerInfo> players, MultiplayerConfiguration.PlayerInfo winner)
	{
		yield return StartCoroutine(WinningRoutine(players, winner));
	}

	private void OnLevelAboutToLoad()
	{
		SetMapContainerActive(false);
	}

	public void SetupBeforeRoutine(int index, List<LevelData> levels, List<MultiplayerConfiguration.PlayerInfo> players, MultiplayerPlayList.MatchTypes matchType)
	{
		if (Maps != null && Maps.Count > 0)
		{
			selectedMap = Maps[0];
			if (selectedMap != null && levels != null)
			{
				selectedMap.CreateMapPoints(levels.Count);
			}
		}
		if (Characters != null)
		{
			Characters.SetCharacters(players);
		}
	}

	public void HideBehindArenaSequence()
	{
		SetMapContainerActive(false);
	}

	public void InitiateVista(List<MultiplayerConfiguration.PlayerInfo> players)
	{
		if (Characters != null)
		{
			Characters.SetCharacters(players);
		}
	}

	public void StartVistaSequence()
	{
		SetMapContainerActive(true);
	}

	public void DisableVista()
	{
		SetMapContainerActive(false);
	}

	public void InitForArena()
	{
		SetCrownCanvasEnabled(true);
	}

	public void HideBehindTransition()
	{
		SetMapContainerActive(false);
	}

	public void HideAndReset()
	{
		SetMapContainerActive(false);
		SetCrownCanvasEnabled(false);
		if (selectedMap != null)
		{
			selectedMap.ResetMap();
		}
		if (Characters != null)
		{
			Characters.ResetCharacters();
		}
	}

	public void FinalLevelLoaded(List<MultiplayerConfiguration.PlayerInfo> players)
	{
	}

	private IEnumerator DelayedMaximize(float delay, bool value, MultiplayerConfiguration.PlayerInfo player)
	{
		yield return new WaitForSeconds(delay);
		ToggleMaximize(value, player);
	}

	private IEnumerator ShowPoints(MultiplayerConfiguration.PlayerInfo player, float initialDelay)
	{
		yield return new WaitForSeconds(initialDelay);
		if (player != null && playerPoints != null && playerPoints.TryGetValue(player.Side, out ProgressUIPlayerPoints ui) && ui != null && ui.Crowns != null)
		{
			int idx = Mathf.Clamp(player.Points - 1, 0, ui.Crowns.Count - 1);
			if (idx >= 0 && idx < ui.Crowns.Count && ui.Crowns[idx] != null)
			{
				Color c = player.Avatar != null ? player.Avatar.BaseColor : Color.yellow;
				ui.Crowns[idx].Claim(c);
				if (CrownClaimedClip != null)
				{
					CrownClaimedClip.Play(null, Vector3.zero, 1f, 1f);
				}
			}
		}
	}

	private void PlayerHealthChanged(MultiplayerConfiguration.PlayerInfo playerHit, int health)
	{
	}

	public IEnumerator OnProgress(int index, List<MultiplayerConfiguration.PlayerInfo> players, MultiplayerConfiguration.PlayerInfo lastWinner, MultiplayerPlayList.MatchTypes matchType)
	{
		SetMapContainerActive(true);
		SetCrownCanvasEnabled(true);
		if (selectedMap != null && lastWinner != null)
		{
			Color c = lastWinner.Avatar != null ? lastWinner.Avatar.BaseColor : Color.yellow;
			selectedMap.CompleteFlag(index, c);
			Transform nextPoint = selectedMap.GetPathPointForFlagIndex(index);
			if (nextPoint != null && Characters != null)
			{
				target = nextPoint;
				yield return StartCoroutine(Characters.MoveCharacters(nextPoint.position));
			}
		}
		if (lastWinner != null)
		{
			yield return StartCoroutine(ShowPoints(lastWinner, 0.25f));
		}
	}

	public void ToggleMaximize(bool value, MultiplayerConfiguration.PlayerInfo player)
	{
		if (player != null && playerPoints != null && playerPoints.TryGetValue(player.Side, out ProgressUIPlayerPoints ui) && ui != null && ui.Animator != null)
		{
			ui.Animator.SetBool("Maximized", value);
		}
	}

	public IEnumerator ConvertStrokesToPoints(List<MultiplayerConfiguration.PlayerInfo> players, MultiplayerConfiguration.PlayerInfo winner, MultiplayerPlayList.MatchTypes matchType, bool instant = false)
	{
		if (winner != null)
		{
			winner.Points++;
			if (!instant)
			{
				yield return StartCoroutine(ShowPoints(winner, 0.1f));
			}
		}
	}
}
