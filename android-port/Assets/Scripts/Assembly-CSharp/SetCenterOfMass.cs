using UnityEngine;

public class SetCenterOfMass : MonoBehaviour
{
	public Transform CenterOfMass;

	private void Awake()
	{
		Rigidbody rb = GetComponent<Rigidbody>();
		if (rb != null && CenterOfMass != null)
		{
			rb.centerOfMass = transform.InverseTransformPoint(CenterOfMass.position);
		}
	}

	public void UpdateCenterOfMass(Vector3 newCoMPosition)
	{
		Rigidbody rb = GetComponent<Rigidbody>();
		if (rb != null)
		{
			rb.centerOfMass = transform.InverseTransformPoint(newCoMPosition);
		}
	}
}
