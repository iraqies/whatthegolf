using System;
using Il2CppDummyDll;

namespace TMPro
{
	[Serializable]
	[Token(Token = "0x200006F")]
	public class TMP_TextElement_Legacy
	{
		[Token(Token = "0x4000471")]
		[FieldOffset(Offset = "0x10")]
		public int id;

		[Token(Token = "0x4000472")]
		[FieldOffset(Offset = "0x14")]
		public float x;

		[Token(Token = "0x4000473")]
		[FieldOffset(Offset = "0x18")]
		public float y;

		[Token(Token = "0x4000474")]
		[FieldOffset(Offset = "0x1C")]
		public float width;

		[Token(Token = "0x4000475")]
		[FieldOffset(Offset = "0x20")]
		public float height;

		[Token(Token = "0x4000476")]
		[FieldOffset(Offset = "0x24")]
		public float xOffset;

		[Token(Token = "0x4000477")]
		[FieldOffset(Offset = "0x28")]
		public float yOffset;

		[Token(Token = "0x4000478")]
		[FieldOffset(Offset = "0x2C")]
		public float xAdvance;

		[Token(Token = "0x4000479")]
		[FieldOffset(Offset = "0x30")]
		public float scale;

		[Token(Token = "0x6000455")]
		[Address(RVA = "0x2AB9290", Offset = "0x2AB9290", VA = "0x2AB9290")]
		public TMP_TextElement_Legacy()
		{
		}
	}
}
