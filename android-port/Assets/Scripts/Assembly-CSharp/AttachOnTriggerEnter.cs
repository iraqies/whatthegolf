using System.Collections.Generic;
using UnityEngine;

public class AttachOnTriggerEnter : MonoBehaviour
{
	[SerializeField]
	private Collider triggerArea;

	[SerializeField]
	private List<GameObject> acceptedObjects;

	private void OnTriggerEnter(Collider other)
	{
	}
}
