using Core;
using UnityEngine;

public class Katamari2DShooter : GolfBall2DShooterBase
{
	[SerializeField]
	public float minShootVelocity;

	[SerializeField]
	public float fullShootVelocity;

	[SerializeField]
	public float directionalSpin;

	public override void OnActivate()
	{
	}

	public override void OnShoot(Vector3 boost)
	{
	}
}
