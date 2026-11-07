using Triband.Splines;
using UnityEngine;

public class RideToyRoad : MonoBehaviour
{
	public float maxSpeed;

	public float followSplineYdistance;

	private Spline currentRoad;

	private Rigidbody rigidbody;

	private float savedVelocity;

	private float dir;

	private Vector3 splineDir;

	private void Start()
	{
	}

	private void FixedUpdate()
	{
	}

	private void VelocityFollowsSpline()
	{
	}
}
