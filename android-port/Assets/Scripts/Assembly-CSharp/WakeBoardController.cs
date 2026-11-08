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
	StandardShoot(boost, 20f, 18f, 5f);
	}

	protected override void FixedUpdate()
	{
	base.FixedUpdate();
	}
}
