using System.Collections.Generic;
using Core;
using UnityEngine;

public class RollerPatrollingMovement : MonoBehaviour
{
	public Transform WaypointContainer;

	private List<Transform> m_wayPoints;

	private RollingCowShooter m_roller;

	private int wp_index;

	private void Start()
	{
	}

	private void FixedUpdate()
	{
	}
}
