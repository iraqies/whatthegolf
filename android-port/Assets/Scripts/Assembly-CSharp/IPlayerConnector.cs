using System;

public abstract class IPlayerConnector
{
	public Action<int> OnPlayerConnected;

	public Action<int, float> OnPlayerConnecting;

	public Action<int> OnPlayerStoppedConnecting;

	public Action<int> OnPlayerDisconnected;

	public abstract void CheckForConnectingPlayers();
}
