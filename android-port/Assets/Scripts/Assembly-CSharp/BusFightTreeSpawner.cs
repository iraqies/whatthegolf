using System.Collections.Generic;
using UnityEngine;

public class BusFightTreeSpawner : MonoBehaviour
{
	public List<Transform> edgeTrees;

	public List<Transform> trees;

	public float distanceInterval;

	public float spawnDistanceFromBus;

	public float centerAvoidRadius;

	private BusFight bus;

	private float nextSpawnZ;

	private float nextEdgeSpawnZ;

	private void Start()
	{
	}

	private void Update()
	{
	}

	private bool MakeEdgeTree()
	{
		return false;
	}

	private bool MakeTree()
	{
		return false;
	}
}
