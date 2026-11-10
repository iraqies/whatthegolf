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
		rigid = GetComponent<Rigidbody2D>();
		if (shooter != null)
			shooter.OnShootEvent += Shooter_OnShoot;
	}

	private void FixedUpdate()
	{
		if (useGravity && rigid != null)
		{
			rigid.AddForce(gravityDir * Time.deltaTime * gravity, ForceMode2D.Force);
		}
	}

	private void Shooter_OnShoot(Vector2 obj)
	{
		useGravity = true;
	}

	private void OnCollisionEnter2D(Collision2D collision)
	{
		if (collision != null && collision.relativeVelocity.magnitude > 2f && sfxHit != null)
		{
			if (AudioManager.Instance != null && AudioManager.Instance.sfx != null)
				AudioManager.Instance.sfx.Play(sfxHit, null, 0f, false);
		}
	}
}
