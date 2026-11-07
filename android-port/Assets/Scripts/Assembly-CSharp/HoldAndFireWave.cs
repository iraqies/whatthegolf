using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HoldAndFireWave : FrogKingBaseWave
{
	public List<GameObject> Prefabs;

	public string ChildNameToScale;

	public Vector2 TentacleScaleMod;

	public float TentacleSpacing;

	public Vector2 TentacleDelay;

	public float TentacleLife;

	public float WaveDuration;

	public float SpawnStartX;

	public float WaveSize;

	public int GabSize;

	public float HoldTime;

	public float MoveSpeed;

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

	private IEnumerator TentacleLifeRoutine(GameObject tentacle, Transform frog)
	{
		return null;
	}
}
