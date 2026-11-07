using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class DebugPlayAllLevelsButton : MonoBehaviour
{
	[SerializeField]
	private Button btn;

	[SerializeField]
	private MultiplayerLobby lobby;

	[SerializeField]
	private Button nextMusicState;

	[SerializeField]
	private Button prevMusicState;

	[SerializeField]
	private TMP_Text currentMusicState;

	private int musicStateIndex;

	private uint[] musicStates;

	private bool Debug;

	private void Awake()
	{
	}

	private void Update()
	{
	}

	private void ToggleDebug()
	{
	}

	private void NextMusicState()
	{
	}

	private void PrevMusicState()
	{
	}

	private void UpdateMusicState(bool playSelected = true)
	{
	}

	private void Destroy(List<MultiplayerLobby.LobbyPlayer> l)
	{
	}
}
