using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;
using Utility;

public class BusFightRoadSpawner : MonoBehaviour
{
	public GameObject linePrefab;

	public List<GameObject> piecePrefabs;

	public Transform bus;

	public Vector2 distanceIntervalRange = new Vector2(15f, 30f);

	public float spawnDistanceFromBus = 80f;

	public float lineDistanceInterval = 10f;

	public float InitialZStart = 10f;

	public bool UseSpawnerPosition;

	public Transform RoadPieceParent;

	private Vector3 nextSpawnPosition;

	private Vector3 nextLineSpawnPosition;

	private List<GameObject> placedPieces = new List<GameObject>();

	private List<GameObject> freePieces = new List<GameObject>();

	private ObjectPool<GameObject> linePool;

	private List<GameObject> placedLines = new List<GameObject>();

	private void Start()
	{
		placedPieces = new List<GameObject>();
		freePieces = new List<GameObject>();
		placedLines = new List<GameObject>();
		if (linePrefab != null)
		{
			linePool = new ObjectPool<GameObject>(linePrefab, 20);
		}
		if (piecePrefabs != null)
		{
			for (int i = 0; i < piecePrefabs.Count; i++)
			{
				if (piecePrefabs[i] != null)
				{
					GameObject p1 = Object.Instantiate(piecePrefabs[i], RoadPieceParent);
					GameObject p2 = Object.Instantiate(piecePrefabs[i], RoadPieceParent);
					p1.SetActive(false);
					p2.SetActive(false);
					freePieces.Add(p1);
					freePieces.Add(p2);
				}
			}
			freePieces = freePieces.OrderBy(_ => Random.value).ToList();
		}
		Vector3 basePos = UseSpawnerPosition ? transform.position : (bus != null ? bus.position : transform.position);
		nextSpawnPosition = basePos + Vector3.forward * InitialZStart;
		nextLineSpawnPosition = nextSpawnPosition;
		if (bus != null)
		{
			while (nextSpawnPosition.z < bus.position.z + spawnDistanceFromBus)
			{
				SpawnRoad();
			}
			while (nextLineSpawnPosition.z < bus.position.z + spawnDistanceFromBus)
			{
				SpawnLine();
			}
		}
	}

	private void SpawnLine()
	{
		for (int i = placedLines.Count - 1; i >= 0; i--)
		{
			GameObject l = placedLines[i];
			if (l != null && bus != null && l.transform.position.z < bus.position.z - spawnDistanceFromBus)
			{
				placedLines.RemoveAt(i);
				linePool?.Release(l);
			}
		}
		if (linePool != null)
		{
			GameObject line = linePool.Get(nextLineSpawnPosition, Quaternion.identity);
			if (line != null)
			{
				line.SetActive(true);
				placedLines.Add(line);
			}
		}
		nextLineSpawnPosition += Vector3.forward * lineDistanceInterval;
	}

	private void SpawnRoad()
	{
		for (int i = placedPieces.Count - 1; i >= 0; i--)
		{
			GameObject p = placedPieces[i];
			if (p != null && bus != null && p.transform.position.z < bus.position.z - spawnDistanceFromBus)
			{
				placedPieces.RemoveAt(i);
				p.SetActive(false);
				freePieces.Add(p);
			}
		}
		if (freePieces.Count == 0 && piecePrefabs != null && piecePrefabs.Count > 0)
		{
			GameObject prefab = piecePrefabs[Random.Range(0, piecePrefabs.Count)];
			if (prefab != null)
			{
				GameObject inst = Object.Instantiate(prefab, RoadPieceParent);
				inst.SetActive(false);
				freePieces.Add(inst);
			}
		}
		if (freePieces.Count > 0)
		{
			int idx = Random.Range(0, freePieces.Count);
			GameObject piece = freePieces[idx];
			freePieces.RemoveAt(idx);
			placedPieces.Add(piece);
			if (piece != null)
			{
				piece.SetActive(true);
				piece.transform.position = nextSpawnPosition;
				StartCoroutine(GrowPiece(piece.transform));
			}
		}
		nextSpawnPosition += Vector3.forward * Random.Range(distanceIntervalRange.x, distanceIntervalRange.y);
	}

	private IEnumerator GrowPiece(Transform piece)
	{
		if (piece == null)
		{
			yield break;
		}
		Vector3 targetPos = piece.position;
		Vector3 startPos = targetPos - Vector3.up * 10f;
		piece.position = startPos;
		yield return StartCoroutine(pTween.To(0.4f, t =>
		{
			if (piece != null)
			{
				piece.position = Vector3.Lerp(startPos, targetPos, Mathf.Clamp01(TweenFunctions.EaseOut(t)));
			}
		}));
	}

	private void Update()
	{
		if (bus == null)
		{
			return;
		}
		if (nextSpawnPosition.z < bus.position.z + spawnDistanceFromBus)
		{
			SpawnRoad();
		}
		if (nextLineSpawnPosition.z < bus.position.z + spawnDistanceFromBus)
		{
			SpawnLine();
		}
	}
}
