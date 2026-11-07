using Audio;
using UnityEngine;

public class TimeControlAudio : MonoBehaviour
{
	[SerializeField]
	private ClipSettingsCollection SlowmotionStartSFX;

	[SerializeField]
	private ClipSettingsCollection SlowmotionEndSFX;

	[SerializeField]
	private float time;

	[SerializeField]
	private float hardMultiplier;

	[SerializeField]
	private float inTime;

	[SerializeField]
	private float outTime;

	[SerializeField]
	private float dbInSlowmotion;

	[SerializeField]
	private float freqInSlowmotion;

	[SerializeField]
	private float pitchInSlowmotion;

	private float baseVolumeMusic;

	private float baseVolumeSFX;

	private float lastTimeScale;

	private float currentAudioValue;

	private bool goingIn;

	private bool hardIn;

	private const string SLOWMOTION_VOLUME = "Slowmotion_Volume";

	private const string SLOWMOTION_FREQ = "Slowmotion_Frequency";

	private const string SLOWMOTION_PITCH = "Slowmotion_Pitch";

	private AudioManager _audio;

	private float lastSlowmotionTime;

	private bool _isQuitting;

	public void OnTimescaleChange(float scale)
	{
	}

	private void Start()
	{
	}

	public void OnSlowmotionStop()
	{
	}

	private void OnDestroy()
	{
	}

	private void OnApplicationQuit()
	{
	}

	private void Update()
	{
	}
}
