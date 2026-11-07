using Core;
using UnityEngine;

public class RagdollShooterSim2d : GolfBallShooterBase
{
	public float Force;

	public Vector2 RandomRange;

	public Rigidbody[] rigidbodies;

	private int groundLayer;

	private bool grounded;

	public float airMultiplier;

	public float maxXWhileFalling;

	private bool constrainX;

	public float xCorrectionSpeedMultiplier;

	public float minimumXCorrectionSpeed;

	public float cameraChangeYValue;

	public GameObject CMCamera;

	public float allowedZVariance;

	public float zCorrectionSpeedMultiplier;

	public float minimumZCorrectionSpeed;

	private float originZ;

	protected override void Awake()
	{
	}

	protected override void FixedUpdate()
	{
	}

	public override void OnShoot(Vector3 boost)
	{
	}

	private void OnTriggerEnter(Collider other)
	{
	}

	private void OnTriggerExit(Collider other)
	{
	}
}
