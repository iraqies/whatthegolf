using UnityEngine;

public class AudioWhileParticleEmits : MonoBehaviour
{
	public ParticleSystem particles;

	public float maxVol = 1f;

	public float minVol;

	public float smoothTime = 0.15f;

	public AudioSource source;
	private float _vel;

	private void Start()
	{
		if (source == null)
			source = GetComponent<AudioSource>();
		if (particles == null)
			particles = GetComponent<ParticleSystem>();
	}

	private void Update()
	{
		if (source == null || particles == null)
			return;
		float target = (particles.isEmitting && particles.particleCount > 0) ? (maxVol > 0f ? maxVol : 1f) : minVol;
		source.volume = Mathf.SmoothDamp(source.volume, target, ref _vel, Mathf.Max(0.02f, smoothTime));
		if (source.volume > 0.01f && !source.isPlaying)
			source.Play();
		else if (source.volume <= 0.01f && source.isPlaying && target <= 0.01f)
			source.Stop();
	}
}
