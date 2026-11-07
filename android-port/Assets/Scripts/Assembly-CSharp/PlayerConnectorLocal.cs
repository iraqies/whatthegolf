using System.Collections.Generic;
using Rewired;

public class PlayerConnectorLocal : IPlayerConnector
{
	public float TimeToConnect;

	private Dictionary<Player, float> connectTimers;

	public override void CheckForConnectingPlayers()
	{
	}
}
