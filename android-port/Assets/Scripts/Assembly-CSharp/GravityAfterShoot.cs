using UnityEngine;

public class GravityAfterShoot : MonoBehaviour
{
	public float gravity;

	public Vector3 gravityDirection;

	public float drag;

	private bool useGravity;

	private BallShooter shooter;

	private Ball ball;

	private Rigidbody2D rigid;

	private void Start()
	{
	}

	private void FixedUpdate()
	{
	}

	private void Shooter_OnShoot(Vector2 obj)
	{
	}

	public void Reset()
	{
	}
}
