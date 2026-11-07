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

	private Dictionary<GolfBallController, MultiplayerConfiguration.PlayerInfo> playerControllers;

	public Dictionary<MultiplayerConfiguration.PlayerInfo, int> playerHealth { get; private set; }

	private void Awake()
	{
	}

	private void OnMultiplayerSetup(MultiplayerLevelInfo obj)
	{
	}

	private IEnumerator ReEnableController(MultiplayerConfiguration.PlayerInfo player)
	{
		return null;
	}

	public bool PlayerHit(GolfBallController controllerHit)
	{
		return false;
	}

	public MultiplayerConfiguration.PlayerInfo GetPlayerLost()
	{
		return null;
	}

	public GolfBallController GetControllerLost()
	{
		return null;
	}
}
