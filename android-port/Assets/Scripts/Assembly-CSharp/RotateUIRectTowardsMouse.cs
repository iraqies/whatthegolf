using UnityEngine;
using UnityEngine.EventSystems;

public class RotateUIRectTowardsMouse : MonoBehaviour, IDragHandler, IEventSystemHandler, IEndDragHandler
{
	public Animator ScanlinesAnimator;

	public GameObject CorrectChannelObject;

	public GameObject FrogKingChannelObject;

	public Canvas canvas;

	public float regularAngle = 24f;

	public float regularTolerace = 16f;

	public float secretAngle = 270f;

	public float secretTolerace = 5f;

	public UnlockAchievement achievement;

	private bool isSecretShown;

	private bool isDraggingWithController;

	private float controllerUpDownValue = 24f;

	public void OnDrag(PointerEventData eventData)
	{
		if (canvas == null || canvas.worldCamera == null)
		{
			return;
		}
		Vector3 mousePos = Input.mousePosition;
		Vector3 screenPos = canvas.worldCamera.WorldToScreenPoint(transform.position);
		float angle = Mathf.Atan2(mousePos.y - screenPos.y, mousePos.x - screenPos.x) * Mathf.Rad2Deg;
		transform.rotation = Quaternion.Euler(0f, 0f, angle);
		UpdateSignal(angle);
	}

	private void UpdateAngle(Vector2 dir)
	{
		float angle = Mathf.Atan2(dir.y, dir.x) * Mathf.Rad2Deg;
		transform.rotation = Quaternion.Euler(0f, 0f, angle);
		UpdateSignal(angle);
	}

	public void Update()
	{
		int vert = InputHelper.GetAllPlayerAxisRoundedVertical();
		if (vert != 0)
		{
			controllerUpDownValue += vert;
			transform.rotation = Quaternion.Euler(0f, 0f, controllerUpDownValue);
			UpdateSignal(controllerUpDownValue);
			isDraggingWithController = true;
		}
		else if (isDraggingWithController)
		{
			isDraggingWithController = false;
			if (isSecretShown && achievement != null)
			{
				achievement.ManualUnlock();
			}
		}
	}

	public void OnEndDrag(PointerEventData eventData)
	{
		if (isSecretShown && achievement != null)
		{
			achievement.ManualUnlock();
		}
	}

	private void UpdateSignal(float angle)
	{
		if (angle < 0f)
		{
			angle += 360f;
		}
		if (angle > secretAngle - secretTolerace && angle < secretAngle + secretTolerace)
		{
			if (CorrectChannelObject != null)
			{
				CorrectChannelObject.SetActive(false);
			}
			if (FrogKingChannelObject != null)
			{
				FrogKingChannelObject.SetActive(true);
			}
			if (ScanlinesAnimator != null)
			{
				ScanlinesAnimator.SetBool("SignalLost", false);
			}
			isSecretShown = true;
		}
		else if (angle > regularAngle - regularTolerace && angle < regularAngle + regularTolerace)
		{
			if (CorrectChannelObject != null)
			{
				CorrectChannelObject.SetActive(true);
			}
			if (FrogKingChannelObject != null)
			{
				FrogKingChannelObject.SetActive(false);
			}
			if (ScanlinesAnimator != null)
			{
				ScanlinesAnimator.SetBool("SignalLost", false);
			}
			isSecretShown = false;
		}
		else
		{
			if (ScanlinesAnimator != null)
			{
				ScanlinesAnimator.SetBool("SignalLost", true);
			}
			isSecretShown = false;
		}
	}

	private void ToggleSignalLost(bool signalIsLost)
	{
		if (ScanlinesAnimator != null)
		{
			ScanlinesAnimator.SetBool("SignalLost", signalIsLost);
		}
	}
}
