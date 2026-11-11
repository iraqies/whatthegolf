using System;
using System.Collections.Generic;
using Audio;
using Core;
using UnityEngine;

public class TriggerObjectsChallenge : Challenge
{
	public bool LookForTriggersInChildren;

	public List<ChallengeTriggerBase> triggers;

	public bool WinOnLastTrigger = true;

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
		if (LookForTriggersInChildren)
		{
			triggers.AddRange(GetComponentsInChildren<ChallengeTriggerBase>());
		}
		for (int i = 0; i < triggers.Count; i++)
		{
			ChallengeTriggerBase challengeTriggerBase = triggers[i];
			challengeTriggerBase.OnTrigger = (Action<ChallengeTriggerBase>)Delegate.Combine(challengeTriggerBase.OnTrigger, new Action<ChallengeTriggerBase>(OnTrigger));
		}
		controller = UnityEngine.Object.FindObjectOfType<GolfBallController>();
		if (!hideStrokeCounter)
		{
			AddressableSingleton<LevelManager>.Instance.InGameMenu.SetStrokeCounterSettings(triggers.Count, StrokeCounter.CounterTypes.CardsDisappearing, true, 0);
		}
	}

	private void OnTrigger(ChallengeTriggerBase trigger)
	{
		if (!triggers.Contains(trigger))
		{
			return;
		}
		onChallengeTrigger?.Invoke(triggers.Count);
		triggerCount++;
		SFX_OnTrigger.Play(Vector3.zero, 1f, 1f);
		if (DestroyObjectOnHit)
		{
			UnityEngine.Object.Destroy(trigger.gameObject);
		}
		triggers.Remove(trigger);
		if (!hideStrokeCounter)
		{
			AddressableSingleton<LevelManager>.Instance.InGameMenu.CountStroke(controller, triggerCount);
		}
		if (customTriggerAmount >= 1 && triggerCount >= customTriggerAmount)
		{
			if (CompleteAfterDelay)
			{
				StartCoroutine(pTween.To(delay, delegate
				{
				}).Then(delegate
				{
					Complete();
					SFX_OnWin.Play(Vector3.zero, 1f, 1f);
				}));
			}
			else
			{
				Complete();
				SFX_OnWin.Play(Vector3.zero, 1f, 1f);
			}
		}
		if (!WinOnLastTrigger || triggers.Count != 0)
		{
			return;
		}
		if (CompleteAfterDelay)
		{
			StartCoroutine(pTween.To(delay, delegate
			{
			}).Then(delegate
			{
				Complete();
				SFX_OnWin.Play(Vector3.zero, 1f, 1f);
			}));
		}
		else
		{
			Complete();
			SFX_OnWin.Play(Vector3.zero, 1f, 1f);
		}
	}

	public override void OnLevelComplete(Level.CompletedState completedState)
	{
		if (triggers.Count == 0)
		{
			Complete();
			SFX_OnWin.Play(Vector3.zero, 1f, 1f);
		}
		else
		{
			Fail();
		}
	}
}
