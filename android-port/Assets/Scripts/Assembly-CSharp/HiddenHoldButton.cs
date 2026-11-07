using System;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.Events;

[Token(Token = "0x20008FA")]
public class HiddenHoldButton : MonoBehaviour, IPointerDownHandler, IEventSystemHandler, IPointerUpHandler, IPointerExitHandler
{
	[Serializable]
	[Token(Token = "0x20008FB")]
	public class ButtonHoldEvent : UnityEvent
	{
		[Token(Token = "0x600297F")]
		[Address(RVA = "0x17BA660", Offset = "0x17BA660", VA = "0x17BA660")]
		public ButtonHoldEvent()
		{
		}
	}

	[Token(Token = "0x40030FE")]
	[FieldOffset(Offset = "0x18")]
	public ButtonHoldEvent onHold;

	[Token(Token = "0x40030FF")]
	[FieldOffset(Offset = "0x20")]
	[SerializeField]
	private float _holdDuration;

	[Token(Token = "0x4003100")]
	[FieldOffset(Offset = "0x24")]
	private float _holdStartTime;

	[Token(Token = "0x600297A")]
	[Address(RVA = "0x14C6A50", Offset = "0x14C6A50", VA = "0x14C6A50", Slot = "4")]
	public void OnPointerDown(PointerEventData pointerEventData)
	{
	}

	[Token(Token = "0x600297B")]
	[Address(RVA = "0x14C6A78", Offset = "0x14C6A78", VA = "0x14C6A78", Slot = "5")]
	public void OnPointerUp(PointerEventData pointerEventData)
	{
	}

	[Token(Token = "0x600297C")]
	[Address(RVA = "0x14C6B2C", Offset = "0x14C6B2C", VA = "0x14C6B2C", Slot = "6")]
	public void OnPointerExit(PointerEventData eventData)
	{
	}

	[Token(Token = "0x600297D")]
	[Address(RVA = "0x14C6A7C", Offset = "0x14C6A7C", VA = "0x14C6A7C")]
	private void TryTriggerEvent()
	{
	}

	[Token(Token = "0x600297E")]
	[Address(RVA = "0x14C6B30", Offset = "0x14C6B30", VA = "0x14C6B30")]
	public HiddenHoldButton()
	{
	}
}
