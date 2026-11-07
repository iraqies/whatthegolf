using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class ScrollRectNested : ScrollRect
{
	[SerializeField]
	private ScrollRect parentScrollRect;

	private bool routeToParent;

	protected override void Start()
	{
	}

	public override void OnInitializePotentialDrag(PointerEventData eventData)
	{
	}

	public override void OnDrag(PointerEventData eventData)
	{
	}

	public override void OnBeginDrag(PointerEventData eventData)
	{
	}

	public override void OnEndDrag(PointerEventData eventData)
	{
	}

	public override void OnScroll(PointerEventData eventData)
	{
	}
}
