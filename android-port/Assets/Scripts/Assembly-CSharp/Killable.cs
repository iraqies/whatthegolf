using System;
using UnityEngine;

public class Killable : MonoBehaviour
{
	public Action OnKilled;

	private void OnCollisionEnter2D(Collision2D collision)
	{
		if (collision != null && (collision.collider.CompareTag("KillZone") || collision.collider.CompareTag("OutOfBounds") || collision.collider.name.Contains("Hazard") || collision.collider.name.Contains("Kill")))
			OnKilled?.Invoke();
	}

	private void OnTriggerEnter2D(Collider2D collision)
	{
		if (collision != null && (collision.CompareTag("KillZone") || collision.CompareTag("OutOfBounds") || collision.name.Contains("Hazard") || collision.name.Contains("Kill")))
			OnKilled?.Invoke();
	}
}
