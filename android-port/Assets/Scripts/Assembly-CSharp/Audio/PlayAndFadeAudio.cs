using UnityEngine;

namespace Audio
{
	public class PlayAndFadeAudio : MonoBehaviour
	{
		[SerializeField]
		private ClipSettingsCollection Sound;

		[SerializeField]
		private bool loop;

		[SerializeField]
		private float fadeIn;

		[SerializeField]
		private float fadeOut;

		private AudioSource m_audioSource;

		private bool m_isPlaying;

		public void Play()
		{
		}

		private void OnDestroy()
		{
		}
	}
}
