using System.Collections.Generic;
using UnityEngine;

public class SimpleWaypointTraffic : MonoBehaviour
{
	public List<Transform> Waypoints;

	public List<GameObject> CarPrefab;

	public int NumberOfCars;

	private List<GameObject> _spawnedCars;

	private void Start()
	{
	}
}
