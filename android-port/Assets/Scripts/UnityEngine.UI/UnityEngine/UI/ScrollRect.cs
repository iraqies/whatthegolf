using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using UnityEngine.EventSystems;
using UnityEngine.Events;

namespace UnityEngine.UI
{
	[Token(Token = "0x2000052")]
	[ExecuteAlways]
	[DisallowMultipleComponent]
	[AttributeAttribute(Name = "RequireComponent", RVA = "0x1F6754", Offset = "0x1F6754")]
	public class ScrollRect : UIBehaviour, IInitializePotentialDragHandler, IEventSystemHandler, IBeginDragHandler, IEndDragHandler, IDragHandler, IScrollHandler, ICanvasElement, ILayoutElement, ILayoutGroup, ILayoutController
	{
		[Token(Token = "0x2000053")]
		public enum MovementType
		{
			[Token(Token = "0x40001B7")]
			Unrestricted = 0,
			[Token(Token = "0x40001B8")]
			Elastic = 1,
			[Token(Token = "0x40001B9")]
			Clamped = 2
		}

		[Token(Token = "0x2000054")]
		public enum ScrollbarVisibility
		{
			[Token(Token = "0x40001BB")]
			Permanent = 0,
			[Token(Token = "0x40001BC")]
			AutoHide = 1,
			[Token(Token = "0x40001BD")]
			AutoHideAndExpandViewport = 2
		}

		[Serializable]
		[Token(Token = "0x2000055")]
		public class ScrollRectEvent : UnityEvent<Vector2>
		{
			[Token(Token = "0x60003B3")]
			[Address(RVA = "0x2C4889C", Offset = "0x2C4889C", VA = "0x2C4889C")]
			public ScrollRectEvent()
			{
			}
		}

		[Token(Token = "0x4000191")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private RectTransform m_Content;

		[Token(Token = "0x4000192")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private bool m_Horizontal;

		[Token(Token = "0x4000193")]
		[FieldOffset(Offset = "0x21")]
		[SerializeField]
		private bool m_Vertical;

		[Token(Token = "0x4000194")]
		[FieldOffset(Offset = "0x24")]
		[SerializeField]
		private MovementType m_MovementType;

		[Token(Token = "0x4000195")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private float m_Elasticity;

		[Token(Token = "0x4000196")]
		[FieldOffset(Offset = "0x2C")]
		[SerializeField]
		private bool m_Inertia;

		[Token(Token = "0x4000197")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private float m_DecelerationRate;

		[Token(Token = "0x4000198")]
		[FieldOffset(Offset = "0x34")]
		[SerializeField]
		private float m_ScrollSensitivity;

		[Token(Token = "0x4000199")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private RectTransform m_Viewport;

		[Token(Token = "0x400019A")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private Scrollbar m_HorizontalScrollbar;

		[Token(Token = "0x400019B")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		private Scrollbar m_VerticalScrollbar;

		[Token(Token = "0x400019C")]
		[FieldOffset(Offset = "0x50")]
		[SerializeField]
		private ScrollbarVisibility m_HorizontalScrollbarVisibility;

		[Token(Token = "0x400019D")]
		[FieldOffset(Offset = "0x54")]
		[SerializeField]
		private ScrollbarVisibility m_VerticalScrollbarVisibility;

		[Token(Token = "0x400019E")]
		[FieldOffset(Offset = "0x58")]
		[SerializeField]
		private float m_HorizontalScrollbarSpacing;

		[Token(Token = "0x400019F")]
		[FieldOffset(Offset = "0x5C")]
		[SerializeField]
		private float m_VerticalScrollbarSpacing;

		[Token(Token = "0x40001A0")]
		[FieldOffset(Offset = "0x60")]
		[SerializeField]
		private ScrollRectEvent m_OnValueChanged;

		[Token(Token = "0x40001A1")]
		[FieldOffset(Offset = "0x68")]
		private Vector2 m_PointerStartLocalCursor;

		[Token(Token = "0x40001A2")]
		[FieldOffset(Offset = "0x70")]
		protected Vector2 m_ContentStartPosition;

		[Token(Token = "0x40001A3")]
		[FieldOffset(Offset = "0x78")]
		private RectTransform m_ViewRect;

		[Token(Token = "0x40001A4")]
		[FieldOffset(Offset = "0x80")]
		protected Bounds m_ContentBounds;

		[Token(Token = "0x40001A5")]
		[FieldOffset(Offset = "0x98")]
		private Bounds m_ViewBounds;

		[Token(Token = "0x40001A6")]
		[FieldOffset(Offset = "0xB0")]
		private Vector2 m_Velocity;

		[Token(Token = "0x40001A7")]
		[FieldOffset(Offset = "0xB8")]
		private bool m_Dragging;

		[Token(Token = "0x40001A8")]
		[FieldOffset(Offset = "0xB9")]
		private bool m_Scrolling;

		[Token(Token = "0x40001A9")]
		[FieldOffset(Offset = "0xBC")]
		private Vector2 m_PrevPosition;

		[Token(Token = "0x40001AA")]
		[FieldOffset(Offset = "0xC4")]
		private Bounds m_PrevContentBounds;

		[Token(Token = "0x40001AB")]
		[FieldOffset(Offset = "0xDC")]
		private Bounds m_PrevViewBounds;

		[NonSerialized]
		[Token(Token = "0x40001AC")]
		[FieldOffset(Offset = "0xF4")]
		private bool m_HasRebuiltLayout;

		[Token(Token = "0x40001AD")]
		[FieldOffset(Offset = "0xF5")]
		private bool m_HSliderExpand;

		[Token(Token = "0x40001AE")]
		[FieldOffset(Offset = "0xF6")]
		private bool m_VSliderExpand;

		[Token(Token = "0x40001AF")]
		[FieldOffset(Offset = "0xF8")]
		private float m_HSliderHeight;

		[Token(Token = "0x40001B0")]
		[FieldOffset(Offset = "0xFC")]
		private float m_VSliderWidth;

		[NonSerialized]
		[Token(Token = "0x40001B1")]
		[FieldOffset(Offset = "0x100")]
		private RectTransform m_Rect;

		[Token(Token = "0x40001B2")]
		[FieldOffset(Offset = "0x108")]
		private RectTransform m_HorizontalScrollbarRect;

		[Token(Token = "0x40001B3")]
		[FieldOffset(Offset = "0x110")]
		private RectTransform m_VerticalScrollbarRect;

		[Token(Token = "0x40001B4")]
		[FieldOffset(Offset = "0x118")]
		private DrivenRectTransformTracker m_Tracker;

		[Token(Token = "0x40001B5")]
		[FieldOffset(Offset = "0x120")]
		private readonly Vector3[] m_Corners;

		[Token(Token = "0x170000E8")]
		public RectTransform content
		{
			[Token(Token = "0x6000358")]
			[Address(RVA = "0x2C313EC", Offset = "0x2C313EC", VA = "0x2C313EC")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000359")]
			[Address(RVA = "0x2C313F4", Offset = "0x2C313F4", VA = "0x2C313F4")]
			set
			{
			}
		}

		[Token(Token = "0x170000E9")]
		public bool horizontal
		{
			[Token(Token = "0x600035A")]
			[Address(RVA = "0x2C313FC", Offset = "0x2C313FC", VA = "0x2C313FC")]
			get
			{
				return default;
			}
			[Token(Token = "0x600035B")]
			[Address(RVA = "0x2C31404", Offset = "0x2C31404", VA = "0x2C31404")]
			set
			{
			}
		}

		[Token(Token = "0x170000EA")]
		public bool vertical
		{
			[Token(Token = "0x600035C")]
			[Address(RVA = "0x2C3140C", Offset = "0x2C3140C", VA = "0x2C3140C")]
			get
			{
				return default;
			}
			[Token(Token = "0x600035D")]
			[Address(RVA = "0x2C31414", Offset = "0x2C31414", VA = "0x2C31414")]
			set
			{
			}
		}

		[Token(Token = "0x170000EB")]
		public MovementType movementType
		{
			[Token(Token = "0x600035E")]
			[Address(RVA = "0x2C3141C", Offset = "0x2C3141C", VA = "0x2C3141C")]
			get
			{
				return default;
			}
			[Token(Token = "0x600035F")]
			[Address(RVA = "0x2C31424", Offset = "0x2C31424", VA = "0x2C31424")]
			set
			{
			}
		}

		[Token(Token = "0x170000EC")]
		public float elasticity
		{
			[Token(Token = "0x6000360")]
			[Address(RVA = "0x2C3142C", Offset = "0x2C3142C", VA = "0x2C3142C")]
			get
			{
				return default;
			}
			[Token(Token = "0x6000361")]
			[Address(RVA = "0x2C31434", Offset = "0x2C31434", VA = "0x2C31434")]
			set
			{
			}
		}

		[Token(Token = "0x170000ED")]
		public bool inertia
		{
			[Token(Token = "0x6000362")]
			[Address(RVA = "0x2C3143C", Offset = "0x2C3143C", VA = "0x2C3143C")]
			get
			{
				return default;
			}
			[Token(Token = "0x6000363")]
			[Address(RVA = "0x2C31444", Offset = "0x2C31444", VA = "0x2C31444")]
			set
			{
			}
		}

		[Token(Token = "0x170000EE")]
		public float decelerationRate
		{
			[Token(Token = "0x6000364")]
			[Address(RVA = "0x2C3144C", Offset = "0x2C3144C", VA = "0x2C3144C")]
			get
			{
				return default;
			}
			[Token(Token = "0x6000365")]
			[Address(RVA = "0x2C31454", Offset = "0x2C31454", VA = "0x2C31454")]
			set
			{
			}
		}

		[Token(Token = "0x170000EF")]
		public float scrollSensitivity
		{
			[Token(Token = "0x6000366")]
			[Address(RVA = "0x2C3145C", Offset = "0x2C3145C", VA = "0x2C3145C")]
			get
			{
				return default;
			}
			[Token(Token = "0x6000367")]
			[Address(RVA = "0x2C31464", Offset = "0x2C31464", VA = "0x2C31464")]
			set
			{
			}
		}

		[Token(Token = "0x170000F0")]
		public RectTransform viewport
		{
			[Token(Token = "0x6000368")]
			[Address(RVA = "0x2C3146C", Offset = "0x2C3146C", VA = "0x2C3146C")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000369")]
			[Address(RVA = "0x2C31474", Offset = "0x2C31474", VA = "0x2C31474")]
			set
			{
			}
		}

		[Token(Token = "0x170000F1")]
		public Scrollbar horizontalScrollbar
		{
			[Token(Token = "0x600036A")]
			[Address(RVA = "0x2C31544", Offset = "0x2C31544", VA = "0x2C31544")]
			get
			{
				return null;
			}
			[Token(Token = "0x600036B")]
			[Address(RVA = "0x2C3154C", Offset = "0x2C3154C", VA = "0x2C3154C")]
			set
			{
			}
		}

		[Token(Token = "0x170000F2")]
		public Scrollbar verticalScrollbar
		{
			[Token(Token = "0x600036C")]
			[Address(RVA = "0x2C31700", Offset = "0x2C31700", VA = "0x2C31700")]
			get
			{
				return null;
			}
			[Token(Token = "0x600036D")]
			[Address(RVA = "0x2C31708", Offset = "0x2C31708", VA = "0x2C31708")]
			set
			{
			}
		}

		[Token(Token = "0x170000F3")]
		public ScrollbarVisibility horizontalScrollbarVisibility
		{
			[Token(Token = "0x600036E")]
			[Address(RVA = "0x2C318BC", Offset = "0x2C318BC", VA = "0x2C318BC")]
			get
			{
				return default;
			}
			[Token(Token = "0x600036F")]
			[Address(RVA = "0x2C318C4", Offset = "0x2C318C4", VA = "0x2C318C4")]
			set
			{
			}
		}

		[Token(Token = "0x170000F4")]
		public ScrollbarVisibility verticalScrollbarVisibility
		{
			[Token(Token = "0x6000370")]
			[Address(RVA = "0x2C318CC", Offset = "0x2C318CC", VA = "0x2C318CC")]
			get
			{
				return default;
			}
			[Token(Token = "0x6000371")]
			[Address(RVA = "0x2C318D4", Offset = "0x2C318D4", VA = "0x2C318D4")]
			set
			{
			}
		}

		[Token(Token = "0x170000F5")]
		public float horizontalScrollbarSpacing
		{
			[Token(Token = "0x6000372")]
			[Address(RVA = "0x2C318DC", Offset = "0x2C318DC", VA = "0x2C318DC")]
			get
			{
				return default;
			}
			[Token(Token = "0x6000373")]
			[Address(RVA = "0x2C318E4", Offset = "0x2C318E4", VA = "0x2C318E4")]
			set
			{
			}
		}

		[Token(Token = "0x170000F6")]
		public float verticalScrollbarSpacing
		{
			[Token(Token = "0x6000374")]
			[Address(RVA = "0x2C31A10", Offset = "0x2C31A10", VA = "0x2C31A10")]
			get
			{
				return default;
			}
			[Token(Token = "0x6000375")]
			[Address(RVA = "0x2C31A18", Offset = "0x2C31A18", VA = "0x2C31A18")]
			set
			{
			}
		}

		[Token(Token = "0x170000F7")]
		public ScrollRectEvent onValueChanged
		{
			[Token(Token = "0x6000376")]
			[Address(RVA = "0x2C31AB0", Offset = "0x2C31AB0", VA = "0x2C31AB0")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000377")]
			[Address(RVA = "0x2C31AB8", Offset = "0x2C31AB8", VA = "0x2C31AB8")]
			set
			{
			}
		}

		[Token(Token = "0x170000F8")]
		protected RectTransform viewRect
		{
			[Token(Token = "0x6000378")]
			[Address(RVA = "0x2C31AC0", Offset = "0x2C31AC0", VA = "0x2C31AC0")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170000F9")]
		public Vector2 velocity
		{
			[Token(Token = "0x6000379")]
			[Address(RVA = "0x2C31BCC", Offset = "0x2C31BCC", VA = "0x2C31BCC")]
			get
			{
				return default;
			}
			[Token(Token = "0x600037A")]
			[Address(RVA = "0x2C31BD4", Offset = "0x2C31BD4", VA = "0x2C31BD4")]
			set
			{
			}
		}

		[Token(Token = "0x170000FA")]
		private RectTransform rectTransform
		{
			[Token(Token = "0x600037B")]
			[Address(RVA = "0x2C31BDC", Offset = "0x2C31BDC", VA = "0x2C31BDC")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170000FB")]
		public Vector2 normalizedPosition
		{
			[Token(Token = "0x600038F")]
			[Address(RVA = "0x2C33E2C", Offset = "0x2C33E2C", VA = "0x2C33E2C")]
			get
			{
				return default;
			}
			[Token(Token = "0x6000390")]
			[Address(RVA = "0x2C341C0", Offset = "0x2C341C0", VA = "0x2C341C0")]
			set
			{
			}
		}

		[Token(Token = "0x170000FC")]
		public float horizontalNormalizedPosition
		{
			[Token(Token = "0x6000391")]
			[Address(RVA = "0x2C33FC4", Offset = "0x2C33FC4", VA = "0x2C33FC4")]
			get
			{
				return default;
			}
			[Token(Token = "0x6000392")]
			[Address(RVA = "0x2C34214", Offset = "0x2C34214", VA = "0x2C34214")]
			set
			{
			}
		}

		[Token(Token = "0x170000FD")]
		public float verticalNormalizedPosition
		{
			[Token(Token = "0x6000393")]
			[Address(RVA = "0x2C340C8", Offset = "0x2C340C8", VA = "0x2C340C8")]
			get
			{
				return default;
			}
			[Token(Token = "0x6000394")]
			[Address(RVA = "0x2C34228", Offset = "0x2C34228", VA = "0x2C34228")]
			set
			{
			}
		}

		[Token(Token = "0x170000FE")]
		private bool hScrollingNeeded
		{
			[Token(Token = "0x600039A")]
			[Address(RVA = "0x2C34518", Offset = "0x2C34518", VA = "0x2C34518")]
			get
			{
				return default;
			}
		}

		[Token(Token = "0x170000FF")]
		private bool vScrollingNeeded
		{
			[Token(Token = "0x600039B")]
			[Address(RVA = "0x2C34584", Offset = "0x2C34584", VA = "0x2C34584")]
			get
			{
				return default;
			}
		}

		[Token(Token = "0x17000100")]
		public virtual float minWidth
		{
			[Token(Token = "0x600039E")]
			[Address(RVA = "0x2C345F8", Offset = "0x2C345F8", VA = "0x2C345F8", Slot = "52")]
			get
			{
				return default;
			}
		}

		[Token(Token = "0x17000101")]
		public virtual float preferredWidth
		{
			[Token(Token = "0x600039F")]
			[Address(RVA = "0x2C34600", Offset = "0x2C34600", VA = "0x2C34600", Slot = "53")]
			get
			{
				return default;
			}
		}

		[Token(Token = "0x17000102")]
		public virtual float flexibleWidth
		{
			[Token(Token = "0x60003A0")]
			[Address(RVA = "0x2C34608", Offset = "0x2C34608", VA = "0x2C34608", Slot = "54")]
			get
			{
				return default;
			}
		}

		[Token(Token = "0x17000103")]
		public virtual float minHeight
		{
			[Token(Token = "0x60003A1")]
			[Address(RVA = "0x2C34610", Offset = "0x2C34610", VA = "0x2C34610", Slot = "55")]
			get
			{
				return default;
			}
		}

		[Token(Token = "0x17000104")]
		public virtual float preferredHeight
		{
			[Token(Token = "0x60003A2")]
			[Address(RVA = "0x2C34618", Offset = "0x2C34618", VA = "0x2C34618", Slot = "56")]
			get
			{
				return default;
			}
		}

		[Token(Token = "0x17000105")]
		public virtual float flexibleHeight
		{
			[Token(Token = "0x60003A3")]
			[Address(RVA = "0x2C34620", Offset = "0x2C34620", VA = "0x2C34620", Slot = "57")]
			get
			{
				return default;
			}
		}

		[Token(Token = "0x17000106")]
		public virtual int layoutPriority
		{
			[Token(Token = "0x60003A4")]
			[Address(RVA = "0x2C34628", Offset = "0x2C34628", VA = "0x2C34628", Slot = "58")]
			get
			{
				return default;
			}
		}

		[Token(Token = "0x600037C")]
		[Address(RVA = "0x2C31C88", Offset = "0x2C31C88", VA = "0x2C31C88")]
		protected ScrollRect()
		{
		}

		[Token(Token = "0x600037D")]
		[Address(RVA = "0x2C31D74", Offset = "0x2C31D74", VA = "0x2C31D74", Slot = "38")]
		public virtual void Rebuild(CanvasUpdate executing)
		{
		}

		[Token(Token = "0x600037E")]
		[Address(RVA = "0x2C32BA0", Offset = "0x2C32BA0", VA = "0x2C32BA0", Slot = "39")]
		public virtual void LayoutComplete()
		{
		}

		[Token(Token = "0x600037F")]
		[Address(RVA = "0x2C32BA4", Offset = "0x2C32BA4", VA = "0x2C32BA4", Slot = "40")]
		public virtual void GraphicUpdateComplete()
		{
		}

		[Token(Token = "0x6000380")]
		[Address(RVA = "0x2C31DC4", Offset = "0x2C31DC4", VA = "0x2C31DC4")]
		private void UpdateCachedData()
		{
		}

		[Token(Token = "0x6000381")]
		[Address(RVA = "0x2C32BA8", Offset = "0x2C32BA8", VA = "0x2C32BA8", Slot = "5")]
		protected override void OnEnable()
		{
		}

		[Token(Token = "0x6000382")]
		[Address(RVA = "0x2C32E0C", Offset = "0x2C32E0C", VA = "0x2C32E0C", Slot = "7")]
		protected override void OnDisable()
		{
		}

		[Token(Token = "0x6000383")]
		[Address(RVA = "0x2C33058", Offset = "0x2C33058", VA = "0x2C33058", Slot = "9")]
		public override bool IsActive()
		{
			return default;
		}

		[Token(Token = "0x6000384")]
		[Address(RVA = "0x2C330F0", Offset = "0x2C330F0", VA = "0x2C330F0")]
		private void EnsureLayoutHasRebuilt()
		{
		}

		[Token(Token = "0x6000385")]
		[Address(RVA = "0x2C33170", Offset = "0x2C33170", VA = "0x2C33170", Slot = "41")]
		public virtual void StopMovement()
		{
		}

		[Token(Token = "0x6000386")]
		[Address(RVA = "0x2C33198", Offset = "0x2C33198", VA = "0x2C33198", Slot = "42")]
		public virtual void OnScroll(PointerEventData data)
		{
		}

		[Token(Token = "0x6000387")]
		[Address(RVA = "0x2C333AC", Offset = "0x2C333AC", VA = "0x2C333AC", Slot = "43")]
		public virtual void OnInitializePotentialDrag(PointerEventData eventData)
		{
		}

		[Token(Token = "0x6000388")]
		[Address(RVA = "0x2C333E4", Offset = "0x2C333E4", VA = "0x2C333E4", Slot = "44")]
		public virtual void OnBeginDrag(PointerEventData eventData)
		{
		}

		[Token(Token = "0x6000389")]
		[Address(RVA = "0x2C334F0", Offset = "0x2C334F0", VA = "0x2C334F0", Slot = "45")]
		public virtual void OnEndDrag(PointerEventData eventData)
		{
		}

		[Token(Token = "0x600038A")]
		[Address(RVA = "0x2C33514", Offset = "0x2C33514", VA = "0x2C33514", Slot = "46")]
		public virtual void OnDrag(PointerEventData eventData)
		{
		}

		[Token(Token = "0x600038B")]
		[Address(RVA = "0x2C337AC", Offset = "0x2C337AC", VA = "0x2C337AC", Slot = "47")]
		protected virtual void SetContentAnchoredPosition(Vector2 position)
		{
		}

		[Token(Token = "0x600038C")]
		[Address(RVA = "0x2C33874", Offset = "0x2C33874", VA = "0x2C33874", Slot = "48")]
		protected virtual void LateUpdate()
		{
		}

		[Token(Token = "0x600038D")]
		[Address(RVA = "0x2C32AD8", Offset = "0x2C32AD8", VA = "0x2C32AD8")]
		protected void UpdatePrevData()
		{
		}

		[Token(Token = "0x600038E")]
		[Address(RVA = "0x2C327EC", Offset = "0x2C327EC", VA = "0x2C327EC")]
		private void UpdateScrollbars(Vector2 offset)
		{
		}

		[Token(Token = "0x6000395")]
		[Address(RVA = "0x2C3423C", Offset = "0x2C3423C", VA = "0x2C3423C")]
		private void SetHorizontalNormalizedPosition(float value)
		{
		}

		[Token(Token = "0x6000396")]
		[Address(RVA = "0x2C34250", Offset = "0x2C34250", VA = "0x2C34250")]
		private void SetVerticalNormalizedPosition(float value)
		{
		}

		[Token(Token = "0x6000397")]
		[Address(RVA = "0x2C34264", Offset = "0x2C34264", VA = "0x2C34264", Slot = "49")]
		protected virtual void SetNormalizedPosition(float value, int axis)
		{
		}

		[Token(Token = "0x6000398")]
		[Address(RVA = "0x2C33758", Offset = "0x2C33758", VA = "0x2C33758")]
		private static float RubberDelta(float overStretching, float viewSize)
		{
			return default;
		}

		[Token(Token = "0x6000399")]
		[Address(RVA = "0x2C34484", Offset = "0x2C34484", VA = "0x2C34484", Slot = "10")]
		protected override void OnRectTransformDimensionsChange()
		{
		}

		[Token(Token = "0x600039C")]
		[Address(RVA = "0x2C345F0", Offset = "0x2C345F0", VA = "0x2C345F0", Slot = "50")]
		public virtual void CalculateLayoutInputHorizontal()
		{
		}

		[Token(Token = "0x600039D")]
		[Address(RVA = "0x2C345F4", Offset = "0x2C345F4", VA = "0x2C345F4", Slot = "51")]
		public virtual void CalculateLayoutInputVertical()
		{
		}

		[Token(Token = "0x60003A5")]
		[Address(RVA = "0x2C34630", Offset = "0x2C34630", VA = "0x2C34630", Slot = "59")]
		public virtual void SetLayoutHorizontal()
		{
		}

		[Token(Token = "0x60003A6")]
		[Address(RVA = "0x2C34CA0", Offset = "0x2C34CA0", VA = "0x2C34CA0", Slot = "60")]
		public virtual void SetLayoutVertical()
		{
		}

		[Token(Token = "0x60003A7")]
		[Address(RVA = "0x2C33E68", Offset = "0x2C33E68", VA = "0x2C33E68")]
		private void UpdateScrollbarVisibility()
		{
		}

		[Token(Token = "0x60003A8")]
		[Address(RVA = "0x2C35090", Offset = "0x2C35090", VA = "0x2C35090")]
		private static void UpdateOneScrollbarVisibility(bool xScrollingNeeded, bool xAxisEnabled, ScrollbarVisibility scrollbarVisibility, Scrollbar scrollbar)
		{
		}

		[Token(Token = "0x60003A9")]
		[Address(RVA = "0x2C34D88", Offset = "0x2C34D88", VA = "0x2C34D88")]
		private void UpdateScrollbarLayout()
		{
		}

		[Token(Token = "0x60003AA")]
		[Address(RVA = "0x2C3225C", Offset = "0x2C3225C", VA = "0x2C3225C")]
		protected void UpdateBounds()
		{
		}

		[Token(Token = "0x60003AB")]
		[Address(RVA = "0x2C351AC", Offset = "0x2C351AC", VA = "0x2C351AC")]
		internal static void AdjustBounds(ref Bounds viewBounds, ref Vector2 contentPivot, ref Vector3 contentSize, ref Vector3 contentPos)
		{
		}

		[Token(Token = "0x60003AC")]
		[Address(RVA = "0x2C34BB8", Offset = "0x2C34BB8", VA = "0x2C34BB8")]
		private Bounds GetBounds()
		{
			return default;
		}

		[Token(Token = "0x60003AD")]
		[Address(RVA = "0x2C35260", Offset = "0x2C35260", VA = "0x2C35260")]
		internal static Bounds InternalGetBounds(Vector3[] corners, ref Matrix4x4 viewWorldToLocalMatrix)
		{
			return default;
		}

		[Token(Token = "0x60003AE")]
		[Address(RVA = "0x2C33370", Offset = "0x2C33370", VA = "0x2C33370")]
		private Vector2 CalculateOffset(Vector2 delta)
		{
			return default;
		}

		[Token(Token = "0x60003AF")]
		[Address(RVA = "0x2C35400", Offset = "0x2C35400", VA = "0x2C35400")]
		internal static Vector2 InternalCalculateOffset(ref Bounds viewBounds, ref Bounds contentBounds, bool horizontal, bool vertical, MovementType movementType, ref Vector2 delta)
		{
			return default;
		}

		[Token(Token = "0x60003B0")]
		[Address(RVA = "0x2C3197C", Offset = "0x2C3197C", VA = "0x2C3197C")]
		protected void SetDirty()
		{
		}

		[Token(Token = "0x60003B1")]
		[Address(RVA = "0x2C3147C", Offset = "0x2C3147C", VA = "0x2C3147C")]
		protected void SetDirtyCaching()
		{
		}

		[SpecialName]
		[Token(Token = "0x60003B2")]
		[Address(RVA = "0x2C35588", Offset = "0x2C35588", VA = "0x2C35588", Slot = "23")]
		private Transform UnityEngine_002EUI_002EICanvasElement_002Eget_transform()
		{
			return null;
		}
	}
}
