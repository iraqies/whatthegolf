using System.Collections.Generic;
using Core;
using UnityEngine;

public class FlabbyGolfShooter : GolfBallShooterBase
{
	public Rigidbody PipeTemplate;

	public Rigidbody WinPipe;

	public Rigidbody StartPipe;

	public Vector2 DistanceBetweenPipes = new Vector2(2f, 7f);

	public Vector2 HeightRange = new Vector2(2f, 7f);

	public int NumberOfPipes;

	public float PipeMoveSpeed = 10f;

	public float FlyForce = 10f;

	private List<Rigidbody> currentPipes;

	private bool hasShot;

	private bool completed;

	private void Start()
	{
		currentPipes = new List<Rigidbody>();
		float xPos = base.transform.position.x + Vector3.right.x * 15f;
		for (int i = 0; i < NumberOfPipes; i++)
		{
			if (i != 0)
			{
				xPos += Random.Range(DistanceBetweenPipes.x, DistanceBetweenPipes.y);
			}
			float yOffset = Random.Range(HeightRange.x, HeightRange.y);
			Vector3 spawnPos = new Vector3(xPos, 0f, 0f) + Vector3.up * yOffset;
			if (PipeTemplate != null)
			{
				Rigidbody pipe = Object.Instantiate(PipeTemplate, spawnPos, Quaternion.identity);
				pipe.gameObject.SetActive(true);
				currentPipes.Add(pipe);
			}
		}

		xPos += Random.Range(DistanceBetweenPipes.x, DistanceBetweenPipes.y);
		if (WinPipe != null)
		{
			WinPipe.transform.position = new Vector3(xPos, 0f, 0f);
			currentPipes.Add(WinPipe);
		}

		xPos += Random.Range(DistanceBetweenPipes.x, DistanceBetweenPipes.y);
		if (PipeTemplate != null)
		{
			Vector3 lastSpawnPos = new Vector3(xPos, 0f, 0f) + Vector3.up * 16f;
			Rigidbody endPipe = Object.Instantiate(PipeTemplate, lastSpawnPos, Quaternion.identity);
			endPipe.gameObject.SetActive(true);
			currentPipes.Add(endPipe);
		}

		if (StartPipe != null)
		{
			currentPipes.Add(StartPipe);
		}

		if (Level.HasInstance)
		{
			Level.Instance.OnComplete += delegate
			{
				completed = true;
			};
		}
	}

	public override void OnShoot(Vector3 boost)
	{
		base.OnShoot(boost);
		if (rigid != null)
		{
			rigid.velocity = new Vector3(boost.x * 0.5f * FlyForce, boost.y * FlyForce, boost.z * FlyForce);
		}
		hasShot = true;
	}

	protected override void FixedUpdate()
	{
		base.FixedUpdate();
		if (!hasShot || completed)
			return;

		if (currentPipes != null)
		{
			foreach (Rigidbody pipe in currentPipes)
			{
				if (pipe != null)
				{
					pipe.MovePosition(pipe.position - pipe.transform.right * Time.deltaTime * PipeMoveSpeed);
				}
			}
		}

		if (rigid != null && rigid.position.y <= -9f && Level.HasInstance)
		{
			Level.Instance.Fail(true, true, null, 0f, true, "ID_FAIL_PINBALL");
		}
	}

	private void OnCollisionEnter(Collision other)
	{
		if (other != null && other.gameObject != null && other.gameObject.CompareTag("Default") && Level.HasInstance)
		{
			Level.Instance.Fail(true, true, null, 0f, true, "ID_FAIL_PINBALL");
		}
	}
}
