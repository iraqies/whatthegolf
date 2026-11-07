using System;

public class Settings
{
	private static bool AnalyticsDefaultValue;

	private static bool BatterySavingDefaultValue;

	private static float MusicVolumeDefaultValue;

	private static float SFXVolumeDefaultValue;

	private static int QualitySettingDefaultValue;

	private static float ScreenshakeDefaultValue;

	public static Action<bool> OnBatterySavingChanged;

	public static Action<bool> OnGyroShakeChanged;

	public static Action<bool> OnUseDebugNotifications;

	public static Action<bool> OnDebugLeaderboards;

	public static Action<float> OnMusicVolumeChanged;

	public static Action<float> OnSFXVolumeChanged;

	public static Action<float> OnQualitySettingsChanged;

	public static Action<float> OnScreenshakeValueChanged;

	public static Action<string> OnLanguageChanged;

	private static bool switchUseGyro;

	public static Action<bool> OnSwitchGyroChanged;

	private static bool cheatUnlockNoSave;

	public static Action<bool> OnCheatUnlockNoSave;

	public static bool BatterySaving => false;

	public static bool UseGyroShake
	{
		get
		{
			return false;
		}
		set
		{
		}
	}

	public static bool UseDebugNotifications
	{
		get
		{
			return false;
		}
		set
		{
		}
	}

	public static bool DebugLeaderboards
	{
		get
		{
			return false;
		}
		set
		{
		}
	}

	public static float MusicVolume
	{
		get
		{
			return 0f;
		}
		set
		{
		}
	}

	public static float SFXVolume
	{
		get
		{
			return 0f;
		}
		set
		{
		}
	}

	public static bool CanAdjustQuality => false;

	public static float QualitySettings
	{
		get
		{
			return 0f;
		}
		set
		{
		}
	}

	public static float ScreenshakeValue => 0f;

	public static string Language
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	public static bool SwitchUseGyro
	{
		get
		{
			return false;
		}
		set
		{
		}
	}

	public static bool CheatingEnabled => false;

	public static bool CheatUnlockNoSave
	{
		set
		{
		}
	}
}
