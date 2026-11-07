using System.Collections.Generic;
using UnityEngine;
using Utility;

public class SpawnFromVolumeTowardsTarget3D : MonoBehaviour, IObjectPooler
{
	public Rigidbody ObjectToSpawn;

	public BoxCollider SpawnVolume;

	public Transform Target;

	public float SpawnInterval;

	public float firstSpawnDelay;

	public float offset;

	private float timer;

	private ObjectPool<GameObject> objectPool;

	private List<GameObject> activeObject;

	public ObjectPool<GameObject> GetPool => null;

	private void Start()
	{
	}

	private void Update()
	{
	}

	public Vector3 CalculateVelocityForTarget(Vector3 startPosition, Vector3 target, float initialAngle)
	{
		return default;
	}
}
