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

		public AudioSource OrigSource => null;

		private void Awake()
		{
		}

		private void Update()
		{
		}

		public void StartLoop()
		{
		}

		public void EndLoop()
		{
		}

		public void StopAll()
		{
		}

		private IEnumerator SetRunningMode(bool status, float time)
		{
			return null;
		}

		private void SetAudioProperties(AudioSource src)
		{
		}

		private double ReturnClipLength(AudioClip clip)
		{
			return 0.0;
		}

		private void CreateAudioSources()
		{
		}

		private void SetEnvelope(AudioEnvelopeSettings settings, ILO_Envelope e)
		{
		}
	}
}
