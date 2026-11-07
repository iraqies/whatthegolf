using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GrasRemoverCollection : MonoBehaviour
{
	public TerrainData GrassTerrain;

	public int RemoveRadius;

	public float DistanceThreshold;

	public ParticleSystem CutParticles;

	public float EmitParticlesModifier;

	public List<Transform> GrassCutters;

	public Dictionary<Transform, Vector3> lastCuts;

	private bool spawnParticles;

	private int[,] detailLayer;

	private bool initialized;

	private void Awake()
	{
	}

	private IEnumerator Start()
	{
		return null;
	}

	private void Update()
	{
	}

	private void Cut(Transform cutter)
	{
	}

	protected virtual bool CheckCoords(int[,] detailLayer, int x, int y, int fromX, int fromY)
	{
		return false;
	}

	private Vector3 ConvertWorldCor2TerrCor(Vector3 worldCor)
	{
		return default;
	}
}
