using Core;
using UnityEngine;

public class OverworldBallSawHelper : MonoBehaviour
{
	public float rotationSpeed = -200f;

	public Transform sawVisuals;

	private bool isStuck;

	private GolfBallController ball;

	private FixedJoint2D joint;

	private float nextStuckTime;

	private Collider2D lastStuckCollider;

	private Rigidbody2D rigid;

	private Vector3 lastVelocity;

	private Vector3 lastlastVelocity;

	public float minSpeed = 1f;

	private float stillTime;

	private void Start()
	{
		ball = GetComponent<GolfBallController>();
		if (ball != null)
		{
			ball.OnShoot += Ball_OnShoot;
		}
		rigid = GetComponent<Rigidbody2D>();
	}

	private void Ball_OnShoot(Vector3 dir)
	{
		if (isStuck)
		{
			if (joint != null)
			{
				Object.Destroy(joint);
			}
			isStuck = false;
			nextStuckTime = Time.time + 0.1f;
		}
	}

	private void Update()
	{
		if (!isStuck && sawVisuals != null)
		{
			sawVisuals.Rotate(0f, 0f, rotationSpeed * Time.deltaTime);
		}
	}

	private void FixedUpdate()
	{
		if (rigid == null)
		{
			return;
		}
		lastlastVelocity = lastVelocity;
		lastVelocity = rigid.velocity;
		if (ball != null)
		{
			ball.BlockAiming = Time.fixedTime - stillTime < 0.25f;
		}
		if (rigid.velocity.magnitude > minSpeed)
		{
			stillTime = Time.fixedTime;
		}
	}

	private void OnCollisionEnter2D(Collision2D collision)
	{
		if (isStuck || collision == null || collision.collider == null || collision.collider.CompareTag("Obstacle"))
		{
			return;
		}
		if (Time.time > nextStuckTime || collision.collider != lastStuckCollider)
		{
			if (lastlastVelocity.magnitude > minSpeed || (collision.contacts != null && collision.contacts.Length > 0 && Vector3.Dot(collision.contacts[0].normal, Vector2.up) < 0.45f))
			{
				isStuck = true;
				joint = gameObject.AddComponent<FixedJoint2D>();
				joint.connectedBody = collision.rigidbody;
				lastStuckCollider = collision.collider;
				stillTime = -1f;
			}
		}
	}
}
