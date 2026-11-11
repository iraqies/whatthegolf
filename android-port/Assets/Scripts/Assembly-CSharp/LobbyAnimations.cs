using UnityEngine;

public class LobbyAnimations : MonoBehaviour
{
	public MultiplayerLobby Lobby;

	public Animator HintAnimator;

	public Animator FlagAnimator;

	private void Awake()
	{
		if (Lobby != null)
		{
			Lobby.OnPlayerJoined += PlayerJoined;
			Lobby.OnAllPlayersReady += AllPlayersReady;
			Lobby.OnPlayerIsReady += PlayerReady;
			Lobby.OnPlayerIsUnready += PlayerIsUnready;
			Lobby.OnPlayerDisconnected += PlayerDisconnected;
			Lobby.OnAllPlayerDisconnected += AllPlayerDisconnected;
		}
	}

	private void AllPlayerDisconnected()
	{
		if (HintAnimator != null)
		{
			HintAnimator.SetBool("Visible", false);
		}
	}

	private void PlayerDisconnected(MultiplayerLobby.LobbyPlayer player)
	{
		if (FlagAnimator != null)
		{
			FlagAnimator.SetTrigger("Hide");
		}
	}

	private void PlayerIsUnready(MultiplayerLobby.LobbyPlayer player)
	{
	}

	private void PlayerReady(MultiplayerLobby.LobbyPlayer player)
	{
	}

	private void AllPlayersReady()
	{
		if (FlagAnimator != null)
		{
			FlagAnimator.SetTrigger("Show");
		}
		if (HintAnimator != null)
		{
			HintAnimator.SetBool("Visible", false);
		}
	}

	private void PlayerJoined(MultiplayerLobby.LobbyPlayer player)
	{
		if (HintAnimator != null)
		{
			HintAnimator.SetBool("Visible", true);
		}
	}
}
