using UnityEngine;

public class ParticlesOnHit : MonoBehaviour
{
	[SerializeField]
	private string m_acceptedTag;

	[SerializeField]
	private ParticleSystem m_hitParticles;

	private void OnCollisionEnter(Collision collision)
	{
	}
}
