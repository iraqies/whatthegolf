using System;
using System.Collections.Generic;
using UnityEngine;

public class AudioSources : MonoBehaviour
{
	public bool debug;
	public Func<AudioClip, AudioClip> OnPrePlay;
	[SerializeField] private bool isSpatialVoice;
	[SerializeField] private int count = 12;
	[SerializeField] private bool warnWhenClipping;
	[SerializeField] private AudioSource audioSourcePrefab;
	[SerializeField] private bool skipIfPlaying;

	private AudioSource[] audioSources;
	private int index;
	private AudioClip lastNonRepeatClip;
	private AnimationCurve defaultSpatialBlendCurve;
	private AnimationCurve nonSpatialCurve;
	private AnimationCurve defaultRolloffCurve;
	private AnimationCurve nonSpatialRolloffCurve;

	private void EnsureInitialized()
	{
		if (audioSources != null && audioSources.Length > 0) return;
		if (audioSourcePrefab != null)
		{
			defaultSpatialBlendCurve = audioSourcePrefab.GetCustomCurve(AudioSourceCurveType.SpatialBlend);
			nonSpatialCurve = new AnimationCurve(new Keyframe(0f, 0f), new Keyframe(1f, 0f));
			defaultRolloffCurve = audioSourcePrefab.GetCustomCurve(AudioSourceCurveType.CustomRolloff);
			nonSpatialRolloffCurve = new AnimationCurve(new Keyframe(0f, 1f), new Keyframe(1f, 1f));
		}
		var existing = GetComponentsInChildren<AudioSource>(true);
		int targetCount = Mathf.Max(count, 8);
		if (existing != null && existing.Length >= targetCount)
		{
			audioSources = existing;
		}
		else
		{
			audioSources = new AudioSource[targetCount];
			for (int i = 0; i < targetCount; i++)
			{
				if (audioSourcePrefab != null)
				{
					audioSources[i] = Instantiate(audioSourcePrefab, transform);
				}
				else
				{
					var go = new GameObject("AudioSource_" + i);
					go.transform.SetParent(transform, false);
					audioSources[i] = go.AddComponent<AudioSource>();
				}
			}
		}
		foreach (var s in audioSources)
		{
			if (s == null) continue;
			s.playOnAwake = false;
			s.spatialBlend = 0f;
			if (nonSpatialCurve != null)
				s.SetCustomCurve(AudioSourceCurveType.SpatialBlend, nonSpatialCurve);
			if (nonSpatialRolloffCurve != null)
				s.SetCustomCurve(AudioSourceCurveType.CustomRolloff, nonSpatialRolloffCurve);
			var lpf = s.GetComponent<AudioLowPassFilter>();
			if (lpf != null)
				lpf.enabled = false;
		}
	}

	public void PreviewInit(AudioSource prefab, int voices)
	{
		audioSourcePrefab = prefab;
		count = voices;
		EnsureInitialized();
	}

	public AudioSource[] GetAudioSources()
	{
		EnsureInitialized();
		return audioSources;
	}

	public AudioSource GetLastAudioSource()
	{
		EnsureInitialized();
		if (audioSources == null || audioSources.Length == 0) return null;
		int prev = (index - 1 + audioSources.Length) % audioSources.Length;
		return audioSources[prev];
	}

	public void Awake()
	{
		EnsureInitialized();
	}

	public void ForAll(Action<AudioSource> modifier)
	{
		EnsureInitialized();
		if (modifier == null || audioSources == null) return;
		foreach (var s in audioSources)
		{
			if (s != null) modifier(s);
		}
	}

	public AudioSource GetNextAudioSource()
	{
		EnsureInitialized();
		if (audioSources == null || audioSources.Length == 0) return null;
		var src = audioSources[index % audioSources.Length];
		index = (index + 1) % audioSources.Length;
		if (src == null)
		{
			src = gameObject.AddComponent<AudioSource>();
			src.playOnAwake = false;
		}
		return src;
	}

	public AudioSource Play(AudioClip clip)
	{
		return Play(clip, null, 0f, false);
	}

	public AudioSource Play(AudioClip clip, float delay = 0f, bool reverse = false)
	{
		return Play(clip, null, delay, reverse);
	}

	public AudioSource Play(List<AudioClip> clips)
	{
		return Play(clips, null, true, 0f, false);
	}

	public AudioSource Play(List<AudioClip> clips, Action<AudioSource> modifier, bool canRepeat, bool reverse, float delay = 0f)
	{
		return Play(clips, modifier, canRepeat, delay, reverse);
	}

	public AudioSource Play(AudioClip clip, Action<AudioSource> modifier, bool reverse, float delay = 0f)
	{
		return Play(clip, modifier, delay, reverse);
	}

	public AudioSource Play(List<AudioClip> clips, Action<AudioSource> modifier, bool canRepeat = true, float delay = 0f, bool reverse = false)
	{
		if (clips == null || clips.Count == 0) return null;
		AudioClip chosen = clips[UnityEngine.Random.Range(0, clips.Count)];
		if (!canRepeat && clips.Count > 1 && chosen == lastNonRepeatClip)
		{
			for (int i = 0; i < clips.Count; i++)
			{
				if (clips[i] != null && clips[i] != lastNonRepeatClip)
				{
					chosen = clips[i];
					break;
				}
			}
		}
		lastNonRepeatClip = chosen;
		return Play(chosen, modifier, delay, reverse);
	}

	public AudioSource Play(AudioClip clip, Action<AudioSource> modifier, float delay = 0f, bool reverse = false)
	{
		if (clip == null) return null;
		if (OnPrePlay != null) clip = OnPrePlay(clip) ?? clip;
		var src = GetNextAudioSource();
		if (src == null) return null;
		src.clip = clip;
		src.volume = 1f;
		src.pitch = 1f;
		src.spatialBlend = 0f;
		src.loop = false;
		modifier?.Invoke(src);
		if (delay > 0f) src.PlayDelayed(delay);
		else src.Play();
		return src;
	}

	public AudioSource PlaySimple(AudioClip clip, float volume, float pitch, Vector3 position, float maxDistance = 0f, bool disableSpatial = false)
	{
		return Play(clip, s =>
		{
			s.volume = Mathf.Clamp(volume <= 0f ? 1f : volume, 0f, 1.5f);
			s.pitch = Mathf.Clamp(Mathf.Abs(pitch) < 0.05f ? 1f : pitch, 0.25f, 3f);
			s.transform.position = position;
			s.spatialBlend = 0f;
		});
	}

	public AudioSource PlaySimpleDelayed(AudioClip clip, float volume, float pitch, Vector3 position, float delay, float maxDistance = 0f)
	{
		return Play(clip, s =>
		{
			s.volume = Mathf.Clamp(volume <= 0f ? 1f : volume, 0f, 1.5f);
			s.pitch = Mathf.Clamp(Mathf.Abs(pitch) < 0.05f ? 1f : pitch, 0.25f, 3f);
			s.transform.position = position;
			s.spatialBlend = 0f;
		}, delay);
	}
}
