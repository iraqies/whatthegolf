using System.Collections;
using UnityEngine;

public class SnapToPositionOnTrigger : MonoBehaviour
{
	[SerializeField]
	private LayerMask layerMask;

	[SerializeField]
	private Transform target;

	[SerializeField]
	private float snapTime;

	private void OnTriggerEnter(Collider other)
	{
	}

	public void StartSnapping(Transform trans)
	{
	}

	private IEnumerator SnapRoutine(Transform trans)
	{
		return null;
	}
}
