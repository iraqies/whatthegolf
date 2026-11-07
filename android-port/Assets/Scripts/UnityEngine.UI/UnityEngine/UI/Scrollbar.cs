using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using UnityEngine.EventSystems;
using UnityEngine.Events;

namespace UnityEngine.UI
{
	[Token(Token = "0x2000056")]
	[ExecuteAlways]
	[AttributeAttribute(Name = "RequireComponent", RVA = "0x1F67DC", Offset = "0x1F67DC")]
	public class Scrollbar : Selectable, IBeginDragHandler, IEventSystemHandler, IDragHandler, IInitializePotentialDragHandler, ICanvasElement
	{
		[Token(Token = "0x2000057")]
		public enum Direction
		{
			[Token(Token = "0x40001CB")]
			LeftToRight = 0,
			[Token(Token = "0x40001CC")]
			RightToLeft = 1,
			[Token(Token = "0x40001CD")]
			BottomToTop = 2,
			[Token(Token = "0x40001CE")]
			TopToBottom = 3
		}

		[Serializable]
		[Token(Token = "0x2000058")]
		public class ScrollEvent : UnityEvent<float>
		{
			[Token(Token = "0x60003E0")]
			[Address(RVA = "0x2C48B64", Offset = "0x2C48B64", VA = "0x2C48B64")]
			public ScrollEvent()
			{
			}
		}

		[Token(Token = "0x2000059")]
		private enum Axis
		{
			[Token(Token = "0x40001D0")]
			Horizontal = 0,
			[Token(Token = "0x40001D1")]
			Vertical = 1
		}

		[Token(Token = "0x200005A")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x1F6854", Offset = "0x1F6854")]
		private sealed class _003CClickRepeat_003Ed__58 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x40001D2")]
			[FieldOffset(Offset = "0x10")]
			private int _003C_003E1__state;

			[Token(Token = "0x40001D3")]
			[FieldOffset(Offset = "0x18")]
			private object _003C_003E2__current;

			[Token(Token = "0x40001D4")]
			[FieldOffset(Offset = "0x20")]
			public Scrollbar _003C_003E4__this;

			[Token(Token = "0x40001D5")]
			[FieldOffset(Offset = "0x28")]
			public Vector2 screenPosition;

			[Token(Token = "0x40001D6")]
			[FieldOffset(Offset = "0x30")]
			public Camera camera;

			[Token(Token = "0x17000110")]
			private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002ECurrent
			{
				[Token(Token = "0x60003E4")]
				[Address(RVA = "0x2C48B14", Offset = "0x2C48B14", VA = "0x2C48B14", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002Eget_Current();
				}
			}

			[Token(Token = "0x17000111")]
			private object System_002ECollections_002EIEnumerator_002ECurrent
			{
				[Token(Token = "0x60003E6")]
				[Address(RVA = "0x2C48B5C", Offset = "0x2C48B5C", VA = "0x2C48B5C", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return System_002ECollections_002EIEnumerator_002Eget_Current();
				}
			}

			[Token(Token = "0x60003E1")]
			[Address(RVA = "0x2C488F4", Offset = "0x2C488F4", VA = "0x2C488F4")]
			[DebuggerHidden]
			public _003CClickRepeat_003Ed__58(int _003C_003E1__state)
			{
			}

			[Token(Token = "0x60003E2")]
			[Address(RVA = "0x2C48920", Offset = "0x2C48920", VA = "0x2C48920", Slot = "5")]
			[DebuggerHidden]
			private void System_002EIDisposable_002EDispose()
			{
			}

			[Token(Token = "0x60003E3")]
			[Address(RVA = "0x2C48924", Offset = "0x2C48924", VA = "0x2C48924", Slot = "6")]
			private bool MoveNext()
			{
				return default;
			}

			[Token(Token = "0x60003E4")]
			[Address(RVA = "0x2C48B14", Offset = "0x2C48B14", VA = "0x2C48B14", Slot = "4")]
			[DebuggerHidden]
			private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002Eget_Current()
			{
				return null;
			}

			[Token(Token = "0x60003E5")]
			[Address(RVA = "0x2C48B1C", Offset = "0x2C48B1C", VA = "0x2C48B1C", Slot = "8")]
			[DebuggerHidden]
			private void System_002ECollections_002EIEnumerator_002EReset()
			{
			}

			[Token(Token = "0x60003E6")]
			[Address(RVA = "0x2C48B5C", Offset = "0x2C48B5C", VA = "0x2C48B5C", Slot = "7")]
			[DebuggerHidden]
			private object System_002ECollections_002EIEnumerator_002Eget_Current()
			{
				return null;
			}
		}

		[Token(Token = "0x40001BE")]
		[FieldOffset(Offset = "0xF8")]
		[SerializeField]
		private RectTransform m_HandleRect;

		[Token(Token = "0x40001BF")]
		[FieldOffset(Offset = "0x100")]
		[SerializeField]
		private Direction m_Direction;

		[Token(Token = "0x40001C0")]
		[FieldOffset(Offset = "0x104")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x1F7F94", Offset = "0x1F7F94")]
		[SerializeField]
		private float m_Value;

		[Token(Token = "0x40001C1")]
		[FieldOffset(Offset = "0x108")]
		[SerializeField]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x1F7FD4", Offset = "0x1F7FD4")]
		private float m_Size;

		[Token(Token = "0x40001C2")]
		[FieldOffset(Offset = "0x10C")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x1F8014", Offset = "0x1F8014")]
		[SerializeField]
		private int m_NumberOfSteps;

		[Token(Token = "0x40001C3")]
		[FieldOffset(Offset = "0x110")]
		[SerializeField]
		private ScrollEvent m_OnValueChanged;

		[Token(Token = "0x40001C4")]
		[FieldOffset(Offset = "0x118")]
		private RectTransform m_ContainerRect;

		[Token(Token = "0x40001C5")]
		[FieldOffset(Offset = "0x120")]
		private Vector2 m_Offset;

		[Token(Token = "0x40001C6")]
		[FieldOffset(Offset = "0x128")]
		private DrivenRectTransformTracker m_Tracker;

		[Token(Token = "0x40001C7")]
		[FieldOffset(Offset = "0x130")]
		private Coroutine m_PointerDownRepeat;

		[Token(Token = "0x40001C8")]
		[FieldOffset(Offset = "0x138")]
		private bool isPointerDownAndNotDragging;

		[Token(Token = "0x40001C9")]
		[FieldOffset(Offset = "0x139")]
		private bool m_DelayedUpdateVisuals;

		[Token(Token = "0x17000107")]
		public RectTransform handleRect
		{
			[Token(Token = "0x60003B4")]
			[Address(RVA = "0x2C35590", Offset = "0x2C35590", VA = "0x2C35590")]
			get
			{
				return null;
			}
			[Token(Token = "0x60003B5")]
			[Address(RVA = "0x2C35598", Offset = "0x2C35598", VA = "0x2C35598")]
			set
			{
			}
		}

		[Token(Token = "0x17000108")]
		public Direction direction
		{
			[Token(Token = "0x60003B6")]
			[Address(RVA = "0x2C35938", Offset = "0x2C35938", VA = "0x2C35938")]
			get
			{
				return default;
			}
			[Token(Token = "0x60003B7")]
			[Address(RVA = "0x2C35940", Offset = "0x2C35940", VA = "0x2C35940")]
			set
			{
			}
		}

		[Token(Token = "0x17000109")]
		public float value
		{
			[Token(Token = "0x60003B9")]
			[Address(RVA = "0x2C35BBC", Offset = "0x2C35BBC", VA = "0x2C35BBC")]
			get
			{
				return default;
			}
			[Token(Token = "0x60003BA")]
			[Address(RVA = "0x2C340C0", Offset = "0x2C340C0", VA = "0x2C340C0")]
			set
			{
			}
		}

		[Token(Token = "0x1700010A")]
		public float size
		{
			[Token(Token = "0x60003BC")]
			[Address(RVA = "0x2C35E6C", Offset = "0x2C35E6C", VA = "0x2C35E6C")]
			get
			{
				return default;
			}
			[Token(Token = "0x60003BD")]
			[Address(RVA = "0x2C33F38", Offset = "0x2C33F38", VA = "0x2C33F38")]
			set
			{
			}
		}

		[Token(Token = "0x1700010B")]
		public int numberOfSteps
		{
			[Token(Token = "0x60003BE")]
			[Address(RVA = "0x2C35E74", Offset = "0x2C35E74", VA = "0x2C35E74")]
			get
			{
				return default;
			}
			[Token(Token = "0x60003BF")]
			[Address(RVA = "0x2C35E7C", Offset = "0x2C35E7C", VA = "0x2C35E7C")]
			set
			{
			}
		}

		[Token(Token = "0x1700010C")]
		public ScrollEvent onValueChanged
		{
			[Token(Token = "0x60003C0")]
			[Address(RVA = "0x2C35F04", Offset = "0x2C35F04", VA = "0x2C35F04")]
			get
			{
				return null;
			}
			[Token(Token = "0x60003C1")]
			[Address(RVA = "0x2C35F0C", Offset = "0x2C35F0C", VA = "0x2C35F0C")]
			set
			{
			}
		}

		[Token(Token = "0x1700010D")]
		private float stepSize
		{
			[Token(Token = "0x60003C2")]
			[Address(RVA = "0x2C35F14", Offset = "0x2C35F14", VA = "0x2C35F14")]
			get
			{
				return default;
			}
		}

		[Token(Token = "0x1700010E")]
		private Axis axis
		{
			[Token(Token = "0x60003CC")]
			[Address(RVA = "0x2C36438", Offset = "0x2C36438", VA = "0x2C36438")]
			get
			{
				return default;
			}
		}

		[Token(Token = "0x1700010F")]
		private bool reverseValue
		{
			[Token(Token = "0x60003CD")]
			[Address(RVA = "0x2C36448", Offset = "0x2C36448", VA = "0x2C36448")]
			get
			{
				return default;
			}
		}

		[Token(Token = "0x60003B8")]
		[Address(RVA = "0x2C359B8", Offset = "0x2C359B8", VA = "0x2C359B8")]
		protected Scrollbar()
		{
		}

		[Token(Token = "0x60003BB")]
		[Address(RVA = "0x2C35E64", Offset = "0x2C35E64", VA = "0x2C35E64", Slot = "47")]
		public virtual void SetValueWithoutNotify(float input)
		{
		}

		[Token(Token = "0x60003C3")]
		[Address(RVA = "0x2C35F44", Offset = "0x2C35F44", VA = "0x2C35F44", Slot = "48")]
		public virtual void Rebuild(CanvasUpdate executing)
		{
		}

		[Token(Token = "0x60003C4")]
		[Address(RVA = "0x2C35F48", Offset = "0x2C35F48", VA = "0x2C35F48", Slot = "49")]
		public virtual void LayoutComplete()
		{
		}

		[Token(Token = "0x60003C5")]
		[Address(RVA = "0x2C35F4C", Offset = "0x2C35F4C", VA = "0x2C35F4C", Slot = "50")]
		public virtual void GraphicUpdateComplete()
		{
		}

		[Token(Token = "0x60003C6")]
		[Address(RVA = "0x2C35F50", Offset = "0x2C35F50", VA = "0x2C35F50", Slot = "5")]
		protected override void OnEnable()
		{
		}

		[Token(Token = "0x60003C7")]
		[Address(RVA = "0x2C3627C", Offset = "0x2C3627C", VA = "0x2C3627C", Slot = "7")]
		protected override void OnDisable()
		{
		}

		[Token(Token = "0x60003C8")]
		[Address(RVA = "0x2C363E0", Offset = "0x2C363E0", VA = "0x2C363E0", Slot = "51")]
		protected virtual void Update()
		{
		}

		[Token(Token = "0x60003C9")]
		[Address(RVA = "0x2C35618", Offset = "0x2C35618", VA = "0x2C35618")]
		private void UpdateCachedReferences()
		{
		}

		[Token(Token = "0x60003CA")]
		[Address(RVA = "0x2C35C6C", Offset = "0x2C35C6C", VA = "0x2C35C6C")]
		private void Set(float input, bool sendCallback = true)
		{
		}

		[Token(Token = "0x60003CB")]
		[Address(RVA = "0x2C363F8", Offset = "0x2C363F8", VA = "0x2C363F8", Slot = "10")]
		protected override void OnRectTransformDimensionsChange()
		{
		}

		[Token(Token = "0x60003CE")]
		[Address(RVA = "0x2C3571C", Offset = "0x2C3571C", VA = "0x2C3571C")]
		private void UpdateVisuals()
		{
		}

		[Token(Token = "0x60003CF")]
		[Address(RVA = "0x2C3645C", Offset = "0x2C3645C", VA = "0x2C3645C")]
		private void UpdateDrag(PointerEventData eventData)
		{
		}

		[Token(Token = "0x60003D0")]
		[Address(RVA = "0x2C366C4", Offset = "0x2C366C4", VA = "0x2C366C4")]
		private void DoUpdateDrag(Vector2 handleCorner, float remainingSize)
		{
		}

		[Token(Token = "0x60003D1")]
		[Address(RVA = "0x2C36758", Offset = "0x2C36758", VA = "0x2C36758")]
		private bool MayDrag(PointerEventData eventData)
		{
			return default;
		}

		[Token(Token = "0x60003D2")]
		[Address(RVA = "0x2C367B4", Offset = "0x2C367B4", VA = "0x2C367B4", Slot = "52")]
		public virtual void OnBeginDrag(PointerEventData eventData)
		{
		}

		[Token(Token = "0x60003D3")]
		[Address(RVA = "0x2C36994", Offset = "0x2C36994", VA = "0x2C36994", Slot = "53")]
		public virtual void OnDrag(PointerEventData eventData)
		{
		}

		[Token(Token = "0x60003D4")]
		[Address(RVA = "0x2C36A70", Offset = "0x2C36A70", VA = "0x2C36A70", Slot = "32")]
		public override void OnPointerDown(PointerEventData eventData)
		{
		}

		[Token(Token = "0x60003D5")]
		[Address(RVA = "0x2C36DC4", Offset = "0x2C36DC4", VA = "0x2C36DC4")]
		protected IEnumerator ClickRepeat(PointerEventData eventData)
		{
			return null;
		}

		[Token(Token = "0x60003D6")]
		[Address(RVA = "0x2C36D34", Offset = "0x2C36D34", VA = "0x2C36D34")]
		protected IEnumerator ClickRepeat(Vector2 screenPosition, Camera camera)
		{
			return null;
		}

		[Token(Token = "0x60003D7")]
		[Address(RVA = "0x2C36E60", Offset = "0x2C36E60", VA = "0x2C36E60", Slot = "33")]
		public override void OnPointerUp(PointerEventData eventData)
		{
		}

		[Token(Token = "0x60003D8")]
		[Address(RVA = "0x2C36FD8", Offset = "0x2C36FD8", VA = "0x2C36FD8", Slot = "31")]
		public override void OnMove(AxisEventData eventData)
		{
		}

		[Token(Token = "0x60003D9")]
		[Address(RVA = "0x2C37330", Offset = "0x2C37330", VA = "0x2C37330", Slot = "27")]
		public override Selectable FindSelectableOnLeft()
		{
			return null;
		}

		[Token(Token = "0x60003DA")]
		[Address(RVA = "0x2C37408", Offset = "0x2C37408", VA = "0x2C37408", Slot = "28")]
		public override Selectable FindSelectableOnRight()
		{
			return null;
		}

		[Token(Token = "0x60003DB")]
		[Address(RVA = "0x2C374E0", Offset = "0x2C374E0", VA = "0x2C374E0", Slot = "29")]
		public override Selectable FindSelectableOnUp()
		{
			return null;
		}

		[Token(Token = "0x60003DC")]
		[Address(RVA = "0x2C375B8", Offset = "0x2C375B8", VA = "0x2C375B8", Slot = "30")]
		public override Selectable FindSelectableOnDown()
		{
			return null;
		}

		[Token(Token = "0x60003DD")]
		[Address(RVA = "0x2C37690", Offset = "0x2C37690", VA = "0x2C37690", Slot = "54")]
		public virtual void OnInitializePotentialDrag(PointerEventData eventData)
		{
		}

		[Token(Token = "0x60003DE")]
		[Address(RVA = "0x2C376A8", Offset = "0x2C376A8", VA = "0x2C376A8")]
		public void SetDirection(Direction direction, bool includeRectLayouts)
		{
		}

		[SpecialName]
		[Token(Token = "0x60003DF")]
		[Address(RVA = "0x2C37890", Offset = "0x2C37890", VA = "0x2C37890", Slot = "43")]
		private Transform UnityEngine_002EUI_002EICanvasElement_002Eget_transform()
		{
			return null;
		}
	}
}
