using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine.Events;

namespace UnityEngine.EventSystems
{
	[Token(Token = "0x200009D")]
	public class EventTrigger : MonoBehaviour, IPointerEnterHandler, IEventSystemHandler, IPointerExitHandler, IPointerDownHandler, IPointerUpHandler, IPointerClickHandler, IInitializePotentialDragHandler, IBeginDragHandler, IDragHandler, IEndDragHandler, IDropHandler, IScrollHandler, IUpdateSelectedHandler, ISelectHandler, IDeselectHandler, IMoveHandler, ISubmitHandler, ICancelHandler
	{
		[Serializable]
		[Token(Token = "0x200009E")]
		public class TriggerEvent : UnityEvent<BaseEventData>
		{
			[Token(Token = "0x60005BD")]
			[Address(RVA = "0x2C44F44", Offset = "0x2C44F44", VA = "0x2C44F44")]
			public TriggerEvent()
			{
			}
		}

		[Serializable]
		[Token(Token = "0x200009F")]
		public class Entry
		{
			[Token(Token = "0x4000291")]
			[FieldOffset(Offset = "0x10")]
			public EventTriggerType eventID;

			[Token(Token = "0x4000292")]
			[FieldOffset(Offset = "0x18")]
			public TriggerEvent callback;

			[Token(Token = "0x60005BE")]
			[Address(RVA = "0x2C44EA4", Offset = "0x2C44EA4", VA = "0x2C44EA4")]
			public Entry()
			{
			}
		}

		[Token(Token = "0x4000290")]
		[FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "FormerlySerializedAsAttribute", RVA = "0x1F85E8", Offset = "0x1F85E8")]
		[SerializeField]
		private List<Entry> m_Delegates;

		[Token(Token = "0x17000188")]
		[AttributeAttribute(Name = "EditorBrowsableAttribute", RVA = "0x1F8E90", Offset = "0x1F8E90")]
		[AttributeAttribute(Name = "ObsoleteAttribute", RVA = "0x1F8E90", Offset = "0x1F8E90")]
		public List<Entry> delegates
		{
			[Token(Token = "0x60005A6")]
			[Address(RVA = "0x2C01FF4", Offset = "0x2C01FF4", VA = "0x2C01FF4")]
			get
			{
				return null;
			}
			[Token(Token = "0x60005A7")]
			[Address(RVA = "0x2C020EC", Offset = "0x2C020EC", VA = "0x2C020EC")]
			set
			{
			}
		}

		[Token(Token = "0x17000189")]
		public List<Entry> triggers
		{
			[Token(Token = "0x60005A9")]
			[Address(RVA = "0x2C02070", Offset = "0x2C02070", VA = "0x2C02070")]
			get
			{
				return null;
			}
			[Token(Token = "0x60005AA")]
			[Address(RVA = "0x2C020FC", Offset = "0x2C020FC", VA = "0x2C020FC")]
			set
			{
			}
		}

		[Token(Token = "0x60005A8")]
		[Address(RVA = "0x2C020F4", Offset = "0x2C020F4", VA = "0x2C020F4")]
		protected EventTrigger()
		{
		}

		[Token(Token = "0x60005AB")]
		[Address(RVA = "0x2C02104", Offset = "0x2C02104", VA = "0x2C02104")]
		private void Execute(EventTriggerType id, BaseEventData eventData)
		{
		}

		[Token(Token = "0x60005AC")]
		[Address(RVA = "0x2C02318", Offset = "0x2C02318", VA = "0x2C02318", Slot = "21")]
		public virtual void OnPointerEnter(PointerEventData eventData)
		{
		}

		[Token(Token = "0x60005AD")]
		[Address(RVA = "0x2C02324", Offset = "0x2C02324", VA = "0x2C02324", Slot = "22")]
		public virtual void OnPointerExit(PointerEventData eventData)
		{
		}

		[Token(Token = "0x60005AE")]
		[Address(RVA = "0x2C02330", Offset = "0x2C02330", VA = "0x2C02330", Slot = "23")]
		public virtual void OnDrag(PointerEventData eventData)
		{
		}

		[Token(Token = "0x60005AF")]
		[Address(RVA = "0x2C0233C", Offset = "0x2C0233C", VA = "0x2C0233C", Slot = "24")]
		public virtual void OnDrop(PointerEventData eventData)
		{
		}

		[Token(Token = "0x60005B0")]
		[Address(RVA = "0x2C02348", Offset = "0x2C02348", VA = "0x2C02348", Slot = "25")]
		public virtual void OnPointerDown(PointerEventData eventData)
		{
		}

		[Token(Token = "0x60005B1")]
		[Address(RVA = "0x2C02354", Offset = "0x2C02354", VA = "0x2C02354", Slot = "26")]
		public virtual void OnPointerUp(PointerEventData eventData)
		{
		}

		[Token(Token = "0x60005B2")]
		[Address(RVA = "0x2C02360", Offset = "0x2C02360", VA = "0x2C02360", Slot = "27")]
		public virtual void OnPointerClick(PointerEventData eventData)
		{
		}

		[Token(Token = "0x60005B3")]
		[Address(RVA = "0x2C0236C", Offset = "0x2C0236C", VA = "0x2C0236C", Slot = "28")]
		public virtual void OnSelect(BaseEventData eventData)
		{
		}

		[Token(Token = "0x60005B4")]
		[Address(RVA = "0x2C02378", Offset = "0x2C02378", VA = "0x2C02378", Slot = "29")]
		public virtual void OnDeselect(BaseEventData eventData)
		{
		}

		[Token(Token = "0x60005B5")]
		[Address(RVA = "0x2C02384", Offset = "0x2C02384", VA = "0x2C02384", Slot = "30")]
		public virtual void OnScroll(PointerEventData eventData)
		{
		}

		[Token(Token = "0x60005B6")]
		[Address(RVA = "0x2C02390", Offset = "0x2C02390", VA = "0x2C02390", Slot = "31")]
		public virtual void OnMove(AxisEventData eventData)
		{
		}

		[Token(Token = "0x60005B7")]
		[Address(RVA = "0x2C0239C", Offset = "0x2C0239C", VA = "0x2C0239C", Slot = "32")]
		public virtual void OnUpdateSelected(BaseEventData eventData)
		{
		}

		[Token(Token = "0x60005B8")]
		[Address(RVA = "0x2C023A8", Offset = "0x2C023A8", VA = "0x2C023A8", Slot = "33")]
		public virtual void OnInitializePotentialDrag(PointerEventData eventData)
		{
		}

		[Token(Token = "0x60005B9")]
		[Address(RVA = "0x2C023B4", Offset = "0x2C023B4", VA = "0x2C023B4", Slot = "34")]
		public virtual void OnBeginDrag(PointerEventData eventData)
		{
		}

		[Token(Token = "0x60005BA")]
		[Address(RVA = "0x2C023C0", Offset = "0x2C023C0", VA = "0x2C023C0", Slot = "35")]
		public virtual void OnEndDrag(PointerEventData eventData)
		{
		}

		[Token(Token = "0x60005BB")]
		[Address(RVA = "0x2C023CC", Offset = "0x2C023CC", VA = "0x2C023CC", Slot = "36")]
		public virtual void OnSubmit(BaseEventData eventData)
		{
		}

		[Token(Token = "0x60005BC")]
		[Address(RVA = "0x2C023D8", Offset = "0x2C023D8", VA = "0x2C023D8", Slot = "37")]
		public virtual void OnCancel(BaseEventData eventData)
		{
		}
	}
}
