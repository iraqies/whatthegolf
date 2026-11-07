using System.Collections.Generic;
using Audio;
using Core;
using UnityEngine;

public class MultiPutChallenge : Challenge
{
	public int ballsToWin;

	public bool dontUsePlayer;

	public GameObject ballDisappearParticles;

	public bool isManualSet;

	public List<GameObject> objectsToPut;

	private GolfBallController[] _controllers;

	private MultiBallFlag _multiBallFlag;

	private ObjectDestroyable _objectDestroyTrigger;

	private int _currentPutCount;

	private int _activeBallCount;

	private TiltChallengeSFX SFX;

	private bool isUnloadingLevel;

	protected override void Activate()
	{
	}

	private void OnLevelWillUnload()
	{
	}

	private void OnObjectWillDestroy(GameObject go)
	{
	}

	private void OnDestroy()
	{
	}

	private void OnMultiballFlagHit(GameObject go)
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

	public override void OnLevelComplete(Level.CompletedState completedState)
	{
	}
}
