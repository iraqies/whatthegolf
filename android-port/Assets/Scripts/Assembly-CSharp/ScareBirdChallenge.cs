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
		scareBirds = GetComponentsInChildren<BirdNPC>(true);
		controller = Object.FindObjectOfType<GolfBallController>();
		SFX = GetComponentInChildren<TiltChallengeSFX>();
		if (scareBirds != null)
		{
			for (int i = 0; i < scareBirds.Length; i++)
			{
				BirdNPC bird = scareBirds[i];
				if (bird != null)
				{
					if (CustomScareTriggerRange > 0f)
					{
						bird.SetTriggerRange(CustomScareTriggerRange);
					}
					bird.OnScared += OnBirdScared;
				}
			}
			if (SFX != null)
			{
				SFX.Init(scareBirds.Length);
			}
			if (LevelManager.Instance != null && LevelManager.Instance.InGameMenu != null)
			{
				LevelManager.Instance.InGameMenu.SetStrokeCounterSettings(scareBirds.Length, false, true, false);
			}
		}
	}

	private void OnBirdScared(BirdNPC bird)
	{
		scareCount++;
		if (LevelManager.Instance != null && LevelManager.Instance.InGameMenu != null)
		{
			LevelManager.Instance.InGameMenu.CountStroke(controller, scareCount);
		}
		if (SFX != null)
		{
			SFX.Play();
		}
		if (scareBirds != null && scareCount == scareBirds.Length && !GolfToFlagAfter)
		{
			Complete();
		}
	}

	public override void OnLevelComplete(Level.CompletedState completedState)
	{
		if (scareBirds != null && scareCount < scareBirds.Length)
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
		string key = string.IsNullOrEmpty(DescriptionLocalizationID) ? "ID_CHALLENGE_SCAREBIRDS" : DescriptionLocalizationID;
		return Localization.Instance != null ? Localization.Instance.GetString(key) : key;
	}

	public override string GetWinMessageID()
	{
		return string.IsNullOrEmpty(CustomWinMessageLocalizationID) ? "ID_CHALLENGE_SCAREBIRDS_COMPLETION" : CustomWinMessageLocalizationID;
	}
}
