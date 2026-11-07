using System.Collections.Generic;
using UnityEngine;

public class VolleyGame : MonoBehaviour
{
	public Transform PlayerBallStartPosition;

	public Transform EnemyBallStartPosition;

	public Rigidbody2D VolleyBall;

	public int AllowedGroundHits;

	public int PlayerScore;

	public int EnemyScore;

	public int ScoreGoal;

	public List<GameObject> PlayerPoints;

	public List<GameObject> EnemyPoints;

	public int Side;

	public Collider2D Divider;

	private int groundHits;

	private void Start()
	{
	}

	private void OnTriggerEnter2D(Collider2D other)
	{
	}

	private void OnTriggerExit2D(Collider2D other)
	{
	}

	private void OnCollisionEnter2D(Collision2D other)
	{
	}

	private void ResetBall(Vector3 resetPos)
	{
	}
}
