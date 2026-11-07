using System.Collections.Generic;
using UnityEngine;

public class BossPipeObstacleSpawner : MonoBehaviour
{
	public List<GameObject> Obstacles;

	public Vector2 TimerIntervalRange;

	public Vector2 PipeAngleRange;

	public BossStage Stage;

	public Rigidbody PipeRigid;

	public Transform Boss;

	public float PipeMoveSpeed;

	public Transform ItemSpawnPosition;

	public float StartDelay;

	public float SpawnDistance;

	private float timer;

	private float nextAngle;

	private Vector3 lastSpawnPos;

	private void Awake()
	{
	}

	private void Update()
	{
	}

	private void FixedUpdate()
	{
	}

	private void SetupNext()
	{
	}
}
