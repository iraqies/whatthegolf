using System;
using Core;
using UnityEngine;

public class BallShooterFake3D : GolfBallShooterBase
{
	public float offsetDistance = 0.5f;

	public bool didShoot;

	public Action<Vector3> OnShootEvent;

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
			OnShootEvent.Invoke(boost);
		}
		else
		{
			StandardShoot(boost, 15f, 5f, 22f, 5f);
		}
	}
}
