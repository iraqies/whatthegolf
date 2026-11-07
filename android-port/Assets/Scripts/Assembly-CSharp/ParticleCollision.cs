using UnityEngine;

public class ParticleCollision : MonoBehaviour
{
	public LayerMask Mask;

	public ParticleSystem ExplosionParticles;

	public float CollisionThreshold;

	public int ParticlesToEmit;

	public Vector3 Offset;

	public bool AddScreenShake;

	private void OnCollisionEnter(Collision other)
	{
	}
}
