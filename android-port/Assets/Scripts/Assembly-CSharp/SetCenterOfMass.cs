using UnityEngine;

public class SetCenterOfMass : MonoBehaviour
{
	public Transform CenterOfMass;

	private void Awake()
	{
		if (CenterOfMass != null)
			UpdateCenterOfMass(CenterOfMass.localPosition);
	}

	public void UpdateCenterOfMass(Vector3 newCoMPosition)
	{
		var rb = GetComponent<Rigidbody>();
		if (rb != null) rb.centerOfMass = newCoMPosition;
	}
}
