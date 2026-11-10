using UnityEngine;

namespace Audio
{
	public class AudioValueLFO : BaseAudioValue
	{
		public enum Signal
		{
			Sine = 0,
			Square = 1
		}

		public bool useAffector;

		public AudioValueMapper Affector;

		public bool isOn = true;

		public float rate;

		public float depth;

		public Signal signal;

		private float m_rate;

		private float m_depth;

		protected override bool Use2D => false;

		private void Update()
		{
			if (isOn)
				SetValue();
		}

		public override string ValueInputName()
		{
			return "LFO";
		}

		protected override void Initialize()
		{
			if (Affector != null)
				Affector.Init();
		}

		protected override void SetValue()
		{
			if (useAffector && Affector != null)
			{
				m_depth = depth * Affector.value;
				m_rate = rate * Affector.value;
			}
			else
			{
				m_depth = depth;
				m_rate = rate;
			}
			value = m_depth * Mathf.Sin(Time.time * m_rate);
			base.SetValue();
		}
	}
}
