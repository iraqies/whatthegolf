using System;
using System.Collections;
using UnityEngine;
using UnityEngine.AddressableAssets;

public class MusicClip : MonoBehaviour
{
	public string id;
	public AudioClip clip;
	public AssetReference clipRefs;
	public double EndTrimOffset;
	public double FadeInDuration;
	public int FadeOutMode;
	public int FadeInMode;
	public double FadeOutDuration;
	public double BeginTrimOffset;
	public double PlayAt;
	public WwiseAudioSources wSources;
	public WwiseAudioSources.SourceInfo source;
	public bool debug;
	public float playVolume = 1f;
	public float currentVolume = 1f;
	public float unityVolume = 1f;
	public float fadeVolume = 1f;
	public float currentTime;
	private Coroutine envelope;
	public int priority;
	public bool isStopping;
	private float lastVolume;

	public void Play(MusicSegment.PlayInfo info)
	{
		if (clip == null) return;
		if (wSources == null)
		{
			var w = GetComponentInParent<Wwise>();
			if (w != null) wSources = w.sourcesMusic;
		}
		if (wSources == null) return;
		source = wSources.Get(this);
		if (source == null || source.source == null) return;
		isStopping = false;
		playVolume = info != null && info.volume != 0f ? dbToUnityVolume(info.volume) : 1f;
		fadeVolume = 1f;
		unityVolume = Mathf.Clamp(playVolume, 0.2f, 1f);
		source.source.clip = clip;
		source.source.volume = unityVolume;
		source.source.pitch = 1f;
		source.source.spatialBlend = 0f;
		source.source.loop = true;
		source.source.Play();
	}

	public void SourceWasTaken()
	{
		source = null;
	}

	public bool IsPlaying()
	{
		return source != null && source.source != null && source.source.isPlaying;
	}

	public void StartStop()
	{
		Stop();
	}

	public void Stop()
	{
		isStopping = true;
		if (source != null && source.source != null)
		{
			source.source.Stop();
		}
		source = null;
	}

	public float dbToUnityVolume(float db)
	{
		if (Mathf.Abs(db) < 0.001f) return 1f;
		if (db <= -80f) return 0f;
		return Mathf.Clamp01(Mathf.Pow(10f, db / 20f));
	}

	public float UpdatePlaying(float parentVolume, float parentFadeVolume)
	{
		if (source != null && source.source != null && source.source.isPlaying)
		{
			unityVolume = Mathf.Clamp01(dbToUnityVolume(parentVolume) * parentFadeVolume);
			source.source.volume = unityVolume;
			currentTime = source.source.time;
		}
		return currentTime;
	}

	public double GetLength()
	{
		return clip != null ? clip.length : 4.0;
	}

	private IEnumerator Envelope(double start, double end, double startClipTime, double endClipTime, Action OnComplete)
	{
		OnComplete?.Invoke();
		yield break;
	}
}
