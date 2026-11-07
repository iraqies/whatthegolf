using System;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.TextCore;

namespace TMPro
{
	[Serializable]
	[Token(Token = "0x200006E")]
	public class TMP_TextElement
	{
		[Token(Token = "0x400046B")]
		[FieldOffset(Offset = "0x10")]
		[SerializeField]
		protected TextElementType m_ElementType;

		[Token(Token = "0x400046C")]
		[FieldOffset(Offset = "0x14")]
		[SerializeField]
		internal uint m_Unicode;

		[Token(Token = "0x400046D")]
		[FieldOffset(Offset = "0x18")]
		internal TMP_Asset m_TextAsset;

		[Token(Token = "0x400046E")]
		[FieldOffset(Offset = "0x20")]
		internal Glyph m_Glyph;

		[Token(Token = "0x400046F")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		internal uint m_GlyphIndex;

		[Token(Token = "0x4000470")]
		[FieldOffset(Offset = "0x2C")]
		[SerializeField]
		internal float m_Scale;

		[Token(Token = "0x17000134")]
		public TextElementType elementType
		{
			[Token(Token = "0x6000449")]
			[Address(RVA = "0x2AB9230", Offset = "0x2AB9230", VA = "0x2AB9230")]
			get
			{
				return default;
			}
		}

		[Token(Token = "0x17000135")]
		public uint unicode
		{
			[Token(Token = "0x600044A")]
			[Address(RVA = "0x2AB9238", Offset = "0x2AB9238", VA = "0x2AB9238")]
			get
			{
				return default;
			}
			[Token(Token = "0x600044B")]
			[Address(RVA = "0x2AB9240", Offset = "0x2AB9240", VA = "0x2AB9240")]
			set
			{
			}
		}

		[Token(Token = "0x17000136")]
		public TMP_Asset textAsset
		{
			[Token(Token = "0x600044C")]
			[Address(RVA = "0x2AB9248", Offset = "0x2AB9248", VA = "0x2AB9248")]
			get
			{
				return null;
			}
			[Token(Token = "0x600044D")]
			[Address(RVA = "0x2AB9250", Offset = "0x2AB9250", VA = "0x2AB9250")]
			set
			{
			}
		}

		[Token(Token = "0x17000137")]
		public Glyph glyph
		{
			[Token(Token = "0x600044E")]
			[Address(RVA = "0x2AB9258", Offset = "0x2AB9258", VA = "0x2AB9258")]
			get
			{
				return null;
			}
			[Token(Token = "0x600044F")]
			[Address(RVA = "0x2AB9260", Offset = "0x2AB9260", VA = "0x2AB9260")]
			set
			{
			}
		}

		[Token(Token = "0x17000138")]
		public uint glyphIndex
		{
			[Token(Token = "0x6000450")]
			[Address(RVA = "0x2AB9268", Offset = "0x2AB9268", VA = "0x2AB9268")]
			get
			{
				return default;
			}
			[Token(Token = "0x6000451")]
			[Address(RVA = "0x2AB9270", Offset = "0x2AB9270", VA = "0x2AB9270")]
			set
			{
			}
		}

		[Token(Token = "0x17000139")]
		public float scale
		{
			[Token(Token = "0x6000452")]
			[Address(RVA = "0x2AB9278", Offset = "0x2AB9278", VA = "0x2AB9278")]
			get
			{
				return default;
			}
			[Token(Token = "0x6000453")]
			[Address(RVA = "0x2AB9280", Offset = "0x2AB9280", VA = "0x2AB9280")]
			set
			{
			}
		}

		[Token(Token = "0x6000454")]
		[Address(RVA = "0x2AB9288", Offset = "0x2AB9288", VA = "0x2AB9288")]
		public TMP_TextElement()
		{
		}
	}
}
