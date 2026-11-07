using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using UnityEngine.EventSystems;
using UnityEngine.Events;

namespace UnityEngine.UI
{
	[Token(Token = "0x200005F")]
	[ExecuteAlways]
	[AttributeAttribute(Name = "RequireComponent", RVA = "0x1F689C", Offset = "0x1F689C")]
	public class Slider : Selectable, IDragHandler, IEventSystemHandler, IInitializePotentialDragHandler, ICanvasElement
	{
		[Token(Token = "0x2000060")]
		public enum Direction
		{
			[Token(Token = "0x4000203")]
			LeftToRight = 0,
			[Token(Token = "0x4000204")]
			RightToLeft = 1,
			[Token(Token = "0x4000205")]
			BottomToTop = 2,
			[Token(Token = "0x4000206")]
			TopToBottom = 3
		}

		[Serializable]
		[Token(Token = "0x2000061")]
		public class SliderEvent : UnityEvent<float>
		{
			[Token(Token = "0x6000457")]
			[Address(RVA = "0x2C48BBC", Offset = "0x2C48BBC", VA = "0x2C48BBC")]
			public SliderEvent()
			{
			}
		}

		[Token(Token = "0x2000062")]
		private enum Axis
		{
			[Token(Token = "0x4000208")]
			Horizontal = 0,
			[Token(Token = "0x4000209")]
			Vertical = 1
		}

		[Token(Token = "0x40001F2")]
		[FieldOffset(Offset = "0xF8")]
		[SerializeField]
		private RectTransform m_FillRect;

		[Token(Token = "0x40001F3")]
		[FieldOffset(Offset = "0x100")]
		[SerializeField]
		private RectTransform m_HandleRect;

		[Token(Token = "0x40001F4")]
		[FieldOffset(Offset = "0x108")]
		[SerializeField]
		private Direction m_Direction;

		[Token(Token = "0x40001F5")]
		[FieldOffset(Offset = "0x10C")]
		[SerializeField]
		private float m_MinValue;

		[Token(Token = "0x40001F6")]
		[FieldOffset(Offset = "0x110")]
		[SerializeField]
		private float m_MaxValue;

		[Token(Token = "0x40001F7")]
		[FieldOffset(Offset = "0x114")]
		[SerializeField]
		private bool m_WholeNumbers;

		[Token(Token = "0x40001F8")]
		[FieldOffset(Offset = "0x118")]
		[SerializeField]
		protected float m_Value;

		[Token(Token = "0x40001F9")]
		[FieldOffset(Offset = "0x120")]
		[SerializeField]
		private SliderEvent m_OnValueChanged;

		[Token(Token = "0x40001FA")]
		[FieldOffset(Offset = "0x128")]
		private Image m_FillImage;

		[Token(Token = "0x40001FB")]
		[FieldOffset(Offset = "0x130")]
		private Transform m_FillTransform;

		[Token(Token = "0x40001FC")]
		[FieldOffset(Offset = "0x138")]
		private RectTransform m_FillContainerRect;

		[Token(Token = "0x40001FD")]
		[FieldOffset(Offset = "0x140")]
		private Transform m_HandleTransform;

		[Token(Token = "0x40001FE")]
		[FieldOffset(Offset = "0x148")]
		private RectTransform m_HandleContainerRect;

		[Token(Token = "0x40001FF")]
		[FieldOffset(Offset = "0x150")]
		private Vector2 m_Offset;

		[Token(Token = "0x4000200")]
		[FieldOffset(Offset = "0x158")]
		private DrivenRectTransformTracker m_Tracker;

		[Token(Token = "0x4000201")]
		[FieldOffset(Offset = "0x159")]
		private bool m_DelayedUpdateVisuals;

		[Token(Token = "0x17000122")]
		public RectTransform fillRect
		{
			[Token(Token = "0x6000428")]
			[Address(RVA = "0x2C3A5A0", Offset = "0x2C3A5A0", VA = "0x2C3A5A0")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000429")]
			[Address(RVA = "0x2C3A5A8", Offset = "0x2C3A5A8", VA = "0x2C3A5A8")]
			set
			{
			}
		}

		[Token(Token = "0x17000123")]
		public RectTransform handleRect
		{
			[Token(Token = "0x600042A")]
			[Address(RVA = "0x2C3AD10", Offset = "0x2C3AD10", VA = "0x2C3AD10")]
			get
			{
				return null;
			}
			[Token(Token = "0x600042B")]
			[Address(RVA = "0x2C3AD18", Offset = "0x2C3AD18", VA = "0x2C3AD18")]
			set
			{
			}
		}

		[Token(Token = "0x17000124")]
		public Direction direction
		{
			[Token(Token = "0x600042C")]
			[Address(RVA = "0x2C3AD98", Offset = "0x2C3AD98", VA = "0x2C3AD98")]
			get
			{
				return default;
			}
			[Token(Token = "0x600042D")]
			[Address(RVA = "0x2C3ADA0", Offset = "0x2C3ADA0", VA = "0x2C3ADA0")]
			set
			{
			}
		}

		[Token(Token = "0x17000125")]
		public float minValue
		{
			[Token(Token = "0x600042E")]
			[Address(RVA = "0x2C3AE18", Offset = "0x2C3AE18", VA = "0x2C3AE18")]
			get
			{
				return default;
			}
			[Token(Token = "0x600042F")]
			[Address(RVA = "0x2C3AE20", Offset = "0x2C3AE20", VA = "0x2C3AE20")]
			set
			{
			}
		}

		[Token(Token = "0x17000126")]
		public float maxValue
		{
			[Token(Token = "0x6000430")]
			[Address(RVA = "0x2C3AEC0", Offset = "0x2C3AEC0", VA = "0x2C3AEC0")]
			get
			{
				return default;
			}
			[Token(Token = "0x6000431")]
			[Address(RVA = "0x2C3AEC8", Offset = "0x2C3AEC8", VA = "0x2C3AEC8")]
			set
			{
			}
		}

		[Token(Token = "0x17000127")]
		public bool wholeNumbers
		{
			[Token(Token = "0x6000432")]
			[Address(RVA = "0x2C3AF68", Offset = "0x2C3AF68", VA = "0x2C3AF68")]
			get
			{
				return default;
			}
			[Token(Token = "0x6000433")]
			[Address(RVA = "0x2C3AF70", Offset = "0x2C3AF70", VA = "0x2C3AF70")]
			set
			{
			}
		}

		[Token(Token = "0x17000128")]
		public virtual float value
		{
			[Token(Token = "0x6000434")]
			[Address(RVA = "0x2C3B004", Offset = "0x2C3B004", VA = "0x2C3B004", Slot = "46")]
			get
			{
				return default;
			}
			[Token(Token = "0x6000435")]
			[Address(RVA = "0x2C3B0B0", Offset = "0x2C3B0B0", VA = "0x2C3B0B0", Slot = "47")]
			set
			{
			}
		}

		[Token(Token = "0x17000129")]
		public float normalizedValue
		{
			[Token(Token = "0x6000437")]
			[Address(RVA = "0x2C3B0D8", Offset = "0x2C3B0D8", VA = "0x2C3B0D8")]
			get
			{
				return default;
			}
			[Token(Token = "0x6000438")]
			[Address(RVA = "0x2C3B150", Offset = "0x2C3B150", VA = "0x2C3B150")]
			set
			{
			}
		}

		[Token(Token = "0x1700012A")]
		public SliderEvent onValueChanged
		{
			[Token(Token = "0x6000439")]
			[Address(RVA = "0x2C3B190", Offset = "0x2C3B190", VA = "0x2C3B190")]
			get
			{
				return null;
			}
			[Token(Token = "0x600043A")]
			[Address(RVA = "0x2C3B198", Offset = "0x2C3B198", VA = "0x2C3B198")]
			set
			{
			}
		}

		[Token(Token = "0x1700012B")]
		private float stepSize
		{
			[Token(Token = "0x600043B")]
			[Address(RVA = "0x2C3B1A0", Offset = "0x2C3B1A0", VA = "0x2C3B1A0")]
			get
			{
				return default;
			}
		}

		[Token(Token = "0x1700012C")]
		private Axis axis
		{
			[Token(Token = "0x6000448")]
			[Address(RVA = "0x2C3B764", Offset = "0x2C3B764", VA = "0x2C3B764")]
			get
			{
				return default;
			}
		}

		[Token(Token = "0x1700012D")]
		private bool reverseValue
		{
			[Token(Token = "0x6000449")]
			[Address(RVA = "0x2C3B750", Offset = "0x2C3B750", VA = "0x2C3B750")]
			get
			{
				return default;
			}
		}

		[Token(Token = "0x6000436")]
		[Address(RVA = "0x2C3B0C4", Offset = "0x2C3B0C4", VA = "0x2C3B0C4", Slot = "48")]
		public virtual void SetValueWithoutNotify(float input)
		{
		}

		[Token(Token = "0x600043C")]
		[Address(RVA = "0x2C3B1CC", Offset = "0x2C3B1CC", VA = "0x2C3B1CC")]
		protected Slider()
		{
		}

		[Token(Token = "0x600043D")]
		[Address(RVA = "0x2C3B278", Offset = "0x2C3B278", VA = "0x2C3B278", Slot = "49")]
		public virtual void Rebuild(CanvasUpdate executing)
		{
		}

		[Token(Token = "0x600043E")]
		[Address(RVA = "0x2C3B27C", Offset = "0x2C3B27C", VA = "0x2C3B27C", Slot = "50")]
		public virtual void LayoutComplete()
		{
		}

		[Token(Token = "0x600043F")]
		[Address(RVA = "0x2C3B280", Offset = "0x2C3B280", VA = "0x2C3B280", Slot = "51")]
		public virtual void GraphicUpdateComplete()
		{
		}

		[Token(Token = "0x6000440")]
		[Address(RVA = "0x2C3B284", Offset = "0x2C3B284", VA = "0x2C3B284", Slot = "5")]
		protected override void OnEnable()
		{
		}

		[Token(Token = "0x6000441")]
		[Address(RVA = "0x2C3B2CC", Offset = "0x2C3B2CC", VA = "0x2C3B2CC", Slot = "7")]
		protected override void OnDisable()
		{
		}

		[Token(Token = "0x6000442")]
		[Address(RVA = "0x2C3B2F8", Offset = "0x2C3B2F8", VA = "0x2C3B2F8", Slot = "52")]
		protected virtual void Update()
		{
		}

		[Token(Token = "0x6000443")]
		[Address(RVA = "0x2C3B344", Offset = "0x2C3B344", VA = "0x2C3B344", Slot = "13")]
		protected override void OnDidApplyAnimationProperties()
		{
		}

		[Token(Token = "0x6000444")]
		[Address(RVA = "0x2C3A628", Offset = "0x2C3A628", VA = "0x2C3A628")]
		private void UpdateCachedReferences()
		{
		}

		[Token(Token = "0x6000445")]
		[Address(RVA = "0x2C3B684", Offset = "0x2C3B684", VA = "0x2C3B684")]
		private float ClampValue(float input)
		{
			return default;
		}

		[Token(Token = "0x6000446")]
		[Address(RVA = "0x2C3B774", Offset = "0x2C3B774", VA = "0x2C3B774", Slot = "53")]
		protected virtual void Set(float input, bool sendCallback = true)
		{
		}

		[Token(Token = "0x6000447")]
		[Address(RVA = "0x2C3B8E0", Offset = "0x2C3B8E0", VA = "0x2C3B8E0", Slot = "10")]
		protected override void OnRectTransformDimensionsChange()
		{
		}

		[Token(Token = "0x600044A")]
		[Address(RVA = "0x2C3A928", Offset = "0x2C3A928", VA = "0x2C3A928")]
		private void UpdateVisuals()
		{
		}

		[Token(Token = "0x600044B")]
		[Address(RVA = "0x2C3B91C", Offset = "0x2C3B91C", VA = "0x2C3B91C")]
		private void UpdateDrag(PointerEventData eventData, Camera cam)
		{
		}

		[Token(Token = "0x600044C")]
		[Address(RVA = "0x2C3BB70", Offset = "0x2C3BB70", VA = "0x2C3BB70")]
		private bool MayDrag(PointerEventData eventData)
		{
			return default;
		}

		[Token(Token = "0x600044D")]
		[Address(RVA = "0x2C3BBCC", Offset = "0x2C3BBCC", VA = "0x2C3BBCC", Slot = "32")]
		public override void OnPointerDown(PointerEventData eventData)
		{
		}

		[Token(Token = "0x600044E")]
		[Address(RVA = "0x2C3BDBC", Offset = "0x2C3BDBC", VA = "0x2C3BDBC", Slot = "54")]
		public virtual void OnDrag(PointerEventData eventData)
		{
		}

		[Token(Token = "0x600044F")]
		[Address(RVA = "0x2C3BE38", Offset = "0x2C3BE38", VA = "0x2C3BE38", Slot = "31")]
		public override void OnMove(AxisEventData eventData)
		{
		}

		[Token(Token = "0x6000450")]
		[Address(RVA = "0x2C3C2B8", Offset = "0x2C3C2B8", VA = "0x2C3C2B8", Slot = "27")]
		public override Selectable FindSelectableOnLeft()
		{
			return null;
		}

		[Token(Token = "0x6000451")]
		[Address(RVA = "0x2C3C2DC", Offset = "0x2C3C2DC", VA = "0x2C3C2DC", Slot = "28")]
		public override Selectable FindSelectableOnRight()
		{
			return null;
		}

		[Token(Token = "0x6000452")]
		[Address(RVA = "0x2C3C300", Offset = "0x2C3C300", VA = "0x2C3C300", Slot = "29")]
		public override Selectable FindSelectableOnUp()
		{
			return null;
		}

		[Token(Token = "0x6000453")]
		[Address(RVA = "0x2C3C324", Offset = "0x2C3C324", VA = "0x2C3C324", Slot = "30")]
		public override Selectable FindSelectableOnDown()
		{
			return null;
		}

		[Token(Token = "0x6000454")]
		[Address(RVA = "0x2C3C348", Offset = "0x2C3C348", VA = "0x2C3C348", Slot = "55")]
		public virtual void OnInitializePotentialDrag(PointerEventData eventData)
		{
		}

		[Token(Token = "0x6000455")]
		[Address(RVA = "0x2C3C360", Offset = "0x2C3C360", VA = "0x2C3C360")]
		public void SetDirection(Direction direction, bool includeRectLayouts)
		{
		}

		[SpecialName]
		[Token(Token = "0x6000456")]
		[Address(RVA = "0x2C3C548", Offset = "0x2C3C548", VA = "0x2C3C548", Slot = "42")]
		private Transform UnityEngine_002EUI_002EICanvasElement_002Eget_transform()
		{
			return null;
		}
	}
}
