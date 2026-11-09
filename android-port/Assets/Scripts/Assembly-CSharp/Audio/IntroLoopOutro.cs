using System;
using System.Collections;
using UnityEngine;

namespace Audio
{
	public class IntroLoopOutro : MonoBehaviour
	{
		[Serializable]
		internal class ILO_Envelope
		{
			public bool on;

			public float attackTime;

			public float decayTime;

			public float sustainLevel;

			public float sustainTime;

			public float releaseTime;

			public AudioEnvelopeSettings reference;
		}

		public AudioClip intro;

		public AudioClip loop;

		public AudioClip outro;

		public bool canAlwaysRestart;

		[SerializeField]
		private ILO_Envelope introEnvelope;

		[SerializeField]
		private ILO_Envelope loopEnvelope;

		[SerializeField]
		private ILO_Envelope outroEnvelope;

		private double introLength;

		private AudioSource origSource;

		private AudioSource[] m_src;

		private bool ending;

		public bool Running { get; protected set; }

		public AudioSource OrigSource => origSource;

		private void Awake()
		{
			origSource = GetComponent<AudioSource>();
			CreateAudioSources();
		}

		private void Update()
		{
		}

		public void StartLoop()
		{
			if (Running && !canAlwaysRestart)
				return;
			CreateAudioSources();
			Running = true;
			ending = false;
			double dsp = AudioSettings.dspTime + 0.02;
			double loopStart = dsp;
			if (intro != null && m_src != null && m_src.Length > 0 && m_src[0] != null)
			{
				m_src[0].clip = intro;
				m_src[0].loop = false;
				m_src[0].PlayScheduled(dsp);
				loopStart += ReturnClipLength(intro);
			}
			if (loop != null && m_src != null && m_src.Length > 1 && m_src[1] != null)
			{
				m_src[1].clip = loop;
				m_src[1].loop = true;
				m_src[1].PlayScheduled(loopStart);
			}
		}

		public void EndLoop()
		{
			if (!Running || ending)
				return;
			ending = true;
			Running = false;
			if (m_src != null)
			{
				if (m_src.Length > 0 && m_src[0] != null) m_src[0].Stop();
				if (m_src.Length > 1 && m_src[1] != null) m_src[1].Stop();
				if (outro != null && m_src.Length > 2 && m_src[2] != null)
				{
					m_src[2].clip = outro;
					m_src[2].loop = false;
					m_src[2].Play();
				}
			}
		}

		public void StopAll()
		{
			Running = false;
			ending = false;
			if (m_src == null) return;
			for (int i = 0; i < m_src.Length; i++)
				if (m_src[i] != null) m_src[i].Stop();
		}

		private IEnumerator SetRunningMode(bool status, float time)
		{
			yield return new WaitForSeconds(time);
			Running = status;
		}

		private void SetAudioProperties(AudioSource src)
		{
			if (src == null || origSource == null) return;
			src.volume = origSource.volume;
			src.pitch = origSource.pitch;
			src.spatialBlend = origSource.spatialBlend;
			src.outputAudioMixerGroup = origSource.outputAudioMixerGroup;
			src.playOnAwake = false;
		}

		private double ReturnClipLength(AudioClip clip)
		{
			if (clip == null || clip.frequency <= 0) return 0.0;
			return (double)clip.samples / clip.frequency;
		}

		private void CreateAudioSources()
		{
			if (m_src != null && m_src.Length == 3 && m_src[0] != null)
				return;
			if (origSource == null)
				origSource = GetComponent<AudioSource>() ?? gameObject.AddComponent<AudioSource>();
			m_src = new AudioSource[3];
			m_src[0] = origSource;
			m_src[1] = gameObject.AddComponent<AudioSource>();
			m_src[2] = gameObject.AddComponent<AudioSource>();
			for (int i = 0; i < 3; i++)
				SetAudioProperties(m_src[i]);
		}

		private void SetEnvelope(AudioEnvelopeSettings settings, ILO_Envelope e)
		{
		}
	}
}
