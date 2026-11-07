using System;
using Il2CppDummyDll;

namespace UnityEngine.UI
{
	[Serializable]
	[Token(Token = "0x2000009")]
	public struct ColorBlock : IEquatable<ColorBlock>
	{
		[Token(Token = "0x400001F")]
		[FieldOffset(Offset = "0x0")]
		[SerializeField]
		[AttributeAttribute(Name = "FormerlySerializedAsAttribute", RVA = "0x1F6E00", Offset = "0x1F6E00")]
		private Color m_NormalColor;

		[Token(Token = "0x4000020")]
		[FieldOffset(Offset = "0x10")]
		[AttributeAttribute(Name = "FormerlySerializedAsAttribute", RVA = "0x1F6E4C", Offset = "0x1F6E4C")]
		[SerializeField]
		private Color m_HighlightedColor;

		[Token(Token = "0x4000021")]
		[FieldOffset(Offset = "0x20")]
		[AttributeAttribute(Name = "FormerlySerializedAsAttribute", RVA = "0x1F6E98", Offset = "0x1F6E98")]
		[SerializeField]
		private Color m_PressedColor;

		[Token(Token = "0x4000022")]
		[FieldOffset(Offset = "0x30")]
		[AttributeAttribute(Name = "FormerlySerializedAsAttribute", RVA = "0x1F6EE4", Offset = "0x1F6EE4")]
		[SerializeField]
		private Color m_SelectedColor;

		[Token(Token = "0x4000023")]
		[FieldOffset(Offset = "0x40")]
		[AttributeAttribute(Name = "FormerlySerializedAsAttribute", RVA = "0x1F6F30", Offset = "0x1F6F30")]
		[SerializeField]
		private Color m_DisabledColor;

		[Token(Token = "0x4000024")]
		[FieldOffset(Offset = "0x50")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x1F6F7C", Offset = "0x1F6F7C")]
		[SerializeField]
		private float m_ColorMultiplier;

		[Token(Token = "0x4000025")]
		[FieldOffset(Offset = "0x54")]
		[SerializeField]
		[AttributeAttribute(Name = "FormerlySerializedAsAttribute", RVA = "0x1F6FBC", Offset = "0x1F6FBC")]
		private float m_FadeDuration;

		[Token(Token = "0x4000026")]
		[FieldOffset(Offset = "0x0")]
		public static ColorBlock defaultColorBlock;

		[Token(Token = "0x1700000B")]
		public Color normalColor
		{
			[Token(Token = "0x600002F")]
			[Address(RVA = "0x2BFCA40", Offset = "0x2BFCA40", VA = "0x2BFCA40")]
			get
			{
				return default;
			}
			[Token(Token = "0x6000030")]
			[Address(RVA = "0x2BFCA4C", Offset = "0x2BFCA4C", VA = "0x2BFCA4C")]
			set
			{
			}
		}

		[Token(Token = "0x1700000C")]
		public Color highlightedColor
		{
			[Token(Token = "0x6000031")]
			[Address(RVA = "0x2BFCA58", Offset = "0x2BFCA58", VA = "0x2BFCA58")]
			get
			{
				return default;
			}
			[Token(Token = "0x6000032")]
			[Address(RVA = "0x2BFCA64", Offset = "0x2BFCA64", VA = "0x2BFCA64")]
			set
			{
			}
		}

		[Token(Token = "0x1700000D")]
		public Color pressedColor
		{
			[Token(Token = "0x6000033")]
			[Address(RVA = "0x2BFCA70", Offset = "0x2BFCA70", VA = "0x2BFCA70")]
			get
			{
				return default;
			}
			[Token(Token = "0x6000034")]
			[Address(RVA = "0x2BFCA7C", Offset = "0x2BFCA7C", VA = "0x2BFCA7C")]
			set
			{
			}
		}

		[Token(Token = "0x1700000E")]
		public Color selectedColor
		{
			[Token(Token = "0x6000035")]
			[Address(RVA = "0x2BFCA88", Offset = "0x2BFCA88", VA = "0x2BFCA88")]
			get
			{
				return default;
			}
		}

		[Token(Token = "0x1700000F")]
		public Color disabledColor
		{
			[Token(Token = "0x6000036")]
			[Address(RVA = "0x2BFCA94", Offset = "0x2BFCA94", VA = "0x2BFCA94")]
			get
			{
				return default;
			}
			[Token(Token = "0x6000037")]
			[Address(RVA = "0x2BFCAA0", Offset = "0x2BFCAA0", VA = "0x2BFCAA0")]
			set
			{
			}
		}

		[Token(Token = "0x17000010")]
		public float colorMultiplier
		{
			[Token(Token = "0x6000038")]
			[Address(RVA = "0x2BFCAAC", Offset = "0x2BFCAAC", VA = "0x2BFCAAC")]
			get
			{
				return default;
			}
			[Token(Token = "0x6000039")]
			[Address(RVA = "0x2BFCAB4", Offset = "0x2BFCAB4", VA = "0x2BFCAB4")]
			set
			{
			}
		}

		[Token(Token = "0x17000011")]
		public float fadeDuration
		{
			[Token(Token = "0x600003A")]
			[Address(RVA = "0x2BFCABC", Offset = "0x2BFCABC", VA = "0x2BFCABC")]
			get
			{
				return default;
			}
			[Token(Token = "0x600003B")]
			[Address(RVA = "0x2BFCAC4", Offset = "0x2BFCAC4", VA = "0x2BFCAC4")]
			set
			{
			}
		}

		[Token(Token = "0x600003C")]
		[Address(RVA = "0x2BFCACC", Offset = "0x2BFCACC", VA = "0x2BFCACC")]
		static ColorBlock()
		{
		}

		[Token(Token = "0x600003D")]
		[Address(RVA = "0x2BFCC90", Offset = "0x2BFCC90", VA = "0x2BFCC90", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default;
		}

		[Token(Token = "0x600003E")]
		[Address(RVA = "0x2BFCD50", Offset = "0x2BFCD50", VA = "0x2BFCD50", Slot = "4")]
		public bool Equals(ColorBlock other)
		{
			return default;
		}

		[Token(Token = "0x600003F")]
		[Address(RVA = "0x2BFCE24", Offset = "0x2BFCE24", VA = "0x2BFCE24", Slot = "2")]
		public override int GetHashCode()
		{
			return default;
		}
	}
}
