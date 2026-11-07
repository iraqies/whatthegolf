using System.Collections;
using UnityEngine;

namespace Audio
{
	public class HammerThrowingAudio : MonoBehaviour
	{
		public SpinningBowlerPuppet bowler;

		public PlayAudioClipsByFrequency clipPlayer;

		public MinMax frequencyRange;

		public MinMax modulationRange;

		public float accelerateOverTime;

		public DropPropOnShoot propDropper;

		public ClipSettingsCollection shootSfx;

		private Coroutine acceleratingStartRoutine;

		private void Start()
		{
		}

		private void OnDroppedProp(Vector3 obj)
		{
		}

		private void StopWhoosh()
		{
		}

		private void StartWhoosh()
		{
		}

		private IEnumerator AcceleratingStartCoroutine()
		{
			return null;
		}
	}
}
