using UnityEngine;

public class Break : MonoBehaviour
{
	private Rigidbody[] rigidShards;

	private Rigidbody[] parentRigidbodies;

	private Collider[] parentColliders;

	private Collider[] childColliders;

	private bool broken;

	[SerializeField]
	private double breakVelocity;

	private Rigidbody rb;

	public Collider[] toBeDestroyed;

	private void Start()
	{
	}

	private void OnCollisionEnter(Collision other)
	{
	}
}
