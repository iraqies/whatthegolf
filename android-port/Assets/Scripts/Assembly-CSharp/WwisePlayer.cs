using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public class WwisePlayer : MonoBehaviour
{
	[Serializable]
	public class PreloadData
	{
		public MusicState state;
		public MusicTransition transition;
	}

	public enum MusicTime
	{
		beat = 0,
		bar = 1,
		exitcue = 2
	}

	private bool isVerbose;
	public MusicState currentState;
	public MusicPlaylist currentPlaylist;
	public MusicPlaylist nextPlayList;
	public MusicTransition currentTransition;
	public AudioClip offTheMapShort;
	public AudioClip offTheMapLong;
	public bool isInTransition;
	private Wwise wwise;
	private double minBufferTime = 0.05;
	public bool isDebugStart;
	public static WwisePlayer Instance;
	public WwiseClipLoader clipLoader;
	public bool isChangingState;
	public bool isNextStateFromLoading;
	public MusicTransition nextTransition;
	public List<PreloadData> preloadMusicData;
	private float lastOffTheMapTrigger;
	private MusicState queuedState;
	public MusicTransition ignoreTransitionFadeTransition;

	private void Awake()
	{
		Instance = this;
		if (wwise == null) wwise = GetComponent<Wwise>();
	}

	public void PostTrigger(uint triggerID)
	{
	}

	public void Init(bool startsWithOnboarding, Action OnPreloadDone)
	{
		Instance = this;
		if (wwise == null) wwise = GetComponent<Wwise>();
		OnPreloadDone?.Invoke();
	}

	private IEnumerator Preload(bool startsWithOnboarding, Action OnPreloadDone)
	{
		OnPreloadDone?.Invoke();
		yield break;
	}

	private void Log(string message) { }
	public double GetFutureTime(MusicTime time) => AudioSettings.dspTime + 0.1;
	private double GetNextPossibleDSPTime(double offset = 0.0) => AudioSettings.dspTime + offset;

	public void SetState(uint wwiseState, bool fromLoading, Action onLoaded = null, bool ignoreTransition = false)
	{
		if (wwise == null) wwise = GetComponent<Wwise>();
		if (wwise == null)
		{
			onLoaded?.Invoke();
			return;
		}
		if (wwise.musicStates == null || wwise.musicStates.Count == 0)
			wwise.musicStates = GetComponentsInChildren<MusicState>(true).ToList();

		var target = wwise.musicStates.FirstOrDefault(s => s != null && s.shortID == wwiseState);
		if (target == null && wwise.musicStates.Count > 0)
			target = wwise.musicStates.FirstOrDefault(s => s != null && s.gameObject.name.Contains("Overworld_A")) ?? wwise.musicStates[0];

		if (target != null && target != currentState)
		{
			currentPlaylist?.StopInstant();
			currentState = target;
			currentPlaylist = target.playlist;
			if (currentPlaylist != null)
				StartCoroutine(currentPlaylist.Play(AudioSettings.dspTime, false, MusicTransition.DestinationSyncTo.EntryCue, 0.0, null));
		}
		onLoaded?.Invoke();
	}

	public void SetRTPC(uint rtpc, float value) { }
	public void SetRTPC(uint rtpc, float value, int timeMS) { }
	public float GetRTPC(uint rtcp) => 0f;
	public void ResetRTPC(uint rtpc, int timeInMs) { }
	private void PlayTransition(double entryCue, MusicTransition transition, Action<double, double> OnSetNext) { }
	private void State_OnPlay(MusicState state, bool fromLoading, Action onLoaded, bool ignoreTransition) { }
	private IEnumerator ChangeStateRoutine() { yield break; }
	private MusicTransition GetTransitionFromPlaylists(MusicPlaylist source, MusicPlaylist destination, bool ignoreTransition) => null;
}
