using System;
using Il2CppDummyDll;
using UnityEngine;

namespace TMPro
{
	[Serializable]
	[Token(Token = "0x2000056")]
	public class TMP_SpriteCharacter : TMP_TextElement
	{
		[Token(Token = "0x40002E7")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private string m_Name;

		[Token(Token = "0x40002E8")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private int m_HashCode;

		[Token(Token = "0x170000B8")]
		public string name
		{
			[Token(Token = "0x60002B0")]
			[Address(RVA = "0x2A9E868", Offset = "0x2A9E868", VA = "0x2A9E868")]
			set
			{
			}
		}

		[Token(Token = "0x170000B9")]
		public int hashCode
		{
			[Token(Token = "0x60002B1")]
			[Address(RVA = "0x2A9E9C0", Offset = "0x2A9E9C0", VA = "0x2A9E9C0")]
			get
			{
				return default;
			}
		}

		[Token(Token = "0x60002B2")]
		[Address(RVA = "0x2A9E83C", Offset = "0x2A9E83C", VA = "0x2A9E83C")]
		public TMP_SpriteCharacter()
		{
		}
	}
}
