using UnityEngine;

public class SetMaxAngularVelocity2D : MonoBehaviour
{
	[SerializeField]
	private float maxAngularVelocity = 7f;

	[SerializeField]
	private bool includeChildren;

	private Rigidbody2D[] bodies;

	private void Awake()
	{
		if (includeChildren)
		{
			bodies = GetComponentsInChildren<Rigidbody2D>();
		}
		else
		{
			Rigidbody2D rb = GetComponent<Rigidbody2D>();
			bodies = rb != null ? new Rigidbody2D[] { rb } : new Rigidbody2D[0];
		}
	}

	private void FixedUpdate()
	{
		if (bodies == null)
			return;
		for (int i = 0; i < bodies.Length; i++)
		{
			Rigidbody2D rb = bodies[i];
			if (rb != null)
			{
				rb.angularVelocity = Mathf.Clamp(rb.angularVelocity, -maxAngularVelocity, maxAngularVelocity);
			}
		}
	}
}
