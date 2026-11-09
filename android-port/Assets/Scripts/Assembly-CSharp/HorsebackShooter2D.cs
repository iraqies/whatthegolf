using Core;
using UnityEngine;
using Utility;

public class HorsebackShooter2D : GolfBall2DShooterBase
{
	public Transform ShootOrigin;

	public GameObject ProjectilePrefab;

	public Rigidbody2D Limb;

	public bool rotate;

	private ObjectPool<GameObject> projectiles;

	private Rigidbody2D[] childLimbs;

	protected override void Awake()
	{
	base.Awake();
	}

	private void Start()
	{
	}

	public override void OnAimUpdate(Vector3 boost, bool onlyAimArrow)
	{
	}

	public override void OnShoot(Vector3 boost)
	{
	base.OnShoot(boost);
		StandardShoot(boost, 15f, 5f, 22f, 5f);
	}
}
