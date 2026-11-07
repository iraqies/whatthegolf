using UnityEngine;

public class JoustingElephant : MonoBehaviour
{
	public Rigidbody elephantRigidbody;

	public Transform rider;

	public Rigidbody lance;

	public LayerMask opponentLayer;

	public float opponentDetectionRadius;

	private Rigidbody[] ragdoll;

	private Collider[] nearbyOpponents;

	private void Start()
	{
	}

	private void FixedUpdate()
	{
	}

	public void EnableRagdoll()
	{
	}

	private void OnDrawGizmos()
	{
	}
}
