using Core;
using UnityEngine;

public class EvilFlagMoveThenStop : MonoBehaviour
{
	public Transform otherPosition;

	public float velocity = 30f;

	public GolfBallController ball;

	private Vector3 startPos;

	private Rigidbody rigidbody;

	private int currentStep;

	private Vector3 currentTarget;

	private bool isMoving;

	private void Awake()
	{
		rigidbody = GetComponent<Rigidbody>();
		startPos = transform.position;
		currentStep = 0;
		currentTarget = startPos;
		if (rigidbody != null)
			rigidbody.position = startPos;
		isMoving = true;
		if (ball != null)
		{
			ball.OnShoot -= Ball_OnShoot;
			ball.OnShoot += Ball_OnShoot;
		}
	}

	private void Ball_OnShoot(Vector3 aim)
	{
		isMoving = false;
	}

	private void FixedUpdate()
	{
		Vector3 delta = currentTarget - transform.position;
		float step = Mathf.Min(delta.magnitude, velocity * Time.fixedDeltaTime);
		if (isMoving && rigidbody != null)
		{
			Vector3 nextPos = transform.position + delta.normalized * step;
			rigidbody.MovePosition(nextPos);
			if (Vector3.Distance(nextPos, currentTarget) <= 0.1f)
			{
				int prevStep = currentStep;
				currentStep++;
				if ((prevStep & 1) == 0 && otherPosition != null)
					currentTarget = otherPosition.position;
				else
					currentTarget = startPos;
			}
		}
	}
}
