using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x2000B6B")]
public class GameSettings : MonoBehaviour
{
	[Token(Token = "0x4003F55")]
	[FieldOffset(Offset = "0x0")]
	private static GameSettings _instance;

	[Token(Token = "0x4003F56")]
	[FieldOffset(Offset = "0x18")]
	private bool isInitialized;

	[Token(Token = "0x170005BC")]
	public static GameSettings Instance
	{
		[Token(Token = "0x60036D3")]
		[Address(RVA = "0x147EAD0", Offset = "0x147EAD0", VA = "0x147EAD0")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x60036D4")]
	[Address(RVA = "0x147EC10", Offset = "0x147EC10", VA = "0x147EC10")]
	public void Start()
	{
	}

	[Token(Token = "0x60036D5")]
	[Address(RVA = "0x147EC14", Offset = "0x147EC14", VA = "0x147EC14")]
	public void Initialize()
	{
	}

	[Token(Token = "0x60036D6")]
	[Address(RVA = "0x147F220", Offset = "0x147F220", VA = "0x147F220")]
	[Attribute(Name = "ContextMenu", RVA = "0x6AA9C", Offset = "0x6AA9C")]
	public void TestLangChange()
	{
	}

	[Token(Token = "0x60036D7")]
	[Address(RVA = "0x147EFD4", Offset = "0x147EFD4", VA = "0x147EFD4")]
	public void RefreshFromSave()
	{
	}

	[Token(Token = "0x60036D8")]
	[Address(RVA = "0x147F600", Offset = "0x147F600", VA = "0x147F600")]
	private void OnScreenshakeValueChanged(float f)
	{
	}

	[Token(Token = "0x60036D9")]
	[Address(RVA = "0x147F314", Offset = "0x147F314", VA = "0x147F314")]
	private void OnSfxVolumeChanged(float vol)
	{
	}

	[Token(Token = "0x60036DA")]
	[Address(RVA = "0x147F46C", Offset = "0x147F46C", VA = "0x147F46C")]
	private void OnQualitySettingsChanged(float value)
	{
	}

	[Token(Token = "0x60036DB")]
	[Address(RVA = "0x147F3B4", Offset = "0x147F3B4", VA = "0x147F3B4")]
	private void OnMusicVolumeChanged(float vol)
	{
	}

	[Token(Token = "0x60036DC")]
	[Address(RVA = "0x147F498", Offset = "0x147F498", VA = "0x147F498")]
	private void OnLanguageChanged(string language)
	{
	}

	[Token(Token = "0x60036DD")]
	[Address(RVA = "0x147F548", Offset = "0x147F548", VA = "0x147F548")]
	private void OnBatterySavingChanged(bool state)
	{
	}

	[Token(Token = "0x60036DE")]
	[Address(RVA = "0x147F604", Offset = "0x147F604", VA = "0x147F604")]
	public string GetPlayerName()
	{
		return null;
	}

	[Token(Token = "0x60036DF")]
	[Address(RVA = "0x147F6A4", Offset = "0x147F6A4", VA = "0x147F6A4")]
	public string GetPlayerId()
	{
		return null;
	}

	[Token(Token = "0x60036E0")]
	[Address(RVA = "0x147F770", Offset = "0x147F770", VA = "0x147F770")]
	private void Update()
	{
	}

	[Token(Token = "0x60036E1")]
	[Address(RVA = "0x147F7CC", Offset = "0x147F7CC", VA = "0x147F7CC")]
	public GameSettings()
	{
	}
}
