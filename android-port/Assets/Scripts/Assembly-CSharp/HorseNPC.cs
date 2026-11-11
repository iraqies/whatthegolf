using Core;
using UnityEngine;
using UnityEngine.AI;

public class HorseNPC : MonoBehaviour
{
	public HorseLaps Waypoints;

	private NavMeshAgent agent;

	private int currentWaypoint = -1;

	private bool hasPath;

	private bool hasStarted;

	private void Awake()
	{
		agent = GetComponent<NavMeshAgent>();
		if (NavMesh.SamplePosition(base.transform.position, out var hit, 10f, -1) && agent != null)
		{
			agent.Warp(hit.position);
		}
	}

	private void Start()
	{
		if (Level.Instance != null && Level.Instance.Ball != null)
		{
			Level.Instance.Ball.OnShoot += Ball_OnShoot;
		}
	}

	private void Ball_OnShoot(Vector3 boost)
	{
		if (!hasStarted)
		{
			SetNewDestination();
			hasStarted = true;
		}
	}

	private void Update()
	{
		if (hasPath && agent != null && agent.remainingDistance != float.PositiveInfinity && agent.pathStatus == NavMeshPathStatus.PathComplete && agent.remainingDistance == 0f)
		{
			SetNewDestination();
		}
	}

	private void SetNewDestination()
	{
		if (Waypoints == null || Waypoints.Waypoints == null || Waypoints.Waypoints.Count == 0)
		{
			return;
		}
		if (currentWaypoint + 1 >= Waypoints.Waypoints.Count && Waypoints.HorseLap(base.gameObject, false))
		{
			return;
		}
		currentWaypoint = (currentWaypoint + 1) % Waypoints.Waypoints.Count;
		BoxCollider boxCollider = Waypoints.Waypoints[currentWaypoint];
		if (boxCollider == null)
		{
			return;
		}
		Vector3 position = boxCollider.transform.position;
		Vector3 center = boxCollider.center;
		Vector3 size = boxCollider.size;
		float x = position.x + center.x + (Random.value - 0.5f) * size.x;
		float z = position.z + center.z + (Random.value - 0.5f) * size.z;
		Vector3 sourcePosition = new Vector3(x, base.transform.position.y, z);
		NavMesh.SamplePosition(sourcePosition, out var hit, 5f, -1);
		if (agent != null)
		{
			hasPath = agent.SetDestination(hit.position);
			if (!hasPath)
			{
				Debug.LogWarning("Couldn't find path to waypoint number " + currentWaypoint);
			}
		}
	}

	private void OnTriggerEnter(Collider other)
	{
		if (currentWaypoint >= 0 && Waypoints != null && Waypoints.Waypoints != null && currentWaypoint < Waypoints.Waypoints.Count && other != null && Waypoints.Waypoints[currentWaypoint] != null && other.transform == Waypoints.Waypoints[currentWaypoint].transform)
		{
			SetNewDestination();
		}
	}
}
