using UnityEngine;

public class GravityAfterShot : MonoBehaviour
{
	public Vector2 gravityDir;

	public AudioClip sfxHit;

	public float gravity;

	private bool useGravity;

	public BallShooter shooter;

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

	private void OnCollisionEnter2D(Collision2D collision)
	{
	}
}
