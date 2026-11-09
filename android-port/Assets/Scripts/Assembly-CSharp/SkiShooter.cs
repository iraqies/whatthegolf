using Core;
using UnityEngine;

public class SkiShooter : GolfBall2DShooterBase
{
	public float JumpUpForce;

	public float JumpForwardForce;

	public bool Grounded;

	public Vector2 OrthographicSizeRange;

	public bool DontModifyAngularDragInFlight;

	private void Update()
	{
	}

	public override void OnShoot(Vector3 boost)
	{
	base.OnShoot(boost);
		StandardShoot(boost, 15f, 5f, 22f, 5f);
	}

	private void OnCollisionStay2D(Collision2D other)
	{
	}

	private void OnCollisionExit2D(Collision2D other)
	{
	}
}
