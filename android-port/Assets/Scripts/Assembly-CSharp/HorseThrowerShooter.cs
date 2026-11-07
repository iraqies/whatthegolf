using Core;
using UnityEngine;

public class HorseThrowerShooter : GolfBall2DShooterExperimental
{
	public float TrackLength;

	public Animator HorseAnimator;

	public FixedJoint2D ManJoint;

	public Rigidbody2D ManRigid;

	private float currentSpeed;

	private Vector2 lastPos;

	public override void OnShoot(Vector3 boost)
	{
	}

	protected override void FixedUpdate()
	{
	}

	private void OnDrawGizmosSelected()
	{
	}
}
