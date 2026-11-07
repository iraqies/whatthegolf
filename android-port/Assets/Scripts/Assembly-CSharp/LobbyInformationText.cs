using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class LobbyInformationText : MonoBehaviour
{
	public List<TextMeshProUGUI> TextFields;

	public Transform TextContainer;

	public MultiplayerLobby Lobby;

	public PlayerColors PlayerColors;

	public float FadeOutTime;

	public float TextTransitionTime;

	private float fadeOutTimer;

	private Vector3 currentScale;

	private void Awake()
	{
	}

	private void OnPlayerIsUnready(MultiplayerLobby.LobbyPlayer player)
	{
	}

	private void OnPlayerIsReady(MultiplayerLobby.LobbyPlayer player)
	{
	}

	private void OnPlayerDisconnected(MultiplayerLobby.LobbyPlayer player)
	{
	}

	private void OnPlayerJoined(MultiplayerLobby.LobbyPlayer player)
	{
	}

	private void SetText(string text, Color color)
	{
	}

	private void Update()
	{
	}
}
