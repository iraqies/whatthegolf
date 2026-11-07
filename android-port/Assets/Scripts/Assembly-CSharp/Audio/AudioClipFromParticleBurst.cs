using UnityEngine;

namespace Audio
{
	public class AudioClipFromParticleBurst : MonoBehaviour
	{
		public ParticleSystem particle;

		public AudioSource source;

		public RandomAudioClips audioClips;

		public float cooldown;

		private float nextSoundTime;

		private void Update()
		{
		}

		private void Play()
		{
		}
	}
}
