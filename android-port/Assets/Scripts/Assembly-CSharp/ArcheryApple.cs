using UnityEngine;

public class ArcheryApple : MonoBehaviour
{
	[SerializeField]
	private Vector3 minVelOnceHit;

	private bool wasHit;

	private Rigidbody rb;

	private string arrowLayerName;

	[SerializeField]
	private Collider col;

	private void Awake()
	{
	}

	private void OnCollisionEnter(Collision collision)
	{
	}

	private void FixedUpdate()
	{
	}
}
