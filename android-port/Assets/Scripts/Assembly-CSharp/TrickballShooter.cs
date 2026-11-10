using UnityEngine;

public class TrickballShooter : BallShooter
{
	public override void OnShoot(Vector3 dir)
	{
		if (OnShootEvent != null)
		{
			if (GolfBallController != null)
				GolfBallController.BlockShooting = true;
			didShoot = true;
			Vector3 neg = (-dir).normalized;
			OnShootEvent.Invoke(new Vector2(neg.x, neg.y));
		}
	}
}
