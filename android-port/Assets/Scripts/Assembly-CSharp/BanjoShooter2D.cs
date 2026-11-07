using Core;
using UnityEngine;

public class BanjoShooter2D : ShooterBase
{
	[SerializeField]
	private float aimSpringFactor;

	[SerializeField]
	private float maxAngularVelocity;

	[SerializeField]
	private float maxAngleDelta;

	[SerializeField]
	private float springDampAngle;

	[SerializeField]
	private float springDampPower;

	[SerializeField]
	private Rigidbody2D grabRigidbody;

	[SerializeField]
	private Vector2 centerOfMass;

	[SerializeField]
	private float shootForce;

	private Rigidbody2D rigidbody2D;

	private FixedJoint2D grabJoint;

	private Vector3 grabLocalPosition;

	private void Awake()
	{
	}

	public override void OnAimStart()
	{
	}

	public override void OnAimUpdate(Vector3 boost, bool onlyAimArrow)
	{
	}

	public override void OnCancel()
	{
	}

	public override void OnShoot(Vector3 boost)
	{
	}

	private void ReleaseGrab()
	{
	}

	private void OnHitGoal()
	{
	}
}
