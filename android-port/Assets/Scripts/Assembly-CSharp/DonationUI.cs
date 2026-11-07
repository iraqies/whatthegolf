using System.Collections.Generic;
using UnityEngine;

public class DonationUI : MonoBehaviour
{
	public LobbyDonationMachine DonationMachine;

	public UnlockablesManager UnlockablesManager;

	public MultiplayerLobby Lobby;

	private void Start()
	{
	}

	private void OnMatchEnded(List<MultiplayerConfiguration.PlayerInfo> obj)
	{
	}

	private void ContentUnlocked(UnlockableContentPackage package)
	{
	}
}
