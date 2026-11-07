using UnityEngine;

public class EffectsInOne : MonoBehaviour
{
	public BallCollider ballCollider;

	public ParticleSystem collisionparticles;

	public float amountOfParticles;

	private Collider2D lastHit;

	private float nextSameParticles;

	public void FindBall()
	{
	}

	private void BallCollider_OnCollisionEnter(Vector3 pos, Vector3 normal, float impactMagnitude, Collider2D other)
	{
	}
}
