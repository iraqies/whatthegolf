using System;
using UnityEngine;

namespace Audio
{
	public class AudioValueModulation : BaseAudioValue
	{
		public AnimationCurve Curve;

		public float phaseDuration;

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
		}

		public override string ValueInputName()
		{
			return null;
		}

		public void TriggerModulation()
		{
		}

		private void StartModulation()
		{
		}
	}
}
