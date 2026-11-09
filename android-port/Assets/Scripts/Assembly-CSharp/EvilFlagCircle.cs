using Core;
using UnityEngine;

public class EvilFlagCircle : MonoBehaviour
{
	public Transform circleCenter;

	public int steps = 8;

	public float velocity = 30f;

	public GolfBallController ball;

	private Rigidbody rigidbody;

	private int currentStep;

	private Vector3 currentTarget;

	private float radius;

	private void Awake()
	{
		rigidbody = GetComponent<Rigidbody>();
		if (circleCenter != null)
		{
			radius = Vector3.Distance(transform.position, circleCenter.position);
			currentStep = 0;
			currentTarget = GetCirclePosition(0, radius, circleCenter.position);
			if (rigidbody != null)
				rigidbody.position = currentTarget;
		}
		if (ball != null)
		{
			ball.OnShoot -= Ball_OnShoot;
			ball.OnShoot += Ball_OnShoot;
		}
	}

	private Vector3 GetCirclePosition(int step, float radius, Vector3 center)
	{
		int count = Mathf.Max(1, steps);
		float angle = (float)step * (Mathf.PI * 2f) / (float)count;
		return center + new Vector3(radius * Mathf.Sin(angle), 0f, radius * Mathf.Cos(angle));
	}

	private void Ball_OnShoot(Vector3 aim)
	{
		int count = Mathf.Max(1, steps);
		currentStep = (currentStep + 1) % count;
		if (circleCenter != null)
		{
			currentTarget = GetCirclePosition(currentStep, radius, circleCenter.position);
		}
	}

	private void FixedUpdate()
	{
		if (rigidbody == null) return;
		Vector3 delta = currentTarget - transform.position;
		float step = Mathf.Min(delta.magnitude, velocity * Time.fixedDeltaTime);
		rigidbody.MovePosition(transform.position + delta.normalized * step);
	}

	private void OnDrawGizmos()
	{
	}
}
