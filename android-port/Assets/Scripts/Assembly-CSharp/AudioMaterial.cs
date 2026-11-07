using System;
using Il2CppDummyDll;
using UnityEngine;

[Serializable]
[Token(Token = "0x2000381")]
public class AudioMaterial : ScriptableObject
{
	[Token(Token = "0x4001346")]
	[FieldOffset(Offset = "0x18")]
	public float volumeModifier;

	[Token(Token = "0x4001347")]
	[FieldOffset(Offset = "0x1C")]
	public float pitchModifier;

	[Token(Token = "0x60010A5")]
	[Address(RVA = "0x150963C", Offset = "0x150963C", VA = "0x150963C")]
	public AudioMaterial()
	{
	}
}
