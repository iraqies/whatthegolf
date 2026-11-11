using System;
using System.Runtime.CompilerServices;
using Chronos;
using UnityEngine;

public class TimeControl : MonoBehaviour
{
	public delegate void PauseDelegate(bool state);

	public float aimTimeScale = 0.15f;
	public float AimTimeScale
	{
		get => aimTimeScale;
		set => aimTimeScale = value;
	}
	public float upSpeed = 8f;
	public float downSpeed = 12f;
	[SerializeField] private float baseFixedTimeStep = 0.02f;
	public bool usePlatformSettingsTimeScaleAdjustment;
	[SerializeField] public LocalClock clockToUseInstead;
	[SerializeField] public bool showVisualEffect;
	[SerializeField] public bool modifyFixedDeltaTime = true;

	private bool inTrailerRecordMode;
	private float trailerModeMultiplier = 1f;
	private float targetTimeScale = 1f;
	private float fixedTimeStep = 0.02f;
	private bool isPaused;
	private static PauseDelegate m_OnPauseStateChanged;
	private float timeScaleBeforePause = 1f;
	private float nextTimeStop;
	private bool useMinimumTime;
	private bool isStopping;
	private bool isAiming;
	private TimeControlAudio timeControlAudio;
	private float currentAimTimeScale = 0.15f;

	public bool IsPaused
	{
		get => isPaused;
		private set => isPaused = value;
	}

	public static event PauseDelegate OnPauseStateChanged
	{
		add => m_OnPauseStateChanged = (PauseDelegate)Delegate.Combine(m_OnPauseStateChanged, value);
		remove => m_OnPauseStateChanged = (PauseDelegate)Delegate.Remove(m_OnPauseStateChanged, value);
	}

	private void Start()
	{
		if (baseFixedTimeStep <= 0f) baseFixedTimeStep = 0.02f;
		fixedTimeStep = baseFixedTimeStep;
		currentAimTimeScale = aimTimeScale > 0f ? aimTimeScale : 0.15f;
		targetTimeScale = 1f;
	}

	private void OnEnable()
	{
		targetTimeScale = 1f;
	}

	private void Instance_OnNewBall() { }

	public void SetCurrentAimTimeScale(float val) => currentAimTimeScale = Mathf.Clamp(val, 0.02f, 1f);

	public void SetAimTimeScale(bool useMinimumTime = false, float minimumTime = 0f)
	{
		isAiming = true;
		this.useMinimumTime = useMinimumTime;
		targetTimeScale = Mathf.Clamp(currentAimTimeScale > 0f ? currentAimTimeScale : aimTimeScale, 0.02f, 1f);
		if (useMinimumTime && minimumTime > 0f)
			nextTimeStop = Time.unscaledTime + minimumTime;
	}

	public void SetNewAimTimeScale(float newAimTimeScale)
	{
		aimTimeScale = newAimTimeScale;
		currentAimTimeScale = newAimTimeScale;
		if (isAiming) targetTimeScale = Mathf.Clamp(newAimTimeScale, 0.02f, 1f);
	}

	public float GetTargetTimeScale() => isPaused ? 0f : targetTimeScale;

	public void ResetTimeScale()
	{
		isAiming = false;
		targetTimeScale = 1f;
		if (!isPaused)
		{
			Time.timeScale = 1f;
			if (modifyFixedDeltaTime && fixedTimeStep > 0f)
				Time.fixedDeltaTime = fixedTimeStep;
		}
	}

	public void TogglePause(bool paused)
	{
		if (isPaused == paused) return;
		isPaused = paused;
		if (isPaused)
		{
			timeScaleBeforePause = Time.timeScale > 0f ? Time.timeScale : 1f;
			Time.timeScale = 0f;
		}
		else
		{
			Time.timeScale = isAiming ? targetTimeScale : 1f;
		}
		m_OnPauseStateChanged?.Invoke(isPaused);
	}

	private void Update()
	{
		if (!isPaused)
			UpdateTimeScale();
	}

	private void UpdateTimeScale()
	{
		float speed = Time.timeScale < targetTimeScale ? (upSpeed > 0f ? upSpeed : 8f) : (downSpeed > 0f ? downSpeed : 12f);
		Time.timeScale = Mathf.MoveTowards(Time.timeScale, targetTimeScale, Time.unscaledDeltaTime * speed);
		if (modifyFixedDeltaTime && fixedTimeStep > 0f)
			Time.fixedDeltaTime = fixedTimeStep * Mathf.Max(0.05f, Time.timeScale);
	}

	private void OnDestroy()
	{
		Time.timeScale = 1f;
		if (baseFixedTimeStep > 0f)
			Time.fixedDeltaTime = baseFixedTimeStep;
	}

	public void SetRecordingMultiplier(float multiplier) => trailerModeMultiplier = multiplier;
}
