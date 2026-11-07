using System;
using System.Collections.Generic;
using UnityEngine;
using WwiseData;
using WwiseInteractiveMusicHierarchyData;

[Serializable]
public class MusicTransition : MonoBehaviour
{
	public enum contextType
	{
		Any = 0,
		Nothing = 1,
		Object = 2
	}

	public enum DestinationSyncTo
	{
		EntryCue = 0,
		SameTime = 1,
		RandomCue = 2,
		RandomCustomCue = 3,
		LastExitPosition = 4
	}

	[Serializable]
	public class FadeInfo
	{
		public double fadeTime;

		public double fadeOffset;
	}

	[NonSerialized]
	public MusicTransitionElement data;

	[NonSerialized]
	public WwiseDocumentInteractiveMusicWorkUnitChildrenListMusicSwitchContainerTransitionListMusicTransitionMusicTransition updateData;

	public bool isEmpty;

	public string transName;

	public MusicPlaylist sourcePlaylist;

	public MusicPlaylist destinationPlaylist;

	public string sourcePlaylistName;

	public string destinationPlaylistName;

	public Wwise.exitType ExitSourceAt;

	public bool PlaySourcePostExit;

	public bool EnableSourceFadeOut;

	public FadeInfo SourceFadeOut;

	public bool PlayDestinationPreEntry;

	public bool EnableDestinationFadeIn;

	public FadeInfo DestinationFadeIn;

	public MusicSegment TransitionObjectRef;

	public bool EnableTransitionFadeIn;

	public bool EnableTransitionFadeOut;

	public bool PlayTransitionPostExit;

	public bool PlayTransitionPreEntry;

	public contextType DestinationContextType;

	public contextType SourceContextType;

	public DestinationSyncTo DestinationJumpPositionPreset;

	public bool UseTransitionObject;

	public void Init(MusicTransitionElement trans, List<MusicPlaylist> playlists)
	{
	}

	public void Init(WwiseDocumentInteractiveMusicWorkUnitChildrenListMusicSwitchContainerTransitionListMusicTransitionMusicTransition trans, List<MusicPlaylist> playlists)
	{
	}

	private bool ParseFadeInfo(FadeInfo fadeInfo, MusicCuePropertyList list)
	{
		return false;
	}

	private bool ParseFadeInfo(FadeInfo fadeInfo, WwiseDocumentInteractiveMusicWorkUnitChildrenListMusicSwitchContainerTransitionListMusicTransitionMusicTransitionTransitionInfoSourceFadeOutMusicFadeProperty[] list)
	{
		return false;
	}

	private MusicPlaylist refToPlayList(string reference, List<MusicPlaylist> playlists)
	{
		return null;
	}

	private MusicSegment refToSegment(string reference, List<MusicPlaylist> playlists)
	{
		return null;
	}

	private void ParseReference(ReferenceElement reference, List<MusicPlaylist> playlists)
	{
	}

	private void ParseReference(WwiseDocumentInteractiveMusicWorkUnitChildrenListMusicSwitchContainerTransitionListMusicTransitionMusicTransitionReferenceListReference reference, List<MusicPlaylist> playlists)
	{
	}
}
