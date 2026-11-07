using System;
using Il2CppDummyDll;

[Token(Token = "0x2000B6C")]
public class Settings
{
	[Token(Token = "0x4003F57")]
	[FieldOffset(Offset = "0x0")]
	private static bool AnalyticsDefaultValue;

	[Token(Token = "0x4003F58")]
	[FieldOffset(Offset = "0x1")]
	private static bool BatterySavingDefaultValue;

	[Token(Token = "0x4003F59")]
	[FieldOffset(Offset = "0x4")]
	private static float MusicVolumeDefaultValue;

	[Token(Token = "0x4003F5A")]
	[FieldOffset(Offset = "0x8")]
	private static float SFXVolumeDefaultValue;

	[Token(Token = "0x4003F5B")]
	[FieldOffset(Offset = "0xC")]
	private static int QualitySettingDefaultValue;

	[Token(Token = "0x4003F5C")]
	[FieldOffset(Offset = "0x10")]
	private static float ScreenshakeDefaultValue;

	[Token(Token = "0x4003F5D")]
	[FieldOffset(Offset = "0x18")]
	public static Action<bool> OnBatterySavingChanged;

	[Token(Token = "0x4003F5E")]
	[FieldOffset(Offset = "0x20")]
	public static Action<bool> OnGyroShakeChanged;

	[Token(Token = "0x4003F5F")]
	[FieldOffset(Offset = "0x28")]
	public static Action<bool> OnUseDebugNotifications;

	[Token(Token = "0x4003F60")]
	[FieldOffset(Offset = "0x30")]
	public static Action<bool> OnDebugLeaderboards;

	[Token(Token = "0x4003F61")]
	[FieldOffset(Offset = "0x38")]
	public static Action<float> OnMusicVolumeChanged;

	[Token(Token = "0x4003F62")]
	[FieldOffset(Offset = "0x40")]
	public static Action<float> OnSFXVolumeChanged;

	[Token(Token = "0x4003F63")]
	[FieldOffset(Offset = "0x48")]
	public static Action<float> OnQualitySettingsChanged;

	[Token(Token = "0x4003F64")]
	[FieldOffset(Offset = "0x50")]
	public static Action<float> OnScreenshakeValueChanged;

	[Token(Token = "0x4003F65")]
	[FieldOffset(Offset = "0x58")]
	public static Action<string> OnLanguageChanged;

	[Token(Token = "0x4003F66")]
	[FieldOffset(Offset = "0x60")]
	private static bool switchUseGyro;

	[Token(Token = "0x4003F67")]
	[FieldOffset(Offset = "0x68")]
	public static Action<bool> OnSwitchGyroChanged;

	[Token(Token = "0x4003F68")]
	[FieldOffset(Offset = "0x70")]
	private static bool cheatUnlockNoSave;

	[Token(Token = "0x4003F69")]
	[FieldOffset(Offset = "0x78")]
	public static Action<bool> OnCheatUnlockNoSave;

	[Token(Token = "0x170005BD")]
	public static bool BatterySaving
	{
		[Token(Token = "0x60036E2")]
		[Address(RVA = "0x169241C", Offset = "0x169241C", VA = "0x169241C")]
		get
		{
			return default;
		}
	}

	[Token(Token = "0x170005BE")]
	public static bool UseGyroShake
	{
		[Token(Token = "0x60036E3")]
		[Address(RVA = "0x1692528", Offset = "0x1692528", VA = "0x1692528")]
		get
		{
			return default;
		}
		[Token(Token = "0x60036E4")]
		[Address(RVA = "0x16925F4", Offset = "0x16925F4", VA = "0x16925F4")]
		set
		{
		}
	}

	[Token(Token = "0x170005BF")]
	public static bool UseDebugNotifications
	{
		[Token(Token = "0x60036E5")]
		[Address(RVA = "0x169272C", Offset = "0x169272C", VA = "0x169272C")]
		get
		{
			return default;
		}
		[Token(Token = "0x60036E6")]
		[Address(RVA = "0x16927F8", Offset = "0x16927F8", VA = "0x16927F8")]
		set
		{
		}
	}

	[Token(Token = "0x170005C0")]
	public static bool DebugLeaderboards
	{
		[Token(Token = "0x60036E7")]
		[Address(RVA = "0x1692930", Offset = "0x1692930", VA = "0x1692930")]
		get
		{
			return default;
		}
		[Token(Token = "0x60036E8")]
		[Address(RVA = "0x1692938", Offset = "0x1692938", VA = "0x1692938")]
		set
		{
		}
	}

	[Token(Token = "0x170005C1")]
	public static float MusicVolume
	{
		[Token(Token = "0x60036E9")]
		[Address(RVA = "0x1692A70", Offset = "0x1692A70", VA = "0x1692A70")]
		get
		{
			return default;
		}
		[Token(Token = "0x60036EA")]
		[Address(RVA = "0x1692B84", Offset = "0x1692B84", VA = "0x1692B84")]
		set
		{
		}
	}

	[Token(Token = "0x170005C2")]
	public static float SFXVolume
	{
		[Token(Token = "0x60036EB")]
		[Address(RVA = "0x1692CEC", Offset = "0x1692CEC", VA = "0x1692CEC")]
		get
		{
			return default;
		}
		[Token(Token = "0x60036EC")]
		[Address(RVA = "0x1692E00", Offset = "0x1692E00", VA = "0x1692E00")]
		set
		{
		}
	}

	[Token(Token = "0x170005C3")]
	public static bool CanAdjustQuality
	{
		[Token(Token = "0x60036ED")]
		[Address(RVA = "0x1692F68", Offset = "0x1692F68", VA = "0x1692F68")]
		get
		{
			return default;
		}
	}

	[Token(Token = "0x170005C4")]
	public static float QualitySettings
	{
		[Token(Token = "0x60036EE")]
		[Address(RVA = "0x1692FE4", Offset = "0x1692FE4", VA = "0x1692FE4")]
		get
		{
			return default;
		}
		[Token(Token = "0x60036EF")]
		[Address(RVA = "0x16930F0", Offset = "0x16930F0", VA = "0x16930F0")]
		set
		{
		}
	}

	[Token(Token = "0x170005C5")]
	public static float ScreenshakeValue
	{
		[Token(Token = "0x60036F0")]
		[Address(RVA = "0x16931D0", Offset = "0x16931D0", VA = "0x16931D0")]
		get
		{
			return default;
		}
	}

	[Token(Token = "0x170005C6")]
	public static string Language
	{
		[Token(Token = "0x60036F1")]
		[Address(RVA = "0x16932E4", Offset = "0x16932E4", VA = "0x16932E4")]
		get
		{
			return null;
		}
		[Token(Token = "0x60036F2")]
		[Address(RVA = "0x1693340", Offset = "0x1693340", VA = "0x1693340")]
		set
		{
		}
	}

	[Token(Token = "0x170005C7")]
	public static bool SwitchUseGyro
	{
		[Token(Token = "0x60036F3")]
		[Address(RVA = "0x1693440", Offset = "0x1693440", VA = "0x1693440")]
		get
		{
			return default;
		}
		[Token(Token = "0x60036F4")]
		[Address(RVA = "0x16934A4", Offset = "0x16934A4", VA = "0x16934A4")]
		set
		{
		}
	}

	[Token(Token = "0x170005C8")]
	public static bool CheatingEnabled
	{
		[Token(Token = "0x60036F5")]
		[Address(RVA = "0x1693570", Offset = "0x1693570", VA = "0x1693570")]
		get
		{
			return default;
		}
	}

	[Token(Token = "0x170005C9")]
	public static bool CheatUnlockNoSave
	{
		[Token(Token = "0x60036F6")]
		[Address(RVA = "0x16935E8", Offset = "0x16935E8", VA = "0x16935E8")]
		set
		{
		}
	}
}
