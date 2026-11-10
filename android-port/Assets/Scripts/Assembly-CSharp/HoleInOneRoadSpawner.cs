using System.Collections.Generic;
using UnityEngine;

public class HoleInOneRoadSpawner : MonoBehaviour
{
	public Transform ball;

	public float speed;

	public Transform tree;

	public List<Transform> treeSpawnPoints;

	public float treeSpawnInterval;

	public bool isBad;

	public bool isWin;

	public List<Transform> spawnedTrees = new List<Transform>();

	public List<Rigidbody2D> spawnedRigids = new List<Rigidbody2D>();

	private float nextTree;

	private void Awake()
	{
	}

	private void Update()
	{
		if (Time.time > nextTree && tree != null && treeSpawnPoints != null && treeSpawnPoints.Count > 0)
		{
			nextTree = Time.time + treeSpawnInterval;
			Transform spawned = Instantiate(tree);
			int idx = Random.Range(0, treeSpawnPoints.Count);
			if (treeSpawnPoints[idx] != null)
				spawned.position = treeSpawnPoints[idx].position;
			spawned.rotation = tree.rotation;
			spawned.SetParent(transform, true);
			Rigidbody2D rb = spawned.GetComponent<Rigidbody2D>();
			if (spawnedTrees == null)
				spawnedTrees = new List<Transform>();
			spawnedTrees.Add(spawned);
			if (rb != null)
			{
				if (spawnedRigids == null)
					spawnedRigids = new List<Rigidbody2D>();
				spawnedRigids.Add(rb);
			}
		}

		if (spawnedTrees == null)
			return;
		foreach (Transform t in spawnedTrees)
		{
			if (t == null)
				continue;
			t.position += Vector3.down * speed * Time.deltaTime;
		}
	}
}
