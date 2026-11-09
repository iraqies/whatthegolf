using Core;
using UnityEngine;

public class RollingBallShooter : GolfBallShooterBase
{
	public float RollSpeed;

	public float ForceSpeed;

	public bool AddForcesInFixedUpdate;

	private Vector3 currentBoost;

	public override void OnAimUpdate(Vector3 boost, bool onlyAimArrow)
	{
	}

	protected override void FixedUpdate()
	{
	base.FixedUpdate();
	}

	public override void OnCancel()
	{
	}

	public override void OnShoot(Vector3 boost)
	{
	base.OnShoot(boost);
		StandardShoot(boost, 15f, 5f, 22f, 5f);
	}
}
