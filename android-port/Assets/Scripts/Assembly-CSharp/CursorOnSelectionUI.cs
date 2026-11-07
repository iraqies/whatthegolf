using System.Collections;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class CursorOnSelectionUI : MonoBehaviour, ISelectHandler, IEventSystemHandler, IDeselectHandler, IPointerEnterHandler, IPointerExitHandler
{
	[SerializeField]
	private Graphic _cursor;

	[SerializeField]
	private float _offset;

	private float _speed;

	private Vector2 _offsetMaxCached;

	private Vector2 _offsetMinCached;

	private Coroutine _animCR;

	private Coroutine _fadeCR;

	private void Awake()
	{
	}

	public void OnDeselect(BaseEventData eventData)
	{
	}

	private void HideCursor()
	{
	}

	private void ShowCursor()
	{
	}

	public void OnSelect(BaseEventData eventData)
	{
	}

	private void OnDisable()
	{
	}

	private IEnumerator DeselectWhenTouchEndedCR()
	{
		return null;
	}

	private IEnumerator AnimCR()
	{
		return null;
	}

	public void OnPointerEnter(PointerEventData eventData)
	{
	}

	public void OnPointerExit(PointerEventData eventData)
	{
	}
}
