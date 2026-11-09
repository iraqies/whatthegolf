using UnityEngine;

public class GenericButton : MonoBehaviour
{
	private Animator anim;
	public bool isPressed;

	private void Awake()
	{
		anim = GetComponent<Animator>() ?? GetComponentInChildren<Animator>();
	}

	protected virtual void OnPress()
	{
	}

	protected virtual void OnToggle()
	{
	}

	private void OnTriggerStay(Collider other)
	{
		if (other == null || other.isTrigger) return;
		if (!isPressed)
		{
			isPressed = true;
			if (anim != null)
				anim.SetBool("Pressed", true);
			OnPress();
			OnToggle();
		}
	}

	private void OnTriggerExit(Collider other)
	{
		if (other == null || other.isTrigger) return;
		if (isPressed)
		{
			isPressed = false;
			if (anim != null)
				anim.SetBool("Pressed", false);
			OnToggle();
		}
	}
}
