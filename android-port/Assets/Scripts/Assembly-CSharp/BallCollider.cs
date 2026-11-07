using System;
using UnityEngine;

public class BallCollider : MonoBehaviour
{
	public Action<Vector3, Vector3, float, Collider2D> OnCollisionEnter;

	private void OnCollisionEnter2D(Collision2D collision)
	{
	}
}
