using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using UnityEngine;

public class WwiseClipLoader : MonoBehaviour
{
	public Dictionary<AudioClip, int> segmentClips;

	public List<MusicState> loadedStates;

	public List<MusicSegment> loadedTransitions;

	public int maxStatesInMemory;

	public int maxTransitionsInMemory;

	private void Awake()
	{
	}

	private void Update()
	{
	}

	private void LoadFile(MusicTrack.AudioclipInfo audioClipInfo)
	{
	}

	private void UnloadFile(MusicTrack.AudioclipInfo audioClipInfo)
	{
	}

	public bool isMusicStateLoaded(MusicState state)
	{
		return false;
	}

	public bool isSegmentLoaded(MusicSegment segment)
	{
		return false;
	}

	public void LoadState(MusicState state, MusicTransition transition, bool fromLoading, Action onLoaded)
	{
	}

	private Task WaitForLoad(MusicState state, MusicTransition transition, Action onLoaded)
	{
		return null;
	}

	private void LoadTransitionSegment(MusicSegment segment)
	{
	}

	private void UnloadSegment(MusicSegment segment)
	{
	}

	private void UnloadState(MusicState state)
	{
	}
}
