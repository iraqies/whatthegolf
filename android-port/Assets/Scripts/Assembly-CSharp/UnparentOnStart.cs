using UnityEngine;

public class UnparentOnStart : MonoBehaviour
{
	private Quaternion originalRotation;
	private Vector3 originalPosition;
	private Transform originalParent;
	private Rigidbody thisRigidbody;
	[SerializeField] private bool DontUnparentOnStart;

	private void Start()
	{
		originalParent = transform.parent;
		originalPosition = transform.localPosition;
		originalRotation = transform.localRotation;
		thisRigidbody = GetComponent<Rigidbody>();
		if (!DontUnparentOnStart) Unparent();
	}

	public void Unparent() => transform.SetParent(null, true);

	public void Reparent(bool alsoReturnToPosition)
	{
		transform.SetParent(originalParent, true);
		if (alsoReturnToPosition) ResetPosition();
	}

	public void ResetPosition()
	{
		transform.localPosition = originalPosition;
		transform.localRotation = originalRotation;
		if (thisRigidbody != null && !thisRigidbody.isKinematic)
		{
			thisRigidbody.velocity = Vector3.zero;
			thisRigidbody.angularVelocity = Vector3.zero;
		}
	}

	public void DestroyObject() => Destroy(gameObject);
}
