using System;
using Core;
using UnityEngine;

public class BallShooter : GolfBall2DShooterBase
{
	public float offsetDistance = 0.5f;

	public bool didShoot;

	public Action<Vector2> OnShootEvent;

	public override void OnShoot(Vector3 boost)
	{
		base.OnShoot(boost);
		if (OnShootEvent != null)
		{
			if (GolfBallController != null)
			{
				GolfBallController.enabled = false;
				if (GolfBallController.shootArrow != null)
					GolfBallController.shootArrow.Hide();
			}
			didShoot = true;
			OnShootEvent.Invoke(new Vector2(boost.x, boost.y));
		}
		else
		{
			StandardShoot(boost, 0f, 5f, 22f, 5f);
		}
	}
}
