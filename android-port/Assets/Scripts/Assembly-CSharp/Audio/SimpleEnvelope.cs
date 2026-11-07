using System.Collections;
using UnityEngine;

namespace Audio
{
	public class SimpleEnvelope : BaseAudioValue
	{
		[SerializeField]
		public float attackTime;

		[SerializeField]
		public float decayTime;

		[SerializeField]
		public float sustainLevel;

		[SerializeField]
		public float sustainTime;

		[SerializeField]
		public float releaseTime;

		private float gain;

		private Coroutine envelopeRoutine;

		private ADSREnvelope.State envelopeState;

		protected override bool Use2D => false;

		private void Update()
		{
		}

		protected override void SetValue()
		{
		}

		public void Trigger()
		{
		}

		private IEnumerator EnvelopeCoroutine()
		{
			return null;
		}
	}
}
