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
		if (isHoldingBall)
		{
			timeWithBall += Time.deltaTime;
			Vector3 vector = Vector3.MoveTowards(localBallPosition, base.transform.InverseTransformPoint(handPosition.position), Time.deltaTime * moveToHandSpeed);
			localBallPosition = new Vector2(vector.x, vector.y);
			Vector3 vector2 = base.transform.TransformPoint(localBallPosition);
			currentBall.rigidBody.MovePosition(vector2);
			currentBall.transform.position = vector2;
			Vector3 vector3 = currentBall.transform.position - throwFromPosition.position;
			vector3.z = 0f;
			if (timeWithBall > 1f && vector3.magnitude < 1f)
			{
				currentBall.rigidBody.isKinematic = false;
				Vector3 normalized = (throwTarget.position - currentBall.transform.position).normalized;
				currentBall.rigidBody.velocity = new Vector2(normalized.x * throwSpeed, normalized.y * throwSpeed);
				isHoldingBall = false;
				currentBall = null;
				timeWithBall = 0f;
			}
			nextCatchTime = Time.time + 0.1f;
		}
		rotation += Time.deltaTime;
	}

	private void FixedUpdate()
	{
		rigid.MoveRotation(rotationSpeed * rotation);
		if (col.isTrigger && Time.time > nextCatchTime)
		{
			col.isTrigger = false;
		}
	}

	private void OnCollisionEnter2D(Collision2D collision)
	{
		if (!isHoldingBall && !(Time.time < nextCatchTime) && collision.rigidbody != null)
		{
			OverworldBall2D component = collision.rigidbody.GetComponent<OverworldBall2D>();
			if (component != null)
			{
				isHoldingBall = true;
				currentBall = component;
				component.rigidBody.isKinematic = true;
				col.isTrigger = true;
				Vector3 vector = base.transform.InverseTransformPoint(component.transform.position);
				localBallPosition = new Vector2(vector.x, vector.y);
			}
		}
	}
}
