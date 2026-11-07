using UnityEngine;

namespace Audio
{
	public class LoopRandomAudioClips : MonoBehaviour
	{
		public float minInterval;

		public float maxInterval;

		public RandomAudioClips clips;

		public bool startOnAwake;

		public bool changeClipOnNewPlay;

		private AudioSource _audioSource;

		private bool running;

		private float nextEventTime;

		private bool isSourcePlaying;

		public void StartPlaying()
		{
		}

		public void StopPlaying()
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
