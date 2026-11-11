using UnityEngine;

public class Car : MonoBehaviour
{
	public bool isApplyingBaseForward = true;

	[SerializeField]
	private float bounceYAngleThreshold = 45f;

	public Rigidbody rigid;

	private Vector3 lastVelocity;

	private Vector3 lastAngularVelocity;

	private void Awake()
	{
		if (rigid == null)
		{
			rigid = GetComponent<Rigidbody>();
		}
	}

	private void FixedUpdate()
	{
		if (rigid != null)
		{
			lastVelocity = rigid.velocity;
			lastAngularVelocity = rigid.angularVelocity;
		}
	}

	public void Push(Vector3 newForce)
	{
		if (rigid != null)
		{
			rigid.velocity = newForce;
			rigid.angularVelocity = Vector3.zero;
		}
	}

	private void OnCollisionEnter(Collision col)
	{
		if (col == null || col.contacts == null || col.contacts.Length == 0 || rigid == null)
		{
			return;
		}
		Vector3 normal = col.contacts[0].normal;
		if (Vector3.Angle(normal, Vector3.up) > bounceYAngleThreshold)
		{
			rigid.velocity = Vector3.Reflect(lastVelocity, normal) * 0.8f;
			rigid.angularVelocity = Vector3.Reflect(lastAngularVelocity, normal);
		}
	}

	public void IgnoreLastCollision(float amount)
	{
		if (rigid != null)
		{
			rigid.velocity = lastVelocity * amount;
		}
	}
}
