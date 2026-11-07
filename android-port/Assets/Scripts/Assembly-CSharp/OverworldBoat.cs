using UnityEngine;

public class OverworldBoat : OverworldBall2D
{
	public float sailSpeed;

	public float RequiredDistanceForHittingFlags;

	private float distanceMovedSinceHitFlag;

	private Vector3 lastPos;

	protected override void Controller_OnAimUpdate(Vector3 dir, bool arg2)
	{
	}

	protected override void Controller_OnAimStart()
	{
	}

	protected override void Shooter_OnShoot(Vector3 dir)
	{
	}

	public override void OnShoot(Vector3 boost)
	{
	}
}
