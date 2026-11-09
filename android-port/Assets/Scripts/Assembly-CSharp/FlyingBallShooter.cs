using UnityEngine;

public class FlyingBallShooter : BallShooter
{
	public float gravity;

	public float moveDistnace;

	public float speed;

	public Vector3 target;

	public bool useBounds;

	public bool useGravity;

	public Vector2 bounds;

	private bool startedFlying;

	protected override void Awake()
	{
		base.Awake();
	}

	private void Controller_OnAimUpdate(Vector3 boost, bool arg2)
	{
	}

	public override void OnShoot(Vector3 boost)
	{
		base.OnShoot(boost);
	}

	private void ClampVelocity()
	{
	}

	protected override void FixedUpdate()
	{
		base.FixedUpdate();
	}
}
