using UnityEngine;

namespace Audio
{
	public class StopwatchSFX : MonoBehaviour
	{
		[SerializeField]
		private AudioClipSettings countdownSFX;

		[SerializeField]
		private AudioClipSettings raceStartSFX;

		[SerializeField]
		private ClipSettingsCollection tickSFX;

		[SerializeField]
		private AudioSource audioSourcePrefab;

		[SerializeField]
		private int setDoubleTempoAtTime;

		[SerializeField]
		private bool playSoundOnStopwatchEnd;

		[SerializeField]
		private AudioClipSettings endSFX;

		private PlayClipInfo m_next;

		private AudioSource[] m_audioSources;

		private Metronome metronome;

		private int index;

		private float timer;

		private bool m_isDoubleTime;

		private void Awake()
		{
		}

		public void PlayCountdown()
		{
		}

		public void PlayStartSFX()
		{
		}

		private void Metronome_Ticked(double obj)
		{
		}

		public void StartStopwatch(float time)
		{
		}

		public void Stop()
		{
		}

		private void Update()
		{
		}
	}
}
