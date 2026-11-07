using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.AddressableAssets;
using UnityEngine.ResourceManagement.AsyncOperations;
using WwiseData;
using WwiseInteractiveMusicHierarchyData;

[Serializable]
[Token(Token = "0x2000D33")]
public class MusicTrack : MonoBehaviour
{
	[Serializable]
	[Token(Token = "0x2000D34")]
	public class AudioclipInfo
	{
		[Token(Token = "0x40047D7")]
		[FieldOffset(Offset = "0x10")]
		public AudioClip clip;

		[Token(Token = "0x40047D8")]
		[FieldOffset(Offset = "0x18")]
		public AssetReference clipAssetReference;

		[Token(Token = "0x40047D9")]
		[FieldOffset(Offset = "0x20")]
		public string id;

		[Token(Token = "0x40047DA")]
		[FieldOffset(Offset = "0x28")]
		public string filename;

		[Token(Token = "0x40047DB")]
		[FieldOffset(Offset = "0x30")]
		public AsyncOperationHandle<AudioClip> asyncOperationHandle;

		[Token(Token = "0x6003E56")]
		[Address(RVA = "0x1806528", Offset = "0x1806528", VA = "0x1806528")]
		public AudioclipInfo()
		{
		}
	}

	[Serializable]
	[Token(Token = "0x2000D35")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x447B0", Offset = "0x447B0")]
	private sealed class _003C_003Ec
	{
		[Token(Token = "0x40047DC")]
		[FieldOffset(Offset = "0x0")]
		public static readonly _003C_003Ec _003C_003E9;

		[Token(Token = "0x40047DD")]
		[FieldOffset(Offset = "0x8")]
		public static Func<MusicClip, double> _003C_003E9__22_0;

		[Token(Token = "0x6003E58")]
		[Address(RVA = "0x1806504", Offset = "0x1806504", VA = "0x1806504")]
		public _003C_003Ec()
		{
		}

		[Token(Token = "0x6003E59")]
		[Address(RVA = "0x180650C", Offset = "0x180650C", VA = "0x180650C")]
		internal double _003CGetLength_003Eb__22_0(MusicClip c)
		{
			return default;
		}
	}

	[Token(Token = "0x40047C5")]
	[FieldOffset(Offset = "0x18")]
	public PurpleMusicTrack data;

	[Token(Token = "0x40047C6")]
	[FieldOffset(Offset = "0x20")]
	public FluffyMusicTrack dataOther;

	[Token(Token = "0x40047C7")]
	[FieldOffset(Offset = "0x28")]
	public WwiseDocumentInteractiveMusicWorkUnitChildrenListMusicSwitchContainerChildrenListMusicPlaylistContainerChildrenListMusicSegmentMusicTrack updateData;

	[Token(Token = "0x40047C8")]
	[FieldOffset(Offset = "0x30")]
	public List<AudioclipInfo> files;

	[Token(Token = "0x40047C9")]
	[FieldOffset(Offset = "0x38")]
	public float volume;

	[Token(Token = "0x40047CA")]
	[FieldOffset(Offset = "0x3C")]
	public bool hasRTPCurve;

	[Token(Token = "0x40047CB")]
	[FieldOffset(Offset = "0x40")]
	public string rtpcName;

	[Token(Token = "0x40047CC")]
	[FieldOffset(Offset = "0x48")]
	public string rtpcRef;

	[Token(Token = "0x40047CD")]
	[FieldOffset(Offset = "0x50")]
	public AnimationCurve rtpcDataCurve;

	[Token(Token = "0x40047CE")]
	[FieldOffset(Offset = "0x58")]
	public Dictionary<string, int> clipCounter;

	[Token(Token = "0x40047CF")]
	[FieldOffset(Offset = "0x60")]
	public bool overrideTempo;

	[Token(Token = "0x40047D0")]
	[FieldOffset(Offset = "0x68")]
	public double tempo;

	[Token(Token = "0x40047D1")]
	[FieldOffset(Offset = "0x70")]
	public double playAt;

	[Token(Token = "0x40047D2")]
	[FieldOffset(Offset = "0x78")]
	public double currentTime;

	[Token(Token = "0x40047D3")]
	[FieldOffset(Offset = "0x80")]
	public List<MusicClip> clips;

	[Token(Token = "0x40047D4")]
	[FieldOffset(Offset = "0x88")]
	public float rtpcValue;

	[Token(Token = "0x40047D5")]
	[FieldOffset(Offset = "0x8C")]
	public float currentVolume;

	[Token(Token = "0x40047D6")]
	[FieldOffset(Offset = "0x90")]
	public float unityVolume;

	[Token(Token = "0x6003E50")]
	[Address(RVA = "0x1589578", Offset = "0x1589578", VA = "0x1589578")]
	public bool IsPlaying()
	{
		return default;
	}

	[Token(Token = "0x6003E51")]
	[Address(RVA = "0x1588A3C", Offset = "0x1588A3C", VA = "0x1588A3C")]
	public void UpdatePlaying(float parentVolume, float parentFadeVolume)
	{
	}

	[Token(Token = "0x6003E52")]
	[Address(RVA = "0x1589220", Offset = "0x1589220", VA = "0x1589220")]
	public void Stop()
	{
	}

	[Token(Token = "0x6003E53")]
	[Address(RVA = "0x15896D8", Offset = "0x15896D8", VA = "0x15896D8")]
	public double GetLength()
	{
		return default;
	}

	[Token(Token = "0x6003E54")]
	[Address(RVA = "0x1588F80", Offset = "0x1588F80", VA = "0x1588F80")]
	public void Play(MusicSegment.PlayInfo info)
	{
	}

	[Token(Token = "0x6003E55")]
	[Address(RVA = "0x158980C", Offset = "0x158980C", VA = "0x158980C")]
	public MusicTrack()
	{
	}
}
