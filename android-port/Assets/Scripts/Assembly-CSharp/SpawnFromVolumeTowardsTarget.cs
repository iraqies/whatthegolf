using System.Collections.Generic;
using UnityEngine;
using Utility;

public class SpawnFromVolumeTowardsTarget : MonoBehaviour, IObjectPooler
{
	public Rigidbody2D ObjectToSpawn;

	public BoxCollider2D SpawnVolume;

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

	private void OnDisable()
	{
	}

	public Vector3 CalculateVelocityForTarget(Vector3 startPosition, Vector3 target, float initialAngle)
	{
		return default;
	}
}
