using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class LobbyInformationText : MonoBehaviour
{
	public List<TextMeshProUGUI> TextFields;

	public Transform TextContainer;

	public MultiplayerLobby Lobby;

	public PlayerColors PlayerColors;

	public float FadeOutTime = 2f;

	public float TextTransitionTime = 0.25f;

	private float fadeOutTimer;

	private Vector3 currentScale;

	private void Awake()
	{
		if (Lobby != null)
		{
			Lobby.OnPlayerJoined += OnPlayerJoined;
			Lobby.OnPlayerDisconnected += OnPlayerDisconnected;
			Lobby.OnPlayerIsReady += OnPlayerIsReady;
			Lobby.OnPlayerIsUnready += OnPlayerIsUnready;
		}
	}

	private void OnPlayerIsUnready(MultiplayerLobby.LobbyPlayer player)
	{
		if (player != null)
		{
			Color c = player.Avatar != null ? player.Avatar.BaseColor : Color.white;
			SetText(string.Format("Player {0} Unready", player.PlayerIndex + 1), c);
		}
	}

	private void OnPlayerIsReady(MultiplayerLobby.LobbyPlayer player)
	{
		if (player != null)
		{
			Color c = player.Avatar != null ? player.Avatar.BaseColor : Color.white;
			SetText(string.Format("Player {0} Ready!", player.PlayerIndex + 1), c);
		}
	}

	private void OnPlayerDisconnected(MultiplayerLobby.LobbyPlayer player)
	{
		if (player != null)
		{
			Color c = player.Avatar != null ? player.Avatar.BaseColor : Color.white;
			SetText(string.Format("Player {0} Left", player.PlayerIndex + 1), c);
		}
	}

	private void OnPlayerJoined(MultiplayerLobby.LobbyPlayer player)
	{
		if (player != null)
		{
			Color c = player.Avatar != null ? player.Avatar.BaseColor : Color.white;
			SetText(string.Format("Player {0} Joined!", player.PlayerIndex + 1), c);
		}
	}

	private void SetText(string text, Color color)
	{
		if (TextFields != null)
		{
			for (int i = 0; i < TextFields.Count; i++)
			{
				if (TextFields[i] != null)
				{
					TextFields[i].text = text;
					TextFields[i].color = color;
				}
			}
		}
		fadeOutTimer = FadeOutTime + TextTransitionTime;
		if (TextContainer != null)
		{
			currentScale = TextContainer.localScale;
		}
	}

	private void Update()
	{
		if (TextContainer == null)
		{
			return;
		}
		fadeOutTimer -= Time.deltaTime;
		if (fadeOutTimer > FadeOutTime)
		{
			float t = Mathf.Clamp01(1f - (fadeOutTimer - FadeOutTime) / Mathf.Max(0.01f, TextTransitionTime));
			TextContainer.localScale = Vector3.Lerp(currentScale, Vector3.one, TweenFunctions.ElasticOut(t));
		}
		else if (fadeOutTimer > 0f && fadeOutTimer <= TextTransitionTime)
		{
			float t = Mathf.Clamp01(1f - fadeOutTimer / Mathf.Max(0.01f, TextTransitionTime));
			TextContainer.localScale = Vector3.Lerp(Vector3.one, Vector3.zero, TweenFunctions.ElasticInOut(t));
		}
	}
}
