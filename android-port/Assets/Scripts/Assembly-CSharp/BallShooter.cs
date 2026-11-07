using System;
using Core;
using UnityEngine;

public class BallShooter : GolfBall2DShooterBase
{
	public float offsetDistance;

	public bool didShoot;

	public Action<Vector2> OnShootEvent;

	public override void OnShoot(Vector3 boost)
	{
	}
}
