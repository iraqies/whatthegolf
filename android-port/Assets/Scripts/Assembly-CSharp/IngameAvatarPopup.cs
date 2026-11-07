using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IngameAvatarPopup : MonoBehaviour
{
	public List<Animator> Animators;

	public float PopupStayTimeOnStart;

	public float PopupStayTimeOnFinished;

	public MultiplayerLobby Lobby;

	private Dictionary<int, float> stayTimes;

	private Coroutine strokeTrackingRoutine;

	private StrokeCounter strokeCounter;

	private void Awake()
	{
	}

	private void MatchAborted(List<MultiplayerConfiguration.PlayerInfo> obj)
	{
	}

	private void PlayerFinished(MultiplayerConfiguration.PlayerInfo player, List<MultiplayerConfiguration.PlayerInfo> players)
	{
	}

	private void LevelStarted(List<MultiplayerConfiguration.PlayerInfo> players)
	{
	}

	private IEnumerator TrackStrokes(List<MultiplayerConfiguration.PlayerInfo> players)
	{
		return null;
	}

	public void DisplayForPlayer(int i, float duration)
	{
	}
}
