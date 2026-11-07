using UnityEngine;

public class GenericButton : MonoBehaviour
{
	private Animator anim;

	public bool isPressed;

	private void Awake()
	{
	}

	protected virtual void OnPress()
	{
	}

	protected virtual void OnToggle()
	{
	}

	private void OnTriggerStay(Collider other)
	{
	}

	private void OnTriggerExit(Collider other)
	{
	}
}
