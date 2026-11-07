using UnityEngine;
using UnityEngine.AI;

public class GoToRandomNavMeshPosition : MonoBehaviour
{
	public Vector2 WaitTimeRange;

	public float range;

	private NavMeshAgent agent;

	private float waitTimer;

	private void Awake()
	{
	}

	private void Update()
	{
	}

	private bool RandomPoint(Vector3 center, float range, out Vector3 result)
	{
		result = default;
		return false;
	}

	private void OnDrawGizmos()
	{
	}
}
