using System.Collections.Generic;
using Core;
using GolfCourse;
using UnityEngine;

public class StoneInOneChallenge : Challenge
{
	public bool failOnHitFlagBeforeMaxSwallow;

	public float stoneScaleSpeed;

	private ChallengeHoleAbsorber _absorber;

	private GolfBallController _controller;

	private int _swallowCount;

	public int swallowsToWin;

	public bool completeOnSwallowCount;

	[SerializeField]
	private bool clampSize;

	[SerializeField]
	private float maxSize;

	private GolfCoursePinGoal golfGoal;

	private readonly List<GameObject> _collectedStones;

	protected override void Activate()
	{
	}

	private void OnStoneSwallow(GameObject obj)
	{
	}

	protected override void ChallengeUpdate()
	{
	}

	public override void OnLevelComplete(Level.CompletedState completedState)
	{
	}

	public override void OnLevelFail(GolfBallController arg1, string arg2, Level.State arg3)
	{
	}
}
