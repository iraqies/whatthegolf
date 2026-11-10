using System;
using UnityEngine;

namespace Audio
{
	public class AudioValueModulation : BaseAudioValue
	{
		public AnimationCurve Curve;

		public float phaseDuration = 1f;

		public bool maxToMin;

		public bool canSelfTrigger;

		public float cooldownMin;

		public float cooldownMax;

		public Action OnModulationComplete;

		private bool m_modulating;

		private float m_nextModulation;

		protected override bool Use2D => false;

		private void Update()
		{
			if (canSelfTrigger && Time.time > m_nextModulation)
				StartModulation();
		}

		public override string ValueInputName()
		{
			return "Modulation";
		}

		public void TriggerModulation()
		{
			StartModulation();
		}

		private void StartModulation()
		{
			m_nextModulation = Time.time + UnityEngine.Random.Range(cooldownMin, cooldownMax);
			m_modulating = true;
			float from = maxToMin ? 1f : 0f;
			float to = maxToMin ? 0f : 1f;
			StartCoroutine(pTween.To(phaseDuration, from, to, t =>
			{
				if (Curve != null)
					value = Curve.Evaluate(t);
				SetValue();
			}).Then(() =>
			{
				m_modulating = false;
				OnModulationComplete?.Invoke();
			}));
		}
	}
}
