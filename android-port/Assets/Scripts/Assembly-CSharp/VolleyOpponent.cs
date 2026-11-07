using UnityEngine;

public class VolleyOpponent : MonoBehaviour
{
	public VolleyGame VolleyGame;

	public float ShootForce;

	public float MoveForce;

	public float ReactionTime;

	public Rigidbody2D Rigidbody;

	private float reactionTimer;

	private Transform currentTarget;

	private Vector2 startPos;

	private void Start()
	{
	}

	private void Update()
	{
	}
}
