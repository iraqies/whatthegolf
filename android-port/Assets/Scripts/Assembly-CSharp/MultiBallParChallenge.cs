using System.Collections.Generic;
using Core;
using UnityEngine;

public class MultiBallParChallenge : Challenge
{
	public int ScoreToBeat;

	private List<GolfBallController> controllers;

	private int strokeCount;

	protected override void Activate()
	{
	}

	private void OnObjectDestroyed(GameObject obj)
	{
	}

	public override string GetDescription()
	{
		return null;
	}

	private void OnShoot(Vector3 vector3)
	{
	}

	public override void OnLevelComplete(Level.CompletedState completedState)
	{
	}
}
