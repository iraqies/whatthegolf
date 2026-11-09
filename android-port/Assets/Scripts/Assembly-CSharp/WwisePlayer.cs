using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WwisePlayer : MonoBehaviour
{
	[Serializable]
	public class LevelSong : ISerializationCallbackReceiver
	{
		public string wwiseState;
		[HideInInspector] public uint wwiseStateID;
		public AudioClip clip;
		[Range(0f, 1f)] public float volume = 1f;
		[Range(0f, 20f)] public float fadeIn;
		[Range(0f, 20f)] public float fadeOut;
		public bool ignoreFirstPlayCall;
		public bool customLoop;
		public float loopPointSeconds;
		public float startSkipSeconds;
		public AudioClip stingerClip;
		[Range(0f, 1f)] public float stingerVolume = 1f;
		[HideInInspector] public int playCalls;
		[HideInInspector] public float lastPosition;

		public void OnBeforeSerialize() { }
		public void OnAfterDeserialize()
		{
			if (!string.IsNullOrEmpty(wwiseState))
				wwiseStateID = AkSoundEngine.GetIDFromString(wwiseState);
		}
	}

	private static WwisePlayer instance;
	public AudioClip offTheMapShort;
	public AudioClip offTheMapLong;
	private float lastOffTheMapTrigger = -10f;
	public List<LevelSong> songs;
	private Dictionary<uint, LevelSong> songDict;
	private AudioSource[] sources;
	private int currentSource;
	private LevelSong currentSong;
	private Coroutine switchSongR;
	private uint currentMusicState;
	private float currentFadeFactor = 1f;
	private float currentRTPCFactor = 1f;
	private float userVolume = 1f;
	private float fadeBeforeEndingTime = 4f;
	private Coroutine customLoopR;
	private Coroutine fadeOutBeforeClipEndR;

	public static WwisePlayer Instance => instance ?? (instance = FindObjectOfType<WwisePlayer>());
	public AudioSource CurrentSource => (sources != null && currentSource >= 0 && currentSource < sources.Length) ? sources[currentSource] : null;
	private AudioSource OtherSource => (sources != null && sources.Length > 1) ? sources[1 - (currentSource % 2)] : CurrentSource;

	private void OnEnable()
	{
		instance = this;
		sources = GetComponents<AudioSource>();
		if (sources == null || sources.Length == 0)
			sources = GetComponentsInChildren<AudioSource>();
		if (songDict == null && songs != null)
		{
			songDict = new Dictionary<uint, LevelSong>();
			foreach (var s in songs)
			{
				if (s == null) continue;
				if (s.wwiseStateID == 0 && !string.IsNullOrEmpty(s.wwiseState))
					s.wwiseStateID = AkSoundEngine.GetIDFromString(s.wwiseState);
				if (s.wwiseStateID != 0 && !songDict.ContainsKey(s.wwiseStateID))
					songDict[s.wwiseStateID] = s;
			}
		}
	}

	private void Update()
	{
		if (CurrentSource != null && currentSong != null)
		{
			CurrentSource.volume = currentSong.volume * currentFadeFactor * currentRTPCFactor * userVolume;
		}
	}

	public void PostEvent(string eventName)
	{
		if (string.IsNullOrEmpty(eventName)) return;
		PostEvent(AkSoundEngine.GetIDFromString(eventName));
	}

	public void PostEvent(uint eventID)
	{
		if (eventID == 4258653052u)
		{
			if (CurrentSource != null) CurrentSource.Stop();
			if (OtherSource != null) OtherSource.Stop();
			return;
		}
		if (eventID == AK.TRIGGERS.OFF_THE_MAP_LONG || eventID == AK.TRIGGERS.OFF_THE_MAP_SHORT)
		{
			PostTrigger(eventID);
			return;
		}
		SetState(0u, eventID);
	}

	public void PostTrigger(string triggerName)
	{
		if (string.IsNullOrEmpty(triggerName)) return;
		PostTrigger(AkSoundEngine.GetIDFromString(triggerName));
	}

	public void PostTrigger(uint triggerID)
	{
		if (triggerID == AK.TRIGGERS.OFF_THE_MAP_LONG || triggerID == 0xB00A1A9Cu)
		{
			if (offTheMapLong != null && AudioManager.Instance != null && AudioManager.Instance.uiEffects != null)
			{
				AudioManager.Instance.uiEffects.PlaySimple(offTheMapLong, 0.5f, 1f, Vector3.zero);
			}
		}
		else if (triggerID == AK.TRIGGERS.OFF_THE_MAP_SHORT || triggerID == 0x0C410B24u)
		{
			if (Time.unscaledTime > lastOffTheMapTrigger + 0.35f)
			{
				if (offTheMapShort != null && AudioManager.Instance != null)
				{
					var pool = AudioManager.Instance.uiEffects ?? AudioManager.Instance.shortEffects;
					if (pool != null)
						pool.PlaySimple(offTheMapShort, 0.65f, 1f, Vector3.zero);
				}
				lastOffTheMapTrigger = Time.unscaledTime;
			}
		}
	}

	public void SetRTPC(string rtpcName, float value)
	{
		if (!string.IsNullOrEmpty(rtpcName))
			SetRTPC(AkSoundEngine.GetIDFromString(rtpcName), value);
	}

	public void SetRTPC(uint rtpcID, float value)
	{
		if (rtpcID == 3695994288u)
		{
			currentRTPCFactor = Mathf.Clamp01(value / 100f);
		}
	}

	public void ResetRTPC(string rtpcName, float time = 0f)
	{
		if (!string.IsNullOrEmpty(rtpcName))
			ResetRTPC(AkSoundEngine.GetIDFromString(rtpcName), time);
	}

	public void ResetRTPC(uint rtpcID, float time = 0f)
	{
		if (rtpcID == 3695994288u)
		{
			currentRTPCFactor = 1f;
		}
	}

	public void SetState(string stateGroup, string state)
	{
		uint g = string.IsNullOrEmpty(stateGroup) ? 0u : AkSoundEngine.GetIDFromString(stateGroup);
		uint s = string.IsNullOrEmpty(state) ? 0u : AkSoundEngine.GetIDFromString(state);
		SetState(g, s);
	}

	public void SetState(uint stateGroup, uint state)
	{
		if (state == 0) return;
		OnEnable();
		LevelSong target = null;
		if (songDict != null)
			songDict.TryGetValue(state, out target);
		if (target == null && songs != null)
		{
			foreach (var s in songs)
			{
				if (s != null && (s.wwiseStateID == state || (!string.IsNullOrEmpty(s.wwiseState) && AkSoundEngine.GetIDFromString(s.wwiseState) == state)))
				{
					target = s;
					break;
				}
			}
		}
		if (target == null || target.clip == null) return;
		if (currentSong == target && CurrentSource != null && CurrentSource.isPlaying) return;
		currentMusicState = state;
		currentSong = target;
		var src = CurrentSource;
		if (src != null)
		{
			src.clip = target.clip;
			src.volume = target.volume * userVolume;
			src.loop = true;
			src.Play();
		}
	}

	private IEnumerator SwitchSong(LevelSong nextSong)
	{
		yield break;
	}

	private IEnumerator CustomLoop(LevelSong song, AudioSource src)
	{
		yield break;
	}

	private IEnumerator FadeOutBeforeClipEnd(LevelSong song, AudioSource src)
	{
		yield break;
	}

	private void OnDisable()
	{
	}
}
