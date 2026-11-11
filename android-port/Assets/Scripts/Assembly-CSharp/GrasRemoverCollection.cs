using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GrasRemoverCollection : MonoBehaviour
{
	public TerrainData GrassTerrain;

	public int RemoveRadius = 3;

	public float DistanceThreshold = 0.25f;

	public ParticleSystem CutParticles;

	public float EmitParticlesModifier = 1f;

	public List<Transform> GrassCutters;

	public Dictionary<Transform, Vector3> lastCuts = new Dictionary<Transform, Vector3>();

	private bool spawnParticles;

	private int[,] detailLayer;

	private bool initialized;

	private void Awake()
	{
		spawnParticles = CutParticles != null;
		lastCuts = new Dictionary<Transform, Vector3>();
		if (GrassCutters != null)
		{
			for (int i = 0; i < GrassCutters.Count; i++)
			{
				if (GrassCutters[i] != null && !lastCuts.ContainsKey(GrassCutters[i]))
				{
					lastCuts.Add(GrassCutters[i], Vector3.zero);
				}
			}
		}
	}

	private IEnumerator Start()
	{
		yield return null;
		if (GrassTerrain != null)
		{
			detailLayer = GrassTerrain.GetDetailLayer(0, 0, GrassTerrain.detailWidth, GrassTerrain.detailHeight, 0);
			initialized = true;
		}
	}

	private void Update()
	{
		if (!initialized || GrassCutters == null)
		{
			return;
		}
		for (int i = 0; i < GrassCutters.Count; i++)
		{
			Transform cutter = GrassCutters[i];
			if (cutter == null)
			{
				continue;
			}
			if (!lastCuts.TryGetValue(cutter, out Vector3 lastPos) || lastPos == Vector3.zero || Vector3.Distance(lastPos, cutter.position) >= DistanceThreshold)
			{
				Cut(cutter);
				lastCuts[cutter] = cutter.position;
			}
		}
	}

	private void Cut(Transform cutter)
	{
		if (cutter == null || GrassTerrain == null || detailLayer == null)
		{
			return;
		}
		Vector3 tCor = ConvertWorldCor2TerrCor(cutter.position);
		int cx = Mathf.RoundToInt(tCor.x);
		int cz = Mathf.RoundToInt(tCor.z);
		int cutCount = 0;
		for (int dx = -RemoveRadius; dx <= RemoveRadius; dx++)
		{
			for (int dz = -RemoveRadius; dz <= RemoveRadius; dz++)
			{
				int rx = cx + dx;
				int rz = cz + dz;
				if (CheckCoords(detailLayer, rx, rz, cx, cz))
				{
					if (detailLayer[rz, rx] > 0)
					{
						cutCount += detailLayer[rz, rx];
						detailLayer[rz, rx] = 0;
					}
				}
			}
		}
		if (cutCount > 0)
		{
			GrassTerrain.SetDetailLayer(0, 0, 0, detailLayer);
			if (spawnParticles && CutParticles != null)
			{
				CutParticles.transform.position = cutter.position;
				CutParticles.Emit(Mathf.RoundToInt(cutCount * EmitParticlesModifier));
			}
		}
	}

	protected virtual bool CheckCoords(int[,] detailLayer, int x, int y, int fromX, int fromY)
	{
		return detailLayer != null && y >= 0 && y < detailLayer.GetLength(0) && x >= 0 && x < detailLayer.GetLength(1);
	}

	private Vector3 ConvertWorldCor2TerrCor(Vector3 worldCor)
	{
		Terrain t = Terrain.activeTerrain;
		if (t == null || t.terrainData == null)
		{
			return Vector3.zero;
		}
		Vector3 rel = worldCor - t.transform.position;
		Vector3 size = t.terrainData.size;
		int res = t.terrainData.detailResolution;
		return new Vector3((rel.x / Mathf.Max(0.01f, size.x)) * res, 0f, (rel.z / Mathf.Max(0.01f, size.z)) * res);
	}
}
