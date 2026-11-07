using UnityEngine;

public class GameSettings : MonoBehaviour
{
	private static GameSettings _instance;

	private bool isInitialized;

	public static GameSettings Instance => null;

	public void Start()
	{
	}

	public void Initialize()
	{
	}

	public void TestLangChange()
	{
	}

	public void RefreshFromSave()
	{
	}

	private void OnScreenshakeValueChanged(float f)
	{
	}

	private void OnSfxVolumeChanged(float vol)
	{
	}

	private void OnQualitySettingsChanged(float value)
	{
	}

	private void OnMusicVolumeChanged(float vol)
	{
	}

	private void OnLanguageChanged(string language)
	{
	}

	private void OnBatterySavingChanged(bool state)
	{
	}

	public string GetPlayerName()
	{
		return null;
	}

	public string GetPlayerId()
	{
		return null;
	}

	private void Update()
	{
	}
}
