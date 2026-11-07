using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Utility;

public class BusFightRoadSpawner : MonoBehaviour
{
	public GameObject linePrefab;

	public List<GameObject> piecePrefabs;

	public Transform bus;

	public Vector2 distanceIntervalRange;

	public float spawnDistanceFromBus;

	public float lineDistanceInterval;

	public float InitialZStart;

	public bool UseSpawnerPosition;

	public Transform RoadPieceParent;

	private Vector3 nextSpawnPosition;

	private Vector3 nextLineSpawnPosition;

	private List<GameObject> placedPieces;

	private List<GameObject> freePieces;

	private ObjectPool<GameObject> linePool;

	private List<GameObject> placedLines;

	private void Start()
	{
	}

	private void SpawnLine()
	{
	}

	private void SpawnRoad()
	{
	}

	private IEnumerator GrowPiece(Transform piece)
	{
		return null;
	}

	private void Update()
	{
	}
}
