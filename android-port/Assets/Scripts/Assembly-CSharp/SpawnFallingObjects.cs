using System.Collections.Generic;
using Chronos;
using UnityEngine;
using Utility;

public class SpawnFallingObjects : MonoBehaviour
{
	[SerializeField]
	public List<Rigidbody> spawnObjects;

	[SerializeField]
	public float spawnInterval;

	[SerializeField]
	public int spawnAmount;

	[SerializeField]
	public Vector2 spawnTorqueForceRange;

	[SerializeField]
	public Vector3 spawnForce;

	[SerializeField]
	public BoxCollider spawnArea;

	[SerializeField]
	public BoxCollider levelBounds;

	[SerializeField]
	public float radiusCheck;

	[SerializeField]
	public float timeChangeSpeed;

	[SerializeField]
	public float timeChangeBackSpeed;

	[SerializeField]
	public float startDelay;

	private float spawnTimer;

	private List<ObjectPool<Rigidbody>> pools;

	private List<Rigidbody> activeObjects;

	private Timeline timeline;

	private float timeScaleTarget;

	private float origTimeScale;

	private float heightOffsetToBall;

	private void Start()
	{
	}

	private void Ball_OnShoot(Vector3 obj)
	{
	}

	private void Update()
	{
	}
}
