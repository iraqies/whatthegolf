using Core;
using UnityEngine;

public class GunShooter : GolfBall2DShooterBase
{
	public Rigidbody2D BulletPrefab;

	public float BulletSpeed;

	public Transform SpawnPosition;

	public Vector2 LookRanges;

	public override void OnShoot(Vector3 boost)
	{
	base.OnShoot(boost);
		StandardShoot(boost, 15f, 5f, 22f, 5f);
	}

	public override void OnAimUpdate(Vector3 boost, bool onlyAimArrow)
	{
	}
}
