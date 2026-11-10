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
		if (goalPin == null) return;
		checker = goalPin.AddComponent<BadBallChecker>();
		if (checker != null)
		{
			checker.OnHitFlag -= OnFlagHit;
			checker.OnHitFlag += OnFlagHit;
		}
		audio = goalPin.GetComponent<FlagAudio>();
		if (audio != null)
			audio.ManualMode = true;
		if (goalPin.TryGetComponent<GolfCourse.GolfCoursePinGoal>(out var pinGoal))
			pinGoal.winsNeeded = int.MaxValue;
		if (goalPin.TryGetComponent<GolfGoal>(out var golfGoal))
			golfGoal.winsNeeded = int.MaxValue;
	}

	public void OnFlagHit(GolfBallController ball)
	{
		if (goodBalls != null && goodBalls.Contains(ball))
		{
			Complete();
			if (audio != null)
				audio.GoodHit();
		}
		else
		{
			Fail();
			if (audio != null)
				audio.BadHit();
		}
	}

	public override string GetDescription()
	{
		string key = !string.IsNullOrEmpty(DescriptionLocalizationId) ? DescriptionLocalizationId : "ID_CHALLENGE_DESC_BADBALL";
		return Localization.Instance != null ? Localization.Instance.GetString(key) : key;
	}

	public override string GetWinMessageID()
	{
		return !string.IsNullOrEmpty(WinMessageLocalizationId) ? WinMessageLocalizationId : "ID_WIN_MESSAGE_CHALLENGE";
	}
}
