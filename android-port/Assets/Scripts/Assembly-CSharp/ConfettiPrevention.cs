using UnityEngine;

public class ConfettiPrevention : MonoBehaviour
{
	[SerializeField]
	private float pushForce = 0.025f;

	private void OnTriggerEnter2D(Collider2D other)
	{
		if (other == null || !other.CompareTag("Particle"))
			return;
		var rb = other.attachedRigidbody;
		if (rb != null)
		{
			Vector3 dir = (other.transform.position - transform.position).normalized;
			rb.AddForce(new Vector2(dir.x, dir.y) * pushForce, ForceMode2D.Impulse);
		}
	}
}
