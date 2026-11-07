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

	public List<Transform> spawnedTrees;

	public List<Rigidbody2D> spawnedRigids;

	private float nextTree;

	private void Awake()
	{
	}

	private void Update()
	{
	}
}
