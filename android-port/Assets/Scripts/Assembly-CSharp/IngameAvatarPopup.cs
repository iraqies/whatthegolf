using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public class IngameAvatarPopup : MonoBehaviour
{
	public List<Animator> Animators;

	public float PopupStayTimeOnStart = 2f;

	public float PopupStayTimeOnFinished = 2f;

	public MultiplayerLobby Lobby;

	private Dictionary<int, float> stayTimes = new Dictionary<int, float>();

	private Coroutine strokeTrackingRoutine;

	private StrokeCounter strokeCounter;

	private void Awake()
	{
		stayTimes = new Dictionary<int, float>();
		if (Lobby != null)
		{
			Lobby.OnPlayerFinished += PlayerFinished;
			Lobby.OnMatchAborted += MatchAborted;
			Lobby.OnLevelStarted += LevelStarted;
		}
		strokeCounter = Object.FindObjectOfType<StrokeCounter>();
	}

	private void MatchAborted(List<MultiplayerConfiguration.PlayerInfo> obj)
	{
		if (strokeTrackingRoutine != null)
		{
			StopCoroutine(strokeTrackingRoutine);
		}
	}

	private void PlayerFinished(MultiplayerConfiguration.PlayerInfo player, List<MultiplayerConfiguration.PlayerInfo> players)
	{
		if (player != null)
		{
			DisplayForPlayer(player.InputIndex, PopupStayTimeOnFinished);
		}
	}

	private void LevelStarted(List<MultiplayerConfiguration.PlayerInfo> players)
	{
		if (strokeTrackingRoutine != null)
		{
			StopCoroutine(strokeTrackingRoutine);
		}
		strokeTrackingRoutine = StartCoroutine(TrackStrokes(players));
	}

	private IEnumerator TrackStrokes(List<MultiplayerConfiguration.PlayerInfo> players)
	{
		while (players != null && players.Count > 0)
		{
			int minStrokes = int.MaxValue;
			MultiplayerConfiguration.PlayerInfo bestPlayer = null;
			for (int i = 0; i < players.Count; i++)
			{
				MultiplayerConfiguration.PlayerInfo p = players[i];
				if (p != null && p.Controllers != null && p.Controllers.Count > 0 && p.Controllers[0] != null)
				{
					int s = p.Controllers[0].NumberOfStrokes;
					if (s < minStrokes)
					{
						minStrokes = s;
						bestPlayer = p;
					}
				}
			}
			if (strokeCounter != null)
			{
				bool tied = players.All(p => p != null && p.Controllers != null && p.Controllers.Count > 0 && p.Controllers[0] != null && p.Controllers[0].NumberOfStrokes == minStrokes);
				if (tied)
				{
					strokeCounter.MoveToMiddle();
				}
				else if (bestPlayer != null)
				{
					strokeCounter.MoveCrownToPlayer(bestPlayer.InputIndex);
				}
			}
			yield return null;
		}
	}

	public void DisplayForPlayer(int i, float duration)
	{
		stayTimes[i] = duration;
		if (Animators != null && i >= 0 && i < Animators.Count && Animators[i] != null)
		{
			if (!Animators[i].GetBool("Visible"))
			{
				Animators[i].SetBool("Visible", true);
				StartCoroutine(DisplayRoutine(i));
			}
		}
	}

	private IEnumerator DisplayRoutine(int playerIndex)
	{
		while (stayTimes.TryGetValue(playerIndex, out float rem) && rem > 0f)
		{
			stayTimes[playerIndex] = rem - Time.deltaTime;
			yield return null;
		}
		if (Animators != null && playerIndex >= 0 && playerIndex < Animators.Count && Animators[playerIndex] != null)
		{
			Animators[playerIndex].SetBool("Visible", false);
		}
	}
}
