using System;
using Il2CppDummyDll;

namespace UnityEngine.UI
{
	[Token(Token = "0x2000066")]
	[AttributeAttribute(Name = "RequireComponent", RVA = "0x1F6914", Offset = "0x1F6914")]
	public class Text : MaskableGraphic, ILayoutElement
	{
		[Token(Token = "0x4000219")]
		[FieldOffset(Offset = "0xD0")]
		[SerializeField]
		private FontData m_FontData;

		[Token(Token = "0x400021A")]
		[FieldOffset(Offset = "0xD8")]
		[SerializeField]
		protected string m_Text;

		[Token(Token = "0x400021B")]
		[FieldOffset(Offset = "0xE0")]
		private TextGenerator m_TextCache;

		[Token(Token = "0x400021C")]
		[FieldOffset(Offset = "0xE8")]
		private TextGenerator m_TextCacheForLayout;

		[Token(Token = "0x400021D")]
		[FieldOffset(Offset = "0x0")]
		protected static Material s_DefaultText;

		[NonSerialized]
		[Token(Token = "0x400021E")]
		[FieldOffset(Offset = "0xF0")]
		protected bool m_DisableFontTextureRebuiltCallback;

		[Token(Token = "0x400021F")]
		[FieldOffset(Offset = "0xF8")]
		private readonly UIVertex[] m_TempVerts;

		[Token(Token = "0x17000132")]
		public TextGenerator cachedTextGenerator
		{
			[Token(Token = "0x6000464")]
			[Address(RVA = "0x2C3F5B8", Offset = "0x2C3F5B8", VA = "0x2C3F5B8")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000133")]
		public TextGenerator cachedTextGeneratorForLayout
		{
			[Token(Token = "0x6000465")]
			[Address(RVA = "0x2C3F650", Offset = "0x2C3F650", VA = "0x2C3F650")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000134")]
		public override Texture mainTexture
		{
			[Token(Token = "0x6000466")]
			[Address(RVA = "0x2C3F6B8", Offset = "0x2C3F6B8", VA = "0x2C3F6B8", Slot = "35")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000135")]
		public Font font
		{
			[Token(Token = "0x6000468")]
			[Address(RVA = "0x2C3F8A8", Offset = "0x2C3F8A8", VA = "0x2C3F8A8")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000469")]
			[Address(RVA = "0x2C3FA0C", Offset = "0x2C3FA0C", VA = "0x2C3FA0C")]
			set
			{
			}
		}

		[Token(Token = "0x17000136")]
		public virtual string text
		{
			[Token(Token = "0x600046A")]
			[Address(RVA = "0x2C3FB50", Offset = "0x2C3FB50", VA = "0x2C3FB50", Slot = "70")]
			get
			{
				return null;
			}
			[Token(Token = "0x600046B")]
			[Address(RVA = "0x2C3FB58", Offset = "0x2C3FB58", VA = "0x2C3FB58", Slot = "71")]
			set
			{
			}
		}

		[Token(Token = "0x17000137")]
		public bool supportRichText
		{
			[Token(Token = "0x600046C")]
			[Address(RVA = "0x2C3FC30", Offset = "0x2C3FC30", VA = "0x2C3FC30")]
			get
			{
				return default;
			}
			[Token(Token = "0x600046D")]
			[Address(RVA = "0x2C3FC4C", Offset = "0x2C3FC4C", VA = "0x2C3FC4C")]
			set
			{
			}
		}

		[Token(Token = "0x17000138")]
		public bool resizeTextForBestFit
		{
			[Token(Token = "0x600046E")]
			[Address(RVA = "0x2C3FCB0", Offset = "0x2C3FCB0", VA = "0x2C3FCB0")]
			get
			{
				return default;
			}
			[Token(Token = "0x600046F")]
			[Address(RVA = "0x2C3FCCC", Offset = "0x2C3FCCC", VA = "0x2C3FCCC")]
			set
			{
			}
		}

		[Token(Token = "0x17000139")]
		public int resizeTextMinSize
		{
			[Token(Token = "0x6000470")]
			[Address(RVA = "0x2C3FD30", Offset = "0x2C3FD30", VA = "0x2C3FD30")]
			get
			{
				return default;
			}
			[Token(Token = "0x6000471")]
			[Address(RVA = "0x2C3FD4C", Offset = "0x2C3FD4C", VA = "0x2C3FD4C")]
			set
			{
			}
		}

		[Token(Token = "0x1700013A")]
		public int resizeTextMaxSize
		{
			[Token(Token = "0x6000472")]
			[Address(RVA = "0x2C3FDB0", Offset = "0x2C3FDB0", VA = "0x2C3FDB0")]
			get
			{
				return default;
			}
			[Token(Token = "0x6000473")]
			[Address(RVA = "0x2C3FDCC", Offset = "0x2C3FDCC", VA = "0x2C3FDCC")]
			set
			{
			}
		}

		[Token(Token = "0x1700013B")]
		public TextAnchor alignment
		{
			[Token(Token = "0x6000474")]
			[Address(RVA = "0x2C3FE30", Offset = "0x2C3FE30", VA = "0x2C3FE30")]
			get
			{
				return default;
			}
			[Token(Token = "0x6000475")]
			[Address(RVA = "0x2C3FE4C", Offset = "0x2C3FE4C", VA = "0x2C3FE4C")]
			set
			{
			}
		}

		[Token(Token = "0x1700013C")]
		public bool alignByGeometry
		{
			[Token(Token = "0x6000476")]
			[Address(RVA = "0x2C3FEB0", Offset = "0x2C3FEB0", VA = "0x2C3FEB0")]
			get
			{
				return default;
			}
			[Token(Token = "0x6000477")]
			[Address(RVA = "0x2C3FECC", Offset = "0x2C3FECC", VA = "0x2C3FECC")]
			set
			{
			}
		}

		[Token(Token = "0x1700013D")]
		public int fontSize
		{
			[Token(Token = "0x6000478")]
			[Address(RVA = "0x2C3FF04", Offset = "0x2C3FF04", VA = "0x2C3FF04")]
			get
			{
				return default;
			}
			[Token(Token = "0x6000479")]
			[Address(RVA = "0x2C3FF20", Offset = "0x2C3FF20", VA = "0x2C3FF20")]
			set
			{
			}
		}

		[Token(Token = "0x1700013E")]
		public HorizontalWrapMode horizontalOverflow
		{
			[Token(Token = "0x600047A")]
			[Address(RVA = "0x2C3FF84", Offset = "0x2C3FF84", VA = "0x2C3FF84")]
			get
			{
				return default;
			}
			[Token(Token = "0x600047B")]
			[Address(RVA = "0x2C3FFA0", Offset = "0x2C3FFA0", VA = "0x2C3FFA0")]
			set
			{
			}
		}

		[Token(Token = "0x1700013F")]
		public VerticalWrapMode verticalOverflow
		{
			[Token(Token = "0x600047C")]
			[Address(RVA = "0x2C40004", Offset = "0x2C40004", VA = "0x2C40004")]
			get
			{
				return default;
			}
			[Token(Token = "0x600047D")]
			[Address(RVA = "0x2C40020", Offset = "0x2C40020", VA = "0x2C40020")]
			set
			{
			}
		}

		[Token(Token = "0x17000140")]
		public float lineSpacing
		{
			[Token(Token = "0x600047E")]
			[Address(RVA = "0x2C40084", Offset = "0x2C40084", VA = "0x2C40084")]
			get
			{
				return default;
			}
			[Token(Token = "0x600047F")]
			[Address(RVA = "0x2C400A0", Offset = "0x2C400A0", VA = "0x2C400A0")]
			set
			{
			}
		}

		[Token(Token = "0x17000141")]
		public FontStyle fontStyle
		{
			[Token(Token = "0x6000480")]
			[Address(RVA = "0x2C40104", Offset = "0x2C40104", VA = "0x2C40104")]
			get
			{
				return default;
			}
			[Token(Token = "0x6000481")]
			[Address(RVA = "0x2C40120", Offset = "0x2C40120", VA = "0x2C40120")]
			set
			{
			}
		}

		[Token(Token = "0x17000142")]
		public float pixelsPerUnit
		{
			[Token(Token = "0x6000482")]
			[Address(RVA = "0x2C40184", Offset = "0x2C40184", VA = "0x2C40184")]
			get
			{
				return default;
			}
		}

		[Token(Token = "0x17000143")]
		public virtual float minWidth
		{
			[Token(Token = "0x600048C")]
			[Address(RVA = "0x2C40EE4", Offset = "0x2C40EE4", VA = "0x2C40EE4", Slot = "74")]
			get
			{
				return default;
			}
		}

		[Token(Token = "0x17000144")]
		public virtual float preferredWidth
		{
			[Token(Token = "0x600048D")]
			[Address(RVA = "0x2C40EEC", Offset = "0x2C40EEC", VA = "0x2C40EEC", Slot = "75")]
			get
			{
				return default;
			}
		}

		[Token(Token = "0x17000145")]
		public virtual float flexibleWidth
		{
			[Token(Token = "0x600048E")]
			[Address(RVA = "0x2C40FC4", Offset = "0x2C40FC4", VA = "0x2C40FC4", Slot = "76")]
			get
			{
				return default;
			}
		}

		[Token(Token = "0x17000146")]
		public virtual float minHeight
		{
			[Token(Token = "0x600048F")]
			[Address(RVA = "0x2C40FCC", Offset = "0x2C40FCC", VA = "0x2C40FCC", Slot = "77")]
			get
			{
				return default;
			}
		}

		[Token(Token = "0x17000147")]
		public virtual float preferredHeight
		{
			[Token(Token = "0x6000490")]
			[Address(RVA = "0x2C40FD4", Offset = "0x2C40FD4", VA = "0x2C40FD4", Slot = "78")]
			get
			{
				return default;
			}
		}

		[Token(Token = "0x17000148")]
		public virtual float flexibleHeight
		{
			[Token(Token = "0x6000491")]
			[Address(RVA = "0x2C410D0", Offset = "0x2C410D0", VA = "0x2C410D0", Slot = "79")]
			get
			{
				return default;
			}
		}

		[Token(Token = "0x17000149")]
		public virtual int layoutPriority
		{
			[Token(Token = "0x6000492")]
			[Address(RVA = "0x2C410D8", Offset = "0x2C410D8", VA = "0x2C410D8", Slot = "80")]
			get
			{
				return default;
			}
		}

		[Token(Token = "0x6000463")]
		[Address(RVA = "0x2C3F520", Offset = "0x2C3F520", VA = "0x2C3F520")]
		protected Text()
		{
		}

		[Token(Token = "0x6000467")]
		[Address(RVA = "0x2C3F8C4", Offset = "0x2C3F8C4", VA = "0x2C3F8C4")]
		public void FontTextureChanged()
		{
		}

		[Token(Token = "0x6000483")]
		[Address(RVA = "0x2C402F0", Offset = "0x2C402F0", VA = "0x2C402F0", Slot = "5")]
		protected override void OnEnable()
		{
		}

		[Token(Token = "0x6000484")]
		[Address(RVA = "0x2C40378", Offset = "0x2C40378", VA = "0x2C40378", Slot = "7")]
		protected override void OnDisable()
		{
		}

		[Token(Token = "0x6000485")]
		[Address(RVA = "0x2C403F0", Offset = "0x2C403F0", VA = "0x2C403F0", Slot = "41")]
		protected override void UpdateGeometry()
		{
		}

		[Token(Token = "0x6000486")]
		[Address(RVA = "0x2C4048C", Offset = "0x2C4048C", VA = "0x2C4048C")]
		internal void AssignDefaultFont()
		{
		}

		[Token(Token = "0x6000487")]
		[Address(RVA = "0x2C40500", Offset = "0x2C40500", VA = "0x2C40500")]
		public TextGenerationSettings GetGenerationSettings(Vector2 extents)
		{
			return default;
		}

		[Token(Token = "0x6000488")]
		[Address(RVA = "0x2C406D4", Offset = "0x2C406D4", VA = "0x2C406D4")]
		public static Vector2 GetTextAnchorPivot(TextAnchor anchor)
		{
			return default;
		}

		[Token(Token = "0x6000489")]
		[Address(RVA = "0x2C4075C", Offset = "0x2C4075C", VA = "0x2C4075C", Slot = "43")]
		protected override void OnPopulateMesh(VertexHelper toFill)
		{
		}

		[Token(Token = "0x600048A")]
		[Address(RVA = "0x2C40EDC", Offset = "0x2C40EDC", VA = "0x2C40EDC", Slot = "72")]
		public virtual void CalculateLayoutInputHorizontal()
		{
		}

		[Token(Token = "0x600048B")]
		[Address(RVA = "0x2C40EE0", Offset = "0x2C40EE0", VA = "0x2C40EE0", Slot = "73")]
		public virtual void CalculateLayoutInputVertical()
		{
		}
	}
}
