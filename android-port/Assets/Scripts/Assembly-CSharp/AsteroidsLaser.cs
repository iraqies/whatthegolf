using UnityEngine;

public class AsteroidsLaser : MonoBehaviour
{
	public float LaserSpeed;

	public float Lifetime;

	public Animator anim;

	private bool deathStarted;

	private void Start()
	{
		Rigidbody2D component = GetComponent<Rigidbody2D>();
		if (component != null)
		{
			component.velocity = base.transform.right * LaserSpeed;
		}
	}

	private void Update()
	{
		Lifetime -= Time.deltaTime;
		if (!deathStarted && Lifetime < 0.1f)
		{
			if (anim != null)
			{
				anim.SetTrigger("Die");
			}
			deathStarted = true;
		}
		if (Lifetime < 0f)
		{
			Object.Destroy(base.gameObject);
		}
	}

	private void OnCollisionEnter2D(Collision2D collision)
	{
		if (collision != null && collision.collider != null)
		{
			Asteroid component = collision.collider.GetComponent<Asteroid>();
			if (component != null)
			{
				component.hit = true;
			}
			Object.Destroy(base.gameObject);
		}
	}
}
