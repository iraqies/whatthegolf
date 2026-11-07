using UnityEngine;

public class Car : MonoBehaviour
{
	public bool isApplyingBaseForward;

	[SerializeField]
	private float bounceYAngleThreshold;

	public Rigidbody rigid;

	private Vector3 lastVelocity;

	private Vector3 lastAngularVelocity;

	private void Awake()
	{
	}

	private void FixedUpdate()
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
