using System.Collections.Generic;
using UnityEngine;
using Utility;

public class SpitWall : MonoBehaviour
{
	public AudioClip sfxSpit;

	public float shootInterval;

	public float shootDistance;

	public int maxShots;

	public float maxAngle;

	public float shootSpeed;

	public Transform spitPositionTransform;

	public Rigidbody2D spitPrefab;

	private float nextSpit;

	private Queue<Rigidbody2D> spawnedSpit;

	private ObjectPool<Rigidbody2D> pool;

	private Vector3 lastBallPosition;

	private void Start()
	{
	}

	private void Update()
	{
	}

	private void Spit(Vector3 dir)
	{
	}
}
