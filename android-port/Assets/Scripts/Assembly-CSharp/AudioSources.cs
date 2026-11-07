using System;
using System.Collections.Generic;
using UnityEngine;

public class AudioSources : MonoBehaviour
{
	public bool debug;

	public Func<AudioClip, AudioClip> OnPrePlay;

	[SerializeField]
	private bool isSpatialVoice;

	[SerializeField]
	private int count;

	[SerializeField]
	private bool warnWhenClipping;

	[SerializeField]
	private AudioSource audioSourcePrefab;

	[SerializeField]
	private bool skipIfPlaying;

	private AudioSource[] audioSources;

	private int index;

	private AudioClip lastNonRepeatClip;

	private AnimationCurve defaultSpatialBlendCurve;

	private AnimationCurve nonSpatialCurve;

	private AnimationCurve defaultRolloffCurve;

	private AnimationCurve nonSpatialRolloffCurve;

	public void PreviewInit(AudioSource prefab, int voices)
	{
	}

	public AudioSource[] GetAudioSources()
	{
		return null;
	}

	public AudioSource GetLastAudioSource()
	{
		return null;
	}

	public void Awake()
	{
	}

	public void ForAll(Action<AudioSource> modifier)
	{
	}

	public AudioSource Play(AudioClip clip)
	{
		return null;
	}

	public AudioSource Play(AudioClip clip, float delay = 0f, bool reverse = false)
	{
		return null;
	}

	public AudioSource Play(List<AudioClip> clips)
	{
		return null;
	}

	public AudioSource Play(List<AudioClip> clips, Action<AudioSource> modifier, bool canRepeat = true, float delay = 0f, bool reverse = false)
	{
		return null;
	}

	public AudioSource GetNextAudioSource()
	{
		return null;
	}

	public AudioSource Play(AudioClip clip, Action<AudioSource> modifier, float delay = 0f, bool reverse = false)
	{
		return null;
	}

	public AudioSource PlaySimple(AudioClip clip, float volume, float pitch, Vector3 position, float maxDistance = 0f, bool disableSpatial = false)
	{
		return null;
	}

	public AudioSource PlaySimpleDelayed(AudioClip clip, float volume, float pitch, Vector3 position, float delay, float maxDistance = 0f)
	{
		return null;
	}
}
