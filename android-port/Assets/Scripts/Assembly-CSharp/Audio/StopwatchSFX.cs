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
		private int setDoubleTempoAtTime = 3;

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
			metronome = GetComponent<Metronome>();
			if (metronome != null)
			{
				metronome.Ticked += Metronome_Ticked;
			}
			if (tickSFX != null)
			{
				m_next = tickSFX.GetPlayInfo();
			}
			m_audioSources = new AudioSource[2];
			for (int i = 0; i < m_audioSources.Length; i++)
			{
				if (audioSourcePrefab != null)
				{
					m_audioSources[i] = Instantiate(audioSourcePrefab);
					m_audioSources[i].gameObject.name = "Stopwatch_" + i;
					m_audioSources[i].transform.parent = transform;
				}
			}
		}

		public void PlayCountdown()
		{
			if (countdownSFX == null || AudioManager.Instance == null || AudioManager.Instance.ui == null)
			{
				return;
			}
			PlayClipInfo info = countdownSFX.GetPlayInfo();
			AudioManager.Instance.ui.PlaySimple(info.clip, info.volume, info.pitch, false, 0f, Vector3.zero);
		}

		public void PlayStartSFX()
		{
			if (raceStartSFX == null || AudioManager.Instance == null || AudioManager.Instance.ui == null)
			{
				return;
			}
			PlayClipInfo info = raceStartSFX.GetPlayInfo();
			AudioManager.Instance.ui.PlaySimple(info.clip, info.volume, info.pitch, false, 0f, Vector3.zero);
		}

		private void Metronome_Ticked(double obj)
		{
			if (m_audioSources == null || m_audioSources.Length == 0)
			{
				return;
			}
			AudioSource src = m_audioSources[index];
			if (src != null)
			{
				src.clip = m_next.clip;
				src.PlayScheduled(obj);
			}
			index = (index + 1) % m_audioSources.Length;
			if (tickSFX != null)
			{
				m_next = tickSFX.GetPlayInfo();
			}
		}

		public void StartStopwatch(float time)
		{
			timer = time;
			if (metronome != null)
			{
				metronome.StartMetronome();
			}
		}

		public void Stop()
		{
			if (metronome != null)
			{
				metronome.StopMetronome();
			}
		}

		private void Update()
		{
			if (metronome == null || !metronome.Running)
			{
				return;
			}
			timer -= Time.unscaledDeltaTime;
			if (!m_isDoubleTime && timer < setDoubleTempoAtTime + 0.1f)
			{
				metronome.SetSubdivisions(4);
				m_isDoubleTime = true;
			}
			if (playSoundOnStopwatchEnd && timer < 0.2f && endSFX != null)
			{
				m_next = endSFX.GetPlayInfo();
			}
			if (timer <= 0f)
			{
				metronome.StopMetronome();
			}
		}
	}
}
