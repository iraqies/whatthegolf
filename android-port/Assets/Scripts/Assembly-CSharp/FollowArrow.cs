using UnityEngine;

public class FollowArrow : MonoBehaviour
{
	public BallShooter shooter;

	private bool isAdjusting;

	private void Start()
	{
		isAdjusting = true;
		if (shooter != null)
		{
			shooter.OnShootEvent += Shooter_OnShoot;
			if (shooter.GolfBallController != null)
				shooter.GolfBallController.OnAimUpdate += UpdateFollow;
		}
	}

	private void UpdateFollow(Vector3 boost, bool t)
	{
		if (isAdjusting && boost.magnitude > 0f && shooter != null)
		{
			transform.position = shooter.transform.position + boost.normalized * 4f;
		}
	}

	private void Shooter_OnShoot(Vector2 obj)
	{
		isAdjusting = false;
	}
}
