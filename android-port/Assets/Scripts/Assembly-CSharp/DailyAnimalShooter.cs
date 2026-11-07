using Core;
using UnityEngine;

public class DailyAnimalShooter : GolfBallShooterBase
{
	[SerializeField]
	private DailyPrize da;

	public bool lookInAimDirection;

	public override void OnShoot(Vector3 boost)
	{
	}

	public override void OnAimUpdate(Vector3 boost, bool onlyAimArrow)
	{
	}

	public override void OnAimStart()
	{
	}
}
