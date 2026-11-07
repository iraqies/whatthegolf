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
	}

	public override void OnAimUpdate(Vector3 boost, bool onlyAimArrow)
	{
	}
}
