using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.EventSystems;

namespace TMPro
{
	[Token(Token = "0x2000088")]
	[Attribute(Name = "RequireComponent", RVA = "0x1B94D8", Offset = "0x1B94D8")]
	public class TextContainer : UIBehaviour
	{
		[Token(Token = "0x4000584")]
		[FieldOffset(Offset = "0x18")]
		private bool m_hasChanged;

		[Token(Token = "0x4000585")]
		[FieldOffset(Offset = "0x1C")]
		[SerializeField]
		private Vector2 m_pivot;

		[Token(Token = "0x4000586")]
		[FieldOffset(Offset = "0x24")]
		[SerializeField]
		private TextContainerAnchors m_anchorPosition;

		[Token(Token = "0x4000587")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private Rect m_rect;

		[Token(Token = "0x4000588")]
		[FieldOffset(Offset = "0x38")]
		private bool m_isDefaultWidth;

		[Token(Token = "0x4000589")]
		[FieldOffset(Offset = "0x39")]
		private bool m_isDefaultHeight;

		[Token(Token = "0x400058A")]
		[FieldOffset(Offset = "0x3A")]
		private bool m_isAutoFitting;

		[Token(Token = "0x400058B")]
		[FieldOffset(Offset = "0x40")]
		private Vector3[] m_corners;

		[Token(Token = "0x400058C")]
		[FieldOffset(Offset = "0x48")]
		private Vector3[] m_worldCorners;

		[Token(Token = "0x400058D")]
		[FieldOffset(Offset = "0x50")]
		[SerializeField]
		private Vector4 m_margins;

		[Token(Token = "0x400058E")]
		[FieldOffset(Offset = "0x60")]
		private RectTransform m_rectTransform;

		[Token(Token = "0x400058F")]
		[FieldOffset(Offset = "0x0")]
		private static Vector2 k_defaultSize;

		[Token(Token = "0x4000590")]
		[FieldOffset(Offset = "0x68")]
		private TextMeshPro m_textMeshPro;

		[Token(Token = "0x1700014F")]
		public bool hasChanged
		{
			[Token(Token = "0x6000543")]
			[Address(RVA = "0x2ABCC6C", Offset = "0x2ABCC6C", VA = "0x2ABCC6C")]
			get
			{
				return default;
			}
			[Token(Token = "0x6000544")]
			[Address(RVA = "0x2ABCC74", Offset = "0x2ABCC74", VA = "0x2ABCC74")]
			set
			{
			}
		}

		[Token(Token = "0x17000150")]
		public Vector2 pivot
		{
			[Token(Token = "0x6000545")]
			[Address(RVA = "0x2ABCC7C", Offset = "0x2ABCC7C", VA = "0x2ABCC7C")]
			get
			{
				return default;
			}
			[Token(Token = "0x6000546")]
			[Address(RVA = "0x2ABCC84", Offset = "0x2ABCC84", VA = "0x2ABCC84")]
			set
			{
			}
		}

		[Token(Token = "0x17000151")]
		public TextContainerAnchors anchorPosition
		{
			[Token(Token = "0x6000547")]
			[Address(RVA = "0x2ABD060", Offset = "0x2ABD060", VA = "0x2ABD060")]
			get
			{
				return default;
			}
			[Token(Token = "0x6000548")]
			[Address(RVA = "0x2ABD068", Offset = "0x2ABD068", VA = "0x2ABD068")]
			set
			{
			}
		}

		[Token(Token = "0x17000152")]
		public Rect rect
		{
			[Token(Token = "0x6000549")]
			[Address(RVA = "0x2ABD0F0", Offset = "0x2ABD0F0", VA = "0x2ABD0F0")]
			get
			{
				return default;
			}
			[Token(Token = "0x600054A")]
			[Address(RVA = "0x2ABD0FC", Offset = "0x2ABD0FC", VA = "0x2ABD0FC")]
			set
			{
			}
		}

		[Token(Token = "0x17000153")]
		public Vector2 size
		{
			[Token(Token = "0x600054B")]
			[Address(RVA = "0x2ABD184", Offset = "0x2ABD184", VA = "0x2ABD184")]
			get
			{
				return default;
			}
			[Token(Token = "0x600054C")]
			[Address(RVA = "0x2ABD1CC", Offset = "0x2ABD1CC", VA = "0x2ABD1CC")]
			set
			{
			}
		}

		[Token(Token = "0x17000154")]
		public float width
		{
			[Token(Token = "0x600054D")]
			[Address(RVA = "0x2ABD324", Offset = "0x2ABD324", VA = "0x2ABD324")]
			get
			{
				return default;
			}
			[Token(Token = "0x600054E")]
			[Address(RVA = "0x2ABD330", Offset = "0x2ABD330", VA = "0x2ABD330")]
			set
			{
			}
		}

		[Token(Token = "0x17000155")]
		public float height
		{
			[Token(Token = "0x600054F")]
			[Address(RVA = "0x2ABD3D0", Offset = "0x2ABD3D0", VA = "0x2ABD3D0")]
			get
			{
				return default;
			}
			[Token(Token = "0x6000550")]
			[Address(RVA = "0x2ABD3DC", Offset = "0x2ABD3DC", VA = "0x2ABD3DC")]
			set
			{
			}
		}

		[Token(Token = "0x17000156")]
		public bool isDefaultWidth
		{
			[Token(Token = "0x6000551")]
			[Address(RVA = "0x2ABD47C", Offset = "0x2ABD47C", VA = "0x2ABD47C")]
			get
			{
				return default;
			}
		}

		[Token(Token = "0x17000157")]
		public bool isDefaultHeight
		{
			[Token(Token = "0x6000552")]
			[Address(RVA = "0x2ABD484", Offset = "0x2ABD484", VA = "0x2ABD484")]
			get
			{
				return default;
			}
		}

		[Token(Token = "0x17000158")]
		public bool isAutoFitting
		{
			[Token(Token = "0x6000553")]
			[Address(RVA = "0x2ABD48C", Offset = "0x2ABD48C", VA = "0x2ABD48C")]
			get
			{
				return default;
			}
			[Token(Token = "0x6000554")]
			[Address(RVA = "0x2ABD494", Offset = "0x2ABD494", VA = "0x2ABD494")]
			set
			{
			}
		}

		[Token(Token = "0x17000159")]
		public Vector3[] corners
		{
			[Token(Token = "0x6000555")]
			[Address(RVA = "0x2ABD49C", Offset = "0x2ABD49C", VA = "0x2ABD49C")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700015A")]
		public Vector3[] worldCorners
		{
			[Token(Token = "0x6000556")]
			[Address(RVA = "0x2ABD4A4", Offset = "0x2ABD4A4", VA = "0x2ABD4A4")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700015B")]
		public Vector4 margins
		{
			[Token(Token = "0x6000557")]
			[Address(RVA = "0x2ABD4AC", Offset = "0x2ABD4AC", VA = "0x2ABD4AC")]
			get
			{
				return default;
			}
			[Token(Token = "0x6000558")]
			[Address(RVA = "0x2ABD4B8", Offset = "0x2ABD4B8", VA = "0x2ABD4B8")]
			set
			{
			}
		}

		[Token(Token = "0x1700015C")]
		public RectTransform rectTransform
		{
			[Token(Token = "0x6000559")]
			[Address(RVA = "0x2ABD518", Offset = "0x2ABD518", VA = "0x2ABD518")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700015D")]
		public TextMeshPro textMeshPro
		{
			[Token(Token = "0x600055A")]
			[Address(RVA = "0x2ABD5C4", Offset = "0x2ABD5C4", VA = "0x2ABD5C4")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x600055B")]
		[Address(RVA = "0x2ABD670", Offset = "0x2ABD670", VA = "0x2ABD670", Slot = "4")]
		protected override void Awake()
		{
		}

		[Token(Token = "0x600055C")]
		[Address(RVA = "0x2ABD740", Offset = "0x2ABD740", VA = "0x2ABD740", Slot = "5")]
		protected override void OnEnable()
		{
		}

		[Token(Token = "0x600055D")]
		[Address(RVA = "0x2ABD744", Offset = "0x2ABD744", VA = "0x2ABD744", Slot = "7")]
		protected override void OnDisable()
		{
		}

		[Token(Token = "0x600055E")]
		[Address(RVA = "0x2ABCEF8", Offset = "0x2ABCEF8", VA = "0x2ABCEF8")]
		private void OnContainerChanged()
		{
		}

		[Token(Token = "0x600055F")]
		[Address(RVA = "0x2ABD940", Offset = "0x2ABD940", VA = "0x2ABD940", Slot = "10")]
		protected override void OnRectTransformDimensionsChange()
		{
		}

		[Token(Token = "0x6000560")]
		[Address(RVA = "0x2ABD2A4", Offset = "0x2ABD2A4", VA = "0x2ABD2A4")]
		private void SetRect(Vector2 size)
		{
		}

		[Token(Token = "0x6000561")]
		[Address(RVA = "0x2ABD748", Offset = "0x2ABD748", VA = "0x2ABD748")]
		private void UpdateCorners()
		{
		}

		[Token(Token = "0x6000562")]
		[Address(RVA = "0x2ABD0AC", Offset = "0x2ABD0AC", VA = "0x2ABD0AC")]
		private Vector2 GetPivot(TextContainerAnchors anchor)
		{
			return default;
		}

		[Token(Token = "0x6000563")]
		[Address(RVA = "0x2ABCDDC", Offset = "0x2ABCDDC", VA = "0x2ABCDDC")]
		private TextContainerAnchors GetAnchorPosition(Vector2 pivot)
		{
			return default;
		}

		[Token(Token = "0x6000564")]
		[Address(RVA = "0x2ABDAC0", Offset = "0x2ABDAC0", VA = "0x2ABDAC0")]
		public TextContainer()
		{
		}
	}
}
