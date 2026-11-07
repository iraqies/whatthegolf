using System;
using Il2CppDummyDll;

namespace TMPro
{
	[Serializable]
	[Token(Token = "0x2000023")]
	public struct FontAssetCreationSettings
	{
		[Token(Token = "0x40000DF")]
		[FieldOffset(Offset = "0x0")]
		public string sourceFontFileName;

		[Token(Token = "0x40000E0")]
		[FieldOffset(Offset = "0x8")]
		public string sourceFontFileGUID;

		[Token(Token = "0x40000E1")]
		[FieldOffset(Offset = "0x10")]
		public int pointSizeSamplingMode;

		[Token(Token = "0x40000E2")]
		[FieldOffset(Offset = "0x14")]
		public int pointSize;

		[Token(Token = "0x40000E3")]
		[FieldOffset(Offset = "0x18")]
		public int padding;

		[Token(Token = "0x40000E4")]
		[FieldOffset(Offset = "0x1C")]
		public int packingMode;

		[Token(Token = "0x40000E5")]
		[FieldOffset(Offset = "0x20")]
		public int atlasWidth;

		[Token(Token = "0x40000E6")]
		[FieldOffset(Offset = "0x24")]
		public int atlasHeight;

		[Token(Token = "0x40000E7")]
		[FieldOffset(Offset = "0x28")]
		public int characterSetSelectionMode;

		[Token(Token = "0x40000E8")]
		[FieldOffset(Offset = "0x30")]
		public string characterSequence;

		[Token(Token = "0x40000E9")]
		[FieldOffset(Offset = "0x38")]
		public string referencedFontAssetGUID;

		[Token(Token = "0x40000EA")]
		[FieldOffset(Offset = "0x40")]
		public string referencedTextAssetGUID;

		[Token(Token = "0x40000EB")]
		[FieldOffset(Offset = "0x48")]
		public int fontStyle;

		[Token(Token = "0x40000EC")]
		[FieldOffset(Offset = "0x4C")]
		public float fontStyleModifier;

		[Token(Token = "0x40000ED")]
		[FieldOffset(Offset = "0x50")]
		public int renderMode;

		[Token(Token = "0x40000EE")]
		[FieldOffset(Offset = "0x54")]
		public bool includeFontFeatures;
	}
}
