using UnityEngine;

public class RotatingArmBlob : GolfBehaviour
{
	public float rotationSpeed;

	public Transform throwTarget;

	public Transform handPosition;

	public Transform throwFromPosition;

	public float throwSpeed = 10f;

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
		base.OnPrePlayOrPreCompile();
		rigid = GetComponent<Rigidbody2D>();
		col = GetComponent<Collider2D>();
	}

	private void Update()
	{
		if (isHoldingBall && currentBall != null && handPosition != null)
		{
			timeWithBall += Time.deltaTime;
			Vector3 targetLocal = transform.InverseTransformPoint(handPosition.position);
			Vector3 nextLocal = Vector3.MoveTowards(localBallPosition, targetLocal, Time.deltaTime * moveToHandSpeed);
			localBallPosition = new Vector2(nextLocal.x, nextLocal.y);
			Vector3 worldPos = transform.TransformPoint(localBallPosition);
			if (currentBall.Rigidbody2D != null)
			{
				currentBall.Rigidbody2D.MovePosition(worldPos);
			}
			currentBall.transform.position = worldPos;
			if (throwFromPosition != null)
			{
				Vector3 diff = currentBall.transform.position - throwFromPosition.position;
				diff.z = 0f;
				if (timeWithBall > 1f && diff.magnitude < 1f)
				{
					if (currentBall.Rigidbody2D != null)
					{
						currentBall.Rigidbody2D.isKinematic = false;
						if (throwTarget != null)
						{
							Vector3 dir = (throwTarget.position - currentBall.transform.position).normalized;
							currentBall.Rigidbody2D.velocity = new Vector2(dir.x * throwSpeed, dir.y * throwSpeed);
						}
					}
					isHoldingBall = false;
					currentBall = null;
					timeWithBall = 0f;
					nextCatchTime = Time.time + 0.1f;
				}
			}
		}
		rotation += Time.deltaTime;
	}

	private void FixedUpdate()
	{
		if (rigid != null)
		{
			rigid.MoveRotation(rotationSpeed * rotation);
		}
		if (col != null && col.isTrigger && Time.time > nextCatchTime)
		{
			col.isTrigger = false;
		}
	}

	private void OnCollisionEnter2D(Collision2D collision)
	{
		if (isHoldingBall || Time.time < nextCatchTime || collision == null || collision.rigidbody == null)
		{
			return;
		}
		OverworldBall2D ball = collision.rigidbody.GetComponent<OverworldBall2D>();
		if (ball != null)
		{
			isHoldingBall = true;
			currentBall = ball;
			if (ball.Rigidbody2D != null)
			{
				ball.Rigidbody2D.isKinematic = true;
			}
			if (col != null)
			{
				col.isTrigger = true;
			}
			Vector3 inv = transform.InverseTransformPoint(ball.transform.position);
			localBallPosition = new Vector2(inv.x, inv.y);
		}
	}
}
