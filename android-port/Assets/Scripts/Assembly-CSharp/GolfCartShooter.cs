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
	base.OnShoot(boost);
		StandardShoot(boost, 15f, 5f, 22f, 5f);
	}

	private new void FixedUpdate()
	{
	}
}
