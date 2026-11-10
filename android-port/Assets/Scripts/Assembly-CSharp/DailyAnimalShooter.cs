using Core;
using UnityEngine;

public class DailyAnimalShooter : GolfBallShooterBase
{
	[SerializeField]
	private DailyPrize da;

	public bool lookInAimDirection;

	public override void OnShoot(Vector3 boost)
	{
		if (da != null)
		{
			da.OnShoot(boost);
		}
	}

	public override void OnAimUpdate(Vector3 boost, bool onlyAimArrow)
	{
		if (da != null)
		{
			da.OnAimUpdate(boost);
		}
		if (lookInAimDirection && rigidbodyC != null && boost != Vector3.zero)
		{
			rigidbodyC.MoveRotation(Quaternion.LookRotation(boost, Vector3.up));
		}
	}

	public override void OnAimStart()
	{
		if (da != null)
		{
			da.OnAimStart();
		}
	}
}
