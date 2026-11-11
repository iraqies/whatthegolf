using System;
using UnityEngine;

public class BeamPoint : MonoBehaviour
{
	public Action<BeamableObject> OnEnterBeamPoint;

	private void OnTriggerEnter(Collider other)
	{
		if (other != null && other.attachedRigidbody != null)
		{
			BeamableObject component = other.attachedRigidbody.GetComponent<BeamableObject>();
			if (component != null)
			{
				OnEnterBeamPoint?.Invoke(component);
			}
		}
	}
}
