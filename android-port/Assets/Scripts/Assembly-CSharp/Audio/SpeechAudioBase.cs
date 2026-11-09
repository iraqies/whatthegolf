using UnityEngine;

namespace Audio
{
	public abstract class SpeechAudioBase : MonoBehaviour
	{
		protected AudioSource m_audioSource;

		protected virtual void Awake()
		{
			m_audioSource = GetComponent<AudioSource>();
		}

		public virtual void UpdateSpeech()
		{
		}

		protected virtual void PlayClip()
		{
		}
	}
}
