using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x2000C1A")]
public class PlatformSpecificGameobject : MonoBehaviour
{
	[Token(Token = "0x40042C7")]
	[FieldOffset(Offset = "0x18")]
	public List<GameObject> GameObjectsToToggle;

	[Token(Token = "0x40042C8")]
	[FieldOffset(Offset = "0x20")]
	public bool StateOnStandalone;

	[Token(Token = "0x40042C9")]
	[FieldOffset(Offset = "0x21")]
	public bool StateOnMobile;

	[Token(Token = "0x40042CA")]
	[FieldOffset(Offset = "0x22")]
	public bool StateOnSwitch;

	[Token(Token = "0x40042CB")]
	[FieldOffset(Offset = "0x23")]
	public bool StateOnAppleTV;

	[Token(Token = "0x40042CC")]
	[FieldOffset(Offset = "0x24")]
	public bool StateOnPS4;

	[Token(Token = "0x40042CD")]
	[FieldOffset(Offset = "0x25")]
	public bool StateOnXboxOne;

	[Token(Token = "0x40042CE")]
	[FieldOffset(Offset = "0x26")]
	public bool StateOnPS5;

	[Token(Token = "0x60039F0")]
	[Address(RVA = "0x15E84AC", Offset = "0x15E84AC", VA = "0x15E84AC")]
	private void Awake()
	{
	}

	[Token(Token = "0x60039F1")]
	[Address(RVA = "0x15E8A18", Offset = "0x15E8A18", VA = "0x15E8A18")]
	public PlatformSpecificGameobject()
	{
	}
}
