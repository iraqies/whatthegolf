using System.Collections.Generic;
using Core;
using GolfCourse;
using UnityEngine;

public class StoneInOneChallenge : Challenge
{
	public bool failOnHitFlagBeforeMaxSwallow;

	public float stoneScaleSpeed = 5f;

	private ChallengeHoleAbsorber _absorber;

	private GolfBallController _controller;

	private int _swallowCount;

	public int swallowsToWin = 5;

	public bool completeOnSwallowCount;

	[SerializeField]
	private bool clampSize;

	[SerializeField]
	private float maxSize = 3f;

	private GolfCoursePinGoal golfGoal;

	private readonly List<GameObject> _collectedStones = new List<GameObject>();

	protected override void Activate()
	{
		golfGoal = Object.FindObjectOfType<GolfCoursePinGoal>();
		if (golfGoal != null && failOnHitFlagBeforeMaxSwallow)
		{
			golfGoal.enabled = false;
		}
		_controller = Object.FindObjectOfType<GolfBallController>();
		_absorber = Object.FindObjectOfType<ChallengeHoleAbsorber>();
		if (_absorber != null)
		{
			_absorber.onStoneSwallow += OnStoneSwallow;
		}
		_swallowCount = 0;
		if (_controller != null)
		{
			_controller.transform.localScale = Vector3.one;
		}
		if (LevelManager.Instance != null && LevelManager.Instance.InGameMenu != null)
		{
			LevelManager.Instance.InGameMenu.SetStrokeCounterSettings(swallowsToWin, StrokeCounter.CounterTypes.CardsDisappearing, true, 0);
		}
	}

	private void OnStoneSwallow(GameObject obj)
	{
		if (obj != null && !_collectedStones.Contains(obj))
		{
			_collectedStones.Add(obj);
		}
		_swallowCount++;
		if (LevelManager.Instance != null && LevelManager.Instance.InGameMenu != null)
		{
			LevelManager.Instance.InGameMenu.CountStroke(Mathf.Max(0, swallowsToWin - _swallowCount));
		}
		if (_swallowCount >= swallowsToWin && golfGoal != null)
		{
			golfGoal.enabled = true;
		}
	}

	protected override void ChallengeUpdate()
	{
		for (int i = _collectedStones.Count - 1; i >= 0; i--)
		{
			GameObject stone = _collectedStones[i];
			if (stone == null)
			{
				_collectedStones.RemoveAt(i);
				continue;
			}
			stone.transform.localScale = Vector3.Lerp(stone.transform.localScale, Vector3.zero, Mathf.Clamp01(Time.deltaTime * stoneScaleSpeed));
			if (stone.transform.lossyScale.magnitude < 0.05f)
			{
				stone.SetActive(false);
				_collectedStones.RemoveAt(i);
			}
		}
		if (_controller != null)
		{
			float targetScale = 1f + _swallowCount * 0.25f;
			if (clampSize)
			{
				targetScale = Mathf.Min(targetScale, maxSize);
			}
			_controller.transform.localScale = Vector3.Lerp(_controller.transform.localScale, Vector3.one * targetScale, Mathf.Clamp01(Time.deltaTime * stoneScaleSpeed));
		}
		if (completeOnSwallowCount && _swallowCount >= swallowsToWin)
		{
			Complete();
		}
	}

	public override void OnLevelComplete(Level.CompletedState completedState)
	{
		if (_swallowCount >= swallowsToWin)
		{
			Complete();
		}
		else if (failOnHitFlagBeforeMaxSwallow)
		{
			Fail();
		}
	}

	public override void OnLevelFail(GolfBallController arg1, string arg2, Level.State arg3)
	{
		Fail();
	}
}
