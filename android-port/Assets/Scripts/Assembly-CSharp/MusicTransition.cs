using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;
using WwiseData;
using WwiseInteractiveMusicHierarchyData;

[Serializable]
[Token(Token = "0x2000D36")]
public class MusicTransition : MonoBehaviour
{
	[Token(Token = "0x2000D37")]
	public enum contextType
	{
		[Token(Token = "0x40047F7")]
		Any = 0,
		[Token(Token = "0x40047F8")]
		Nothing = 1,
		[Token(Token = "0x40047F9")]
		Object = 2
	}

	[Token(Token = "0x2000D38")]
	public enum DestinationSyncTo
	{
		[Token(Token = "0x40047FB")]
		EntryCue = 0,
		[Token(Token = "0x40047FC")]
		SameTime = 1,
		[Token(Token = "0x40047FD")]
		RandomCue = 2,
		[Token(Token = "0x40047FE")]
		RandomCustomCue = 3,
		[Token(Token = "0x40047FF")]
		LastExitPosition = 4
	}

	[Serializable]
	[Token(Token = "0x2000D39")]
	public class FadeInfo
	{
		[Token(Token = "0x4004800")]
		[FieldOffset(Offset = "0x10")]
		public double fadeTime;

		[Token(Token = "0x4004801")]
		[FieldOffset(Offset = "0x18")]
		public double fadeOffset;

		[Token(Token = "0x6003E63")]
		[Address(RVA = "0x1806530", Offset = "0x1806530", VA = "0x1806530")]
		public FadeInfo()
		{
		}
	}

	[NonSerialized]
	[Token(Token = "0x40047DE")]
	[FieldOffset(Offset = "0x18")]
	public MusicTransitionElement data;

	[NonSerialized]
	[Token(Token = "0x40047DF")]
	[FieldOffset(Offset = "0x20")]
	public WwiseDocumentInteractiveMusicWorkUnitChildrenListMusicSwitchContainerTransitionListMusicTransitionMusicTransition updateData;

	[Token(Token = "0x40047E0")]
	[FieldOffset(Offset = "0x28")]
	public bool isEmpty;

	[Token(Token = "0x40047E1")]
	[FieldOffset(Offset = "0x30")]
	public string transName;

	[Token(Token = "0x40047E2")]
	[FieldOffset(Offset = "0x38")]
	public MusicPlaylist sourcePlaylist;

	[Token(Token = "0x40047E3")]
	[FieldOffset(Offset = "0x40")]
	public MusicPlaylist destinationPlaylist;

	[Token(Token = "0x40047E4")]
	[FieldOffset(Offset = "0x48")]
	public string sourcePlaylistName;

	[Token(Token = "0x40047E5")]
	[FieldOffset(Offset = "0x50")]
	public string destinationPlaylistName;

	[Token(Token = "0x40047E6")]
	[FieldOffset(Offset = "0x58")]
	public Wwise.exitType ExitSourceAt;

	[Token(Token = "0x40047E7")]
	[FieldOffset(Offset = "0x5C")]
	public bool PlaySourcePostExit;

	[Token(Token = "0x40047E8")]
	[FieldOffset(Offset = "0x5D")]
	public bool EnableSourceFadeOut;

	[Token(Token = "0x40047E9")]
	[FieldOffset(Offset = "0x60")]
	public FadeInfo SourceFadeOut;

	[Token(Token = "0x40047EA")]
	[FieldOffset(Offset = "0x68")]
	public bool PlayDestinationPreEntry;

	[Token(Token = "0x40047EB")]
	[FieldOffset(Offset = "0x69")]
	public bool EnableDestinationFadeIn;

	[Token(Token = "0x40047EC")]
	[FieldOffset(Offset = "0x70")]
	public FadeInfo DestinationFadeIn;

	[Token(Token = "0x40047ED")]
	[FieldOffset(Offset = "0x78")]
	public MusicSegment TransitionObjectRef;

	[Token(Token = "0x40047EE")]
	[FieldOffset(Offset = "0x80")]
	public bool EnableTransitionFadeIn;

	[Token(Token = "0x40047EF")]
	[FieldOffset(Offset = "0x81")]
	public bool EnableTransitionFadeOut;

	[Token(Token = "0x40047F0")]
	[FieldOffset(Offset = "0x82")]
	public bool PlayTransitionPostExit;

	[Token(Token = "0x40047F1")]
	[FieldOffset(Offset = "0x83")]
	public bool PlayTransitionPreEntry;

	[Token(Token = "0x40047F2")]
	[FieldOffset(Offset = "0x84")]
	public contextType DestinationContextType;

	[Token(Token = "0x40047F3")]
	[FieldOffset(Offset = "0x88")]
	public contextType SourceContextType;

	[Token(Token = "0x40047F4")]
	[FieldOffset(Offset = "0x8C")]
	public DestinationSyncTo DestinationJumpPositionPreset;

	[Token(Token = "0x40047F5")]
	[FieldOffset(Offset = "0x90")]
	public bool UseTransitionObject;

	[Token(Token = "0x6003E5A")]
	[Address(RVA = "0x1589814", Offset = "0x1589814", VA = "0x1589814")]
	public void Init(MusicTransitionElement trans, List<MusicPlaylist> playlists)
	{
	}

	[Token(Token = "0x6003E5B")]
	[Address(RVA = "0x158B304", Offset = "0x158B304", VA = "0x158B304")]
	public void Init(WwiseDocumentInteractiveMusicWorkUnitChildrenListMusicSwitchContainerTransitionListMusicTransitionMusicTransition trans, List<MusicPlaylist> playlists)
	{
	}

	[Token(Token = "0x6003E5C")]
	[Address(RVA = "0x158AB1C", Offset = "0x158AB1C", VA = "0x158AB1C")]
	private bool ParseFadeInfo(FadeInfo fadeInfo, MusicCuePropertyList list)
	{
		return default;
	}

	[Token(Token = "0x6003E5D")]
	[Address(RVA = "0x158B920", Offset = "0x158B920", VA = "0x158B920")]
	private bool ParseFadeInfo(FadeInfo fadeInfo, WwiseDocumentInteractiveMusicWorkUnitChildrenListMusicSwitchContainerTransitionListMusicTransitionMusicTransitionTransitionInfoSourceFadeOutMusicFadeProperty[] list)
	{
		return default;
	}

	[Token(Token = "0x6003E5E")]
	[Address(RVA = "0x158BB2C", Offset = "0x158BB2C", VA = "0x158BB2C")]
	private MusicPlaylist refToPlayList(string reference, List<MusicPlaylist> playlists)
	{
		return null;
	}

	[Token(Token = "0x6003E5F")]
	[Address(RVA = "0x158B000", Offset = "0x158B000", VA = "0x158B000")]
	private MusicSegment refToSegment(string reference, List<MusicPlaylist> playlists)
	{
		return null;
	}

	[Token(Token = "0x6003E60")]
	[Address(RVA = "0x158A944", Offset = "0x158A944", VA = "0x158A944")]
	private void ParseReference(ReferenceElement reference, List<MusicPlaylist> playlists)
	{
	}

	[Token(Token = "0x6003E61")]
	[Address(RVA = "0x158B7C8", Offset = "0x158B7C8", VA = "0x158B7C8")]
	private void ParseReference(WwiseDocumentInteractiveMusicWorkUnitChildrenListMusicSwitchContainerTransitionListMusicTransitionMusicTransitionReferenceListReference reference, List<MusicPlaylist> playlists)
	{
	}

	[Token(Token = "0x6003E62")]
	[Address(RVA = "0x158BCD8", Offset = "0x158BCD8", VA = "0x158BCD8")]
	public MusicTransition()
	{
	}
}
