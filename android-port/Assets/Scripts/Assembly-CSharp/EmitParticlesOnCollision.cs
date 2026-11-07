using UnityEngine;

public class EmitParticlesOnCollision : MonoBehaviour
{
	public LayerMask CollisionLayers;

	public ParticleSystem Particles;

	public int ParticlesEmitted;

	private void OnCollisionEnter(Collision other)
	{
	}
}
