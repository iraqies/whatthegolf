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

	private double minBufferTime;

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

	public void PostTrigger(uint triggerID)
	{
	}

	public void Init(bool startsWithOnboarding, Action OnPreloadDone)
	{
	}

	private IEnumerator Preload(bool startsWithOnboarding, Action OnPreloadDone)
	{
		return null;
	}

	private void Log(string message)
	{
	}

	public double GetFutureTime(MusicTime time)
	{
		return 0.0;
	}

	private double GetNextPossibleDSPTime(double offset = 0.0)
	{
		return 0.0;
	}

	public void SetState(uint wwiseState, bool fromLoading, Action onLoaded = null, bool ignoreTransition = false)
	{
	}

	public void SetRTPC(uint rtpc, float value)
	{
	}

	public void SetRTPC(uint rtpc, float value, int timeMS)
	{
	}

	public float GetRTPC(uint rtcp)
	{
		return 0f;
	}

	public void ResetRTPC(uint rtpc, int timeInMs)
	{
	}

	private void PlayTransition(double entryCue, MusicTransition transition, Action<double, double> OnSetNext)
	{
	}

	private void State_OnPlay(MusicState state, bool fromLoading, Action onLoaded, bool ignoreTransition)
	{
	}

	private IEnumerator ChangeStateRoutine()
	{
		return null;
	}

	private MusicTransition GetTransitionFromPlaylists(MusicPlaylist source, MusicPlaylist destination, bool ignoreTransition)
	{
		return null;
	}
}
