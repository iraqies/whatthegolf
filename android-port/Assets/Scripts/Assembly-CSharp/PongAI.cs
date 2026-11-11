using System.Collections;
using UnityEngine;

public class PongAI : MonoBehaviour
{
	public BreakoutBall ball;

	private Rigidbody2D ballRb;

	public Rigidbody2D predictionBall;

	public float predictionBallSpeedScale = 2f;

	public float minDistBeforeMove = 0.2f;

	public float maxVel = 10f;

	private Rigidbody2D rigid;

	public float yMin = -4f;

	public float yMax = 4f;

	public float delayBeforePredictionUpdate = 0.1f;

	private Coroutine updatePredictionBall;

	private bool stopped;

	private void Start()
	{
		rigid = GetComponent<Rigidbody2D>();
		if (ball != null)
		{
			ballRb = ball.gameObject.GetComponent<Rigidbody2D>();
			ball.OnTouchBat += UpdatePredictionBall;
		}
	}

	private void UpdatePredictionBall()
	{
		if (updatePredictionBall != null)
		{
			StopCoroutine(updatePredictionBall);
		}
		updatePredictionBall = StartCoroutine(UpdatePredictionBallCo());
	}

	private IEnumerator UpdatePredictionBallCo()
	{
		yield return new WaitForSeconds(delayBeforePredictionUpdate);
		if (ballRb != null && predictionBall != null)
		{
			predictionBall.MovePosition(ballRb.position);
			predictionBall.MoveRotation(ballRb.rotation);
			predictionBall.velocity = ballRb.velocity * predictionBallSpeedScale;
			predictionBall.angularVelocity = ballRb.angularVelocity;
			stopped = false;
		}
	}

	private void FixedUpdate()
	{
		if (rigid == null)
		{
			return;
		}
		Rigidbody2D targetRb = predictionBall != null ? predictionBall : ballRb;
		if (targetRb == null)
		{
			return;
		}
		if (!stopped && predictionBall != null && Mathf.Abs(predictionBall.position.x - rigid.position.x) < 0.5f)
		{
			predictionBall.velocity = Vector2.zero;
			stopped = true;
		}
		float dy = targetRb.position.y - rigid.position.y;
		if (Mathf.Abs(dy) > minDistBeforeMove)
		{
			float step = Mathf.Sign(dy) * Mathf.Min(Mathf.Abs(dy), maxVel * Time.deltaTime);
			float nextY = Mathf.Clamp(rigid.position.y + step, yMin, yMax);
			rigid.MovePosition(new Vector2(rigid.position.x, nextY));
		}
	}

	private void OnDrawGizmosSelected()
	{
	}
}
