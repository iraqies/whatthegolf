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

	public float maxWaitTime;

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

	private int GetNextIndex()
	{
		return 0;
	}

	private void StartCheck(Vector3 boost)
	{
	}

	private void Update()
	{
	}
}
