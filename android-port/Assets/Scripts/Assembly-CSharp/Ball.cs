using UnityEngine;

public class Ball : MonoBehaviour
{
	public float speed = 1f;

	public LayerMask layers;

	public float minSpeed = 5f;

	public float maxSpeedMultiplier = 2f;

	private Rigidbody2D rigid;

	public bool adjustSpeed = true;

	private BallShooter shooter;

	private Killable killable;

	private Winable winable;

	private bool isMoving;

	public bool UseMinSpeed;

	private void Start()
	{
		rigid = GetComponent<Rigidbody2D>();
		shooter = GetComponent<BallShooter>();
		killable = GetComponent<Killable>();
		winable = GetComponent<Winable>();
		if (rigid != null)
		{
			rigid.sleepMode = RigidbodySleepMode2D.NeverSleep;
		}
		if (shooter != null)
		{
			shooter.OnShoot += Shooter_OnShoot;
		}
		if (killable != null)
		{
			killable.OnKilled += Killable_OnKilled;
		}
		if (winable != null)
		{
			winable.OnWon += Winable_OnWon;
		}
	}

	private void Killable_OnKilled()
	{
		isMoving = false;
	}

	private void Winable_OnWon(Vector3 pos)
	{
		isMoving = false;
	}

	private void Shooter_OnShoot(Vector2 dir)
	{
		isMoving = true;
		if (rigid != null)
		{
			rigid.velocity = dir * speed;
		}
	}

	private void FixedUpdate()
	{
		if (rigid == null)
		{
			return;
		}
		if (!isMoving)
		{
			rigid.velocity = Vector2.zero;
			return;
		}
		if (!adjustSpeed)
		{
			return;
		}
		if (UseMinSpeed && rigid.velocity.magnitude < minSpeed)
		{
			Vector2 dir = rigid.velocity.normalized;
			rigid.AddForce(dir * (minSpeed - rigid.velocity.magnitude), ForceMode2D.Impulse);
		}
		float maxSpeed = minSpeed * maxSpeedMultiplier;
		if (rigid.velocity.magnitude > maxSpeed)
		{
			Vector2 dir2 = rigid.velocity.normalized;
			rigid.AddForce(dir2 * (maxSpeed - rigid.velocity.magnitude), ForceMode2D.Impulse);
		}
	}
}
