using UnityEngine;

public class ExplodeOnCollision : MonoBehaviour
{
	public ExplosionBarrel2D Explosion;

	public ParticleSystem explosionParticlesPrefab;

	private Rigidbody _rigidbody;

	public float explosionForce;

	private void Start()
	{
	}

	private void OnCollisionEnter2D(Collision2D collision)
	{
	}

	private void OnCollisionEnter(Collision other)
	{
	}
}
