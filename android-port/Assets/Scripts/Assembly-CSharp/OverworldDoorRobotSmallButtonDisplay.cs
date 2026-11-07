using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x200097B")]
public class OverworldDoorRobotSmallButtonDisplay : MonoBehaviour
{
	[Token(Token = "0x4003425")]
	[FieldOffset(Offset = "0x18")]
	public List<Color> colors;

	[Token(Token = "0x4003426")]
	[FieldOffset(Offset = "0x20")]
	private float nextChange;

	[Token(Token = "0x4003427")]
	[FieldOffset(Offset = "0x28")]
	private List<SpriteRenderer> renders;

	[Token(Token = "0x6002C54")]
	[Address(RVA = "0x15B3A68", Offset = "0x15B3A68", VA = "0x15B3A68")]
	private void Awake()
	{
	}

	[Token(Token = "0x6002C55")]
	[Address(RVA = "0x15B3AE0", Offset = "0x15B3AE0", VA = "0x15B3AE0")]
	private void Update()
	{
	}

	[Token(Token = "0x6002C56")]
	[Address(RVA = "0x15B3CE0", Offset = "0x15B3CE0", VA = "0x15B3CE0")]
	public OverworldDoorRobotSmallButtonDisplay()
	{
	}
}
