using UnityEngine;

namespace Audio
{
	public class PlayAudioClipsByFrequency : MonoBehaviour
	{
		[SerializeField]
		private ClipSettingsCollection clips;

		[SerializeField]
		private AudioSource customAudioSource;

		[SerializeField]
		private float startFrequency;

		[SerializeField]
		private bool startOnAwake;

		private float nextPlayTime;

		private float volumeModifier;

		private float pitchModifier;

		public float Frequency { get; private set; }

		public float Delay { get; private set; }

		public bool IsPlaying { get; private set; }

		public void Play()
		{
		}

		public void Stop()
		{
		}

		public void SetModifiers(float vol, float pitch)
		{
		}

		public void SetFrequency(float freq)
		{
		}

		private void Awake()
		{
		}

		private void Update()
		{
		}
	}
}
