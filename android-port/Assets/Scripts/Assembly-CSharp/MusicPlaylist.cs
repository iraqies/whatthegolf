using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using WwiseData;
using WwiseInteractiveMusicHierarchyData;

[Serializable]
public class MusicPlaylist : MonoBehaviour
{
	public enum LoopTypes
	{
		sequenceContinues = 0,
		randomContinues = 1,
		randomStep = 2
	}

	public enum PlaylistState
	{
		playing = 0,
		stopping = 1,
		none = 2
	}

	[Serializable]
	public class MusicSegmentBuffer
	{
		public int nextIndex;
		public List<MusicSegment> segments;

		public MusicSegment GetSegment(bool increment)
		{
			if (segments == null || segments.Count == 0) return null;
			var s = segments[nextIndex % segments.Count];
			if (increment) nextIndex = (nextIndex + 1) % segments.Count;
			return s;
		}

		public void Stop()
		{
			if (segments == null) return;
			foreach (var s in segments) s?.Stop();
		}
	}

	[NonSerialized] public MusicPlaylistContainer data;
	[NonSerialized] public WwiseDocumentInteractiveMusicWorkUnitChildrenListMusicSwitchContainerChildrenListMusicPlaylistContainer updateData;
	public List<MusicSegment> segments;
	public float volume;
	public float fadeVolume = 1f;
	public string id;
	public long shortID;
	public bool overrideTempo;
	public double tempo;
	public LoopTypes loopType;
	public int loopCount;
	public PlaylistState state = PlaylistState.none;
	private double nextExitCue;
	private double lastEntryCue;
	public List<MusicSegmentBuffer> segmentContainers;
	private int segmentIndex;
	public float lastStart;
	public bool debug;
	private Coroutine fadeInRoutine;

	private void EnsureSegments()
	{
		if (segments == null || segments.Count == 0)
			segments = new List<MusicSegment>(GetComponentsInChildren<MusicSegment>(true));
	}

	public double GetNextEntryCue() => lastEntryCue;
	public double GetLastEntryCue() => lastEntryCue;

	public void StopInstant()
	{
		state = PlaylistState.none;
		EnsureSegments();
		if (segments != null)
		{
			foreach (var s in segments) s?.Stop();
		}
		if (segmentContainers != null)
		{
			foreach (var sc in segmentContainers) sc?.Stop();
		}
	}

	public IEnumerator StopFast(float time)
	{
		StopInstant();
		yield break;
	}

	public IEnumerator Stop(double endtime, double fadeOutTime)
	{
		StopInstant();
		yield break;
	}

	private IEnumerator FadeIn(MusicTransition.FadeInfo info, double entryCueDSPtime)
	{
		fadeVolume = 1f;
		yield break;
	}

	public IEnumerator Play(double entryCue, bool playPreEntry, MusicTransition.DestinationSyncTo destinationJumpPositionPreset, double lastEntryCueFromParent, MusicTransition.FadeInfo fade)
	{
		state = PlaylistState.playing;
		var seg = GetNextSegment(true);
		if (seg != null)
		{
			seg.Play(entryCue, playPreEntry, true, destinationJumpPositionPreset, lastEntryCueFromParent);
		}
		yield break;
	}

	private MusicSegment GetNextSegment(bool increment)
	{
		EnsureSegments();
		if (segments != null && segments.Count > 0)
		{
			var s = segments[segmentIndex % segments.Count];
			if (increment) segmentIndex = (segmentIndex + 1) % segments.Count;
			return s;
		}
		if (segmentContainers != null && segmentContainers.Count > 0)
			return segmentContainers[0]?.GetSegment(increment);
		return null;
	}

	public double GetNextBeat(double min) => AudioSettings.dspTime + 0.1;
	public double GetNextExitCueInDSP(double min) => AudioSettings.dspTime + 0.1;
	public double GetNextBar(double min) => AudioSettings.dspTime + 0.1;

	public void UpdatePlaying()
	{
		EnsureSegments();
		if (segments != null)
		{
			foreach (var s in segments)
				if (s != null && s.isPlaying) s.UpdatePlaying();
		}
	}
}
