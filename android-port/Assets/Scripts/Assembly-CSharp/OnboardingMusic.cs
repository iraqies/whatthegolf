using Audio;
using Core;
using UnityEngine;

public class OnboardingMusic : MonoBehaviour
{
	public AmbientAudio onboardingAmbient;

	public LevelMusicSettings onboardingMusic;

	public bool useSettingFromLevelData;

	private Onboarding onboarding;

	private void Start()
	{
	}

	private void Onboarding_OnReadyForMusic()
	{
	}

	private void Onboarding_OnOnboardingCompleted()
	{
	}

	private void Onboarding_OnOnboardingLevelChanged(LevelData level)
	{
	}

	private void Onboarding_OnboardingProgressChanged(float pct, int levelIndex)
	{
	}
}
