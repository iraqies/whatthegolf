using System;
using UnityEngine;
using UnityEngine.EventSystems;

public class NotifyOnMouseOverImage : MonoBehaviour, IPointerEnterHandler, IEventSystemHandler, IPointerClickHandler, IPointerExitHandler
{
	public Action<GameObject> OnMouseOverEvent;

	public Action<GameObject> OnMouseExitEvent;

	public Action<GameObject> OnMouseUpEvent;

	public void OnPointerEnter(PointerEventData eventData)
	{
	}

	public void OnPointerClick(PointerEventData eventDatra)
	{
	}

	public void OnPointerExit(PointerEventData eventData)
	{
	}
}
