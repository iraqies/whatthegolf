using UnityEngine;

namespace Audio
{
	public abstract class SpeechAudioBase : MonoBehaviour
	{
		protected AudioSource m_audioSource;

		protected virtual void Awake()
		{
		}

		public virtual void UpdateSpeech()
		{
		}

		protected virtual void PlayClip()
		{
		}
	}
}
