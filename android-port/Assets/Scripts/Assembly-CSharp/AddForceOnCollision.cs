using UnityEngine;

public class AddForceOnCollision : MonoBehaviour
{
	public float Force;

	public float UpwardsForce;

	public ForceMode ForceMode;

	public bool AddToIncomingRigidbody;

	public bool CheckLayer;

	public LayerMask LayerMask;

	private Rigidbody m_ThisRigidbody;

	private void Awake()
	{
	}

	private void OnCollisionEnter(Collision collision)
	{
	}
}
