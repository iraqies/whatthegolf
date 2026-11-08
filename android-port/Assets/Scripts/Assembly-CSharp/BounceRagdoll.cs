using UnityEngine;
using UnityEngine.Events;

public class BounceRagdoll : MonoBehaviour
{
	[SerializeField]
	private float bouncePower = 1f;

	private Transform lastObject;

	[SerializeField]
	private UnityEvent onRagdollHit;

	private void OnCollisionEnter(Collision collision)
	{
		if (collision == null || collision.transform == null) return;
		var ragdoll = collision.transform.GetComponentInParent<ToggleGenericRagdoll>();
		if (ragdoll == null) return;
		var root = collision.transform.root;
		var rb = root != null ? root.GetComponentInChildren<Rigidbody>() : null;
		Vector3 vel = rb != null ? rb.velocity : Vector3.zero;
		ragdoll.SetVelocity(vel + Vector3.up * bouncePower);
		if (lastObject != root)
		{
			onRagdollHit?.Invoke();
			lastObject = root;
		}
	}
}
