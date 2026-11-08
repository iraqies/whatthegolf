using System.Collections.Generic;
using Audio;
using Core;
using UnityEngine;

public class SpawnNewManballAfterShot : MonoBehaviour
{
	public List<GameObject> m_ball;

	public ParticleSystem OnDestroySystem;

	private int NumBallsSpawned;

	public float maxWaitTime = 1f;

	public float destroyAfter;

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
			return;

		GolfBallController oldCtrl = null;
		if (ball != null)
		{
			oldCtrl = ball.GetComponentInChildren<GolfBallController>();
			if (oldCtrl != null)
			{
				oldCtrl.StopAiming();
				oldCtrl.enabled = false;
			}
		}

		if (m_ball == null || m_ball.Count == 0) return;
		GameObject prefab = m_ball[Random.Range(0, m_ball.Count)];
		if (prefab == null) return;
		ball = Instantiate(prefab, transform);
		ball.SetActive(true);
		ball.transform.position = transform.position;
		ball.transform.localPosition = Vector3.zero;
		controller = ball.GetComponentInChildren<GolfBallController>();
		if (controller != null)
		{
			controller.OnSpawnController(oldCtrl);
			controller.OnShoot += StartCheck;
		}
		if (OnAppear != null)
			OnAppear.Play(transform.position, 1f, 1f);
		NumBallsSpawned++;
	}

	private void StartCheck(Vector3 boost)
	{
		checkForZeroVel = true;
		if (controller != null)
			controller.OnShoot -= StartCheck;
		shootTime = Time.time;
	}

	private void Update()
	{
		if (!checkForZeroVel || isWon) return;
		if (Time.time - shootTime <= maxWaitTime) return;

		if (ball != null)
		{
			GolfBallController c = ball.GetComponentInChildren<GolfBallController>();
			if (c != null)
			{
				c.StopAiming();
				c.enabled = false;
			}
			doughnuts.Add(ball);
		}

		if (maxAmount != -1 && doughnuts.Count > maxAmount && doughnuts.Count > 0)
		{
			if (doughnuts[0] != null)
				Destroy(doughnuts[0]);
			doughnuts.RemoveAt(0);
		}

		checkForZeroVel = false;
		SpawnNew();
	}
}
