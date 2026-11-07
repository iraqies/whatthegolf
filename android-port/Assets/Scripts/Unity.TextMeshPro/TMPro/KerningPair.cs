using System;
using Il2CppDummyDll;
using UnityEngine;

namespace TMPro
{
	[Serializable]
	[Token(Token = "0x2000026")]
	public class KerningPair
	{
		[Token(Token = "0x40000F5")]
		[FieldOffset(Offset = "0x10")]
		[AttributeAttribute(Name = "FormerlySerializedAsAttribute", RVA = "0x1B984C", Offset = "0x1B984C")]
		[SerializeField]
		private uint m_FirstGlyph;

		[Token(Token = "0x40000F6")]
		[FieldOffset(Offset = "0x14")]
		[SerializeField]
		private GlyphValueRecord_Legacy m_FirstGlyphAdjustments;

		[Token(Token = "0x40000F7")]
		[FieldOffset(Offset = "0x24")]
		[SerializeField]
		[AttributeAttribute(Name = "FormerlySerializedAsAttribute", RVA = "0x1B98A8", Offset = "0x1B98A8")]
		private uint m_SecondGlyph;

		[Token(Token = "0x40000F8")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private GlyphValueRecord_Legacy m_SecondGlyphAdjustments;

		[Token(Token = "0x40000F9")]
		[FieldOffset(Offset = "0x38")]
		[AttributeAttribute(Name = "FormerlySerializedAsAttribute", RVA = "0x1B9904", Offset = "0x1B9904")]
		public float xOffset;

		[Token(Token = "0x40000FA")]
		[FieldOffset(Offset = "0x0")]
		internal static KerningPair empty;

		[Token(Token = "0x40000FB")]
		[FieldOffset(Offset = "0x3C")]
		[SerializeField]
		private bool m_IgnoreSpacingAdjustments;

		[Token(Token = "0x1700003C")]
		public uint firstGlyph
		{
			[Token(Token = "0x6000109")]
			[Address(RVA = "0x2A7A838", Offset = "0x2A7A838", VA = "0x2A7A838")]
			get
			{
				return default;
			}
		}

		[Token(Token = "0x1700003D")]
		public GlyphValueRecord_Legacy firstGlyphAdjustments
		{
			[Token(Token = "0x600010A")]
			[Address(RVA = "0x2A7A840", Offset = "0x2A7A840", VA = "0x2A7A840")]
			get
			{
				return default;
			}
		}

		[Token(Token = "0x1700003E")]
		public uint secondGlyph
		{
			[Token(Token = "0x600010B")]
			[Address(RVA = "0x2A7A84C", Offset = "0x2A7A84C", VA = "0x2A7A84C")]
			get
			{
				return default;
			}
		}

		[Token(Token = "0x1700003F")]
		public GlyphValueRecord_Legacy secondGlyphAdjustments
		{
			[Token(Token = "0x600010C")]
			[Address(RVA = "0x2A7A854", Offset = "0x2A7A854", VA = "0x2A7A854")]
			get
			{
				return default;
			}
		}

		[Token(Token = "0x600010D")]
		[Address(RVA = "0x2A7A860", Offset = "0x2A7A860", VA = "0x2A7A860")]
		public KerningPair()
		{
		}

		[Token(Token = "0x600010E")]
		[Address(RVA = "0x2A7A890", Offset = "0x2A7A890", VA = "0x2A7A890")]
		public KerningPair(uint firstGlyph, GlyphValueRecord_Legacy firstGlyphAdjustments, uint secondGlyph, GlyphValueRecord_Legacy secondGlyphAdjustments)
		{
		}
	}
}
