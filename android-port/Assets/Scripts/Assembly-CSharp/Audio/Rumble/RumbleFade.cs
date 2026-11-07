using System.Collections;
using UnityEngine;

namespace Audio.Rumble
{
	public class RumbleFade : MonoBehaviour
	{
		public float amplitudeLow;

		public float frequencyLow;

		public float amplitudeHigh;

		public float frequencyHigh;

		private Coroutine fadeRoutine;

		private float gain;

		public void FadeInRumble(float duration)
		{
		}

		public void FadeOutRumble(float duration)
		{
		}

		private IEnumerator FadeRoutine(float duration, bool fadeIn)
		{
			return null;
		}
	}
}
