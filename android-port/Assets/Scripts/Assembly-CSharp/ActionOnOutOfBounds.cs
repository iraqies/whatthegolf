using UnityEngine;
using UnityEngine.Events;

public class ActionOnOutOfBounds : MonoBehaviour
{
	[SerializeField]
	private UnityEvent OnOutOfBounds;

	private void OnTriggerEnter(Collider other)
	{
	}
}
