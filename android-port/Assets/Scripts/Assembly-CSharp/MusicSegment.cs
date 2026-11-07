using System;
using System.Collections.Generic;
using UnityEngine;
using WwiseData;
using WwiseInteractiveMusicHierarchyData;

[Serializable]
public class MusicSegment : MonoBehaviour
{
	public class PlayInfo
	{
		public double startTrackTime;

		public double endTrackTime;

		public double startOffset;

		public double startTime;

		public float volume;
	}

	public PurpleMusicSegment data;

	public FluffyMusicSegment dataOther;

	[NonSerialized]
	public WwiseDocumentInteractiveMusicWorkUnitChildrenListMusicSwitchContainerChildrenListMusicPlaylistContainerChildrenListMusicSegment updateData;

	public List<MusicTrack> tracks;

	public string id;

	public float volume;

	public bool hasExitCue;

	public double exitCue;

	public bool hasEntryCue;

	public double entryCue;

	public double length;

	public bool overrideTempo;

	public double tempo;

	public List<double> cues;

	public double lastEntryCue;

	public double lastExitCue;

	public double currentTime;

	public bool ignoreParentVolumeFade;

	public bool isPlaying;

	public MusicPlaylist parentPlaylist;

	public void UpdatePlaying()
	{
	}

	public double GetEntryToExitLength()
	{
		return 0.0;
	}

	public double GetLength()
	{
		return 0.0;
	}

	public double Play(double nextEntryCuePlay, bool playPreEntry, bool playPost, MusicTransition.DestinationSyncTo destinationJumpPositionPreset, double lastEntryCueFromParent, bool parentVolume = false)
	{
		return 0.0;
	}

	public void Stop()
	{
	}
}
