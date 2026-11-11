using UnityEngine;

namespace Arena
{
	public class FreezeTimescale : MonoBehaviour
	{
		public float FreezeDuration = 0.25f;

		public AnimationCurve FreezeTimeCurve = AnimationCurve.Linear(0f, 0.1f, 1f, 1f);

		public bool ModifyFixedDeltaTime = true;

		private bool doFreeze;

		private float freezeTimer;

		private float currentFreezeDuration;

		private TimeControl timeController;

		private float fixedTimeStep = 0.02f;

		private void Awake()
		{
			timeController = Object.FindObjectOfType<TimeControl>();
			fixedTimeStep = Time.fixedDeltaTime;
		}

		public void StartFreeze()
		{
			StartFreeze(1f);
		}

		public void StartFreeze(float durationMultiplier)
		{
			currentFreezeDuration = FreezeDuration * durationMultiplier;
			freezeTimer = 0f;
			enabled = true;
			if (timeController != null)
			{
				timeController.enabled = false;
			}
		}

		private void Update()
		{
			freezeTimer += Time.unscaledDeltaTime;
			if (freezeTimer < currentFreezeDuration)
			{
				float t = currentFreezeDuration > 0.001f ? freezeTimer / currentFreezeDuration : 1f;
				float eval = FreezeTimeCurve != null && FreezeTimeCurve.length > 0 ? Mathf.Clamp01(FreezeTimeCurve.Evaluate(t)) : t;
				Time.timeScale = eval;
				if (ModifyFixedDeltaTime)
				{
					Time.fixedDeltaTime = fixedTimeStep * Mathf.Max(0.05f, Time.timeScale);
				}
			}
			else
			{
				Time.timeScale = 1f;
				if (ModifyFixedDeltaTime)
				{
					Time.fixedDeltaTime = fixedTimeStep;
				}
				enabled = false;
				freezeTimer = 0f;
				if (timeController != null)
				{
					timeController.enabled = true;
				}
			}
		}

		private void OnDestroy()
		{
			if (ModifyFixedDeltaTime && fixedTimeStep > 0f)
			{
				Time.fixedDeltaTime = fixedTimeStep;
			}
		}
	}
}
