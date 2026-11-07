using System;
using Il2CppDummyDll;
using UnityEngine;

namespace TMPro
{
	[Serializable]
	[Token(Token = "0x2000051")]
	public class TMP_Sprite : TMP_TextElement_Legacy
	{
		[Token(Token = "0x40002C0")]
		[FieldOffset(Offset = "0x38")]
		public string name;

		[Token(Token = "0x40002C1")]
		[FieldOffset(Offset = "0x40")]
		public int hashCode;

		[Token(Token = "0x40002C2")]
		[FieldOffset(Offset = "0x44")]
		public int unicode;

		[Token(Token = "0x40002C3")]
		[FieldOffset(Offset = "0x48")]
		public Vector2 pivot;

		[Token(Token = "0x40002C4")]
		[FieldOffset(Offset = "0x50")]
		public Sprite sprite;

		[Token(Token = "0x6000285")]
		[Address(RVA = "0x2A9C7FC", Offset = "0x2A9C7FC", VA = "0x2A9C7FC")]
		public TMP_Sprite()
		{
		}
	}
}
