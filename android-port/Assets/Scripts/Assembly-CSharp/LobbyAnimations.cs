using UnityEngine;

public class LobbyAnimations : MonoBehaviour
{
	public MultiplayerLobby Lobby;

	public Animator HintAnimator;

	public Animator FlagAnimator;

	private void Awake()
	{
	}

	private void AllPlayerDisconnected()
	{
	}

	private void PlayerDisconnected(MultiplayerLobby.LobbyPlayer player)
	{
	}

	private void PlayerIsUnready(MultiplayerLobby.LobbyPlayer player)
	{
	}

	private void PlayerReady(MultiplayerLobby.LobbyPlayer player)
	{
	}

	private void AllPlayersReady()
	{
	}

	private void PlayerJoined(MultiplayerLobby.LobbyPlayer player)
	{
	}
}
