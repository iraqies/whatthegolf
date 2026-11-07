using System.Collections.Generic;
using Audio;
using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x20001A8")]
public class MainMenu2Music : MonoBehaviour
{
	[Token(Token = "0x4000782")]
	[FieldOffset(Offset = "0x18")]
	[SerializeField]
	private LevelMusicSettings _menuMusic;

	[Token(Token = "0x4000783")]
	[FieldOffset(Offset = "0x20")]
	[SerializeField]
	private List<AmbientAudio> _menuAmbients;

	[Token(Token = "0x4000784")]
	[FieldOffset(Offset = "0x28")]
	[SerializeField]
	private ClipSettingsCollection _showSubmenuSFX;

	[Token(Token = "0x4000785")]
	[FieldOffset(Offset = "0x30")]
	[SerializeField]
	private ClipSettingsCollection _hideSubmenuSFX;

	[Token(Token = "0x4000786")]
	[FieldOffset(Offset = "0x38")]
	private bool _initialized;

	[Token(Token = "0x600075D")]
	[Address(RVA = "0x15585BC", Offset = "0x15585BC", VA = "0x15585BC")]
	public void Play()
	{
	}

	[Token(Token = "0x600075E")]
	[Address(RVA = "0x15586C4", Offset = "0x15586C4", VA = "0x15586C4")]
	public void StopAmbience()
	{
	}

	[Token(Token = "0x600075F")]
	[Address(RVA = "0x1558758", Offset = "0x1558758", VA = "0x1558758")]
	public void OnShowSubmenu()
	{
	}

	[Token(Token = "0x6000760")]
	[Address(RVA = "0x1558794", Offset = "0x1558794", VA = "0x1558794")]
	public void OnHideSubmenu()
	{
	}

	[Token(Token = "0x6000761")]
	[Address(RVA = "0x15587D0", Offset = "0x15587D0", VA = "0x15587D0")]
	public MainMenu2Music()
	{
	}

	[Token(Token = "0x6000762")]
	[Address(RVA = "0x15587D8", Offset = "0x15587D8", VA = "0x15587D8")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x5F178", Offset = "0x5F178")]
	private void _003CPlay_003Eb__5_0()
	{
	}
}
