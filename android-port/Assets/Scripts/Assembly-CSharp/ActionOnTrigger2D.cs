using UnityEngine;
using UnityEngine.Events;

public class ActionOnTrigger2D : MonoBehaviour
{
	public UnityEvent OnTriggerEnter;

	private void OnTriggerEnter2D(Collider2D other)
	{
		OnTriggerEnter?.Invoke();
	}
}
