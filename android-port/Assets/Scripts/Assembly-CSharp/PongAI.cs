using System.Collections;
using UnityEngine;

public class PongAI : MonoBehaviour
{
	public BreakoutBall ball;

	private Rigidbody2D ballRb;

	public Rigidbody2D predictionBall;

	public float predictionBallSpeedScale;

	public float minDistBeforeMove;

	public float maxVel;

	private Rigidbody2D rigid;

	public float yMin;

	public float yMax;

	public float delayBeforePredictionUpdate;

	private Coroutine updatePredictionBall;

	private bool stopped;

	private void Start()
	{
	}

	private void UpdatePredictionBall()
	{
	}

	private IEnumerator UpdatePredictionBallCo()
	{
		return null;
	}

	private void FixedUpdate()
	{
	}

	private void OnDrawGizmosSelected()
	{
	}
}
