using Core;
using UnityEngine;

public class OverworldBallSawHelper : MonoBehaviour
{
	public float rotationSpeed;

	public Transform sawVisuals;

	private bool isStuck;

	private GolfBallController ball;

	private FixedJoint2D joint;

	private float nextStuckTime;

	private Collider2D lastStuckCollider;

	private Rigidbody2D rigid;

	private Vector3 lastVelocity;

	private Vector3 lastlastVelocity;

	public float minSpeed;

	private float stillTime;

	private void Start()
	{
	}

	private void Ball_OnShoot(Vector3 dir)
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
