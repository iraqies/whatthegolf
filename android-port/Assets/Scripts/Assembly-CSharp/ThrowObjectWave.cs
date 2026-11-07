using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ThrowObjectWave : FrogKingBaseWave
{
	public Transform SpawnPosition;

	public Vector3 EndOffsetFromBoat;

	public List<Transform> ObjectPrefabs;

	public Transform PlayerBoat;

	public Transform ObjectShadow;

	public int ObjectsToThrow;

	public float DelayBetweenThrows;

	public float WaveDuration;

	public float ObjectFlyTime;

	public float ThrowHeight;

	public float InitialWaitTime;

	public AnimationCurve ShadowScaleCurve;

	private Transform frogKingTrans;

	private List<Transform> spawnedObjects;

	public override IEnumerator WaveRoutine(SHMUPFrogKing frogKing)
	{
		return null;
	}

	public override void OnSinkReset()
	{
	}

	private IEnumerator MoveObjectRoutine(Transform trans, Transform shadowTrans)
	{
		return null;
	}

	public Vector3 CalculateVelocityForTarget(Vector3 startPosition, Vector3 target, float initialAngle)
	{
		return default;
	}
}
