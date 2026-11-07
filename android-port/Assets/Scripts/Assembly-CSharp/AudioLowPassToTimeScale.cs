using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x200037D")]
[Attribute(Name = "RequireComponent", RVA = "0x3F4BC", Offset = "0x3F4BC")]
public class AudioLowPassToTimeScale : MonoBehaviour
{
	[Token(Token = "0x400131C")]
	[FieldOffset(Offset = "0x18")]
	public float normalAmount;

	[Token(Token = "0x400131D")]
	[FieldOffset(Offset = "0x1C")]
	public float slowDownAmount;

	[Token(Token = "0x400131E")]
	[FieldOffset(Offset = "0x20")]
	private AudioLowPassFilter filter;

	[Token(Token = "0x6001080")]
	[Address(RVA = "0x142DF14", Offset = "0x142DF14", VA = "0x142DF14")]
	private void Awake()
	{
	}

	[Token(Token = "0x6001081")]
	[Address(RVA = "0x142DF70", Offset = "0x142DF70", VA = "0x142DF70")]
	private void Update()
	{
	}

	[Token(Token = "0x6001082")]
	[Address(RVA = "0x142DFC0", Offset = "0x142DFC0", VA = "0x142DFC0")]
	public AudioLowPassToTimeScale()
	{
	}
}
