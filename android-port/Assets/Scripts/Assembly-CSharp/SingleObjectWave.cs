using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SingleObjectWave : FrogKingBaseWave
{
	public List<GameObject> ObjectPrefab;

	public Vector2 SpawnRangeX;

	public Vector2 ScaleMod;

	public float WaveDuration;

	public float zOffset;

	public SHMUPController PlayerBoat;

	public bool StopWaveOncePlyerHasPassed;

	public float FollowBossTime;

	private List<GameObject> currentObjects;

	public override IEnumerator WaveRoutine(SHMUPFrogKing frogKing)
	{
		return null;
	}

	private IEnumerator FollowBoss(Transform trans, Transform frogKing)
	{
		return null;
	}

	public override void OnSinkReset()
	{
	}
}
