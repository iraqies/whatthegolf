using UnityEngine;

public class MovingTarget : MonoBehaviour
{
	public bool isMovingAway;

	public float speed;

	public float minDistance;

	public Transform avoidTarget;

	private Rigidbody2D rigid;

	private bool fadeInSpeed;

	private void Awake()
	{
	}

	private void FixedUpdate()
	{
	}
}
