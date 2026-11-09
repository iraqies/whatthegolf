using Core;
using UnityEngine;

public class WakeBoardController : GolfBallShooterBase
{
	public Transform Boat;

	public float MoveForce;

	public float JumpForce;

	public Rigidbody Rigidbody;

	private Vector3 targetDir;

	public override void OnAimUpdate(Vector3 boost, bool onlyAimArrow)
	{
	}

	public override void OnCancel()
	{
	}

	public override void OnShoot(Vector3 boost)
	{
	base.OnShoot(boost);
		StandardShoot(boost, 15f, 5f, (MoveForce > 0f ? MoveForce : 22f), 5f);
	}

	protected override void FixedUpdate()
	{
	base.FixedUpdate();
	}
}
