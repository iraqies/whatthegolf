using UnityEngine;

public class RespawnOnOutOfBounds : MonoBehaviour
{
	private Vector3 startPos;

	private Quaternion startRot;

	private void Start()
	{
		startPos = transform.position;
		startRot = transform.rotation;
	}

	private void OnTriggerEnter(Collider other)
	{
		if (other != null && (other.tag == "OutOfBounds" || other.tag == "OutOfBoundsReset" || other.tag == "OutOfBoundsReload"))
		{
			OutOfBounds();
		}
	}

	public void OutOfBounds()
	{
		transform.position = startPos;
		transform.rotation = startRot;
		Rigidbody rb = GetComponent<Rigidbody>();
		if (rb != null && !rb.isKinematic)
		{
			rb.velocity = Vector3.zero;
			rb.angularVelocity = Vector3.zero;
		}
	}
}
