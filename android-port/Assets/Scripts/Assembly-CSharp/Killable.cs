using System;
using UnityEngine;

public class Killable : MonoBehaviour
{
	public Action OnKilled;

	private void OnCollisionEnter2D(Collision2D collision)
	{
		if (collision == null)
			return;
		Bad bad = collision.transform != null ? collision.transform.GetComponent<Bad>() : null;
		Bad badRb = (collision.collider != null && collision.collider.attachedRigidbody != null)
			? collision.collider.attachedRigidbody.GetComponent<Bad>()
			: null;
		if ((bad != null || badRb != null) && OnKilled != null)
		{
			OnKilled();
		}
	}

	private void OnTriggerEnter2D(Collider2D collision)
	{
		if (collision == null)
			return;
		Bad bad = collision.transform != null ? collision.transform.GetComponent<Bad>() : null;
		Bad badRb = collision.attachedRigidbody != null ? collision.attachedRigidbody.GetComponent<Bad>() : null;
		if ((bad != null || badRb != null) && OnKilled != null)
		{
			OnKilled();
		}
	}
}
