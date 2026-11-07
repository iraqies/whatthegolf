using Core;
using UnityEngine;

public class EvilFlagCircle : MonoBehaviour
{
	public Transform circleCenter;

	public int steps;

	public float velocity;

	public GolfBallController ball;

	private Rigidbody rigidbody;

	private int currentStep;

	private Vector3 currentTarget;

	private float radius;

	private void Awake()
	{
	}

	private Vector3 GetCirclePosition(int step, float radius, Vector3 center)
	{
		return default;
	}

	private void Ball_OnShoot(Vector3 aim)
	{
	}

	private void FixedUpdate()
	{
	}

	private void OnDrawGizmos()
	{
	}
}
