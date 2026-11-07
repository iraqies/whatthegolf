using System.Collections;
using UnityEngine;

public class ToggleKinematicOnTrigger : MonoBehaviour
{
	[SerializeField]
	private LayerMask layerMask;

	[SerializeField]
	private bool kinematicState;

	[SerializeField]
	private float delay;

	private void OnTriggerEnter(Collider other)
	{
	}

	private IEnumerator DelayedToggle(Rigidbody rigid)
	{
		return null;
	}
}
