using System;
using Il2CppDummyDll;

[Serializable]
[Token(Token = "0x2000021")]
public class ContentPackDef
{
	[Token(Token = "0x4000076")]
	[FieldOffset(Offset = "0x10")]
	public ContentPack pack;

	[Token(Token = "0x4000077")]
	[FieldOffset(Offset = "0x18")]
	public bool visible;

	[Token(Token = "0x4000078")]
	[FieldOffset(Offset = "0x19")]
	public bool accessible;

	[Token(Token = "0x600008E")]
	[Address(RVA = "0x18AE3BC", Offset = "0x18AE3BC", VA = "0x18AE3BC")]
	public ContentPackDef()
	{
	}
}
