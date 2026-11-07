using System;
using Il2CppDummyDll;

[Serializable]
[Token(Token = "0x2000C0A")]
public class MinMax
{
	[Token(Token = "0x4004298")]
	[FieldOffset(Offset = "0x10")]
	public float min;

	[Token(Token = "0x4004299")]
	[FieldOffset(Offset = "0x14")]
	public float max;

	[Token(Token = "0x60039BE")]
	[Address(RVA = "0x156765C", Offset = "0x156765C", VA = "0x156765C")]
	public MinMax(float min, float max)
	{
	}

	[Token(Token = "0x60039BF")]
	[Address(RVA = "0x156769C", Offset = "0x156769C", VA = "0x156769C")]
	public float LerpInRange(float normalized)
	{
		return default;
	}
}
