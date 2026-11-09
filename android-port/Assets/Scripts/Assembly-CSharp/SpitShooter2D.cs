using Core;
using UnityEngine;
using Utility;

public class SpitShooter2D : GolfBall2DShooterBase
{
	public Transform HeadTransform;

	public float ShootForce;

	public Transform ShootOriginTransform;

	public Spit2D SpitTemplate;

	private ObjectPool<Spit2D> spitPool;

	private void Start()
	{
	}

	private void BallOnOnAimUpdate(Vector3 vector3, bool b)
	{
	}

	private void OnHitGoal()
	{
	}

	public override void OnShoot(Vector3 boost)
	{
	base.OnShoot(boost);
		StandardShoot(boost, 15f, 5f, (ShootForce > 0f ? ShootForce : 22f), 5f);
	}

	private Spit2D SpawnNewArrow()
	{
		return null;
	}
}
