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
		OnMouseOverEvent?.Invoke(gameObject);
	}

	public void OnPointerClick(PointerEventData eventDatra)
	{
		OnMouseUpEvent?.Invoke(gameObject);
	}

	public void OnPointerExit(PointerEventData eventData)
	{
		OnMouseExitEvent?.Invoke(gameObject);
	}
}
