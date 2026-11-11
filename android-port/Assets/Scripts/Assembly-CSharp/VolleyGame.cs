using System.Collections.Generic;
using Core;
using UnityEngine;

public class VolleyGame : MonoBehaviour
{
	public Transform PlayerBallStartPosition;

	public Transform EnemyBallStartPosition;

	public Rigidbody2D VolleyBall;

	public int AllowedGroundHits = 1;

	public int PlayerScore;

	public int EnemyScore;

	public int ScoreGoal = 3;

	public List<GameObject> PlayerPoints;

	public List<GameObject> EnemyPoints;

	public int Side;

	public Collider2D Divider;

	private int groundHits;

	private void Start()
	{
		if (VolleyBall != null && Divider != null)
		{
			Collider2D component = VolleyBall.GetComponent<Collider2D>();
			if (component != null)
			{
				Physics2D.IgnoreCollision(component, Divider, true);
			}
		}
	}

	private void OnTriggerEnter2D(Collider2D other)
	{
		if (other != null && VolleyBall != null && other.gameObject == VolleyBall.gameObject)
		{
			Side = 0;
			groundHits = 0;
		}
	}

	private void OnTriggerExit2D(Collider2D other)
	{
		if (other != null && VolleyBall != null && other.gameObject == VolleyBall.gameObject)
		{
			Side = 1;
			groundHits = 0;
		}
	}

	private void OnCollisionEnter2D(Collision2D other)
	{
		if (other == null || VolleyBall == null || other.gameObject != VolleyBall.gameObject)
		{
			return;
		}
		groundHits++;
		if (groundHits <= AllowedGroundHits)
		{
			return;
		}
		if (Side == 1)
		{
			PlayerScore++;
			if (PlayerBallStartPosition != null)
			{
				ResetBall(PlayerBallStartPosition.position);
			}
			if (PlayerPoints != null)
			{
				for (int i = 0; i < PlayerScore && i < PlayerPoints.Count; i++)
				{
					if (PlayerPoints[i] != null)
					{
						PlayerPoints[i].SetActive(true);
					}
				}
			}
		}
		else
		{
			EnemyScore++;
			if (EnemyBallStartPosition != null)
			{
				ResetBall(EnemyBallStartPosition.position);
			}
			if (EnemyPoints != null)
			{
				for (int j = 0; j < EnemyScore && j < EnemyPoints.Count; j++)
				{
					if (EnemyPoints[j] != null)
					{
						EnemyPoints[j].SetActive(true);
					}
				}
			}
		}
		groundHits = 0;
		if (PlayerScore == ScoreGoal)
		{
			AllowedGroundHits = int.MaxValue;
			GolfGoal component = GetComponent<GolfGoal>();
			if (component != null)
			{
				component.Complete(0.2f);
			}
		}
		else if (EnemyScore == ScoreGoal && Level.Instance != null)
		{
			Level.Instance.Fail(true, true, null, 0f, true, "");
		}
	}

	private void ResetBall(Vector3 resetPos)
	{
		if (VolleyBall != null)
		{
			VolleyBall.velocity = Vector2.zero;
			VolleyBall.angularVelocity = 0f;
			VolleyBall.transform.position = resetPos;
		}
	}
}
