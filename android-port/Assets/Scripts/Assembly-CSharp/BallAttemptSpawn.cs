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
		if (spawnNewBallCoroutine == null)
		{
			spawnNewBallCoroutine = StartCoroutine(SpawningBall());
		}
	}

	private IEnumerator SpawningBall()
	{
		yield return new WaitForSeconds(delayBeforeSpawn);
		if (ballGameObject != null)
		{
			nextBall = Object.Instantiate(ballGameObject, base.transform.position + spawnOffset, Quaternion.identity);
			if (nextBall != null)
			{
				nextBall.AddForce(spawnForce, ForceMode.VelocityChange);
			}
		}
		spawnNewBallCoroutine = null;
	}
}
