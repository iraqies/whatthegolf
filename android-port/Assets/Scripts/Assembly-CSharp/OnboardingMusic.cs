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
		onboarding = GetComponent<Onboarding>() ?? FindObjectOfType<Onboarding>();
		if (onboarding != null)
		{
			onboarding.OnReadyForMusic += Onboarding_OnReadyForMusic;
			onboarding.OnOnboardingCompleted += Onboarding_OnOnboardingCompleted;
			onboarding.OnOnboardingLevelChanged += Onboarding_OnOnboardingLevelChanged;
			onboarding.OnOnboardingProgressChanged += Onboarding_OnboardingProgressChanged;
		}
		Onboarding_OnReadyForMusic();
	}

	private void Onboarding_OnReadyForMusic()
	{
		if (onboardingAmbient != null)
			onboardingAmbient.OnSceneStart();
		if (onboardingMusic != null && AudioManager.Instance != null && AudioManager.Instance.music != null)
			AudioManager.Instance.music.SetLevelMusic(onboardingMusic, true);
	}

	private void Onboarding_OnOnboardingCompleted()
	{
	}

	private void Onboarding_OnOnboardingLevelChanged(LevelData level)
	{
		if (useSettingFromLevelData && level != null && level.music != null && AudioManager.Instance != null && AudioManager.Instance.music != null)
			AudioManager.Instance.music.SetLevelMusic(level.music, true);
	}

	private void Onboarding_OnboardingProgressChanged(float pct, int levelIndex)
	{
	}
}
