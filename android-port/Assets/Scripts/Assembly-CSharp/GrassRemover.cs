using System.Collections;
using UnityEngine;

public class GrassRemover : MonoBehaviour
{
	public TerrainData GrassTerrain;

	public int RemoveRadius;

	public float DistanceThreshold;

	public ParticleSystem CutParticles;

	public float EmitParticlesModifier;

	public AudioSource cutAudioSource;

	public float maxVolume;

	private Vector3 lastCut;

	private float audioCutTimer;

	private bool spawnParticles;

	private float targetVolume;

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

	private void Cut()
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
