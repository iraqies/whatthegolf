using Core;
using UnityEngine;

public class TrainShooter : GolfBall2DShooterBase
{
	public float JumpUpForce;

	public float JumpForwardForce;

	public bool Grounded;

	public float engineDirection;

	[SerializeField]
	private float engineBaseForce;

	[SerializeField]
	private Vector3 localForcePoint;

	[SerializeField]
	private float groundedCheckRadius;

	[SerializeField]
	private Vector2[] groundedCheckPositions;

	private int groundLayer;

	public Vector2 engineVelocity { get; private set; }

	protected override void Awake()
	{
	base.Awake();
	}

	private void Update()
	{
	}

	private void UpdateGrounded()
	{
	}

	protected override void FixedUpdate()
	{
	base.FixedUpdate();
	}

	public override void OnShoot(Vector3 boost)
	{
	base.OnShoot(boost);
		StandardShoot(boost, 15f, 5f, 22f, 5f);
	}
}
