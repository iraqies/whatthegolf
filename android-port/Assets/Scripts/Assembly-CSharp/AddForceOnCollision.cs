using UnityEngine;

public class AddForceOnCollision : MonoBehaviour
{
	public float Force = 10f;

	public float UpwardsForce = 2f;

	public ForceMode ForceMode = ForceMode.Impulse;

	public bool AddToIncomingRigidbody;

	public bool CheckLayer;

	public LayerMask LayerMask;

	private Rigidbody m_ThisRigidbody;

	private void Awake()
	{
		m_ThisRigidbody = GetComponent<Rigidbody>();
	}

	private void OnCollisionEnter(Collision collision)
	{
		if (!enabled || collision == null || collision.rigidbody == null)
			return;
		if (CheckLayer && collision.gameObject != null)
		{
			int mask = LayerMask.value;
			if ((mask | (1 << collision.gameObject.layer)) != mask)
				return;
		}
		Vector3 contactPoint = (collision.contacts != null && collision.contacts.Length > 0)
			? collision.GetContact(0).point
			: collision.transform.position;
		Vector3 dir = (collision.rigidbody.position - contactPoint).normalized;
		Rigidbody targetRb = AddToIncomingRigidbody ? collision.rigidbody : (m_ThisRigidbody != null ? m_ThisRigidbody : GetComponent<Rigidbody>());
		if (targetRb != null)
		{
			targetRb.AddForce(dir * Force + Vector3.up * UpwardsForce, ForceMode);
		}
	}
}
