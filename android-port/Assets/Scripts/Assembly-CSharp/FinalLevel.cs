using System;
using System.Collections;
using System.Collections.Generic;
using Audio;
using Core;
using UnityEngine;

public class FinalLevel : MonoBehaviour
{
	public ClipSettingsCollection HealthLostClip;

	public ClipSettingsCollection PlayerDiedClip;

	public Action<MultiplayerConfiguration.PlayerInfo, int> PlayerHealthChanged;

	private bool somebodyLost;

	private Dictionary<GolfBallController, MultiplayerConfiguration.PlayerInfo> playerControllers = new Dictionary<GolfBallController, MultiplayerConfiguration.PlayerInfo>();

	public Dictionary<MultiplayerConfiguration.PlayerInfo, int> playerHealth { get; private set; } = new Dictionary<MultiplayerConfiguration.PlayerInfo, int>();

	private void Awake()
	{
		if (Level.Instance != null)
		{
			Level.Instance.OnMultiplayerSetup += OnMultiplayerSetup;
		}
	}

	private void OnMultiplayerSetup(MultiplayerLevelInfo obj)
	{
		MultiplayerConfiguration config = Level.Instance != null ? Level.Instance.GetMultiplayerConfiguration() : null;
		if (config != null && config.Players != null)
		{
			playerHealth.Clear();
			playerControllers.Clear();
			for (int i = 0; i < config.Players.Count; i++)
			{
				MultiplayerConfiguration.PlayerInfo p = config.Players[i];
				if (p == null)
				{
					continue;
				}
				playerHealth[p] = 5;
				if (p.Controllers != null && p.Controllers.Count > 0 && p.Controllers[0] != null)
				{
					playerControllers[p.Controllers[0]] = p;
				}
			}
		}
	}

	private IEnumerator ReEnableController(MultiplayerConfiguration.PlayerInfo player)
	{
		yield return new WaitForSeconds(0.5f);
		if (player != null && player.Controllers != null && player.Controllers.Count > 0 && player.Controllers[0] != null)
		{
			player.Controllers[0].gameObject.SetActive(true);
		}
	}

	public bool PlayerHit(GolfBallController controllerHit)
	{
		if (somebodyLost || controllerHit == null || !playerControllers.TryGetValue(controllerHit, out MultiplayerConfiguration.PlayerInfo player))
		{
			return false;
		}
		int hp = playerHealth.ContainsKey(player) ? playerHealth[player] - 1 : 0;
		playerHealth[player] = hp;
		PlayerHealthChanged?.Invoke(player, hp);
		if (hp > 0)
		{
			if (HealthLostClip != null)
			{
				HealthLostClip.Play(null, controllerHit.transform.position, 1f, 1f);
			}
			StartCoroutine(ReEnableController(player));
			return false;
		}
		if (PlayerDiedClip != null)
		{
			PlayerDiedClip.Play(null, controllerHit.transform.position, 1f, 1f);
		}
		somebodyLost = true;
		return true;
	}

	public MultiplayerConfiguration.PlayerInfo GetPlayerLost()
	{
		foreach (KeyValuePair<MultiplayerConfiguration.PlayerInfo, int> kvp in playerHealth)
		{
			if (kvp.Value <= 0)
			{
				return kvp.Key;
			}
		}
		return null;
	}

	public GolfBallController GetControllerLost()
	{
		MultiplayerConfiguration.PlayerInfo lost = GetPlayerLost();
		if (lost != null && lost.Controllers != null && lost.Controllers.Count > 0)
		{
			return lost.Controllers[0];
		}
		return null;
	}
}
