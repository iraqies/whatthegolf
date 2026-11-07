using UnityEngine;
using UnityEngine.EventSystems;

public class RotateUIRectTowardsMouse : MonoBehaviour, IDragHandler, IEventSystemHandler, IEndDragHandler
{
	public Animator ScanlinesAnimator;

	public GameObject CorrectChannelObject;

	public GameObject FrogKingChannelObject;

	public Canvas canvas;

	public float regularAngle;

	public float regularTolerace;

	public float secretAngle;

	public float secretTolerace;

	public UnlockAchievement achievement;

	private bool isSecretShown;

	private bool isDraggingWithController;

	private float controllerUpDownValue;

	public void OnDrag(PointerEventData eventData)
	{
	}

	private void UpdateAngle(Vector2 dir)
	{
	}

	public void Update()
	{
	}

	public void OnEndDrag(PointerEventData eventData)
	{
	}

	private void UpdateSignal(float angle)
	{
	}

	private void ToggleSignalLost(bool signalIsLost)
	{
	}
}
