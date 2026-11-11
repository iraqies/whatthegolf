using System;
using UnityEngine;
using UnityEngine.Events;

public class EventStepSequencer : MonoBehaviour
{
	[Serializable]
	public class EventStep
	{
		public UnityEvent Event;

		public float DelayUntilFire;

		[HideInInspector]
		public bool hasFired;

		public void Update(float currentTime)
		{
			if (!hasFired && currentTime >= DelayUntilFire)
			{
				hasFired = true;
				Event?.Invoke();
			}
		}

		public void Reset()
		{
			hasFired = false;
		}
	}

	[SerializeField]
	private bool triggerAutomaticallyOnAwake;

	[SerializeField]
	private bool loop;

	[SerializeField]
	private EventStep[] steps;

	private float timeCounter;

	private bool running;

	public bool IsRunning => running;

	private void Awake()
	{
		if (triggerAutomaticallyOnAwake)
		{
			StartSequencer();
		}
	}

	private void Update()
	{
		if (!running || steps == null)
		{
			return;
		}
		timeCounter += Time.deltaTime;
		bool allDone = true;
		for (int i = 0; i < steps.Length; i++)
		{
			if (steps[i] != null)
			{
				steps[i].Update(timeCounter);
				allDone &= steps[i].hasFired;
			}
		}
		if (allDone)
		{
			ResetSteps();
			running = loop;
		}
	}

	public void StartSequencer()
	{
		running = true;
	}

	public void PauseSequencer()
	{
		running = false;
	}

	public void StopAndResetSequencer()
	{
		running = false;
		ResetSteps();
	}

	private void ResetSteps()
	{
		timeCounter = 0f;
		if (steps != null)
		{
			for (int i = 0; i < steps.Length; i++)
			{
				steps[i]?.Reset();
			}
		}
	}
}
