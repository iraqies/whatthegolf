using System;
using UnityEngine;

public class Javelin : MonoBehaviour
{
	public Collider Collider;

	public Rigidbody Rigidbody;

	public Action OnHitGoal;

	public Action OnMissGoal;

	public LayerMask HitLayers;

	public Action OnReset;

	public bool CanWin;

	public bool Initialized;

	public bool stuck;

	private RotateWithVelocity rotator;

	private void OnEnable()
	{
	}

	private void HitSomething(Collider hit)
	{
	}

	private void OnCollisionEnter(Collision col)
	{
	}

	private void OnTriggerEnter(Collider other)
	{
	}

	public void EnteredPortal(PortalPackage package)
	{
	}
}
