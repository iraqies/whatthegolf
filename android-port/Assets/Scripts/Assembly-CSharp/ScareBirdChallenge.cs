using Audio;
using Core;
using UnityEngine;

public class ScareBirdChallenge : Challenge
{
	public bool GolfToFlagAfter;

	public float CustomScareTriggerRange = -1f;

	private BirdNPC[] scareBirds;

	private int scareCount;

	private GolfBallController controller;

	private TiltChallengeSFX SFX;

	protected override void Activate()
	{
		scareBirds = GetComponentsInChildren<BirdNPC>(includeInactive: true);
		controller = Object.FindObjectOfType<GolfBallController>();
		SFX = GetComponentInChildren<TiltChallengeSFX>();
		for (int i = 0; i < scareBirds.Length; i++)
		{
			if (scareBirds[i] != null)
			{
				if (CustomScareTriggerRange > 0f)
				{
					scareBirds[i].SetTriggerRange(CustomScareTriggerRange);
				}
				scareBirds[i].OnBirdScared += OnBirdScared;
			}
		}
		if (SFX != null)
		{
			SFX.Init(scareBirds.Length);
		}
		LevelManager.Instance.InGameMenu.SetStrokeCounterSettings(scareBirds.Length, StrokeCounter.CounterTypes.CardsAppearing, useExternalCountActivator: true);
	}

	private void OnBirdScared(BirdNPC bird)
	{
		scareCount++;
		LevelManager.Instance.InGameMenu.CountStroke(controller, scareCount);
		if (SFX != null)
		{
			SFX.Play();
		}
		if (scareCount == scareBirds.Length && !GolfToFlagAfter)
		{
			Complete();
		}
	}

	public override void OnLevelComplete(Level.CompletedState completedState)
	{
		if (scareCount < scareBirds.Length)
		{
			Fail();
		}
		else
		{
			Complete();
		}
	}

	public override string GetDescription()
	{
		if (string.IsNullOrEmpty(DescriptionLocalizationId))
		{
			return Localization.Instance.GetString("ID_CHALLENGE_SCAREBIRDS");
		}
		return Localization.Instance.GetString(DescriptionLocalizationId);
	}

	public override string GetWinMessageID()
	{
		return string.IsNullOrEmpty(WinMessageLocalizationId) ? "ID_CHALLENGE_SCAREBIRDS_COMPLETION" : WinMessageLocalizationId;
	}
}
