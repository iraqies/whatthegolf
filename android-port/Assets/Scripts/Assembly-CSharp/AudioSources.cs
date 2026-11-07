using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x200038B")]
public class AudioSources : MonoBehaviour
{
	[Serializable]
	[Token(Token = "0x200038C")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x3F624", Offset = "0x3F624")]
	private sealed class _003C_003Ec
	{
		[Token(Token = "0x4001380")]
		[FieldOffset(Offset = "0x0")]
		public static readonly _003C_003Ec _003C_003E9;

		[Token(Token = "0x4001381")]
		[FieldOffset(Offset = "0x8")]
		public static Action<AudioSource> _003C_003E9__21_0;

		[Token(Token = "0x4001382")]
		[FieldOffset(Offset = "0x10")]
		public static Action<AudioSource> _003C_003E9__22_0;

		[Token(Token = "0x60010CE")]
		[Address(RVA = "0x1770390", Offset = "0x1770390", VA = "0x1770390")]
		public _003C_003Ec()
		{
		}

		[Token(Token = "0x60010CF")]
		[Address(RVA = "0x1770398", Offset = "0x1770398", VA = "0x1770398")]
		internal void _003CPlay_003Eb__21_0(AudioSource t)
		{
		}

		[Token(Token = "0x60010D0")]
		[Address(RVA = "0x177039C", Offset = "0x177039C", VA = "0x177039C")]
		internal void _003CPlay_003Eb__22_0(AudioSource t)
		{
		}
	}

	[Token(Token = "0x4001372")]
	[FieldOffset(Offset = "0x18")]
	public bool debug;

	[Token(Token = "0x4001373")]
	[FieldOffset(Offset = "0x20")]
	public Func<AudioClip, AudioClip> OnPrePlay;

	[Token(Token = "0x4001374")]
	[FieldOffset(Offset = "0x28")]
	[SerializeField]
	private bool isSpatialVoice;

	[Token(Token = "0x4001375")]
	[FieldOffset(Offset = "0x2C")]
	[SerializeField]
	private int count;

	[Token(Token = "0x4001376")]
	[FieldOffset(Offset = "0x30")]
	[SerializeField]
	private bool warnWhenClipping;

	[Token(Token = "0x4001377")]
	[FieldOffset(Offset = "0x38")]
	[SerializeField]
	private AudioSource audioSourcePrefab;

	[Token(Token = "0x4001378")]
	[FieldOffset(Offset = "0x40")]
	[SerializeField]
	private bool skipIfPlaying;

	[Token(Token = "0x4001379")]
	[FieldOffset(Offset = "0x48")]
	private AudioSource[] audioSources;

	[Token(Token = "0x400137A")]
	[FieldOffset(Offset = "0x50")]
	private int index;

	[Token(Token = "0x400137B")]
	[FieldOffset(Offset = "0x58")]
	private AudioClip lastNonRepeatClip;

	[Token(Token = "0x400137C")]
	[FieldOffset(Offset = "0x60")]
	private AnimationCurve defaultSpatialBlendCurve;

	[Token(Token = "0x400137D")]
	[FieldOffset(Offset = "0x68")]
	private AnimationCurve nonSpatialCurve;

	[Token(Token = "0x400137E")]
	[FieldOffset(Offset = "0x70")]
	private AnimationCurve defaultRolloffCurve;

	[Token(Token = "0x400137F")]
	[FieldOffset(Offset = "0x78")]
	private AnimationCurve nonSpatialRolloffCurve;

	[Token(Token = "0x60010BF")]
	[Address(RVA = "0x150C59C", Offset = "0x150C59C", VA = "0x150C59C")]
	public void PreviewInit(AudioSource prefab, int voices)
	{
	}

	[Token(Token = "0x60010C0")]
	[Address(RVA = "0x150C5A8", Offset = "0x150C5A8", VA = "0x150C5A8")]
	public AudioSource[] GetAudioSources()
	{
		return null;
	}

	[Token(Token = "0x60010C1")]
	[Address(RVA = "0x150C5B0", Offset = "0x150C5B0", VA = "0x150C5B0")]
	public AudioSource GetLastAudioSource()
	{
		return null;
	}

	[Token(Token = "0x60010C2")]
	[Address(RVA = "0x150C604", Offset = "0x150C604", VA = "0x150C604")]
	public void Awake()
	{
	}

	[Token(Token = "0x60010C3")]
	[Address(RVA = "0x150CABC", Offset = "0x150CABC", VA = "0x150CABC")]
	public void ForAll(Action<AudioSource> modifier)
	{
	}

	[Token(Token = "0x60010C4")]
	[Address(RVA = "0x150CB60", Offset = "0x150CB60", VA = "0x150CB60")]
	public AudioSource Play(AudioClip clip)
	{
		return null;
	}

	[Token(Token = "0x60010C5")]
	[Address(RVA = "0x150CD50", Offset = "0x150CD50", VA = "0x150CD50")]
	public AudioSource Play(AudioClip clip, float delay = 0f, bool reverse = false)
	{
		return null;
	}

	[Token(Token = "0x60010C6")]
	[Address(RVA = "0x150CC14", Offset = "0x150CC14", VA = "0x150CC14")]
	public AudioSource Play(List<AudioClip> clips)
	{
		return null;
	}

	[Token(Token = "0x60010C7")]
	[Address(RVA = "0x1509DEC", Offset = "0x1509DEC", VA = "0x1509DEC")]
	public AudioSource Play(List<AudioClip> clips, Action<AudioSource> modifier, bool canRepeat = true, float delay = 0f, bool reverse = false)
	{
		return null;
	}

	[Token(Token = "0x60010C8")]
	[Address(RVA = "0x150D258", Offset = "0x150D258", VA = "0x150D258")]
	public AudioSource GetNextAudioSource()
	{
		return null;
	}

	[Token(Token = "0x60010C9")]
	[Address(RVA = "0x150CE98", Offset = "0x150CE98", VA = "0x150CE98")]
	public AudioSource Play(AudioClip clip, Action<AudioSource> modifier, float delay = 0f, bool reverse = false)
	{
		return null;
	}

	[Token(Token = "0x60010CA")]
	[Address(RVA = "0x150D2AC", Offset = "0x150D2AC", VA = "0x150D2AC")]
	public AudioSource PlaySimple(AudioClip clip, float volume, float pitch, Vector3 position, float maxDistance = 0f, bool disableSpatial = false)
	{
		return null;
	}

	[Token(Token = "0x60010CB")]
	[Address(RVA = "0x150D608", Offset = "0x150D608", VA = "0x150D608")]
	public AudioSource PlaySimpleDelayed(AudioClip clip, float volume, float pitch, Vector3 position, float delay, float maxDistance = 0f)
	{
		return null;
	}

	[Token(Token = "0x60010CC")]
	[Address(RVA = "0x150D87C", Offset = "0x150D87C", VA = "0x150D87C")]
	public AudioSources()
	{
	}
}
