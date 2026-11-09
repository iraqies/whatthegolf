using System;
using UnityEngine;

public class BallCollider : MonoBehaviour
{
	public Action<Vector3, Vector3, float, Collider2D> OnCollisionEnter;

	private void OnCollisionEnter2D(Collision2D collision)
	{
		if (OnCollisionEnter == null || collision == null || collision.contacts == null || collision.contacts.Length == 0)
			return;
		Vector2 pt = collision.contacts[0].point;
		Vector2 n = collision.contacts[0].normal;
		float mag = collision.relativeVelocity.magnitude;
		OnCollisionEnter(new Vector3(pt.x, pt.y, 0f), new Vector3(n.x, n.y, 0f), mag, collision.otherCollider);
	}
}
