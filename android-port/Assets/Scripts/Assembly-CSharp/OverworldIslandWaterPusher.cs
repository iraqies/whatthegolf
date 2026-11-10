using UnityEngine;

public class OverworldIslandWaterPusher : MonoBehaviour
{
	public Transform PushTowards;

	public float PushForce = 1f;

	public LayerMask PushLayer;

	private void OnTriggerStay2D(Collider2D other)
	{
		if (other == null)
		{
			return;
		}
		int value = PushLayer.value;
		if (value == (value | (1 << other.gameObject.layer)))
		{
			Rigidbody2D attachedRigidbody = other.attachedRigidbody;
			if (attachedRigidbody != null && PushTowards != null)
			{
				Vector3 normalized = (PushTowards.position - other.transform.position).normalized;
				attachedRigidbody.AddForce(new Vector2(normalized.x * PushForce, normalized.y * PushForce), ForceMode2D.Force);
			}
		}
	}
}
