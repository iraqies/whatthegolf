using System;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.Events;

public class HiddenHoldButton : MonoBehaviour, IPointerDownHandler, IEventSystemHandler, IPointerUpHandler, IPointerExitHandler
{
	[Serializable]
	public class ButtonHoldEvent : UnityEvent
	{
	}

	public ButtonHoldEvent onHold;

	[SerializeField]
	private float _holdDuration;

	private float _holdStartTime;

	public void OnPointerDown(PointerEventData pointerEventData)
	{
	}

	public void OnPointerUp(PointerEventData pointerEventData)
	{
	}

	public void OnPointerExit(PointerEventData eventData)
	{
	}

	private void TryTriggerEvent()
	{
	}
}
