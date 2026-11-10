using Core;
using UnityEngine;

public class TrainShooter : GolfBall2DShooterBase
{
	public float JumpUpForce = 10f;

	public float JumpForwardForce = 10f;

	public bool Grounded;

	public float engineDirection;

	[SerializeField]
	private float engineBaseForce = 10f;

	[SerializeField]
	private Vector3 localForcePoint;

	[SerializeField]
	private float groundedCheckRadius = 1f;

	[SerializeField]
	private Vector2[] groundedCheckPositions;

	private int groundLayer;

	public Vector2 engineVelocity { get; private set; }

	protected override void Awake()
	{
		base.Awake();
		groundLayer = 1 << LayerMask.NameToLayer("Ground");
	}

	private void Update()
	{
	}

	private void UpdateGrounded()
	{
		if (groundedCheckPositions == null)
			return;
		int count = 0;
		for (int i = 0; i < groundedCheckPositions.Length; i++)
		{
			Vector3 worldPt = transform.TransformPoint(new Vector3(groundedCheckPositions[i].x, groundedCheckPositions[i].y, 0f));
			if (Physics2D.OverlapCircle(worldPt, groundedCheckRadius, groundLayer) != null)
			{
				count++;
			}
		}
		Grounded = count > 1;
	}

	protected override void FixedUpdate()
	{
		base.FixedUpdate();
		UpdateGrounded();
		if (Grounded && Rigidbody != null)
		{
			Vector3 right = transform.right;
			float force = engineDirection * engineBaseForce;
			Vector2 vel = new Vector2(right.x * force * Time.deltaTime, right.y * force * Time.deltaTime);
			engineVelocity = vel;
			Vector3 worldForcePt = transform.TransformPoint(localForcePoint);
			Rigidbody.AddForceAtPosition(vel, worldForcePt, ForceMode2D.Force);
		}
	}

	public override void OnShoot(Vector3 boost)
	{
		Vector3 norm = boost.normalized;
		float dir = 0f;
		if (Mathf.Abs(norm.x) > 0.2f)
		{
			dir = Mathf.Sign(boost.x);
		}
		engineDirection = dir;
	}
}
