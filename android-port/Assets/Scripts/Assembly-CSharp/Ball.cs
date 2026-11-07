using UnityEngine;

public class Ball : MonoBehaviour
{
	public float speed;

	public LayerMask layers;

	public float minSpeed;

	public float maxSpeedMultiplier;

	private Rigidbody2D rigid;

	public bool adjustSpeed;

	private BallShooter shooter;

	private Killable killable;

	private Winable winable;

	private bool isMoving;

	public bool UseMinSpeed;

	private void Start()
	{
	}

	private void Killable_OnKilled()
	{
	}

	private void Winable_OnWon(Vector3 pos)
	{
	}

	private void Shooter_OnShoot(Vector2 dir)
	{
	}

	private void FixedUpdate()
	{
	}
}
