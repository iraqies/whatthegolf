using UnityEngine;

public class RotatingArmBlob : GolfBehaviour
{
	public float rotationSpeed;

	public Transform throwTarget;

	public Transform handPosition;

	public Transform throwFromPosition;

	public float throwSpeed;

	public float moveToHandSpeed;

	private float timeWithBall;

	private bool isHoldingBall;

	private OverworldBall2D currentBall;

	private float lastBallPosition;

	private float nextCatchTime;

	[SerializeField]
	private Rigidbody2D rigid;

	[SerializeField]
	private Collider2D col;

	private float rotation;

	private Vector2 localBallPosition;

	public override void OnPrePlayOrPreCompile()
	{
	}

	private void Update()
	{
	}

	private void FixedUpdate()
	{
	}

	private void OnCollisionEnter2D(Collision2D collision)
	{
	}
}
