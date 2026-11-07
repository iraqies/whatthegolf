using System;
using System.Collections.Generic;
using Audio;
using Core;

public class TriggerObjectsChallenge : Challenge
{
	public bool LookForTriggersInChildren;

	public List<ChallengeTriggerBase> triggers;

	public bool WinOnLastTrigger;

	public bool DestroyObjectOnHit;

	public Action<int> onChallengeTrigger;

	public ClipSettingsCollection SFX_OnTrigger;

	public ClipSettingsCollection SFX_OnWin;

	public bool CompleteAfterDelay;

	public float delay;

	public int customTriggerAmount;

	public bool hideStrokeCounter;

	private int triggerCount;

	private GolfBallController controller;

	protected override void Activate()
	{
	}

	private void OnTrigger(ChallengeTriggerBase trigger)
	{
	}

	public override void OnLevelComplete(Level.CompletedState completedState)
	{
	}
}
