using System;
using Il2CppDummyDll;

namespace UnityEngine.UI
{
	[Serializable]
	[Token(Token = "0x2000016")]
	public class FontData : ISerializationCallbackReceiver
	{
		[Token(Token = "0x4000048")]
		[FieldOffset(Offset = "0x10")]
		[AttributeAttribute(Name = "FormerlySerializedAsAttribute", RVA = "0x1F7108", Offset = "0x1F7108")]
		[SerializeField]
		private Font m_Font;

		[Token(Token = "0x4000049")]
		[FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "FormerlySerializedAsAttribute", RVA = "0x1F7154", Offset = "0x1F7154")]
		[SerializeField]
		private int m_FontSize;

		[Token(Token = "0x400004A")]
		[FieldOffset(Offset = "0x1C")]
		[AttributeAttribute(Name = "FormerlySerializedAsAttribute", RVA = "0x1F71A0", Offset = "0x1F71A0")]
		[SerializeField]
		private FontStyle m_FontStyle;

		[Token(Token = "0x400004B")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private bool m_BestFit;

		[Token(Token = "0x400004C")]
		[FieldOffset(Offset = "0x24")]
		[SerializeField]
		private int m_MinSize;

		[Token(Token = "0x400004D")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private int m_MaxSize;

		[Token(Token = "0x400004E")]
		[FieldOffset(Offset = "0x2C")]
		[AttributeAttribute(Name = "FormerlySerializedAsAttribute", RVA = "0x1F721C", Offset = "0x1F721C")]
		[SerializeField]
		private TextAnchor m_Alignment;

		[Token(Token = "0x400004F")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private bool m_AlignByGeometry;

		[Token(Token = "0x4000050")]
		[FieldOffset(Offset = "0x31")]
		[AttributeAttribute(Name = "FormerlySerializedAsAttribute", RVA = "0x1F7278", Offset = "0x1F7278")]
		[SerializeField]
		private bool m_RichText;

		[Token(Token = "0x4000051")]
		[FieldOffset(Offset = "0x34")]
		[SerializeField]
		private HorizontalWrapMode m_HorizontalOverflow;

		[Token(Token = "0x4000052")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private VerticalWrapMode m_VerticalOverflow;

		[Token(Token = "0x4000053")]
		[FieldOffset(Offset = "0x3C")]
		[SerializeField]
		private float m_LineSpacing;

		[Token(Token = "0x17000026")]
		public static FontData defaultFontData
		{
			[Token(Token = "0x600009E")]
			[Address(RVA = "0x2C045C4", Offset = "0x2C045C4", VA = "0x2C045C4")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000027")]
		public Font font
		{
			[Token(Token = "0x600009F")]
			[Address(RVA = "0x2C0465C", Offset = "0x2C0465C", VA = "0x2C0465C")]
			get
			{
				return null;
			}
			[Token(Token = "0x60000A0")]
			[Address(RVA = "0x2C04664", Offset = "0x2C04664", VA = "0x2C04664")]
			set
			{
			}
		}

		[Token(Token = "0x17000028")]
		public int fontSize
		{
			[Token(Token = "0x60000A1")]
			[Address(RVA = "0x2C0466C", Offset = "0x2C0466C", VA = "0x2C0466C")]
			get
			{
				return default;
			}
			[Token(Token = "0x60000A2")]
			[Address(RVA = "0x2C04674", Offset = "0x2C04674", VA = "0x2C04674")]
			set
			{
			}
		}

		[Token(Token = "0x17000029")]
		public FontStyle fontStyle
		{
			[Token(Token = "0x60000A3")]
			[Address(RVA = "0x2C0467C", Offset = "0x2C0467C", VA = "0x2C0467C")]
			get
			{
				return default;
			}
			[Token(Token = "0x60000A4")]
			[Address(RVA = "0x2C04684", Offset = "0x2C04684", VA = "0x2C04684")]
			set
			{
			}
		}

		[Token(Token = "0x1700002A")]
		public bool bestFit
		{
			[Token(Token = "0x60000A5")]
			[Address(RVA = "0x2C0468C", Offset = "0x2C0468C", VA = "0x2C0468C")]
			get
			{
				return default;
			}
			[Token(Token = "0x60000A6")]
			[Address(RVA = "0x2C04694", Offset = "0x2C04694", VA = "0x2C04694")]
			set
			{
			}
		}

		[Token(Token = "0x1700002B")]
		public int minSize
		{
			[Token(Token = "0x60000A7")]
			[Address(RVA = "0x2C0469C", Offset = "0x2C0469C", VA = "0x2C0469C")]
			get
			{
				return default;
			}
			[Token(Token = "0x60000A8")]
			[Address(RVA = "0x2C046A4", Offset = "0x2C046A4", VA = "0x2C046A4")]
			set
			{
			}
		}

		[Token(Token = "0x1700002C")]
		public int maxSize
		{
			[Token(Token = "0x60000A9")]
			[Address(RVA = "0x2C046AC", Offset = "0x2C046AC", VA = "0x2C046AC")]
			get
			{
				return default;
			}
			[Token(Token = "0x60000AA")]
			[Address(RVA = "0x2C046B4", Offset = "0x2C046B4", VA = "0x2C046B4")]
			set
			{
			}
		}

		[Token(Token = "0x1700002D")]
		public TextAnchor alignment
		{
			[Token(Token = "0x60000AB")]
			[Address(RVA = "0x2C046BC", Offset = "0x2C046BC", VA = "0x2C046BC")]
			get
			{
				return default;
			}
			[Token(Token = "0x60000AC")]
			[Address(RVA = "0x2C046C4", Offset = "0x2C046C4", VA = "0x2C046C4")]
			set
			{
			}
		}

		[Token(Token = "0x1700002E")]
		public bool alignByGeometry
		{
			[Token(Token = "0x60000AD")]
			[Address(RVA = "0x2C046CC", Offset = "0x2C046CC", VA = "0x2C046CC")]
			get
			{
				return default;
			}
			[Token(Token = "0x60000AE")]
			[Address(RVA = "0x2C046D4", Offset = "0x2C046D4", VA = "0x2C046D4")]
			set
			{
			}
		}

		[Token(Token = "0x1700002F")]
		public bool richText
		{
			[Token(Token = "0x60000AF")]
			[Address(RVA = "0x2C046DC", Offset = "0x2C046DC", VA = "0x2C046DC")]
			get
			{
				return default;
			}
			[Token(Token = "0x60000B0")]
			[Address(RVA = "0x2C046E4", Offset = "0x2C046E4", VA = "0x2C046E4")]
			set
			{
			}
		}

		[Token(Token = "0x17000030")]
		public HorizontalWrapMode horizontalOverflow
		{
			[Token(Token = "0x60000B1")]
			[Address(RVA = "0x2C046EC", Offset = "0x2C046EC", VA = "0x2C046EC")]
			get
			{
				return default;
			}
			[Token(Token = "0x60000B2")]
			[Address(RVA = "0x2C046F4", Offset = "0x2C046F4", VA = "0x2C046F4")]
			set
			{
			}
		}

		[Token(Token = "0x17000031")]
		public VerticalWrapMode verticalOverflow
		{
			[Token(Token = "0x60000B3")]
			[Address(RVA = "0x2C046FC", Offset = "0x2C046FC", VA = "0x2C046FC")]
			get
			{
				return default;
			}
			[Token(Token = "0x60000B4")]
			[Address(RVA = "0x2C04704", Offset = "0x2C04704", VA = "0x2C04704")]
			set
			{
			}
		}

		[Token(Token = "0x17000032")]
		public float lineSpacing
		{
			[Token(Token = "0x60000B5")]
			[Address(RVA = "0x2C0470C", Offset = "0x2C0470C", VA = "0x2C0470C")]
			get
			{
				return default;
			}
			[Token(Token = "0x60000B6")]
			[Address(RVA = "0x2C04714", Offset = "0x2C04714", VA = "0x2C04714")]
			set
			{
			}
		}

		[Token(Token = "0x60000B7")]
		[Address(RVA = "0x2C0471C", Offset = "0x2C0471C", VA = "0x2C0471C", Slot = "4")]
		private void UnityEngine_002EISerializationCallbackReceiver_002EOnBeforeSerialize()
		{
		}

		[Token(Token = "0x60000B8")]
		[Address(RVA = "0x2C04720", Offset = "0x2C04720", VA = "0x2C04720", Slot = "5")]
		private void UnityEngine_002EISerializationCallbackReceiver_002EOnAfterDeserialize()
		{
		}

		[Token(Token = "0x60000B9")]
		[Address(RVA = "0x2C04654", Offset = "0x2C04654", VA = "0x2C04654")]
		public FontData()
		{
		}
	}
}
