using UnityEngine;

public class HoleInOneShooter : MonoBehaviour
{
	public bool reflect;

	public float speed;

	public BallShooter shooter;

	private Rigidbody2D rigid;

	private void Start()
	{
		rigid = GetComponent<Rigidbody2D>();
		if (shooter != null)
			shooter.OnShootEvent += Shooter_OnShoot;
	}

	private void Shooter_OnShoot(Vector2 dir)
	{
		if (reflect)
			dir = Vector2.Reflect(dir, Vector2.up);
		if (rigid != null)
			rigid.velocity = dir * speed;
	}
}
