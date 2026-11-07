using Core;
using UnityEngine;

public class TruckForceHelper : MonoBehaviour
{
	public GolfBallController controller;

	public Rigidbody forceSource;

	public Rigidbody forceTarget;

	public float multiplier;

	public float baseForce;

	public Transform localTargetPosition;

	public float extraBaseWhenAiming;

	private void FixedUpdate()
	{
	}
}
