using UnityEngine;

public class FroggerShooter : BallShooter
{
	public float moveDistnace;

	public float speed;

	public Vector3 target;

	public Vector2 bounds;

	protected override void Awake()
	{
		base.Awake();
	}

	public override void OnShoot(Vector3 boost)
	{
		base.OnShoot(boost);
	}

	protected override void FixedUpdate()
	{
		base.FixedUpdate();
	}
}
