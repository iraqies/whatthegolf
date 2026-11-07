using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;
using WwiseData;
using WwiseInteractiveMusicHierarchyData;

[Serializable]
[Token(Token = "0x2000D2F")]
public class MusicSegment : MonoBehaviour
{
	[Token(Token = "0x2000D30")]
	public class PlayInfo
	{
		[Token(Token = "0x40047B8")]
		[FieldOffset(Offset = "0x10")]
		public double startTrackTime;

		[Token(Token = "0x40047B9")]
		[FieldOffset(Offset = "0x18")]
		public double endTrackTime;

		[Token(Token = "0x40047BA")]
		[FieldOffset(Offset = "0x20")]
		public double startOffset;

		[Token(Token = "0x40047BB")]
		[FieldOffset(Offset = "0x28")]
		public double startTime;

		[Token(Token = "0x40047BC")]
		[FieldOffset(Offset = "0x30")]
		public float volume;

		[Token(Token = "0x6003E47")]
		[Address(RVA = "0x180649C", Offset = "0x180649C", VA = "0x180649C")]
		public PlayInfo()
		{
		}
	}

	[Serializable]
	[Token(Token = "0x2000D31")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x447A0", Offset = "0x447A0")]
	private sealed class _003C_003Ec
	{
		[Token(Token = "0x40047BD")]
		[FieldOffset(Offset = "0x0")]
		public static readonly _003C_003Ec _003C_003E9;

		[Token(Token = "0x40047BE")]
		[FieldOffset(Offset = "0x8")]
		public static Func<MusicTrack, double> _003C_003E9__22_0;

		[Token(Token = "0x6003E49")]
		[Address(RVA = "0x1806478", Offset = "0x1806478", VA = "0x1806478")]
		public _003C_003Ec()
		{
		}

		[Token(Token = "0x6003E4A")]
		[Address(RVA = "0x1806480", Offset = "0x1806480", VA = "0x1806480")]
		internal double _003CGetLength_003Eb__22_0(MusicTrack t)
		{
			return default;
		}
	}

	[Token(Token = "0x40047A4")]
	[FieldOffset(Offset = "0x18")]
	public PurpleMusicSegment data;

	[Token(Token = "0x40047A5")]
	[FieldOffset(Offset = "0x20")]
	public FluffyMusicSegment dataOther;

	[NonSerialized]
	[Token(Token = "0x40047A6")]
	[FieldOffset(Offset = "0x28")]
	public WwiseDocumentInteractiveMusicWorkUnitChildrenListMusicSwitchContainerChildrenListMusicPlaylistContainerChildrenListMusicSegment updateData;

	[Token(Token = "0x40047A7")]
	[FieldOffset(Offset = "0x30")]
	public List<MusicTrack> tracks;

	[Token(Token = "0x40047A8")]
	[FieldOffset(Offset = "0x38")]
	public string id;

	[Token(Token = "0x40047A9")]
	[FieldOffset(Offset = "0x40")]
	public float volume;

	[Token(Token = "0x40047AA")]
	[FieldOffset(Offset = "0x44")]
	public bool hasExitCue;

	[Token(Token = "0x40047AB")]
	[FieldOffset(Offset = "0x48")]
	public double exitCue;

	[Token(Token = "0x40047AC")]
	[FieldOffset(Offset = "0x50")]
	public bool hasEntryCue;

	[Token(Token = "0x40047AD")]
	[FieldOffset(Offset = "0x58")]
	public double entryCue;

	[Token(Token = "0x40047AE")]
	[FieldOffset(Offset = "0x60")]
	public double length;

	[Token(Token = "0x40047AF")]
	[FieldOffset(Offset = "0x68")]
	public bool overrideTempo;

	[Token(Token = "0x40047B0")]
	[FieldOffset(Offset = "0x70")]
	public double tempo;

	[Token(Token = "0x40047B1")]
	[FieldOffset(Offset = "0x78")]
	public List<double> cues;

	[Token(Token = "0x40047B2")]
	[FieldOffset(Offset = "0x80")]
	public double lastEntryCue;

	[Token(Token = "0x40047B3")]
	[FieldOffset(Offset = "0x88")]
	public double lastExitCue;

	[Token(Token = "0x40047B4")]
	[FieldOffset(Offset = "0x90")]
	public double currentTime;

	[Token(Token = "0x40047B5")]
	[FieldOffset(Offset = "0x98")]
	public bool ignoreParentVolumeFade;

	[Token(Token = "0x40047B6")]
	[FieldOffset(Offset = "0x99")]
	public bool isPlaying;

	[Token(Token = "0x40047B7")]
	[FieldOffset(Offset = "0xA0")]
	public MusicPlaylist parentPlaylist;

	[Token(Token = "0x6003E41")]
	[Address(RVA = "0x158882C", Offset = "0x158882C", VA = "0x158882C")]
	public void UpdatePlaying()
	{
	}

	[Token(Token = "0x6003E42")]
	[Address(RVA = "0x15887A0", Offset = "0x15887A0", VA = "0x15887A0")]
	public double GetEntryToExitLength()
	{
		return default;
	}

	[Token(Token = "0x6003E43")]
	[Address(RVA = "0x1588BD8", Offset = "0x1588BD8", VA = "0x1588BD8")]
	public double GetLength()
	{
		return default;
	}

	[Token(Token = "0x6003E44")]
	[Address(RVA = "0x1588D0C", Offset = "0x1588D0C", VA = "0x1588D0C")]
	public double Play(double nextEntryCuePlay, bool playPreEntry, bool playPost, MusicTransition.DestinationSyncTo destinationJumpPositionPreset, double lastEntryCueFromParent, bool parentVolume = false)
	{
		return default;
	}

	[Token(Token = "0x6003E45")]
	[Address(RVA = "0x15890D4", Offset = "0x15890D4", VA = "0x15890D4")]
	public void Stop()
	{
	}

	[Token(Token = "0x6003E46")]
	[Address(RVA = "0x158936C", Offset = "0x158936C", VA = "0x158936C")]
	public MusicSegment()
	{
	}
}
