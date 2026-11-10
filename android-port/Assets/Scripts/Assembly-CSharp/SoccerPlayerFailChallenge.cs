using System;
using System.Collections.Generic;
using UnityEngine;

public class SoccerPlayerFailChallenge : MonoBehaviour
{
	public Challenge ChallengeToFail;

	public List<SoccerPlayer> Players;

	private void Start()
	{
		if (Players == null)
		{
			return;
		}
		foreach (SoccerPlayer player in Players)
		{
			if (player != null)
			{
				player.onKick = (Action)Delegate.Combine(player.onKick, new Action(OnKick));
			}
		}
	}

	private void OnKick()
	{
		if (ChallengeToFail != null)
		{
			ChallengeToFail.Fail();
		}
	}
}
