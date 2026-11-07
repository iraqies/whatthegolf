using UnityEngine.EventSystems;
using UnityEngine.UI;

public class ScrollableButton : Button, IBeginDragHandler, IEventSystemHandler, IDragHandler, IEndDragHandler
{
	private ScrollRect _scrollGameObject;

	private bool _canClick;

	public void Init(ScrollRect scrollGameObject)
	{
	}

	public override void OnPointerClick(PointerEventData eventData)
	{
	}

	public override void OnSubmit(BaseEventData eventData)
	{
	}

	public override void OnPointerUp(PointerEventData eventData)
	{
	}

	public void OnBeginDrag(PointerEventData eventData)
	{
	}

	public void OnDrag(PointerEventData eventData)
	{
	}

	public void OnEndDrag(PointerEventData eventData)
	{
	}
}
