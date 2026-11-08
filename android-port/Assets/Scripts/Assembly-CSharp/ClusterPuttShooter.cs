using Core;
using UnityEngine;

public class ClusterPuttShooter : GolfBallShooterBase
{
	public float Force;

	public float Pitch;

	public Vector2 RandomRange;

	public float InheritVelocity;

	public Rigidbody[] rigidbodies;

	public Rigidbody[] blacklist;

	public GameObject Tracker;

	public float MaxAutoAimDistance;

	public float SphereCastRadius;

	private Collider onCar;

	private BlockIfNotNearStuff blocker;

	private float delay;

	private float trackerTimer;

	private Collider lastTrackerHit;

	private string carLayer;

	protected override void Awake()
	{
	base.Awake();
	}

	private void Update()
	{
	}

	public override void OnAimUpdate(Vector3 boost, bool onlyAimArrow)
	{
	}

	public override void OnCancel()
	{
	}

	public override void OnShoot(Vector3 boost)
	{
	StandardShoot(boost, 20f, 18f, 5f);
	}

	private void OnCollisionEnter(Collision other)
	{
	}

	private void OnTriggerEnter(Collider other)
	{
	}

	private void OnTriggerExit(Collider other)
	{
	}

	public static Vector3 CalculateVelocityForTarget(Vector3 startPosition, Vector3 target, float initialAngle)
	{
		return default;
	}
}
