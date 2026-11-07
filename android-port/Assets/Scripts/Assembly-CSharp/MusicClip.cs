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

	public float playVolume;

	public float currentVolume;

	public float unityVolume;

	public float fadeVolume;

	public float currentTime;

	private Coroutine envelope;

	public int priority;

	public bool isStopping;

	private float lastVolume;

	public void Play(MusicSegment.PlayInfo info)
	{
	}

	public void SourceWasTaken()
	{
	}

	public bool IsPlaying()
	{
		return false;
	}

	public void StartStop()
	{
	}

	public void Stop()
	{
	}

	public float dbToUnityVolume(float db)
	{
		return 0f;
	}

	public float UpdatePlaying(float parentVolume, float parentFadeVolume)
	{
		return 0f;
	}

	public double GetLength()
	{
		return 0.0;
	}

	private IEnumerator Envelope(double start, double end, double startClipTime, double endClipTime, Action OnComplete)
	{
		return null;
	}
}
