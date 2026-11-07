using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine.U2D;

namespace UnityEngine.UI
{
	[Token(Token = "0x200001E")]
	[AttributeAttribute(Name = "RequireComponent", RVA = "0x1F627C", Offset = "0x1F627C")]
	public class Image : MaskableGraphic, ISerializationCallbackReceiver, ILayoutElement, ICanvasRaycastFilter
	{
		[Token(Token = "0x200001F")]
		public enum Type
		{
			[Token(Token = "0x4000094")]
			Simple = 0,
			[Token(Token = "0x4000095")]
			Sliced = 1,
			[Token(Token = "0x4000096")]
			Tiled = 2,
			[Token(Token = "0x4000097")]
			Filled = 3
		}

		[Token(Token = "0x2000020")]
		public enum FillMethod
		{
			[Token(Token = "0x4000099")]
			Horizontal = 0,
			[Token(Token = "0x400009A")]
			Vertical = 1,
			[Token(Token = "0x400009B")]
			Radial90 = 2,
			[Token(Token = "0x400009C")]
			Radial180 = 3,
			[Token(Token = "0x400009D")]
			Radial360 = 4
		}

		[Token(Token = "0x400007E")]
		[FieldOffset(Offset = "0x0")]
		protected static Material s_ETC1DefaultUI;

		[Token(Token = "0x400007F")]
		[FieldOffset(Offset = "0xD0")]
		[SerializeField]
		[AttributeAttribute(Name = "FormerlySerializedAsAttribute", RVA = "0x1F7428", Offset = "0x1F7428")]
		private Sprite m_Sprite;

		[NonSerialized]
		[Token(Token = "0x4000080")]
		[FieldOffset(Offset = "0xD8")]
		private Sprite m_OverrideSprite;

		[Token(Token = "0x4000081")]
		[FieldOffset(Offset = "0xE0")]
		[SerializeField]
		private Type m_Type;

		[Token(Token = "0x4000082")]
		[FieldOffset(Offset = "0xE4")]
		[SerializeField]
		private bool m_PreserveAspect;

		[Token(Token = "0x4000083")]
		[FieldOffset(Offset = "0xE5")]
		[SerializeField]
		private bool m_FillCenter;

		[Token(Token = "0x4000084")]
		[FieldOffset(Offset = "0xE8")]
		[SerializeField]
		private FillMethod m_FillMethod;

		[Token(Token = "0x4000085")]
		[FieldOffset(Offset = "0xEC")]
		[SerializeField]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x1F74B4", Offset = "0x1F74B4")]
		private float m_FillAmount;

		[Token(Token = "0x4000086")]
		[FieldOffset(Offset = "0xF0")]
		[SerializeField]
		private bool m_FillClockwise;

		[Token(Token = "0x4000087")]
		[FieldOffset(Offset = "0xF4")]
		[SerializeField]
		private int m_FillOrigin;

		[Token(Token = "0x4000088")]
		[FieldOffset(Offset = "0xF8")]
		private float m_AlphaHitTestMinimumThreshold;

		[Token(Token = "0x4000089")]
		[FieldOffset(Offset = "0xFC")]
		private bool m_Tracked;

		[Token(Token = "0x400008A")]
		[FieldOffset(Offset = "0xFD")]
		[SerializeField]
		private bool m_UseSpriteMesh;

		[Token(Token = "0x400008B")]
		[FieldOffset(Offset = "0x100")]
		[SerializeField]
		private float m_PixelsPerUnitMultiplier;

		[Token(Token = "0x400008C")]
		[FieldOffset(Offset = "0x104")]
		private float m_CachedReferencePixelsPerUnit;

		[Token(Token = "0x400008D")]
		[FieldOffset(Offset = "0x8")]
		private static readonly Vector2[] s_VertScratch;

		[Token(Token = "0x400008E")]
		[FieldOffset(Offset = "0x10")]
		private static readonly Vector2[] s_UVScratch;

		[Token(Token = "0x400008F")]
		[FieldOffset(Offset = "0x18")]
		private static readonly Vector3[] s_Xy;

		[Token(Token = "0x4000090")]
		[FieldOffset(Offset = "0x20")]
		private static readonly Vector3[] s_Uv;

		[Token(Token = "0x4000091")]
		[FieldOffset(Offset = "0x28")]
		private static List<Image> m_TrackedTexturelessImages;

		[Token(Token = "0x4000092")]
		[FieldOffset(Offset = "0x30")]
		private static bool s_Initialized;

		[Token(Token = "0x17000049")]
		public Sprite sprite
		{
			[Token(Token = "0x6000116")]
			[Address(RVA = "0x2C0CA28", Offset = "0x2C0CA28", VA = "0x2C0CA28")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000117")]
			[Address(RVA = "0x2BFDF8C", Offset = "0x2BFDF8C", VA = "0x2BFDF8C")]
			set
			{
			}
		}

		[Token(Token = "0x1700004A")]
		public Sprite overrideSprite
		{
			[Token(Token = "0x6000119")]
			[Address(RVA = "0x2C0CC0C", Offset = "0x2C0CC0C", VA = "0x2C0CC0C")]
			get
			{
				return null;
			}
			[Token(Token = "0x600011A")]
			[Address(RVA = "0x2C0CD34", Offset = "0x2C0CD34", VA = "0x2C0CD34")]
			set
			{
			}
		}

		[Token(Token = "0x1700004B")]
		private Sprite activeSprite
		{
			[Token(Token = "0x600011B")]
			[Address(RVA = "0x2C0CCA0", Offset = "0x2C0CCA0", VA = "0x2C0CCA0")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700004C")]
		public Type type
		{
			[Token(Token = "0x600011C")]
			[Address(RVA = "0x2C0CDC0", Offset = "0x2C0CDC0", VA = "0x2C0CDC0")]
			get
			{
				return default;
			}
			[Token(Token = "0x600011D")]
			[Address(RVA = "0x2C0CDC8", Offset = "0x2C0CDC8", VA = "0x2C0CDC8")]
			set
			{
			}
		}

		[Token(Token = "0x1700004D")]
		public bool preserveAspect
		{
			[Token(Token = "0x600011E")]
			[Address(RVA = "0x2C0CE4C", Offset = "0x2C0CE4C", VA = "0x2C0CE4C")]
			get
			{
				return default;
			}
			[Token(Token = "0x600011F")]
			[Address(RVA = "0x2C0CE54", Offset = "0x2C0CE54", VA = "0x2C0CE54")]
			set
			{
			}
		}

		[Token(Token = "0x1700004E")]
		public bool fillCenter
		{
			[Token(Token = "0x6000120")]
			[Address(RVA = "0x2C0CED8", Offset = "0x2C0CED8", VA = "0x2C0CED8")]
			get
			{
				return default;
			}
			[Token(Token = "0x6000121")]
			[Address(RVA = "0x2C0CEE0", Offset = "0x2C0CEE0", VA = "0x2C0CEE0")]
			set
			{
			}
		}

		[Token(Token = "0x1700004F")]
		public FillMethod fillMethod
		{
			[Token(Token = "0x6000122")]
			[Address(RVA = "0x2C0CF64", Offset = "0x2C0CF64", VA = "0x2C0CF64")]
			get
			{
				return default;
			}
			[Token(Token = "0x6000123")]
			[Address(RVA = "0x2C0CF6C", Offset = "0x2C0CF6C", VA = "0x2C0CF6C")]
			set
			{
			}
		}

		[Token(Token = "0x17000050")]
		public float fillAmount
		{
			[Token(Token = "0x6000124")]
			[Address(RVA = "0x2C0CFE8", Offset = "0x2C0CFE8", VA = "0x2C0CFE8")]
			get
			{
				return default;
			}
			[Token(Token = "0x6000125")]
			[Address(RVA = "0x2C0CFF0", Offset = "0x2C0CFF0", VA = "0x2C0CFF0")]
			set
			{
			}
		}

		[Token(Token = "0x17000051")]
		public bool fillClockwise
		{
			[Token(Token = "0x6000126")]
			[Address(RVA = "0x2C0D088", Offset = "0x2C0D088", VA = "0x2C0D088")]
			get
			{
				return default;
			}
			[Token(Token = "0x6000127")]
			[Address(RVA = "0x2C0D090", Offset = "0x2C0D090", VA = "0x2C0D090")]
			set
			{
			}
		}

		[Token(Token = "0x17000052")]
		public int fillOrigin
		{
			[Token(Token = "0x6000128")]
			[Address(RVA = "0x2C0D114", Offset = "0x2C0D114", VA = "0x2C0D114")]
			get
			{
				return default;
			}
			[Token(Token = "0x6000129")]
			[Address(RVA = "0x2C0D11C", Offset = "0x2C0D11C", VA = "0x2C0D11C")]
			set
			{
			}
		}

		[Token(Token = "0x17000053")]
		[AttributeAttribute(Name = "ObsoleteAttribute", RVA = "0x1F8DAC", Offset = "0x1F8DAC")]
		public float eventAlphaThreshold
		{
			[Token(Token = "0x600012A")]
			[Address(RVA = "0x2C0D1A0", Offset = "0x2C0D1A0", VA = "0x2C0D1A0")]
			get
			{
				return default;
			}
			[Token(Token = "0x600012B")]
			[Address(RVA = "0x2C0D1B0", Offset = "0x2C0D1B0", VA = "0x2C0D1B0")]
			set
			{
			}
		}

		[Token(Token = "0x17000054")]
		public float alphaHitTestMinimumThreshold
		{
			[Token(Token = "0x600012C")]
			[Address(RVA = "0x2C0D1C0", Offset = "0x2C0D1C0", VA = "0x2C0D1C0")]
			get
			{
				return default;
			}
			[Token(Token = "0x600012D")]
			[Address(RVA = "0x2C0D1C8", Offset = "0x2C0D1C8", VA = "0x2C0D1C8")]
			set
			{
			}
		}

		[Token(Token = "0x17000055")]
		public bool useSpriteMesh
		{
			[Token(Token = "0x600012E")]
			[Address(RVA = "0x2C0D1D0", Offset = "0x2C0D1D0", VA = "0x2C0D1D0")]
			get
			{
				return default;
			}
			[Token(Token = "0x600012F")]
			[Address(RVA = "0x2C0D1D8", Offset = "0x2C0D1D8", VA = "0x2C0D1D8")]
			set
			{
			}
		}

		[Token(Token = "0x17000056")]
		public static Material defaultETC1GraphicMaterial
		{
			[Token(Token = "0x6000131")]
			[Address(RVA = "0x2C0D2A8", Offset = "0x2C0D2A8", VA = "0x2C0D2A8")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000057")]
		public override Texture mainTexture
		{
			[Token(Token = "0x6000132")]
			[Address(RVA = "0x2C0D3B0", Offset = "0x2C0D3B0", VA = "0x2C0D3B0", Slot = "35")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000058")]
		public bool hasBorder
		{
			[Token(Token = "0x6000133")]
			[Address(RVA = "0x2C0D628", Offset = "0x2C0D628", VA = "0x2C0D628")]
			get
			{
				return default;
			}
		}

		[Token(Token = "0x17000059")]
		public float pixelsPerUnitMultiplier
		{
			[Token(Token = "0x6000134")]
			[Address(RVA = "0x2C0D7B4", Offset = "0x2C0D7B4", VA = "0x2C0D7B4")]
			get
			{
				return default;
			}
			[Token(Token = "0x6000135")]
			[Address(RVA = "0x2C0D7BC", Offset = "0x2C0D7BC", VA = "0x2C0D7BC")]
			set
			{
			}
		}

		[Token(Token = "0x1700005A")]
		public float pixelsPerUnit
		{
			[Token(Token = "0x6000136")]
			[Address(RVA = "0x2C0D804", Offset = "0x2C0D804", VA = "0x2C0D804")]
			get
			{
				return default;
			}
		}

		[Token(Token = "0x1700005B")]
		protected float multipliedPixelsPerUnit
		{
			[Token(Token = "0x6000137")]
			[Address(RVA = "0x2C0DA88", Offset = "0x2C0DA88", VA = "0x2C0DA88")]
			get
			{
				return default;
			}
		}

		[Token(Token = "0x1700005C")]
		public override Material material
		{
			[Token(Token = "0x6000138")]
			[Address(RVA = "0x2C0DAB0", Offset = "0x2C0DAB0", VA = "0x2C0DAB0", Slot = "32")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000139")]
			[Address(RVA = "0x2C0DCE4", Offset = "0x2C0DCE4", VA = "0x2C0DCE4", Slot = "33")]
			set
			{
			}
		}

		[Token(Token = "0x1700005D")]
		public virtual float minWidth
		{
			[Token(Token = "0x6000151")]
			[Address(RVA = "0x2C12B3C", Offset = "0x2C12B3C", VA = "0x2C12B3C", Slot = "77")]
			get
			{
				return default;
			}
		}

		[Token(Token = "0x1700005E")]
		public virtual float preferredWidth
		{
			[Token(Token = "0x6000152")]
			[Address(RVA = "0x2C12B44", Offset = "0x2C12B44", VA = "0x2C12B44", Slot = "78")]
			get
			{
				return default;
			}
		}

		[Token(Token = "0x1700005F")]
		public virtual float flexibleWidth
		{
			[Token(Token = "0x6000153")]
			[Address(RVA = "0x2C12D58", Offset = "0x2C12D58", VA = "0x2C12D58", Slot = "79")]
			get
			{
				return default;
			}
		}

		[Token(Token = "0x17000060")]
		public virtual float minHeight
		{
			[Token(Token = "0x6000154")]
			[Address(RVA = "0x2C12D60", Offset = "0x2C12D60", VA = "0x2C12D60", Slot = "80")]
			get
			{
				return default;
			}
		}

		[Token(Token = "0x17000061")]
		public virtual float preferredHeight
		{
			[Token(Token = "0x6000155")]
			[Address(RVA = "0x2C12D68", Offset = "0x2C12D68", VA = "0x2C12D68", Slot = "81")]
			get
			{
				return default;
			}
		}

		[Token(Token = "0x17000062")]
		public virtual float flexibleHeight
		{
			[Token(Token = "0x6000156")]
			[Address(RVA = "0x2C12F7C", Offset = "0x2C12F7C", VA = "0x2C12F7C", Slot = "82")]
			get
			{
				return default;
			}
		}

		[Token(Token = "0x17000063")]
		public virtual int layoutPriority
		{
			[Token(Token = "0x6000157")]
			[Address(RVA = "0x2C12F84", Offset = "0x2C12F84", VA = "0x2C12F84", Slot = "83")]
			get
			{
				return default;
			}
		}

		[Token(Token = "0x6000118")]
		[Address(RVA = "0x2C0CC04", Offset = "0x2C0CC04", VA = "0x2C0CC04")]
		public void DisableSpriteOptimizations()
		{
		}

		[Token(Token = "0x6000130")]
		[Address(RVA = "0x2C0D25C", Offset = "0x2C0D25C", VA = "0x2C0D25C")]
		protected Image()
		{
		}

		[Token(Token = "0x600013A")]
		[Address(RVA = "0x2C0DD90", Offset = "0x2C0DD90", VA = "0x2C0DD90", Slot = "73")]
		public virtual void OnBeforeSerialize()
		{
		}

		[Token(Token = "0x600013B")]
		[Address(RVA = "0x2C0DD94", Offset = "0x2C0DD94", VA = "0x2C0DD94", Slot = "74")]
		public virtual void OnAfterDeserialize()
		{
		}

		[Token(Token = "0x600013C")]
		[Address(RVA = "0x2C0DDE8", Offset = "0x2C0DDE8", VA = "0x2C0DDE8")]
		private void PreserveSpriteAspectRatio(ref Rect rect, Vector2 spriteSize)
		{
		}

		[Token(Token = "0x600013D")]
		[Address(RVA = "0x2C0DFF0", Offset = "0x2C0DFF0", VA = "0x2C0DFF0")]
		private Vector4 GetDrawingDimensions(bool shouldPreserveAspect)
		{
			return default;
		}

		[Token(Token = "0x600013E")]
		[Address(RVA = "0x2C0E49C", Offset = "0x2C0E49C", VA = "0x2C0E49C", Slot = "44")]
		public override void SetNativeSize()
		{
		}

		[Token(Token = "0x600013F")]
		[Address(RVA = "0x2C0E7F8", Offset = "0x2C0E7F8", VA = "0x2C0E7F8", Slot = "43")]
		protected override void OnPopulateMesh(VertexHelper toFill)
		{
		}

		[Token(Token = "0x6000140")]
		[Address(RVA = "0x2C0CA30", Offset = "0x2C0CA30", VA = "0x2C0CA30")]
		private void TrackSprite()
		{
		}

		[Token(Token = "0x6000141")]
		[Address(RVA = "0x2C11B60", Offset = "0x2C11B60", VA = "0x2C11B60", Slot = "5")]
		protected override void OnEnable()
		{
		}

		[Token(Token = "0x6000142")]
		[Address(RVA = "0x2C11B88", Offset = "0x2C11B88", VA = "0x2C11B88", Slot = "7")]
		protected override void OnDisable()
		{
		}

		[Token(Token = "0x6000143")]
		[Address(RVA = "0x2C11CA0", Offset = "0x2C11CA0", VA = "0x2C11CA0", Slot = "40")]
		protected override void UpdateMaterial()
		{
		}

		[Token(Token = "0x6000144")]
		[Address(RVA = "0x2C11E78", Offset = "0x2C11E78", VA = "0x2C11E78", Slot = "15")]
		protected override void OnCanvasHierarchyChanged()
		{
		}

		[Token(Token = "0x6000145")]
		[Address(RVA = "0x2C0E9B4", Offset = "0x2C0E9B4", VA = "0x2C0E9B4")]
		private void GenerateSimpleSprite(VertexHelper vh, bool lPreserveAspect)
		{
		}

		[Token(Token = "0x6000146")]
		[Address(RVA = "0x2C0ED8C", Offset = "0x2C0ED8C", VA = "0x2C0ED8C")]
		private void GenerateSprite(VertexHelper vh, bool lPreserveAspect)
		{
		}

		[Token(Token = "0x6000147")]
		[Address(RVA = "0x2C0F410", Offset = "0x2C0F410", VA = "0x2C0F410")]
		private void GenerateSlicedSprite(VertexHelper toFill)
		{
		}

		[Token(Token = "0x6000148")]
		[Address(RVA = "0x2C0FB90", Offset = "0x2C0FB90", VA = "0x2C0FB90")]
		private void GenerateTiledSprite(VertexHelper toFill)
		{
		}

		[Token(Token = "0x6000149")]
		[Address(RVA = "0x2C124C8", Offset = "0x2C124C8", VA = "0x2C124C8")]
		private static void AddQuad(VertexHelper vertexHelper, Vector3[] quadPositions, Color32 color, Vector3[] quadUVs)
		{
		}

		[Token(Token = "0x600014A")]
		[Address(RVA = "0x2C122EC", Offset = "0x2C122EC", VA = "0x2C122EC")]
		private static void AddQuad(VertexHelper vertexHelper, Vector2 posMin, Vector2 posMax, Color32 color, Vector2 uvMin, Vector2 uvMax)
		{
		}

		[Token(Token = "0x600014B")]
		[Address(RVA = "0x2C120A4", Offset = "0x2C120A4", VA = "0x2C120A4")]
		private Vector4 GetAdjustedBorders(Vector4 border, Rect adjustedRect)
		{
			return default;
		}

		[Token(Token = "0x600014C")]
		[Address(RVA = "0x2C10DD4", Offset = "0x2C10DD4", VA = "0x2C10DD4")]
		private void GenerateFilledSprite(VertexHelper toFill, bool preserveAspect)
		{
		}

		[Token(Token = "0x600014D")]
		[Address(RVA = "0x2C125F4", Offset = "0x2C125F4", VA = "0x2C125F4")]
		private static bool RadialCut(Vector3[] xy, Vector3[] uv, float fill, bool invert, int corner)
		{
			return default;
		}

		[Token(Token = "0x600014E")]
		[Address(RVA = "0x2C1272C", Offset = "0x2C1272C", VA = "0x2C1272C")]
		private static void RadialCut(Vector3[] xy, float cos, float sin, bool invert, int corner)
		{
		}

		[Token(Token = "0x600014F")]
		[Address(RVA = "0x2C12B34", Offset = "0x2C12B34", VA = "0x2C12B34", Slot = "75")]
		public virtual void CalculateLayoutInputHorizontal()
		{
		}

		[Token(Token = "0x6000150")]
		[Address(RVA = "0x2C12B38", Offset = "0x2C12B38", VA = "0x2C12B38", Slot = "76")]
		public virtual void CalculateLayoutInputVertical()
		{
		}

		[Token(Token = "0x6000158")]
		[Address(RVA = "0x2C12F8C", Offset = "0x2C12F8C", VA = "0x2C12F8C", Slot = "84")]
		public virtual bool IsRaycastLocationValid(Vector2 screenPoint, Camera eventCamera)
		{
			return default;
		}

		[Token(Token = "0x6000159")]
		[Address(RVA = "0x2C1360C", Offset = "0x2C1360C", VA = "0x2C1360C")]
		private Vector2 MapCoordinate(Vector2 local, Rect rect)
		{
			return default;
		}

		[Token(Token = "0x600015A")]
		[Address(RVA = "0x2C13B08", Offset = "0x2C13B08", VA = "0x2C13B08")]
		private static void RebuildImage(SpriteAtlas spriteAtlas)
		{
		}

		[Token(Token = "0x600015B")]
		[Address(RVA = "0x2C119E4", Offset = "0x2C119E4", VA = "0x2C119E4")]
		private static void TrackImage(Image g)
		{
		}

		[Token(Token = "0x600015C")]
		[Address(RVA = "0x2C11C0C", Offset = "0x2C11C0C", VA = "0x2C11C0C")]
		private static void UnTrackImage(Image g)
		{
		}

		[Token(Token = "0x600015D")]
		[Address(RVA = "0x2C13D94", Offset = "0x2C13D94", VA = "0x2C13D94", Slot = "13")]
		protected override void OnDidApplyAnimationProperties()
		{
		}
	}
}
