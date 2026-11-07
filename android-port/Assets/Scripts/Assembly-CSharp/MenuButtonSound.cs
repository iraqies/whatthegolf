using Audio;
using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x20001B5")]
public class MenuButtonSound : MonoBehaviour
{
	[Token(Token = "0x40007B2")]
	[FieldOffset(Offset = "0x18")]
	[SerializeField]
	private ClipSettingsCollection _pressedSFX;

	[Token(Token = "0x40007B3")]
	[FieldOffset(Offset = "0x20")]
	[SerializeField]
	private ClipSettingsCollection _selectedSFX;

	[Token(Token = "0x40007B4")]
	[FieldOffset(Offset = "0x28")]
	private MainMenu2Button _button;

	[Token(Token = "0x6000796")]
	[Address(RVA = "0x1560E30", Offset = "0x1560E30", VA = "0x1560E30")]
	private void Start()
	{
	}

	[Token(Token = "0x6000797")]
	[Address(RVA = "0x1560F98", Offset = "0x1560F98", VA = "0x1560F98")]
	private void PlayClick()
	{
	}

	[Token(Token = "0x6000798")]
	[Address(RVA = "0x1560FF0", Offset = "0x1560FF0", VA = "0x1560FF0")]
	private void PlaySelected()
	{
	}

	[Token(Token = "0x6000799")]
	[Address(RVA = "0x1561048", Offset = "0x1561048", VA = "0x1561048")]
	public MenuButtonSound()
	{
	}
}
