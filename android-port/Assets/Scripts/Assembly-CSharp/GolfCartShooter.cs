using Core;
using UnityEngine;

public class GolfCartShooter : GolfBallShooterBase
{
	private Rigidbody rb;

	[SerializeField]
	private WheelCollider FL;

	[SerializeField]
	private WheelCollider FR;

	[SerializeField]
	private WheelCollider BL;

	[SerializeField]
	private WheelCollider BR;

	[SerializeField]
	private float torque;

	private WheelCollider[] wheels;

	private bool spinWheels;

	protected override void Awake()
	{
	base.Awake();
	}

	public override void OnAimStart()
	{
	}

	public override void OnAimUpdate(Vector3 boost, bool onlyAimArrow)
	{
	}

	public override void OnShoot(Vector3 boost)
	{
	StandardShoot(boost, 20f, 18f, 5f);
	}

	private new void FixedUpdate()
	{
	}
}
