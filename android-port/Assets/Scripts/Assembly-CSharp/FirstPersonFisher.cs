using Core;
using UnityEngine;
using Utility;

public class FirstPersonFisher : GolfBallShooterBase
{
	public float SleepVelocity;

	public float ShootInterval;

	public float minShootVelocity;

	public float fullShootVelocity;

	public GameObject Bullet;

	public bool CanShoot;

	private ObjectPool<GameObject> bulletPool;

	private Collider collider;

	private GolfBallController golfControl;

	private Rigidbody fishingRod;

	private float shootTimer;

	private Vector3 shootVelocity;

	public static Vector3 fishingRodTop;

	[RuntimeInitializeOnLoadMethod]
	private static void Init()
	{
	}

	private void Start()
	{
	}

	private void Update()
	{
	}

	protected override void FixedUpdate()
	{
	base.FixedUpdate();
	}

	public override void OnShoot(Vector3 boost)
	{
	base.OnShoot(boost);
		StandardShoot(boost, 15f, (minShootVelocity > 0f ? minShootVelocity : 5f), (fullShootVelocity > 0f ? fullShootVelocity : 22f), 5f);
	}

	private void TryShoot(Vector3 boost)
	{
	}

	private void Yank()
	{
	}

	private void OnCollisionEnter(Collision other)
	{
	}
}
