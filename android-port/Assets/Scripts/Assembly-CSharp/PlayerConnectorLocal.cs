using System.Collections.Generic;
using Rewired;
using UnityEngine;

public class PlayerConnectorLocal : IPlayerConnector
{
	public float TimeToConnect = 0.5f;

	private Dictionary<Player, float> connectTimers = new Dictionary<Player, float>();

	public override void CheckForConnectingPlayers()
	{
		if (!ReInput.isReady || ReInput.players == null)
		{
			return;
		}
		IList<Player> players = ReInput.players.Players;
		if (players == null)
		{
			return;
		}
		for (int i = 0; i < players.Count; i++)
		{
			Player p = players[i];
			if (p == null)
			{
				continue;
			}
			if (p.GetAnyButton())
			{
				if (!connectTimers.ContainsKey(p))
				{
					connectTimers[p] = 0f;
				}
				connectTimers[p] += Time.deltaTime;
				float norm = Mathf.Clamp01(connectTimers[p] / Mathf.Max(0.01f, TimeToConnect));
				OnPlayerConnecting?.Invoke(p.id, norm);
				if (connectTimers[p] >= TimeToConnect)
				{
					connectTimers.Remove(p);
					OnPlayerConnected?.Invoke(p.id);
				}
			}
			else if (connectTimers.ContainsKey(p))
			{
				connectTimers.Remove(p);
				OnPlayerStoppedConnecting?.Invoke(p.id);
			}
		}
	}
}
