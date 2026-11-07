using System;
using UnityEngine;

public class WesternShootableObstacle : MonoBehaviour, IHitscanTarget
{
	public float forceOnHit;

	private Collider2D m_collider;

	private Rigidbody2D m_Rigidbody;

	public Action<IHitscanTarget> OnHitscanHit { get; set; }

	private void Awake()
	{
	}

	public void OnHit(Vector3 point)
	{
	}

	private void OnCollisionEnter2D(Collision2D collision)
	{
	}
}
