using System;
using Il2CppDummyDll;
using UnityEngine.TextCore;

namespace TMPro
{
	[Serializable]
	[Token(Token = "0x200000A")]
	public class TMP_Character : TMP_TextElement
	{
		[Token(Token = "0x6000020")]
		[Address(RVA = "0x2A7D89C", Offset = "0x2A7D89C", VA = "0x2A7D89C")]
		public TMP_Character()
		{
		}

		[Token(Token = "0x6000021")]
		[Address(RVA = "0x2A7D8D0", Offset = "0x2A7D8D0", VA = "0x2A7D8D0")]
		public TMP_Character(uint unicode, TMP_FontAsset fontAsset, Glyph glyph)
		{
		}

		[Token(Token = "0x6000022")]
		[Address(RVA = "0x2A7D934", Offset = "0x2A7D934", VA = "0x2A7D934")]
		internal TMP_Character(uint unicode, uint glyphIndex)
		{
		}
	}
}
