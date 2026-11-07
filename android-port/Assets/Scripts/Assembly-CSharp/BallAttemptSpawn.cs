using System.Collections;
using UnityEngine;

public class BallAttemptSpawn : MonoBehaviour
{
	public Rigidbody ballGameObject;

	public Vector3 spawnOffset;

	public Vector3 spawnForce;

	public float delayBeforeSpawn;

	private Rigidbody nextBall;

	private Coroutine spawnNewBallCoroutine;

	public void SpawnNewBall()
	{
	}

	private IEnumerator SpawningBall()
	{
		return null;
	}
}
