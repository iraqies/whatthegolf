using System.Collections.Generic;
using Chronos;
using UnityEngine;
using Utility;

public class FishingBall : MonoBehaviour
{
	public ObjectPool<GameObject> BulletPool;

	public float MoveSpeed;

	public float LifeTime;

	public ParticleSystem BulletDeathParticles;

	public Collider collider;

	private float currentLifeTime;

	private Rigidbody rigidBody;

	private Timeline timeline;

	private TrailRenderer trail;

	private LineRenderer line;

	private Vector3 lastLinePos;

	public float lineSegmentDistance;

	private int lineSections;

	private List<Vector3> linePositions;

	private bool inWater;

	private void Awake()
	{
	}

	private void OnEnable()
	{
	}

	public void SetSpeed(float speedMod)
	{
	}

	private void Update()
	{
	}

	private void OnCollisionEnter(Collision other)
	{
	}

	private void OnTriggerEnter(Collider other)
	{
	}

	private void KillBullet(Vector3 point)
	{
	}

	private void DrawFishingLine()
	{
	}
}
