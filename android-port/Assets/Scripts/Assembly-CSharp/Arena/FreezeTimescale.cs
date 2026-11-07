using UnityEngine;

namespace Arena
{
	public class FreezeTimescale : MonoBehaviour
	{
		public float FreezeDuration;

		public AnimationCurve FreezeTimeCurve;

		public bool ModifyFixedDeltaTime;

		private bool doFreeze;

		private float freezeTimer;

		private float currentFreezeDuration;

		private TimeControl timeController;

		private float fixedTimeStep;

		private void Awake()
		{
		}

		public void StartFreeze()
		{
		}

		public void StartFreeze(float durationMultiplier)
		{
		}

		private void Update()
		{
		}

		private void OnDestroy()
		{
		}
	}
}
