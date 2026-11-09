using System.Collections.Generic;
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
			onboarding.OnOnboardingProgressChanged -= Onboarding_OnboardingProgressChanged;
			onboarding.OnOnboardingProgressChanged += Onboarding_OnboardingProgressChanged;
			onboarding.OnOnboardingLevelChanged -= Onboarding_OnOnboardingLevelChanged;
			onboarding.OnOnboardingLevelChanged += Onboarding_OnOnboardingLevelChanged;
			onboarding.OnOnboardingCompleted -= Onboarding_OnOnboardingCompleted;
			onboarding.OnOnboardingCompleted += Onboarding_OnOnboardingCompleted;
			onboarding.OnReadyForMusic -= Onboarding_OnReadyForMusic;
			onboarding.OnReadyForMusic += Onboarding_OnReadyForMusic;
		}
		Onboarding_OnReadyForMusic();
	}

	private void Onboarding_OnReadyForMusic()
	{
		if (AudioManager.Instance != null)
		{
			if (onboardingAmbient != null && AudioManager.Instance.AmbientPlayer != null)
				AudioManager.Instance.AmbientPlayer.SetAmbients(new List<AmbientAudio> { onboardingAmbient });
			if (AudioManager.Instance.music != null)
			{
				AudioManager.Instance.music.InitializeBank(() =>
				{
					if (AudioManager.Instance != null && AudioManager.Instance.music != null)
					{
						AudioManager.Instance.music.InitializeMusic();
						AudioManager.Instance.music.SetGain(1f);
						if (onboardingMusic != null)
							AudioManager.Instance.music.SetLevelMusic(onboardingMusic, false, null);
					}
				}, false);
			}
		}
	}

	private void Onboarding_OnOnboardingCompleted()
	{
		if (onboarding != null)
		{
			onboarding.OnOnboardingProgressChanged -= Onboarding_OnboardingProgressChanged;
			onboarding.OnOnboardingCompleted -= Onboarding_OnOnboardingCompleted;
		}
		if (AudioManager.Instance != null && AudioManager.Instance.music != null)
			AudioManager.Instance.music.SetClosingIn(0f, 300);
	}

	private void Onboarding_OnOnboardingLevelChanged(LevelData level)
	{
		if (!useSettingFromLevelData || level == null) return;
		if (AudioManager.Instance != null && AudioManager.Instance.music != null && level.music != null)
		{
			if (level.music.baseMusicData != null)
				AudioManager.Instance.music.setRTCPRaw(level.music.baseMusicData.rtcp, level.music.RTCPStart, 20);
		}
	}

	private void Onboarding_OnboardingProgressChanged(float pct, int levelIndex)
	{
		if (useSettingFromLevelData) return;
		if (AudioManager.Instance != null && AudioManager.Instance.music != null && onboardingMusic != null && onboardingMusic.baseMusicData != null)
		{
			AudioManager.Instance.music.setRTCPRaw(onboardingMusic.baseMusicData.rtcp, levelIndex + 1f, 20);
		}
	}
}
