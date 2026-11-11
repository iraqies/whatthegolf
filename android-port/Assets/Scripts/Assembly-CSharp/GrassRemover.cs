using System.Collections;
using UnityEngine;

public class GrassRemover : MonoBehaviour
{
	public TerrainData GrassTerrain;

	public int RemoveRadius = 3;

	public float DistanceThreshold = 0.25f;

	public ParticleSystem CutParticles;

	public float EmitParticlesModifier = 1f;

	public AudioSource cutAudioSource;

	public float maxVolume = 1f;

	private Vector3 lastCut;

	private float audioCutTimer;

	private bool spawnParticles;

	private float targetVolume;

	private int[,] detailLayer;

	private bool initialized;

	private void Awake()
	{
		spawnParticles = CutParticles != null;
	}

	private IEnumerator Start()
	{
		yield return null;
		if (GrassTerrain != null)
		{
			detailLayer = GrassTerrain.GetDetailLayer(0, 0, GrassTerrain.detailWidth, GrassTerrain.detailHeight, 0);
			initialized = true;
			Cut();
		}
	}

	private void Update()
	{
		if (!initialized)
		{
			return;
		}
		if (lastCut == Vector3.zero || Vector3.Distance(lastCut, transform.position) >= DistanceThreshold)
		{
			Cut();
			lastCut = transform.position;
		}
		if (cutAudioSource != null)
		{
			if (audioCutTimer > 0f)
			{
				audioCutTimer -= Time.deltaTime;
				targetVolume = maxVolume;
			}
			else
			{
				targetVolume = 0f;
			}
			cutAudioSource.volume = Mathf.MoveTowards(cutAudioSource.volume, targetVolume, Time.deltaTime * 5f);
		}
	}

	private void Cut()
	{
		if (GrassTerrain == null || detailLayer == null)
		{
			return;
		}
		Vector3 tCor = ConvertWorldCor2TerrCor(transform.position);
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
				CutParticles.Emit(Mathf.RoundToInt(cutCount * EmitParticlesModifier));
			}
			audioCutTimer = 0.25f;
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
