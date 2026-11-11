using System.Collections.Generic;
using UnityEngine;

public class BossPipeObstacleSpawner : MonoBehaviour
{
	public List<GameObject> Obstacles;

	public Vector2 TimerIntervalRange;

	public Vector2 PipeAngleRange = new Vector2(-20f, 20f);

	public BossStage Stage;

	public Rigidbody PipeRigid;

	public Transform Boss;

	public float PipeMoveSpeed = 1f;

	public Transform ItemSpawnPosition;

	public float StartDelay = 1.5f;

	public float SpawnDistance = 10f;

	private float timer;

	private float nextAngle;

	private Vector3 lastSpawnPos;

	private void Awake()
	{
		if (Obstacles.Count == 0)
		{
			base.enabled = false;
			return;
		}
		Stage.OnChallengeBegin += delegate
		{
			base.enabled = true;
		};
		Stage.OnChallengeEnd += delegate
		{
			base.enabled = false;
		};
		base.enabled = false;
		SetupNext();
	}

	private void Update()
	{
		if (StartDelay > 0f)
		{
			StartDelay -= Time.deltaTime;
			return;
		}
		timer -= Time.deltaTime;
		if (Vector3.Distance(Boss.transform.position, lastSpawnPos) > SpawnDistance && Obstacles.Count >= 1)
		{
			int index = Random.Range(0, Obstacles.Count);
			Object.Instantiate(Obstacles[index], ItemSpawnPosition.position, ItemSpawnPosition.rotation);
			SetupNext();
		}
	}

	private void FixedUpdate()
	{
		Quaternion to = Boss.rotation * Quaternion.Euler(0f, nextAngle, 0f);
		PipeRigid.MoveRotation(Quaternion.RotateTowards(PipeRigid.rotation, to, Time.deltaTime * PipeMoveSpeed));
	}

	private void SetupNext()
	{
		lastSpawnPos = Boss.transform.position;
		timer = Random.Range(TimerIntervalRange.x, TimerIntervalRange.y);
		nextAngle = Random.Range(PipeAngleRange.x, PipeAngleRange.y);
	}
}
