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
	[NonSerialized] public WwiseDocumentInteractiveMusicWorkUnitChildrenListMusicSwitchContainerChildrenListMusicPlaylistContainerChildrenListMusicSegment updateData;
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

	private void EnsureTracks()
	{
		if (tracks == null || tracks.Count == 0)
			tracks = new List<MusicTrack>(GetComponentsInChildren<MusicTrack>(true));
	}

	public void UpdatePlaying()
	{
		EnsureTracks();
		if (tracks == null) return;
		foreach (var t in tracks)
			t?.UpdatePlaying(volume, 1f);
	}

	public double GetEntryToExitLength()
	{
		return exitCue > entryCue ? exitCue - entryCue : GetLength();
	}

	public double GetLength()
	{
		if (length > 0.1) return length;
		EnsureTracks();
		if (tracks != null && tracks.Count > 0 && tracks[0] != null)
			return tracks[0].GetLength();
		return 8.0;
	}

	public double Play(double nextEntryCuePlay, bool playPreEntry, bool playPost, MusicTransition.DestinationSyncTo destinationJumpPositionPreset, double lastEntryCueFromParent, bool parentVolume = false)
	{
		EnsureTracks();
		isPlaying = true;
		var info = new PlayInfo { startTime = nextEntryCuePlay, volume = volume };
		if (tracks != null && tracks.Count > 0)
		{
			tracks[0]?.Play(info);
		}
		return GetLength();
	}

	public void Stop()
	{
		isPlaying = false;
		EnsureTracks();
		if (tracks == null) return;
		foreach (var t in tracks)
			t?.Stop();
	}
}
