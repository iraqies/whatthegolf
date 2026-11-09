using UnityEngine;

namespace Audio
{
	public class SpeechAudioSimple : SpeechAudioByInterval
	{
		public ClipSettingsCollection clips;

		public override void UpdateSpeech()
		{
			if (Time.time >= m_nextSoundTime)
			{
				PlayClip();
			}
		}

		protected override void PlayClip()
		{
			if (m_audioSource == null)
				m_audioSource = GetComponent<AudioSource>();
			if (m_audioSource != null && clips != null)
			{
				m_nextSoundTime = Time.time + Mathf.Max(0.04f, interval.GetResult);
				var info = clips.GetPlayInfo();
				if (info.clip != null)
				{
					m_audioSource.clip = info.clip;
					m_audioSource.volume = info.VolumeResult;
					m_audioSource.pitch = info.PitchResult;
					m_audioSource.Play();
				}
			}
		}
	}
}
