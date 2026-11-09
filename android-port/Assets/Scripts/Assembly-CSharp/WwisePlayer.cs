using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WwisePlayer : MonoBehaviour
{
	[Serializable]
	public class PreloadData
	{
		public MusicState state;
		public MusicTransition transition;
	}

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
	public MusicState currentState;
	public MusicPlaylist currentPlaylist;
	public MusicPlaylist nextPlayList;
	public MusicTransition currentTransition;
	public AudioClip offTheMapShort;
	public AudioClip offTheMapLong;
	public bool isInTransition;
	private Wwise wwise;
	private double minBufferTime;
	public bool isDebugStart;
	public WwiseClipLoader clipLoader;
	public bool isChangingState;
	public bool isNextStateFromLoading;
	public MusicTransition nextTransition;
	public List<PreloadData> preloadMusicData;
	private float lastOffTheMapTrigger = -10f;
	private MusicState queuedState;
	public MusicTransition ignoreTransitionFadeTransition;

	public List<LevelSong> songs;
	private Dictionary<uint, LevelSong> songDict;
	private AudioSource[] sources;
	private int currentSource;
	private LevelSong currentSong;
	private uint currentMusicState;
	private float currentFadeFactor = 1f;
	private float currentRTPCFactor = 1f;
	private float userVolume = 1f;
	private Coroutine transitionRoutine;

	public static WwisePlayer Instance => instance ?? (instance = FindObjectOfType<WwisePlayer>());
	public AudioSource CurrentSource
	{
		get
		{
			EnsureSources();
			return (sources != null && currentSource >= 0 && currentSource < sources.Length) ? sources[currentSource] : null;
		}
	}
	private AudioSource OtherSource
	{
		get
		{
			EnsureSources();
			return (sources != null && sources.Length > 1) ? sources[1 - (currentSource % 2)] : CurrentSource;
		}
	}

	private void EnsureSources()
	{
		if (sources != null && sources.Length >= 2 && sources[0] != null && sources[1] != null)
			return;
		var existing = GetComponents<AudioSource>();
		if (existing == null || existing.Length < 2)
		{
			var list = new List<AudioSource>();
			if (existing != null) list.AddRange(existing);
			while (list.Count < 2)
			{
				var s = gameObject.AddComponent<AudioSource>();
				s.playOnAwake = false;
				s.spatialBlend = 0f;
				list.Add(s);
			}
			sources = list.ToArray();
		}
		else
		{
			sources = existing;
		}
		foreach (var s in sources)
		{
			if (s != null)
			{
				s.playOnAwake = false;
				s.spatialBlend = 0f;
			}
		}
	}

	private void EnsureWwise()
	{
		if (wwise == null)
			wwise = GetComponent<Wwise>() ?? GetComponentInParent<Wwise>() ?? FindObjectOfType<Wwise>();
	}

	private void OnEnable()
	{
		instance = this;
		EnsureSources();
		EnsureWwise();
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

	public void Init(bool startsWithOnboarding, Action OnPreloadDone)
	{
		OnEnable();
		OnPreloadDone?.Invoke();
	}

	private void Update()
	{
		if (CurrentSource != null && CurrentSource.isPlaying)
		{
			float baseVol = currentSong != null ? currentSong.volume : 0.7f;
			CurrentSource.volume = baseVol * currentFadeFactor * currentRTPCFactor * userVolume;
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
			if (offTheMapLong != null && AudioManager.Instance != null)
			{
				var pool = AudioManager.Instance.uiEffects ?? AudioManager.Instance.shortEffects;
				pool?.PlaySimple(offTheMapLong, 0.75f, 1f, Vector3.zero);
			}
		}
		else if (triggerID == AK.TRIGGERS.OFF_THE_MAP_SHORT || triggerID == 0x0C410B24u)
		{
			if (Time.unscaledTime > lastOffTheMapTrigger + 0.35f)
			{
				if (offTheMapShort != null && AudioManager.Instance != null)
				{
					var pool = AudioManager.Instance.uiEffects ?? AudioManager.Instance.shortEffects;
					pool?.PlaySimple(offTheMapShort, 0.8f, 1f, Vector3.zero);
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

	private static AudioClip ExtractMainClipFromSegment(MusicSegment seg, bool preferLonger = false)
	{
		if (seg == null) return null;
		var tracks = seg.tracks;
		if (tracks == null || tracks.Count == 0)
			tracks = new List<MusicTrack>(seg.GetComponentsInChildren<MusicTrack>(true));
		AudioClip best = null;
		foreach (var tr in tracks)
		{
			if (tr == null || tr.files == null) continue;
			foreach (var f in tr.files)
			{
				if (f == null || f.clip == null) continue;
				if (!tr.hasRTPCurve)
				{
					if (best == null || (preferLonger && f.clip.length > best.length))
						best = f.clip;
					else if (!preferLonger)
						return f.clip;
				}
				else if (best == null)
				{
					best = f.clip;
				}
			}
		}
		return best;
	}

	private static AudioClip ExtractMainClipFromPlaylist(MusicPlaylist pl)
	{
		if (pl == null) return null;
		if (pl.segments != null)
		{
			foreach (var seg in pl.segments)
			{
				var c = ExtractMainClipFromSegment(seg);
				if (c != null) return c;
			}
		}
		if (pl.segmentContainers != null)
		{
			foreach (var sc in pl.segmentContainers)
			{
				if (sc?.segments == null) continue;
				foreach (var seg in sc.segments)
				{
					var c = ExtractMainClipFromSegment(seg);
					if (c != null) return c;
				}
			}
		}
		var childSegs = pl.GetComponentsInChildren<MusicSegment>(true);
		if (childSegs != null)
		{
			foreach (var seg in childSegs)
			{
				var c = ExtractMainClipFromSegment(seg);
				if (c != null) return c;
			}
		}
		return null;
	}

	private MusicState FindWwiseState(uint state)
	{
		EnsureWwise();
		if (wwise == null || wwise.musicStates == null) return null;
		foreach (var ms in wwise.musicStates)
		{
			if (ms == null) continue;
			if (ms.shortID == state)
				return ms;
			string cleanName = ms.gameObject.name.Replace("State:", "").Trim();
			if (!string.IsNullOrEmpty(cleanName) && AkSoundEngine.GetIDFromString(cleanName) == state)
				return ms;
		}
		return null;
	}

	private AudioClip FindTransitionClip(MusicPlaylist fromPl, MusicPlaylist toPl, uint toStateId, bool ignoreTransition)
	{
		if (ignoreTransition || toPl == null) return null;
		EnsureWwise();
		if (wwise == null || wwise.musicTransitions == null) return null;
		foreach (var tr in wwise.musicTransitions)
		{
			if (tr == null || tr.TransitionObjectRef == null) continue;
			if (tr.destinationPlaylist == toPl)
			{
				if (tr.sourcePlaylist == fromPl || (fromPl == null && toStateId == 1462071333u) || tr.sourcePlaylistName == "Any")
				{
					var c = ExtractMainClipFromSegment(tr.TransitionObjectRef, true);
					if (c != null) return c;
				}
			}
		}
		return null;
	}

	public void SetState(string stateGroup, string state)
	{
		uint g = string.IsNullOrEmpty(stateGroup) ? 0u : AkSoundEngine.GetIDFromString(stateGroup);
		uint s = string.IsNullOrEmpty(state) ? 0u : AkSoundEngine.GetIDFromString(state);
		SetState(g, s);
	}

	public void SetState(uint stateGroup, uint state)
	{
		SetState(state, false, null, false);
	}

	public void SetState(uint state, bool fromLoading, Action onLoaded = null, bool ignoreTransition = false)
	{
		if (state == 0)
		{
			onLoaded?.Invoke();
			return;
		}
		OnEnable();

		var wState = FindWwiseState(state);
		if (wState != null && wState.playlist != null)
		{
			AudioClip mainClip = ExtractMainClipFromPlaylist(wState.playlist);
			AudioClip transClip = FindTransitionClip(currentPlaylist, wState.playlist, state, ignoreTransition);
			currentState = wState;
			currentPlaylist = wState.playlist;
			currentMusicState = state;

			if (mainClip != null)
			{
				var src = CurrentSource;
				if (src != null)
				{
					if (transClip != null && transClip != mainClip && gameObject.activeInHierarchy)
					{
						if (transitionRoutine != null)
							StopCoroutine(transitionRoutine);
						transitionRoutine = StartCoroutine(PlayTransitionThenMainRoutine(src, transClip, mainClip));
					}
					else if (src.clip != mainClip || !src.isPlaying)
					{
						if (transitionRoutine != null)
						{
							StopCoroutine(transitionRoutine);
							transitionRoutine = null;
						}
						src.clip = mainClip;
						src.volume = 0.7f * userVolume;
						src.loop = true;
						src.Play();
					}
				}
			}
			onLoaded?.Invoke();
			return;
		}

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
		if (target != null && target.clip != null)
		{
			if (currentSong != target || CurrentSource == null || !CurrentSource.isPlaying)
			{
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
		}
		onLoaded?.Invoke();
	}

	private IEnumerator PlayTransitionThenMainRoutine(AudioSource src, AudioClip transClip, AudioClip mainClip)
	{
		if (src == null) yield break;
		src.clip = transClip;
		src.volume = 0.75f * userVolume;
		src.loop = false;
		src.Play();
		float wait = Mathf.Max(0.1f, transClip.length - 0.1f);
		yield return new WaitForSecondsRealtime(wait);
		if (src != null && src.clip == transClip)
		{
			src.clip = mainClip;
			src.volume = 0.7f * userVolume;
			src.loop = true;
			src.Play();
		}
		transitionRoutine = null;
	}

	private void OnDisable()
	{
	}
}
