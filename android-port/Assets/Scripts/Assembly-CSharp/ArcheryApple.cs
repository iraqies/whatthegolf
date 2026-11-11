using UnityEngine;

public class ArcheryApple : MonoBehaviour
{
	[SerializeField]
	private Vector3 minVelOnceHit = new Vector3(5f, 0f, 0f);

	private bool wasHit;

	private Rigidbody rb;

	private string arrowLayerName = "ShootArrow";

	[SerializeField]
	private Collider col;

	private void Awake()
	{
		rb = GetComponent<Rigidbody>();
	}

	private void OnCollisionEnter(Collision collision)
	{
		if (LayerMask.NameToLayer(arrowLayerName) == collision.collider.gameObject.layer)
		{
			wasHit = true;
			Physics.IgnoreCollision(collision.collider, col);
		}
	}

	private void FixedUpdate()
	{
		if (wasHit)
		{
			Vector3 vector = Vector3.Project(rb.velocity, minVelOnceHit);
			rb.velocity = rb.velocity - vector + minVelOnceHit.normalized * Mathf.Max(vector.magnitude, minVelOnceHit.magnitude);
		}
	}
}
