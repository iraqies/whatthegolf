using System;
using Core;
using UnityEngine;

public class BallShooterFake3D : GolfBallShooterBase
{
	public float offsetDistance;

	public bool didShoot;

	public Action<Vector2> OnShootEvent;

	protected override void Awake()
	{
	base.Awake();
	}

	private void GolfBallControllerOverride_OnAimUpdate(Vector3 boost, bool arg2)
	{
	}

	public override void OnShoot(Vector3 boost)
	{
	StandardShoot(boost, 20f, 18f, 5f);
	}
}
