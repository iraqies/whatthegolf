using Audio;
using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x2000CE9")]
public class TimeControlAudio : MonoBehaviour
{
	[Token(Token = "0x4004623")]
	[FieldOffset(Offset = "0x18")]
	[SerializeField]
	private ClipSettingsCollection SlowmotionStartSFX;

	[Token(Token = "0x4004624")]
	[FieldOffset(Offset = "0x20")]
	[SerializeField]
	private ClipSettingsCollection SlowmotionEndSFX;

	[Token(Token = "0x4004625")]
	[FieldOffset(Offset = "0x28")]
	[SerializeField]
	private float time;

	[Token(Token = "0x4004626")]
	[FieldOffset(Offset = "0x2C")]
	[SerializeField]
	private float hardMultiplier;

	[Token(Token = "0x4004627")]
	[FieldOffset(Offset = "0x30")]
	[SerializeField]
	private float inTime;

	[Token(Token = "0x4004628")]
	[FieldOffset(Offset = "0x34")]
	[SerializeField]
	private float outTime;

	[Token(Token = "0x4004629")]
	[FieldOffset(Offset = "0x38")]
	[SerializeField]
	private float dbInSlowmotion;

	[Token(Token = "0x400462A")]
	[FieldOffset(Offset = "0x3C")]
	[SerializeField]
	private float freqInSlowmotion;

	[Token(Token = "0x400462B")]
	[FieldOffset(Offset = "0x40")]
	[SerializeField]
	private float pitchInSlowmotion;

	[Token(Token = "0x400462C")]
	[FieldOffset(Offset = "0x44")]
	private float baseVolumeMusic;

	[Token(Token = "0x400462D")]
	[FieldOffset(Offset = "0x48")]
	private float baseVolumeSFX;

	[Token(Token = "0x400462E")]
	[FieldOffset(Offset = "0x4C")]
	private float lastTimeScale;

	[Token(Token = "0x400462F")]
	[FieldOffset(Offset = "0x50")]
	private float currentAudioValue;

	[Token(Token = "0x4004630")]
	[FieldOffset(Offset = "0x54")]
	private bool goingIn;

	[Token(Token = "0x4004631")]
	[FieldOffset(Offset = "0x55")]
	private bool hardIn;

	[Token(Token = "0x4004632")]
	private const string SLOWMOTION_VOLUME = "Slowmotion_Volume";

	[Token(Token = "0x4004633")]
	private const string SLOWMOTION_FREQ = "Slowmotion_Frequency";

	[Token(Token = "0x4004634")]
	private const string SLOWMOTION_PITCH = "Slowmotion_Pitch";

	[Token(Token = "0x4004635")]
	[FieldOffset(Offset = "0x58")]
	private AudioManager _audio;

	[Token(Token = "0x4004636")]
	[FieldOffset(Offset = "0x60")]
	private float lastSlowmotionTime;

	[Token(Token = "0x4004637")]
	[FieldOffset(Offset = "0x64")]
	private bool _isQuitting;

	[Token(Token = "0x6003D0F")]
	[Address(RVA = "0x1715498", Offset = "0x1715498", VA = "0x1715498")]
	public void OnTimescaleChange(float scale)
	{
	}

	[Token(Token = "0x6003D10")]
	[Address(RVA = "0x1715B14", Offset = "0x1715B14", VA = "0x1715B14")]
	private void Start()
	{
	}

	[Token(Token = "0x6003D11")]
	[Address(RVA = "0x17157C0", Offset = "0x17157C0", VA = "0x17157C0")]
	public void OnSlowmotionStop()
	{
	}

	[Token(Token = "0x6003D12")]
	[Address(RVA = "0x1715C04", Offset = "0x1715C04", VA = "0x1715C04")]
	private void OnDestroy()
	{
	}

	[Token(Token = "0x6003D13")]
	[Address(RVA = "0x1715E1C", Offset = "0x1715E1C", VA = "0x1715E1C")]
	private void OnApplicationQuit()
	{
	}

	[Token(Token = "0x6003D14")]
	[Address(RVA = "0x1715E28", Offset = "0x1715E28", VA = "0x1715E28")]
	private void Update()
	{
	}

	[Token(Token = "0x6003D15")]
	[Address(RVA = "0x17160A0", Offset = "0x17160A0", VA = "0x17160A0")]
	public TimeControlAudio()
	{
	}
}
