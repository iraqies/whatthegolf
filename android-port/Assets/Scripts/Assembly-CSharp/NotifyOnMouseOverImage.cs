using System;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.EventSystems;

[Token(Token = "0x20008EF")]
public class NotifyOnMouseOverImage : MonoBehaviour, IPointerEnterHandler, IEventSystemHandler, IPointerClickHandler, IPointerExitHandler
{
	[Token(Token = "0x40030CD")]
	[FieldOffset(Offset = "0x18")]
	public Action<GameObject> OnMouseOverEvent;

	[Token(Token = "0x40030CE")]
	[FieldOffset(Offset = "0x20")]
	public Action<GameObject> OnMouseExitEvent;

	[Token(Token = "0x40030CF")]
	[FieldOffset(Offset = "0x28")]
	public Action<GameObject> OnMouseUpEvent;

	[Token(Token = "0x6002945")]
	[Address(RVA = "0x158FB50", Offset = "0x158FB50", VA = "0x158FB50", Slot = "4")]
	public void OnPointerEnter(PointerEventData eventData)
	{
	}

	[Token(Token = "0x6002946")]
	[Address(RVA = "0x158FBC4", Offset = "0x158FBC4", VA = "0x158FBC4", Slot = "5")]
	public void OnPointerClick(PointerEventData eventDatra)
	{
	}

	[Token(Token = "0x6002947")]
	[Address(RVA = "0x158FC38", Offset = "0x158FC38", VA = "0x158FC38", Slot = "6")]
	public void OnPointerExit(PointerEventData eventData)
	{
	}

	[Token(Token = "0x6002948")]
	[Address(RVA = "0x158FCAC", Offset = "0x158FCAC", VA = "0x158FCAC")]
	public NotifyOnMouseOverImage()
	{
	}
}
