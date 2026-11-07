using UnityEngine;
using UnityEngine.Events;

public class TriggerEnterAction : MonoBehaviour
{
	public UnityEvent<GameObject> triggerEntered;

	private void OnTriggerEnter(Collider other)
	{
	}
}
