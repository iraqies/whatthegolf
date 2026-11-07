using System.Collections.Generic;
using Audio;
using Core;
using UnityEngine;

public class SpawnNewManballAfterShot : MonoBehaviour
{
	public List<GameObject> m_ball;

	public ParticleSystem OnDestroySystem;

	private int NumBallsSpawned;

	public float maxWaitTime;

	public float destroyAfter;

	public int maxAmount;

	private List<GameObject> doughnuts;

	private float shootTime;

	private GameObject ball;

	private GolfBallController controller;

	public ClipSettingsCollection OnAppear;

	public bool isWon;

	public bool destroy;

	private bool checkForZeroVel;

	public void Complete()
	{
	}

	private void Start()
	{
	}

	private void SpawnNew()
	{
	}

	private void StartCheck(Vector3 boost)
	{
	}

	private void Update()
	{
	}
}
