using Audio;
using Core;
using UnityEngine;

public class TimeControlAudio : MonoBehaviour
{
	[SerializeField]
	private ClipSettingsCollection SlowmotionStartSFX;

	[SerializeField]
	private ClipSettingsCollection SlowmotionEndSFX;

	[SerializeField]
	private float time = 3f;

	[SerializeField]
	private float hardMultiplier = 10f;

	[SerializeField]
	private float inTime = 0.1f;

	[SerializeField]
	private float outTime = 0.05f;

	[SerializeField]
	private float dbInSlowmotion = -3f;

	[SerializeField]
	private float freqInSlowmotion = 5000f;

	[SerializeField]
	private float pitchInSlowmotion = 0.8f;

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
		if (Level.Instance != null && Level.Instance.IsMultiplayer)
		{
			return;
		}
		if (scale > 0f && lastTimeScale == 0f)
		{
			hardIn = Time.unscaledTime < lastSlowmotionTime + time;
			if (SlowmotionStartSFX != null && AudioManager.Instance != null)
			{
				SlowmotionStartSFX.Play(AudioManager.Instance.uiEffects, Vector3.zero, 0f);
			}
			goingIn = true;
			lastSlowmotionTime = Time.unscaledTime;
		}
		lastTimeScale = scale;
	}

	private void Start()
	{
		_audio = AudioManager.Instance;
		if (_audio != null)
		{
			if (_audio.sfxMixer != null)
			{
				_audio.sfxMixer.GetFloat(SLOWMOTION_VOLUME, out baseVolumeSFX);
			}
			if (_audio.musicMixer != null)
			{
				_audio.musicMixer.GetFloat(SLOWMOTION_VOLUME, out baseVolumeMusic);
			}
		}
	}

	public void OnSlowmotionStop()
	{
		lastTimeScale = 0f;
		if (SlowmotionEndSFX != null && AudioManager.Instance != null)
		{
			SlowmotionEndSFX.Play(AudioManager.Instance.uiEffects, Vector3.zero, 0f);
		}
		goingIn = false;
	}

	private void OnDestroy()
	{
		if (_audio != null && !_isQuitting)
		{
			if (_audio.musicMixer != null)
			{
				_audio.musicMixer.SetFloat(SLOWMOTION_VOLUME, baseVolumeMusic);
				_audio.musicMixer.SetFloat(SLOWMOTION_FREQ, 22000f);
			}
			if (_audio.sfxMixer != null)
			{
				_audio.sfxMixer.SetFloat(SLOWMOTION_VOLUME, baseVolumeSFX);
				_audio.sfxMixer.SetFloat(SLOWMOTION_FREQ, 22000f);
				_audio.sfxMixer.SetFloat(SLOWMOTION_PITCH, 1f);
			}
		}
	}

	private void OnApplicationQuit()
	{
		_isQuitting = true;
	}

	private void Update()
	{
		if (_audio == null || Mathf.Approximately(currentAudioValue, lastTimeScale))
		{
			return;
		}
		float stepRate = (goingIn ? inTime : outTime) * (hardIn ? hardMultiplier : 1f);
		currentAudioValue = Mathf.MoveTowards(currentAudioValue, lastTimeScale, stepRate * Time.unscaledDeltaTime);
		float t = Mathf.Clamp01(currentAudioValue / 0.1f);
		float musicVol = Mathf.Lerp(baseVolumeMusic, baseVolumeMusic + dbInSlowmotion, t);
		float sfxVol = Mathf.Lerp(baseVolumeSFX, baseVolumeSFX + dbInSlowmotion, t);
		float freq = Mathf.Lerp(22000f, freqInSlowmotion, t);
		float pitch = Mathf.Lerp(1f, pitchInSlowmotion, t);
		if (_audio.musicMixer != null)
		{
			_audio.musicMixer.SetFloat(SLOWMOTION_VOLUME, musicVol);
			_audio.musicMixer.SetFloat(SLOWMOTION_FREQ, freq);
		}
		if (_audio.sfxMixer != null)
		{
			_audio.sfxMixer.SetFloat(SLOWMOTION_VOLUME, sfxVol);
			_audio.sfxMixer.SetFloat(SLOWMOTION_FREQ, freq);
			_audio.sfxMixer.SetFloat(SLOWMOTION_PITCH, pitch);
		}
	}
}
