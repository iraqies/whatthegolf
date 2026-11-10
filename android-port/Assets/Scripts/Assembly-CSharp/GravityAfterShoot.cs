using UnityEngine;

public class GravityAfterShoot : MonoBehaviour
{
	public float gravity;

	public Vector3 gravityDirection = Vector2.down;

	public float drag = 0.15f;

	private bool useGravity;

	private BallShooter shooter;

	private Ball ball;

	private Rigidbody2D rigid;

	private void Start()
	{
		shooter = GetComponent<BallShooter>();
		ball = GetComponent<Ball>();
		rigid = GetComponent<Rigidbody2D>();
		if (shooter != null)
			shooter.OnShootEvent += Shooter_OnShoot;
	}

	private void FixedUpdate()
	{
		if (useGravity && rigid != null)
		{
			Vector2 force = new Vector2(gravityDirection.x, gravityDirection.y) * Time.deltaTime * gravity;
			rigid.AddForce(force, ForceMode2D.Force);
		}
	}

	private void Shooter_OnShoot(Vector2 obj)
	{
		useGravity = true;
		if (ball != null)
			ball.UseMinSpeed = false;
		if (rigid != null)
			rigid.drag = drag;
	}

	public void Reset()
	{
		useGravity = false;
	}
}
