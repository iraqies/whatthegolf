using UnityEngine;

public class PlayParticles : MonoBehaviour
{
	private ParticleSystem particles;

	private void Start()
	{
		particles = GetComponent<ParticleSystem>();
	}

	public void Play()
	{
		if (particles == null)
			particles = GetComponent<ParticleSystem>();
		if (particles != null)
			particles.Play(true);
	}
}
