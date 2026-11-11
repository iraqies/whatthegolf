using System.Collections.Generic;
using Core;
using UnityEngine;

public class PortAllChallenge : Challenge
{
	public bool passThroughOnceOnly;

	public bool allInOne;

	public List<SimplePortal> Portals;

	private GolfBallController golfBallController;

	private FlagAudio flagAudio;

	protected override void Activate()
	{
		flagAudio = Object.FindObjectOfType<FlagAudio>();
		if (flagAudio != null)
		{
			flagAudio.PlayManually = true;
		}
		foreach (SimplePortal portal in Portals)
		{
			portal.portAll = true;
			if (passThroughOnceOnly)
			{
				portal.portOnce = true;
			}
		}
		golfBallController = Object.FindObjectOfType<GolfBallController>();
	}

	protected override void ChallengeUpdate()
	{
		if (golfBallController.Strokes >= 1 && allInOne && golfBallController.gameObject.GetComponent<Rigidbody>().velocity.magnitude <= 0.5f)
		{
			Fail();
		}
		foreach (SimplePortal portal in Portals)
		{
			if (portal.baseColor == Color.gray)
			{
				Fail();
			}
			else if (portal.baseColor != Color.white)
			{
				return;
			}
		}
	}

	public override void OnLevelComplete(Level.CompletedState completedState)
	{
		completedState.winMessageID = "ID_EMPTY_STRING";
		completedState.delay = 2f;
		bool flag = true;
		foreach (SimplePortal portal in Portals)
		{
			flag = !(portal.baseColor != Color.white) && flag;
		}
		if (flag)
		{
			Complete();
			if (flagAudio != null)
			{
				flagAudio.GoodHit();
			}
		}
		else
		{
			Fail();
			if (flagAudio != null)
			{
				flagAudio.BadHit();
			}
		}
	}
}
