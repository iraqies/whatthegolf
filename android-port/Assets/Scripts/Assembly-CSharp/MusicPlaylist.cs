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
			return null;
		}

		public void Stop()
		{
		}
	}

	[NonSerialized]
	public MusicPlaylistContainer data;

	[NonSerialized]
	public WwiseDocumentInteractiveMusicWorkUnitChildrenListMusicSwitchContainerChildrenListMusicPlaylistContainer updateData;

	public List<MusicSegment> segments;

	public float volume;

	public float fadeVolume;

	public string id;

	public long shortID;

	public bool overrideTempo;

	public double tempo;

	public LoopTypes loopType;

	public int loopCount;

	public PlaylistState state;

	private double nextExitCue;

	private double lastEntryCue;

	public List<MusicSegmentBuffer> segmentContainers;

	private int segmentIndex;

	public float lastStart;

	public bool debug;

	private Coroutine fadeInRoutine;

	public double GetNextEntryCue()
	{
		return 0.0;
	}

	public double GetLastEntryCue()
	{
		return 0.0;
	}

	public void StopInstant()
	{
	}

	public IEnumerator StopFast(float time)
	{
		return null;
	}

	public IEnumerator Stop(double endtime, double fadeOutTime)
	{
		return null;
	}

	private IEnumerator FadeIn(MusicTransition.FadeInfo info, double entryCueDSPtime)
	{
		return null;
	}

	public IEnumerator Play(double entryCue, bool playPreEntry, MusicTransition.DestinationSyncTo destinationJumpPositionPreset, double lastEntryCueFromParent, MusicTransition.FadeInfo fade)
	{
		return null;
	}

	private MusicSegment GetNextSegment(bool increment)
	{
		return null;
	}

	public double GetNextBeat(double min)
	{
		return 0.0;
	}

	public double GetNextExitCueInDSP(double min)
	{
		return 0.0;
	}

	public double GetNextBar(double min)
	{
		return 0.0;
	}

	public void UpdatePlaying()
	{
	}
}
