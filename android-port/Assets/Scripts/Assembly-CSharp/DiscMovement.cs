using UnityEngine;

public class DiscMovement : MonoBehaviour
{
	public Transform Pivot;

	public float ForceMod;

	public float MoveSpeed;

	public float DeadZoneSize;

	public float MaxRotate;

	public Collider WinCollider;

	private Rigidbody rigidbody;

	private Vector3 currentDirection;

	private ParticleSystem crashParticles;

	private void Start()
	{
	}

	private void OnCollisionStay(Collision other)
	{
	}

	private void OnTriggerEnter(Collider other)
	{
	}

	private void FixedUpdate()
	{
	}

	private void OnDrawGizmosSelected()
	{
	}
}
