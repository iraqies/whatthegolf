using UnityEngine;

public class SetCenterOfMass2D : MonoBehaviour
{
	public Transform CenterOfMass;

	private void Awake()
	{
		Rigidbody2D rb = GetComponent<Rigidbody2D>();
		if (rb != null && CenterOfMass != null)
		{
			Vector3 local = transform.InverseTransformPoint(CenterOfMass.position);
			rb.centerOfMass = new Vector2(local.x, local.y);
		}
	}
}
