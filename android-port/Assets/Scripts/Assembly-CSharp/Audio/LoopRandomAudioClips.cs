using UnityEngine;

namespace Audio
{
	public class LoopRandomAudioClips : MonoBehaviour
	{
		public float minInterval = 0.5f;

		public float maxInterval = 2f;

		public RandomAudioClips clips;

		public bool startOnAwake;

		public bool changeClipOnNewPlay;

		private AudioSource _audioSource;

		private bool running;

		private float nextEventTime;

		private bool isSourcePlaying;

		public void StartPlaying()
		{
			running = true;
			nextEventTime = Time.time;
		}

		public void StopPlaying()
		{
			running = false;
			if (_audioSource != null && _audioSource.isPlaying)
				_audioSource.Stop();
		}

		private void Awake()
		{
			_audioSource = GetComponent<AudioSource>();
			if (startOnAwake)
				StartPlaying();
		}

		private void Update()
		{
			if (!running || clips == null)
				return;
			if (Time.time >= nextEventTime)
			{
				if (_audioSource != null)
					clips.PlayRandomClipOnSource(_audioSource);
				else
					clips.PlayRandomClip(transform);
				float dur = (_audioSource != null && _audioSource.clip != null) ? _audioSource.clip.length : 0.2f;
				nextEventTime = Time.time + dur + Random.Range(minInterval, Mathf.Max(minInterval, maxInterval));
			}
		}
	}
}
