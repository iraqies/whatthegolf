using UnityEngine;

public class NiceBall : MonoBehaviour
{
	public float radius;

	public bool lockYbounceToZero;

	[SerializeField]
	private float bounceYAngleThreshold = 10f;

	[SerializeField]
	private float useNormalAsGravityAngleThreshold = 10f;

	[SerializeField]
	private float dampenYMultiplier = 0.8f;

	[SerializeField]
	private float dampenAngularVelocityMultiplier;

	[SerializeField]
	private float otherIsRigidMultiplier = 0.3f;

	public Rigidbody rigidbody;

	private Vector3 lastVelocity;

	private Vector3 lastAngularVelocity;

	private void Awake()
	{
		rigidbody = GetComponent<Rigidbody>();
		if (rigidbody != null)
		{
			rigidbody.useGravity = false;
		}
	}

	private void FixedUpdate()
	{
		if (rigidbody == null)
		{
			return;
		}
		lastVelocity = rigidbody.velocity;
		lastAngularVelocity = rigidbody.angularVelocity;
		Vector3 grav = Physics.gravity;
		Ray ray = new Ray(transform.position + Vector3.up * 0.05f, Vector3.down);
		if (Physics.SphereCast(ray, radius, out RaycastHit hit, 0.15f))
		{
			if (Vector3.Angle(hit.normal, Vector3.up) < useNormalAsGravityAngleThreshold)
			{
				grav = -hit.normal.normalized * grav.magnitude;
			}
		}
		rigidbody.AddForce(grav, ForceMode.Acceleration);
	}

	private void OnDrawGizmosSelected()
	{
		Gizmos.DrawSphere(transform.position, radius);
	}

	public void Push(Vector3 newForce)
	{
		if (rigidbody != null)
		{
			rigidbody.velocity = newForce;
			rigidbody.angularVelocity = Vector3.zero;
		}
	}

	private void OnCollisionEnter(Collision col)
	{
		if (col == null || col.contacts == null || col.contacts.Length == 0 || rigidbody == null)
		{
			return;
		}
		Vector3 contactNormal = col.contacts[0].normal;
		if (Vector3.Angle(contactNormal, Vector3.up) < bounceYAngleThreshold || Vector3.Angle(contactNormal, Vector3.down) < bounceYAngleThreshold)
		{
			return;
		}
		float bounceMult = 0.8f;
		float lerpFactor = 0.9f;
		Rigidbody otherRb = col.transform != null ? col.transform.GetComponent<Rigidbody>() : null;
		if (otherRb != null && !otherRb.isKinematic)
		{
			lerpFactor *= otherIsRigidMultiplier;
		}
		if (lastVelocity == Vector3.zero || lastVelocity.magnitude <= 0.05f)
		{
			return;
		}
		Ray ray = new Ray(col.contacts[0].point - lastVelocity.normalized, lastVelocity.normalized);
		if (col.collider == null || !col.collider.Raycast(ray, out _, 2f))
		{
			return;
		}
		Vector3 vIn = new Vector3(lastVelocity.x, lastVelocity.y * dampenYMultiplier, lastVelocity.z);
		Vector3 reflected = Vector3.Reflect(vIn, contactNormal);
		float targetY = lockYbounceToZero ? 0f : (reflected.y * dampenYMultiplier * bounceMult);
		Vector3 targetVel = new Vector3(reflected.x * bounceMult, targetY, reflected.z * bounceMult);
		rigidbody.velocity = Vector3.Lerp(rigidbody.velocity, targetVel, Mathf.Clamp01(lerpFactor));
	}

	public void IgnoreLastCollision(float amount)
	{
		if (rigidbody != null)
		{
			rigidbody.velocity = lastVelocity * amount;
		}
	}
}
