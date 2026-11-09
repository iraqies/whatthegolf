using Core;
using UnityEngine;

public class HorseTamerShooter : GolfBall2DShooterBase
{
	public float Force;

	public Rigidbody2D[] rigidbodies;

	protected override void Awake()
	{
	base.Awake();
	}

	public override void OnShoot(Vector3 boost)
	{
	base.OnShoot(boost);
		StandardShoot(boost, 15f, 5f, (Force > 0f ? Force : 22f), 5f);
	}
}
