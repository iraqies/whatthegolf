using Audio;
using UnityEngine;

public class AmongUsPlaySoundWithParticle : MonoBehaviour
{
	public ClipSettingsCollection clipCollection;

	public Transform position;

	private ParticleSystem particle;

	private bool played;

	private void Start()
	{
		if (position == null)
		{
			position = base.transform;
		}
		particle = GetComponent<ParticleSystem>();
	}

	private void DefaultSetPos()
	{
		if (position == null)
		{
			position = base.transform;
		}
	}

	private void Update()
	{
		if (particle != null && particle.IsAlive() && particle.isStopped && !played)
		{
			played = true;
			Play();
		}
	}

	public void Play()
	{
		if (position == null)
		{
			position = base.transform;
		}
		if (clipCollection != null)
		{
			clipCollection.Play(position.position);
		}
	}
}
