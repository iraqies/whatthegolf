using UnityEngine;
using UnityEngine.Events;

public class ActionOnOutOfBounds : MonoBehaviour
{
	[SerializeField]
	private UnityEvent OnOutOfBounds;

	private void OnTriggerEnter(Collider other)
	{
		if (other == null) return;
		if (other.CompareTag("OutOfBoundsReload") || other.CompareTag("OutOfBoundsReset") || other.CompareTag("OutOfBounds"))
		{
			OnOutOfBounds?.Invoke();
		}
	}
}
