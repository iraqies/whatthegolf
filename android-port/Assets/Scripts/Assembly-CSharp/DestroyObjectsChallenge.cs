using System.Collections.Generic;
using Core;
using UnityEngine;

public class DestroyObjectsChallenge : Challenge
{
	public List<GameObject> ObjectsToDestroy;

	private int destroyed;

	private GolfBallController controller;

	private bool running;

	protected override void Activate()
	{
	}

	protected override void ChallengeUpdate()
	{
	}
}
