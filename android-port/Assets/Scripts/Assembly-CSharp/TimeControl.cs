using System.Runtime.CompilerServices;
using Chronos;
using UnityEngine;

public class TimeControl : MonoBehaviour
{
	public delegate void PauseDelegate(bool state);

	public float aimTimeScale;

	public float upSpeed;

	public float downSpeed;

	[SerializeField]
	private float baseFixedTimeStep;

	public bool usePlatformSettingsTimeScaleAdjustment;

	[SerializeField]
	public LocalClock clockToUseInstead;

	[SerializeField]
	public bool showVisualEffect;

	[SerializeField]
	public bool modifyFixedDeltaTime;

	private bool inTrailerRecordMode;

	private float trailerModeMultiplier;

	private float targetTimeScale;

	private float fixedTimeStep;

	private bool isPaused;

	[CompilerGenerated]
	private static PauseDelegate m_OnPauseStateChanged;

	private float timeScaleBeforePause;

	private float nextTimeStop;

	private bool useMinimumTime;

	private bool isStopping;

	private bool isAiming;

	private TimeControlAudio timeControlAudio;

	private float currentAimTimeScale;

	public bool IsPaused
	{
		get
		{
			return false;
		}
		private set
		{
		}
	}

	public static event PauseDelegate OnPauseStateChanged
	{
		[CompilerGenerated]
		add
		{
		}
		[CompilerGenerated]
		remove
		{
		}
	}

	private void Start()
	{
	}

	private void OnEnable()
	{
	}

	private void Instance_OnNewBall()
	{
	}

	public void SetCurrentAimTimeScale(float val)
	{
	}

	public void SetAimTimeScale(bool useMinimumTime = false, float minimumTime = 0f)
	{
	}

	public void SetNewAimTimeScale(float newAimTimeScale)
	{
	}

	public float GetTargetTimeScale()
	{
		return 0f;
	}

	public void ResetTimeScale()
	{
	}

	public void TogglePause(bool isPaused)
	{
	}

	private void Update()
	{
	}

	private void UpdateTimeScale()
	{
	}

	private void OnDestroy()
	{
	}

	public void SetRecordingMultiplier(float multiplier)
	{
	}
}
