using UnityEngine;

namespace Audio
{
	public class AudioClipFromParticleBurst : MonoBehaviour
	{
		public ParticleSystem particle;

		public AudioSource source;

		public RandomAudioClips audioClips;

		public float cooldown = 0.05f;

		private float nextSoundTime;
		private int _lastCount;

		private void Update()
		{
			if (particle == null) return;
			int cur = particle.particleCount;
			if (cur > _lastCount && Time.time >= nextSoundTime)
			{
				Play();
				nextSoundTime = Time.time + cooldown;
			}
			_lastCount = cur;
		}

		private void Play()
		{
			if (audioClips != null)
			{
				if (source != null)
					audioClips.PlayRandomClipOnSource(source);
				else
					audioClips.PlayRandomClip(transform);
			}
		}
	}
}
