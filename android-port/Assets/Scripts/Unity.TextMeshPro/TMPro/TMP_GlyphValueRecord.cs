using System;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.TextCore.LowLevel;

namespace TMPro
{
	[Serializable]
	[Token(Token = "0x200002C")]
	public struct TMP_GlyphValueRecord
	{
		[Token(Token = "0x4000108")]
		[FieldOffset(Offset = "0x0")]
		[SerializeField]
		internal float m_XPlacement;

		[Token(Token = "0x4000109")]
		[FieldOffset(Offset = "0x4")]
		[SerializeField]
		internal float m_YPlacement;

		[Token(Token = "0x400010A")]
		[FieldOffset(Offset = "0x8")]
		[SerializeField]
		internal float m_XAdvance;

		[Token(Token = "0x400010B")]
		[FieldOffset(Offset = "0xC")]
		[SerializeField]
		internal float m_YAdvance;

		[Token(Token = "0x17000041")]
		public float xPlacement
		{
			[Token(Token = "0x600011F")]
			[Address(RVA = "0x2A8A28C", Offset = "0x2A8A28C", VA = "0x2A8A28C")]
			get
			{
				return default;
			}
		}

		[Token(Token = "0x17000042")]
		public float yPlacement
		{
			[Token(Token = "0x6000120")]
			[Address(RVA = "0x2A8A294", Offset = "0x2A8A294", VA = "0x2A8A294")]
			get
			{
				return default;
			}
		}

		[Token(Token = "0x17000043")]
		public float xAdvance
		{
			[Token(Token = "0x6000121")]
			[Address(RVA = "0x2A8A29C", Offset = "0x2A8A29C", VA = "0x2A8A29C")]
			get
			{
				return default;
			}
		}

		[Token(Token = "0x17000044")]
		public float yAdvance
		{
			[Token(Token = "0x6000122")]
			[Address(RVA = "0x2A8A2A4", Offset = "0x2A8A2A4", VA = "0x2A8A2A4")]
			get
			{
				return default;
			}
		}

		[Token(Token = "0x6000123")]
		[Address(RVA = "0x2A88A6C", Offset = "0x2A88A6C", VA = "0x2A88A6C")]
		public TMP_GlyphValueRecord(float xPlacement, float yPlacement, float xAdvance, float yAdvance)
		{
		}

		[Token(Token = "0x6000124")]
		[Address(RVA = "0x2A8A1F8", Offset = "0x2A8A1F8", VA = "0x2A8A1F8")]
		internal TMP_GlyphValueRecord(GlyphValueRecord valueRecord)
		{
		}

		[Token(Token = "0x6000125")]
		[Address(RVA = "0x2A8A2AC", Offset = "0x2A8A2AC", VA = "0x2A8A2AC")]
		public static TMP_GlyphValueRecord operator +(TMP_GlyphValueRecord a, TMP_GlyphValueRecord b)
		{
			return default;
		}
	}
}
