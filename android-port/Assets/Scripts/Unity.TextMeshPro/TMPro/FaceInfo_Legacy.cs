using System;
using Il2CppDummyDll;

namespace TMPro
{
	[Serializable]
	[Token(Token = "0x2000021")]
	public class FaceInfo_Legacy
	{
		[Token(Token = "0x40000CA")]
		[FieldOffset(Offset = "0x10")]
		public string Name;

		[Token(Token = "0x40000CB")]
		[FieldOffset(Offset = "0x18")]
		public float PointSize;

		[Token(Token = "0x40000CC")]
		[FieldOffset(Offset = "0x1C")]
		public float Scale;

		[Token(Token = "0x40000CD")]
		[FieldOffset(Offset = "0x20")]
		public int CharacterCount;

		[Token(Token = "0x40000CE")]
		[FieldOffset(Offset = "0x24")]
		public float LineHeight;

		[Token(Token = "0x40000CF")]
		[FieldOffset(Offset = "0x28")]
		public float Baseline;

		[Token(Token = "0x40000D0")]
		[FieldOffset(Offset = "0x2C")]
		public float Ascender;

		[Token(Token = "0x40000D1")]
		[FieldOffset(Offset = "0x30")]
		public float CapHeight;

		[Token(Token = "0x40000D2")]
		[FieldOffset(Offset = "0x34")]
		public float Descender;

		[Token(Token = "0x40000D3")]
		[FieldOffset(Offset = "0x38")]
		public float CenterLine;

		[Token(Token = "0x40000D4")]
		[FieldOffset(Offset = "0x3C")]
		public float SuperscriptOffset;

		[Token(Token = "0x40000D5")]
		[FieldOffset(Offset = "0x40")]
		public float SubscriptOffset;

		[Token(Token = "0x40000D6")]
		[FieldOffset(Offset = "0x44")]
		public float SubSize;

		[Token(Token = "0x40000D7")]
		[FieldOffset(Offset = "0x48")]
		public float Underline;

		[Token(Token = "0x40000D8")]
		[FieldOffset(Offset = "0x4C")]
		public float UnderlineThickness;

		[Token(Token = "0x40000D9")]
		[FieldOffset(Offset = "0x50")]
		public float strikethrough;

		[Token(Token = "0x40000DA")]
		[FieldOffset(Offset = "0x54")]
		public float strikethroughThickness;

		[Token(Token = "0x40000DB")]
		[FieldOffset(Offset = "0x58")]
		public float TabWidth;

		[Token(Token = "0x40000DC")]
		[FieldOffset(Offset = "0x5C")]
		public float Padding;

		[Token(Token = "0x40000DD")]
		[FieldOffset(Offset = "0x60")]
		public float AtlasWidth;

		[Token(Token = "0x40000DE")]
		[FieldOffset(Offset = "0x64")]
		public float AtlasHeight;

		[Token(Token = "0x6000107")]
		[Address(RVA = "0x2A7A2C8", Offset = "0x2A7A2C8", VA = "0x2A7A2C8")]
		public FaceInfo_Legacy()
		{
		}
	}
}
