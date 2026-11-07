using UnityEngine;

public class MoveBetween : MonoBehaviour
{
	public bool startMoving;

	public bool stopOnShoot;

	public bool startOnShoot;

	public Transform A;

	public Transform B;

	public float offsetTimer;

	public float Speed;

	public float startPos;

	private BallShooter shooter;

	private Rigidbody2D rigid;

	private float adjustedSpeed;

	private float timer;

	private bool isMoving;

	private void Awake()
	{
	}

	private void Shooter_OnShoot(Vector2 dir)
	{
	}

	private void FixedUpdate()
	{
	}
}
