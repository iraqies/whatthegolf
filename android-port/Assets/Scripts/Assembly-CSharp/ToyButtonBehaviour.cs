using UnityEngine;
using UnityEngine.Events;

public class ToyButtonBehaviour : MonoBehaviour
{
	public bool canBePushedAgain;
	public Animator buttonAnimator;
	public ButtonConsoleBehaviour console;
	public UnityEvent OnButtonPushed;
	private bool pushed;

	private void OnCollisionEnter(Collision collision)
	{
		if (pushed && !canBePushedAgain)
			return;
		pushed = true;
		if (buttonAnimator != null)
			buttonAnimator.SetTrigger("Push");
		OnButtonPushed?.Invoke();
	}
}
