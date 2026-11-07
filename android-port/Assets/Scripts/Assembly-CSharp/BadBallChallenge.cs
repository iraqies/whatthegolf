using System.Collections.Generic;
using Core;
using UnityEngine;

public class BadBallChallenge : Challenge
{
	public List<GolfBallController> goodBalls;

	public GameObject goalPin;

	private BadBallChecker checker;

	private FlagAudio audio;

	protected override void Activate()
	{
	}

	public void OnFlagHit(GolfBallController ball)
	{
	}

	public override string GetDescription()
	{
		return null;
	}

	public override string GetWinMessageID()
	{
		return null;
	}
}
