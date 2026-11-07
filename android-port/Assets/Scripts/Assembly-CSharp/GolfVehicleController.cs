using Core;
using UnityEngine;

public class GolfVehicleController : GolfBallShooterBase
{
	public Vehicle Vehicle;

	public float SteerThreshold;

	public override void OnAimUpdate(Vector3 boost, bool onlyAimArrow)
	{
	}
}
