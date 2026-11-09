using System.Threading.Tasks;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class ScrollableButton : Button, IBeginDragHandler, IEventSystemHandler, IDragHandler, IEndDragHandler
{
	private ScrollRect _scrollGameObject;

	private bool _canClick = true;

	public void Init(ScrollRect scrollGameObject)
	{
		_scrollGameObject = scrollGameObject;
	}

	public override void OnPointerClick(PointerEventData eventData)
	{
		if (_canClick)
			base.OnPointerClick(eventData);
	}

	public override void OnSubmit(BaseEventData eventData)
	{
		if (_canClick)
			base.OnSubmit(eventData);
	}

	public override async void OnPointerUp(PointerEventData eventData)
	{
		base.OnPointerUp(eventData);
		await Task.Yield();
		_canClick = true;
	}

	public void OnBeginDrag(PointerEventData eventData)
	{
		_canClick = false;
		if (_scrollGameObject != null)
			_scrollGameObject.OnBeginDrag(eventData);
	}

	public void OnDrag(PointerEventData eventData)
	{
		if (_scrollGameObject != null)
			_scrollGameObject.OnDrag(eventData);
	}

	public void OnEndDrag(PointerEventData eventData)
	{
		if (_scrollGameObject != null)
			_scrollGameObject.OnEndDrag(eventData);
	}
}
