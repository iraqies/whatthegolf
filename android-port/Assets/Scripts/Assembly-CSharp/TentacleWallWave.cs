using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TentacleWallWave : FrogKingBaseWave
{
	public List<GameObject> TentaclePrefabs;

	public Vector2 TentacleScaleMod;

	public float TentacleSpacing;

	public Vector2 TentacleDelay;

	public float TentacleLife;

	public float WaveDuration;

	public float SpawnStartX;

	public float WaveSize;

	public int GabSize;

	public string ChildNameToScale;

	private List<GameObject> activeObjects;

	public override IEnumerator WaveRoutine(SHMUPFrogKing frogKing)
	{
		return null;
	}

	public Vector3 FindMidpoint(int amount, float z)
	{
		return default;
	}

	public override void OnSinkReset()
	{
	}

	private IEnumerator TentacleLifeRoutine(GameObject tentacle)
	{
		return null;
	}
}
