using System.Collections.Generic;
using UnityEngine;

public class CollisionBasedParticles : MonoBehaviour
{
	public List<Collider> collidersToNotRespondTo;

	private float collisionThreshold = 5f;

	private void OnCollisionEnter(Collision collision)
	{
		if (collision == null) return;
		if (collidersToNotRespondTo != null && collidersToNotRespondTo.Contains(collision.collider)) return;
		if (collision.relativeVelocity.magnitude > collisionThreshold && collision.contacts != null && collision.contacts.Length > 0)
		{
			Effects.EmitDustPuff(collision.contacts[0].point, 1);
		}
	}
}
