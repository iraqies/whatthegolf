using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x200054F")]
public class ActivateSettingsBasedOnPlatformSettings : MonoBehaviour
{
	[Token(Token = "0x4001B6C")]
	[FieldOffset(Offset = "0x18")]
	public GameObject language;

	[Token(Token = "0x4001B6D")]
	[FieldOffset(Offset = "0x20")]
	public GameObject music;

	[Token(Token = "0x4001B6E")]
	[FieldOffset(Offset = "0x28")]
	public GameObject sfx;

	[Token(Token = "0x4001B6F")]
	[FieldOffset(Offset = "0x30")]
	public GameObject quality;

	[Token(Token = "0x4001B70")]
	[FieldOffset(Offset = "0x38")]
	public GameObject resolution;

	[Token(Token = "0x4001B71")]
	[FieldOffset(Offset = "0x40")]
	public GameObject fullscreen;

	[Token(Token = "0x4001B72")]
	[FieldOffset(Offset = "0x48")]
	public GameObject saveslot;

	[Token(Token = "0x4001B73")]
	[FieldOffset(Offset = "0x50")]
	public GameObject saveslotRecovery;

	[Token(Token = "0x4001B74")]
	[FieldOffset(Offset = "0x58")]
	public GameObject switchGyroOn;

	[Token(Token = "0x4001B75")]
	[FieldOffset(Offset = "0x60")]
	public GameObject ReconfigureController;

	[Token(Token = "0x6001836")]
	[Address(RVA = "0x140519C", Offset = "0x140519C", VA = "0x140519C")]
	public void Activate()
	{
	}

	[Token(Token = "0x6001837")]
	[Address(RVA = "0x14052E4", Offset = "0x14052E4", VA = "0x14052E4")]
	public ActivateSettingsBasedOnPlatformSettings()
	{
	}
}
