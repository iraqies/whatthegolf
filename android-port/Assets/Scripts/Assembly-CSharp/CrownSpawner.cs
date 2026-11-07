using System.Collections.Generic;
using UnityEngine;

public class CrownSpawner : MonoBehaviour
{
	public MultiplayerLobby Lobby;

	public GameObject CrownPrefab;

	private Dictionary<int, int> crownsWon;

	private void Awake()
	{
	}

	private void MatchEnded(List<MultiplayerConfiguration.PlayerInfo> players)
	{
	}
}
