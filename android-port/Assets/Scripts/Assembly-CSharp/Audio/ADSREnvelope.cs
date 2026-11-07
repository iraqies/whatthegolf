using System;

namespace Audio
{
	[Serializable]
	public class ADSREnvelope
	{
		public enum State
		{
			Idle = 0,
			Attack = 1,
			Decay = 2,
			Sustain = 3,
			Release = 4
		}

		public float attackTime;

		public float decayTime;

		public float sustainLevel;

		public float sustainTime;

		public float releaseTime;

		private float _attackIncrement;

		private float _decayIncrement;

		private uint _decaySamples;

		private uint _sustainSamples;

		private float _releaseIncrement;

		private float _outputLevel;

		private int _samplesUntillTrigger;

		public State EnvelopeState { get; private set; }

		public float Duration => 0f;

		public ADSREnvelope(float attackTime, float decayTime, float sustainLevel, float sustainTime, float releaseTime)
		{
		}

		public void SetSustainTime(float sustainTime)
		{
		}

		public void Trigger(int sampleRate, bool resetVolume = true)
		{
		}

		public float GetLevel()
		{
			return 0f;
		}

		public void SetLevel(bool held = false)
		{
		}
	}
}
