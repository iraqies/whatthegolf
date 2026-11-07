using Core;
using UnityEngine;

public class HorseTamerShooter : GolfBall2DShooterBase
{
	public float Force;

	public Rigidbody2D[] rigidbodies;

	protected override void Awake()
	{
	}

	public override void OnShoot(Vector3 boost)
	{
	}
}
