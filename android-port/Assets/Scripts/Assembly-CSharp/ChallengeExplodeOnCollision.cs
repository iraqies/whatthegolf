using UnityEngine;

public class ChallengeExplodeOnCollision : MonoBehaviour
{
	public ParticleSystem explosionParticlesPrefab;

	private ParticleSystem _explosion;

	private Rigidbody _rigidbody;

	public float explosionForce;

	public bool explodeFootballPlayers;

	public LayerMask checkLayer;

	public float explosionRadius;

	private void Start()
	{
	}

	private void OnCollisionEnter(Collision other)
	{
	}
}
