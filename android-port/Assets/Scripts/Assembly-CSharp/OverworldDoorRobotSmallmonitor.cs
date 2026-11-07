using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x200097C")]
public class OverworldDoorRobotSmallmonitor : MonoBehaviour
{
	[Token(Token = "0x4003428")]
	[FieldOffset(Offset = "0x18")]
	public OverworldMainDoorPlate plate;

	[Token(Token = "0x4003429")]
	[FieldOffset(Offset = "0x20")]
	public List<Color> colors;

	[Token(Token = "0x400342A")]
	[FieldOffset(Offset = "0x28")]
	private float nextChange;

	[Token(Token = "0x400342B")]
	[FieldOffset(Offset = "0x30")]
	private SpriteRenderer render;

	[Token(Token = "0x6002C57")]
	[Address(RVA = "0x15B3CE8", Offset = "0x15B3CE8", VA = "0x15B3CE8")]
	private void Awake()
	{
	}

	[Token(Token = "0x6002C58")]
	[Address(RVA = "0x15B3D44", Offset = "0x15B3D44", VA = "0x15B3D44")]
	private void Update()
	{
	}

	[Token(Token = "0x6002C59")]
	[Address(RVA = "0x15B3E50", Offset = "0x15B3E50", VA = "0x15B3E50")]
	public OverworldDoorRobotSmallmonitor()
	{
	}
}
