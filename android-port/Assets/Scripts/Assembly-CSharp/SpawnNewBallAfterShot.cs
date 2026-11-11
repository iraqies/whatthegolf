using System;
using System.Collections.Generic;
using Audio;
using Core;
using UnityEngine;

public class SpawnNewBallAfterShot : MonoBehaviour
{
	public enum SpawnOrder
	{
		Random = 0,
		NextInList = 1
	}

	public List<GameObject> m_ball;

	public ParticleSystem OnDestroySystem;

	[SerializeField]
	private SpawnOrder spawnOrder;

	private int NumBallsSpawned;

	public float maxWaitTime = 1f;

	public int maxAmount = 3;

	private List<GameObject> doughnuts = new List<GameObject>();

	private float shootTime;

	private GameObject ball;

	private GolfBallController controller;

	public ClipSettingsCollection OnAppear;

	public bool isWon;

	public bool destroy;

	private bool checkForZeroVel;

	public void Complete()
	{
		isWon = true;
	}

	private void Start()
	{
		SpawnNew();
	}

	private void SpawnNew()
	{
		if (maxAmount != -1 && NumBallsSpawned >= maxAmount)
		{
			return;
		}
		GolfBallController oldController = null;
		if (ball != null)
		{
			oldController = ball.GetComponent<GolfBallController>();
			if (oldController != null)
			{
				if (oldController.ShootArrow != null)
				{
					oldController.ShootArrow.Hide();
				}
				oldController.enabled = false;
			}
		}
		if (m_ball == null || m_ball.Count == 0)
		{
			return;
		}
		int nextIndex = GetNextIndex();
		ball = UnityEngine.Object.Instantiate(m_ball[nextIndex], base.transform);
		ball.gameObject.SetActive(true);
		ball.transform.position = base.transform.position;
		ball.transform.localPosition = Vector3.zero;
		controller = ball.GetComponent<GolfBallController>();
		if (controller != null)
		{
			controller.OnSpawnController(oldController);
			controller.OnShoot += StartCheck;
			controller.transform.parent = null;
		}
		if (OnAppear != null)
		{
			OnAppear.Play(base.transform.position);
		}
		NumBallsSpawned++;
	}

	private int GetNextIndex()
	{
		switch (spawnOrder)
		{
		case SpawnOrder.Random:
			return UnityEngine.Random.Range(0, m_ball.Count);
		case SpawnOrder.NextInList:
			return NumBallsSpawned % m_ball.Count;
		default:
			throw new ArgumentOutOfRangeException();
		}
	}

	private void StartCheck(Vector3 boost)
	{
		checkForZeroVel = true;
		if (controller != null)
		{
			controller.OnShoot -= StartCheck;
		}
		shootTime = Time.time;
	}

	private void Update()
	{
		if (!checkForZeroVel || isWon || !(Time.time - shootTime > maxWaitTime))
		{
			return;
		}
		if (ball != null)
		{
			GolfBallController component = ball.GetComponent<GolfBallController>();
			if (component != null)
			{
				if (component.ShootArrow != null)
				{
					component.ShootArrow.Hide();
				}
				component.enabled = false;
			}
		}
		if (doughnuts != null)
		{
			doughnuts.Add(ball);
			if (doughnuts.Count > maxAmount && maxAmount != -1)
			{
				UnityEngine.Object.Destroy(doughnuts[0]);
				doughnuts.RemoveAt(0);
			}
		}
		checkForZeroVel = false;
		SpawnNew();
	}
}
