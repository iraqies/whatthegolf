using UnityEngine;

public class NiceBall : MonoBehaviour
{
	public float radius;

	public bool lockYbounceToZero;

	[SerializeField]
	private float bounceYAngleThreshold;

	[SerializeField]
	private float useNormalAsGravityAngleThreshold;

	[SerializeField]
	private float dampenYMultiplier;

	[SerializeField]
	private float dampenAngularVelocityMultiplier;

	[SerializeField]
	private float otherIsRigidMultiplier;

	public Rigidbody rigidbody;

	private Vector3 lastVelocity;

	private Vector3 lastAngularVelocity;

	private void Awake()
	{
	}

	private void FixedUpdate()
	{
	}

	private void OnDrawGizmosSelected()
	{
	}

	public void Push(Vector3 newForce)
	{
	}

	private void OnCollisionEnter(Collision col)
	{
	}

	public void IgnoreLastCollision(float amount)
	{
	}
}
