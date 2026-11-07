using UnityEngine;

public class ParticlesOnImpact : MonoBehaviour
{
	public ParticleSystem Particles;

	public float ImpactVelocityNeeded;

	public bool useTrigger;

	public string otherTriggerTag;

	public string tagForCollision;

	public bool moveToCollisionPoint;

	public bool ignoreY;

	private void OnCollisionEnter(Collision collision)
	{
	}

	private void OnTriggerEnter(Collider other)
	{
	}
}
