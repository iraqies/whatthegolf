using Chronos;
using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x200053C")]
public class TimeControl : MonoBehaviour
{
	[Token(Token = "0x200053D")]
	public delegate void PauseDelegate(bool state);

	[Token(Token = "0x4001AF3")]
	[FieldOffset(Offset = "0x18")]
	public float aimTimeScale;

	[Token(Token = "0x4001AF4")]
	[FieldOffset(Offset = "0x1C")]
	public float upSpeed;

	[Token(Token = "0x4001AF5")]
	[FieldOffset(Offset = "0x20")]
	public float downSpeed;

	[Token(Token = "0x4001AF6")]
	[FieldOffset(Offset = "0x24")]
	[SerializeField]
	private float baseFixedTimeStep;

	[Token(Token = "0x4001AF7")]
	[FieldOffset(Offset = "0x28")]
	public bool usePlatformSettingsTimeScaleAdjustment;

	[Token(Token = "0x4001AF8")]
	[FieldOffset(Offset = "0x30")]
	[SerializeField]
	public LocalClock clockToUseInstead;

	[Token(Token = "0x4001AF9")]
	[FieldOffset(Offset = "0x38")]
	[SerializeField]
	public bool showVisualEffect;

	[Token(Token = "0x4001AFA")]
	[FieldOffset(Offset = "0x39")]
	[SerializeField]
	public bool modifyFixedDeltaTime;

	[Token(Token = "0x4001AFB")]
	[FieldOffset(Offset = "0x3A")]
	private bool inTrailerRecordMode;

	[Token(Token = "0x4001AFC")]
	[FieldOffset(Offset = "0x3C")]
	private float trailerModeMultiplier;

	[Token(Token = "0x4001AFD")]
	[FieldOffset(Offset = "0x40")]
	private float targetTimeScale;

	[Token(Token = "0x4001AFE")]
	[FieldOffset(Offset = "0x44")]
	private float fixedTimeStep;

	[Token(Token = "0x4001AFF")]
	[FieldOffset(Offset = "0x48")]
	private bool isPaused;

	[Token(Token = "0x4001B00")]
	[FieldOffset(Offset = "0x0")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x4DBBC", Offset = "0x4DBBC")]
	private static PauseDelegate m_OnPauseStateChanged;

	[Token(Token = "0x4001B01")]
	[FieldOffset(Offset = "0x4C")]
	private float timeScaleBeforePause;

	[Token(Token = "0x4001B02")]
	[FieldOffset(Offset = "0x50")]
	private float nextTimeStop;

	[Token(Token = "0x4001B03")]
	[FieldOffset(Offset = "0x54")]
	private bool useMinimumTime;

	[Token(Token = "0x4001B04")]
	[FieldOffset(Offset = "0x55")]
	private bool isStopping;

	[Token(Token = "0x4001B05")]
	[FieldOffset(Offset = "0x56")]
	private bool isAiming;

	[Token(Token = "0x4001B06")]
	[FieldOffset(Offset = "0x58")]
	private TimeControlAudio timeControlAudio;

	[Token(Token = "0x4001B07")]
	[FieldOffset(Offset = "0x60")]
	private float currentAimTimeScale;

	[Token(Token = "0x170002A6")]
	public bool IsPaused
	{
		[Token(Token = "0x60017DE")]
		[Address(RVA = "0x1714FAC", Offset = "0x1714FAC", VA = "0x1714FAC")]
		get
		{
			return default;
		}
		[Token(Token = "0x60017DF")]
		[Address(RVA = "0x1714FB4", Offset = "0x1714FB4", VA = "0x1714FB4")]
		private set
		{
		}
	}

	[Token(Token = "0x14000026")]
	public static event PauseDelegate OnPauseStateChanged
	{
		[Token(Token = "0x60017E0")]
		[Address(RVA = "0x1714FBC", Offset = "0x1714FBC", VA = "0x1714FBC")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x62FE8", Offset = "0x62FE8")]
		add
		{
		}
		[Token(Token = "0x60017E1")]
		[Address(RVA = "0x171507C", Offset = "0x171507C", VA = "0x171507C")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x62FF8", Offset = "0x62FF8")]
		remove
		{
		}
	}

	[Token(Token = "0x60017E2")]
	[Address(RVA = "0x171513C", Offset = "0x171513C", VA = "0x171513C")]
	private void Start()
	{
	}

	[Token(Token = "0x60017E3")]
	[Address(RVA = "0x1715198", Offset = "0x1715198", VA = "0x1715198")]
	private void OnEnable()
	{
	}

	[Token(Token = "0x60017E4")]
	[Address(RVA = "0x1715314", Offset = "0x1715314", VA = "0x1715314")]
	private void Instance_OnNewBall()
	{
	}

	[Token(Token = "0x60017E5")]
	[Address(RVA = "0x1715270", Offset = "0x1715270", VA = "0x1715270")]
	public void SetCurrentAimTimeScale(float val)
	{
	}

	[Token(Token = "0x60017E6")]
	[Address(RVA = "0x171537C", Offset = "0x171537C", VA = "0x171537C")]
	public void SetAimTimeScale(bool useMinimumTime = false, float minimumTime = 0f)
	{
	}

	[Token(Token = "0x60017E7")]
	[Address(RVA = "0x17155C8", Offset = "0x17155C8", VA = "0x17155C8")]
	public void SetNewAimTimeScale(float newAimTimeScale)
	{
	}

	[Token(Token = "0x60017E8")]
	[Address(RVA = "0x17156B0", Offset = "0x17156B0", VA = "0x17156B0")]
	public float GetTargetTimeScale()
	{
		return default;
	}

	[Token(Token = "0x60017E9")]
	[Address(RVA = "0x17156B8", Offset = "0x17156B8", VA = "0x17156B8")]
	public void ResetTimeScale()
	{
	}

	[Token(Token = "0x60017EA")]
	[Address(RVA = "0x1715824", Offset = "0x1715824", VA = "0x1715824")]
	public void TogglePause(bool isPaused)
	{
	}

	[Token(Token = "0x60017EB")]
	[Address(RVA = "0x17158C4", Offset = "0x17158C4", VA = "0x17158C4")]
	private void Update()
	{
	}

	[Token(Token = "0x60017EC")]
	[Address(RVA = "0x171594C", Offset = "0x171594C", VA = "0x171594C")]
	private void UpdateTimeScale()
	{
	}

	[Token(Token = "0x60017ED")]
	[Address(RVA = "0x1715AAC", Offset = "0x1715AAC", VA = "0x1715AAC")]
	private void OnDestroy()
	{
	}

	[Token(Token = "0x60017EE")]
	[Address(RVA = "0x1715AC8", Offset = "0x1715AC8", VA = "0x1715AC8")]
	public void SetRecordingMultiplier(float multiplier)
	{
	}

	[Token(Token = "0x60017EF")]
	[Address(RVA = "0x1715AD8", Offset = "0x1715AD8", VA = "0x1715AD8")]
	public TimeControl()
	{
	}
}
