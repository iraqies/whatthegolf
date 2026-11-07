using System;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.TextCore;

namespace TMPro
{
	[Serializable]
	[Token(Token = "0x2000057")]
	public class TMP_SpriteGlyph : Glyph
	{
		[Token(Token = "0x40002E9")]
		[FieldOffset(Offset = "0x40")]
		public Sprite sprite;

		[Token(Token = "0x60002B3")]
		[Address(RVA = "0x2A9E834", Offset = "0x2A9E834", VA = "0x2A9E834")]
		public TMP_SpriteGlyph()
		{
		}
	}
}
