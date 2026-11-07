using System.Collections.Generic;
using Rewired;
using TMPro;
using UnityEngine;

public class ManageControllerDisconnects : MonoBehaviour
{
	public GameObject WarningContainer;

	public TextMeshProUGUI Text;

	private List<Player> disconnectedPlayers;

	private bool checkForMouseClick;

	private void Start()
	{
	}

	private void Update()
	{
	}

	private void OnControllerPreDisconnectEvent(ControllerStatusChangedEventArgs args)
	{
	}

	private void OnControllerConnectedEvent(ControllerStatusChangedEventArgs args)
	{
	}

	private void ControllerReconnected(int id)
	{
	}
}
