using I2.Loc;
using UnityEngine;

public class GameSettings : MonoBehaviour
{
	private static GameSettings _instance;

	private bool isInitialized;

	public static GameSettings Instance => _instance ?? (_instance = FindObjectOfType<GameSettings>());

	public void Start()
	{
		Initialize();
	}

	public void Initialize()
	{
		if (isInitialized) return;
		_instance = this;
		isInitialized = true;
		RefreshFromSave();
	}

	public void TestLangChange()
	{
	}

	public void RefreshFromSave()
	{
		float sfxVol = SaveGame.GetValue(AudioManager.SFX_Volume, 5f) / 5f;
		float musVol = SaveGame.GetValue(AudioManager.Music_Volume, 5f) / 5f;
		AudioManager.SetSoundGain(Mathf.Clamp01(sfxVol));
		AudioManager.SetMusicGain(Mathf.Clamp01(musVol));
	}

	private void OnScreenshakeValueChanged(float f)
	{
	}

	private void OnSfxVolumeChanged(float vol)
	{
		AudioManager.SetSoundGain(Mathf.Clamp01(vol));
	}

	private void OnQualitySettingsChanged(float value)
	{
		QualitySettings.SetQualityLevel(Mathf.Clamp(Mathf.RoundToInt(value), 0, QualitySettings.names.Length - 1));
	}

	private void OnMusicVolumeChanged(float vol)
	{
		AudioManager.SetMusicGain(Mathf.Clamp01(vol));
	}

	private void OnLanguageChanged(string language)
	{
		if (!string.IsNullOrEmpty(language) && LocalizationManager.HasLanguage(language))
			LocalizationManager.CurrentLanguage = language;
	}

	private void OnBatterySavingChanged(bool state)
	{
		Application.targetFrameRate = state ? 30 : 60;
	}

	public string GetPlayerName() => "Player";

	public string GetPlayerId() => "0";

	private void Update()
	{
	}
}
