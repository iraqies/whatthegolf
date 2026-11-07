using Core;
using UnityEngine;

public class TotemController : GolfBallShooterBase
{
	public float MoveSpeed;

	public float ShootSpeed;

	public float RotateSpeed;

	public Rigidbody Rigid;

	private Vector3 targetRot;

	public override void OnAimUpdate(Vector3 boost, bool onlyAimArrow)
	{
	}

	public override void OnCancel()
	{
	}

	public override void OnShoot(Vector3 boost)
	{
	}

	protected override void FixedUpdate()
	{
	}
}
