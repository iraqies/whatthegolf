using System.Collections;
using UnityEngine;

public class Effects : MonoBehaviour
{
	public BallCollider ballCollider;

	public ParticleSystem collisionparticles;

	public float amountOfParticles;

	private Collider2D lastHit;

	private float nextSameParticles;

	private IEnumerator Start()
	{
		return null;
	}

	private void Instance_OnNewBall(Transmogrif.BALLSHAPES obj)
	{
	}

	private void BallCollider_OnCollisionEnter(Vector3 pos, Vector3 normal, float impactMagnitude, Collider2D other)
	{
	}
}
