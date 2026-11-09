using UnityEngine;

public class EmitParticlesOnCollision : MonoBehaviour
{
	public ParticleSystem system;

	public int count = 1;

	public bool moveTransformToCollisionPoint;

	public bool alignTransformZToNormal;

	public float velocityMinimumThreshold;

	private void OnCollisionEnter2D(Collision2D collision)
	{
		if (collision == null || system == null) return;
		if (collision.relativeVelocity.magnitude <= velocityMinimumThreshold) return;
		if (moveTransformToCollisionPoint && collision.contacts != null && collision.contacts.Length > 0)
		{
			system.transform.position = collision.contacts[0].point;
		}
		if (alignTransformZToNormal && collision.contacts != null && collision.contacts.Length > 0)
		{
			system.transform.forward = collision.contacts[0].normal;
		}
		system.Emit(count);
	}

	private void OnCollisionEnter(Collision collision)
	{
		if (collision == null || system == null) return;
		if (collision.relativeVelocity.magnitude <= velocityMinimumThreshold) return;
		if (moveTransformToCollisionPoint && collision.contacts != null && collision.contacts.Length > 0)
		{
			system.transform.position = collision.contacts[0].point;
		}
		if (alignTransformZToNormal && collision.contacts != null && collision.contacts.Length > 0)
		{
			system.transform.forward = collision.contacts[0].normal;
		}
		system.Emit(count);
	}
}
