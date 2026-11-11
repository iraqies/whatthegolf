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
		bus = GetComponent<BusFight>();
		nextSpawnZ = base.transform.position.z + distanceInterval;
	}

	private void Update()
	{
		if (base.transform.position.z > nextSpawnZ && MakeTree())
		{
			nextSpawnZ = base.transform.position.z + distanceInterval * Random.Range(0.8f, 1.55f);
		}
		if (base.transform.position.z > nextEdgeSpawnZ && MakeEdgeTree())
		{
			nextEdgeSpawnZ = base.transform.position.z + distanceInterval * 4f * Random.Range(0.8f, 1.55f);
		}
	}

	private bool MakeEdgeTree()
	{
		int index = Random.Range(0, edgeTrees.Count - 1);
		Vector3 busPositionForOffsetZ = bus.GetBusPositionForOffsetZ(spawnDistanceFromBus, false);
		float num = Mathf.Abs(busPositionForOffsetZ.x);
		float num2 = centerAvoidRadius * 0.8f;
		if (num > num2)
		{
			float x = Mathf.Sign(0f - busPositionForOffsetZ.x) * 41.5f;
			Transform transform = Object.Instantiate(edgeTrees[index], new Vector3(x, busPositionForOffsetZ.y, busPositionForOffsetZ.z), Quaternion.Euler(0f, Random.Range(0f, 360f), 0f));
			transform.localScale *= Random.Range(1f, 1.2f);
		}
		return num > num2;
	}

	private bool MakeTree()
	{
		int index = Random.Range(0, trees.Count - 1);
		Vector3 busPositionForOffsetZ = bus.GetBusPositionForOffsetZ(spawnDistanceFromBus, false);
		float num = Mathf.Abs(busPositionForOffsetZ.x);
		float num2 = centerAvoidRadius;
		if (num > num2)
		{
			float x = (0f - busPositionForOffsetZ.x) * Random.Range(0.6f, 1.4f);
			Transform transform = Object.Instantiate(trees[index], new Vector3(x, busPositionForOffsetZ.y, busPositionForOffsetZ.z), Quaternion.Euler(0f, Random.Range(0f, 360f), 0f));
			transform.localScale *= Random.Range(1f, 1.2f);
		}
		return num > num2;
	}
}
