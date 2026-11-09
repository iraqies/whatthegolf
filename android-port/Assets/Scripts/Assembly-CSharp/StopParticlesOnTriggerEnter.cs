using UnityEngine;

public class StopParticlesOnTriggerEnter : MonoBehaviour
{
	public ParticleSystem particles;

	private void OnTriggerEnter(Collider other)
	{
		if (particles != null)
			particles.Stop();
	}
}
