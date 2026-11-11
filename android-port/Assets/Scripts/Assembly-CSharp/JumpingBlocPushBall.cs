using Core;
using UnityEngine;

public class JumpingBlocPushBall : MonoBehaviour
{
	private bool applyForce;

	private Rigidbody ball_rb;

	private Vector3 savedBallVelocity;

	private void OnTriggerEnter(Collider other)
	{
		if (other.GetComponent<GolfBallController>() != null)
		{
			applyForce = true;
			ball_rb = other.GetComponent<Rigidbody>();
			savedBallVelocity = ball_rb.velocity;
		}
	}

	private void LateUpdate()
	{
		if (applyForce && ball_rb != null)
		{
			ball_rb.velocity = savedBallVelocity;
		}
	}

	private void OnTriggerExit(Collider other)
	{
		if (other.GetComponent<GolfBallController>() != null)
		{
			applyForce = false;
		}
	}
}
