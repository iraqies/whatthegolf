using System;
using Il2CppDummyDll;

namespace TMPro
{
	[Serializable]
	[Token(Token = "0x2000024")]
	public struct TMP_FontWeightPair
	{
		[Token(Token = "0x40000EF")]
		[FieldOffset(Offset = "0x0")]
		public TMP_FontAsset regularTypeface;

		[Token(Token = "0x40000F0")]
		[FieldOffset(Offset = "0x8")]
		public TMP_FontAsset italicTypeface;
	}
}
