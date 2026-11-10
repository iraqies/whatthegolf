using Core;
using UnityEngine;

public class HoleInOneShooter : GolfBall2DShooterBase
{
	[SerializeField]
	private float minVelocity;

	[SerializeField]
	private float maxVelocity;

	[SerializeField]
	private float maxSpin;

	[SerializeField]
	private Rigidbody2D Ball;

	[SerializeField]
	private float BallOffset;

	private BallShooter ballShooter;

	private bool ballFollow;

	protected override void Awake()
	{
		base.Awake();
		if (Ball != null)
		{
			ballShooter = Ball.GetComponent<BallShooter>();
			if (ballShooter != null)
			{
				ballShooter.OnShootEvent = BallShooter_OnShootEvent;
			}
		}
	}

	public void SetBallFollow(bool follow)
	{
		if (ballShooter != null && !ballShooter.didShoot)
		{
			ballFollow = follow;
			if (Ball != null)
			{
				Ball.isKinematic = follow;
			}
		}
	}

	protected override void FixedUpdate()
	{
		base.FixedUpdate();
		if (ballShooter != null && !ballShooter.didShoot && ballFollow && Ball != null && rigid != null)
		{
			Vector2 offset = new Vector2(Mathf.Cos(rigid.rotation * ((float)System.Math.PI / 180f)), Mathf.Sin(rigid.rotation * ((float)System.Math.PI / 180f))) * BallOffset;
			Ball.position = rigid.position + offset;
		}
	}

	private void BallShooter_OnShootEvent(Vector2 boost)
	{
		if (Ball != null)
		{
			Ball.isKinematic = false;
			if (rigid != null)
			{
				Ball.transform.position = rigid.position + boost.normalized * ballShooter.offsetDistance;
			}
			Ball.velocity = Vector2.zero;
			Ball.angularVelocity = 0f;
			Vector2 norm = boost.normalized;
			Vector2 force = Vector2.Lerp(norm * minVelocity, norm * maxVelocity, Mathf.Clamp01(boost.magnitude));
			Ball.AddForce(force, ForceMode2D.Impulse);
		}
		if (GolfBallController != null)
		{
			GolfBallController.didShoot = true;
		}
	}

	public override void OnShoot(Vector3 boost)
	{
		base.OnShoot(boost);
		StandardShoot(boost, 0f, minVelocity, maxVelocity, maxSpin);
	}
}
