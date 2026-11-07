using System.Collections;
using System.Collections.Generic;
using Core;
using UnityEngine;

public class ChallengeMultiBallSpawner : MonoBehaviour
{
	public GolfBallController controller;

	private GolfBallController _currentController;

	public int maxSpawn;

	private List<GolfBallController> _spawnedBalls;

	private void Awake()
	{
	}

	private void ControllerOnShoot(Vector3 obj)
	{
	}

	private IEnumerator WaitAndSpawn()
	{
		return null;
	}

	private GolfBallController InstantiateGolfBall()
	{
		return null;
	}
}
