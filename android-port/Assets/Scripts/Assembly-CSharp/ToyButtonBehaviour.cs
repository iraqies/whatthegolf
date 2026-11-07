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
	}
}
