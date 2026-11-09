using UnityEngine;

namespace Audio
{
	public class SoundFromAnimation : MonoBehaviour
	{
		public RandomAudioClips clips;

		public AudioSource audioSource;

		public bool startRandomPosition;

		public void Play()
		{
			if (clips == null) return;
			if (audioSource != null)
			{
				clips.PlayRandomClipOnSource(audioSource);
				if (startRandomPosition && audioSource.clip != null)
					audioSource.time = Random.Range(0f, audioSource.clip.length);
			}
			else
			{
				clips.PlayRandomClip(transform);
			}
		}

		public void Stop()
		{
			if (audioSource != null && audioSource.isPlaying)
				audioSource.Stop();
		}
	}
}
