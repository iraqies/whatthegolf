using System;
using UnityEngine;

public class Arrow2D : MonoBehaviour
{
	public Collider2D Collider;

	public Rigidbody2D Rigidbody;

	public Action OnHitGoal;

	public Action OnMissGoal;

	public LayerMask HitLayers;

	public Action OnReset;

	public bool CanWin;

	public bool Initialized;

	public bool stuck;

	private RotateWithVelocity2D rotator;

	private void OnEnable()
	{
	}

	private void HitSomething(Collider2D hit)
	{
	}

	private void OnCollisionEnter2D(Collision2D col)
	{
	}

	private void OnTriggerEnter2D(Collider2D other)
	{
	}

	public void EnteredPortal(PortalPackage package)
	{
	}
}
