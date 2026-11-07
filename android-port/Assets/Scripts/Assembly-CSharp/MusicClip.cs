using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.AddressableAssets;

[Token(Token = "0x2000D25")]
public class MusicClip : MonoBehaviour
{
	[Token(Token = "0x2000D26")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x44750", Offset = "0x44750")]
	private sealed class _003CEnvelope_003Ed__30 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x400475D")]
		[FieldOffset(Offset = "0x10")]
		private int _003C_003E1__state;

		[Token(Token = "0x400475E")]
		[FieldOffset(Offset = "0x18")]
		private object _003C_003E2__current;

		[Token(Token = "0x400475F")]
		[FieldOffset(Offset = "0x20")]
		public double startClipTime;

		[Token(Token = "0x4004760")]
		[FieldOffset(Offset = "0x28")]
		public double start;

		[Token(Token = "0x4004761")]
		[FieldOffset(Offset = "0x30")]
		public MusicClip _003C_003E4__this;

		[Token(Token = "0x4004762")]
		[FieldOffset(Offset = "0x38")]
		public double endClipTime;

		[Token(Token = "0x4004763")]
		[FieldOffset(Offset = "0x40")]
		public double end;

		[Token(Token = "0x4004764")]
		[FieldOffset(Offset = "0x48")]
		public Action OnComplete;

		[Token(Token = "0x4004765")]
		[FieldOffset(Offset = "0x50")]
		private int _003CstartClipSample_003E5__2;

		[Token(Token = "0x4004766")]
		[FieldOffset(Offset = "0x54")]
		private float _003CstartClipTimeF_003E5__3;

		[Token(Token = "0x4004767")]
		[FieldOffset(Offset = "0x58")]
		private float _003Clength_003E5__4;

		[Token(Token = "0x4004768")]
		[FieldOffset(Offset = "0x60")]
		private AudioSource _003Csrc_003E5__5;

		[Token(Token = "0x4004769")]
		[FieldOffset(Offset = "0x68")]
		private float _003CclipTime_003E5__6;

		[Token(Token = "0x400476A")]
		[FieldOffset(Offset = "0x6C")]
		private float _003CtargetVolume_003E5__7;

		[Token(Token = "0x17000659")]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002ECurrent
		{
			[Token(Token = "0x6003E15")]
			[Address(RVA = "0x1804738", Offset = "0x1804738", VA = "0x1804738", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002Eget_Current();
			}
		}

		[Token(Token = "0x1700065A")]
		private object System_002ECollections_002EIEnumerator_002ECurrent
		{
			[Token(Token = "0x6003E17")]
			[Address(RVA = "0x1804780", Offset = "0x1804780", VA = "0x1804780", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return System_002ECollections_002EIEnumerator_002Eget_Current();
			}
		}

		[Token(Token = "0x6003E12")]
		[Address(RVA = "0x1804170", Offset = "0x1804170", VA = "0x1804170")]
		[DebuggerHidden]
		public _003CEnvelope_003Ed__30(int _003C_003E1__state)
		{
		}

		[Token(Token = "0x6003E13")]
		[Address(RVA = "0x180419C", Offset = "0x180419C", VA = "0x180419C", Slot = "5")]
		[DebuggerHidden]
		private void System_002EIDisposable_002EDispose()
		{
		}

		[Token(Token = "0x6003E14")]
		[Address(RVA = "0x18041A0", Offset = "0x18041A0", VA = "0x18041A0", Slot = "6")]
		private bool MoveNext()
		{
			return default;
		}

		[Token(Token = "0x6003E15")]
		[Address(RVA = "0x1804738", Offset = "0x1804738", VA = "0x1804738", Slot = "4")]
		[DebuggerHidden]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002Eget_Current()
		{
			return null;
		}

		[Token(Token = "0x6003E16")]
		[Address(RVA = "0x1804740", Offset = "0x1804740", VA = "0x1804740", Slot = "8")]
		[DebuggerHidden]
		private void System_002ECollections_002EIEnumerator_002EReset()
		{
		}

		[Token(Token = "0x6003E17")]
		[Address(RVA = "0x1804780", Offset = "0x1804780", VA = "0x1804780", Slot = "7")]
		[DebuggerHidden]
		private object System_002ECollections_002EIEnumerator_002Eget_Current()
		{
			return null;
		}
	}

	[Token(Token = "0x4004747")]
	[FieldOffset(Offset = "0x18")]
	public string id;

	[Token(Token = "0x4004748")]
	[FieldOffset(Offset = "0x20")]
	public AudioClip clip;

	[Token(Token = "0x4004749")]
	[FieldOffset(Offset = "0x28")]
	public AssetReference clipRefs;

	[Token(Token = "0x400474A")]
	[FieldOffset(Offset = "0x30")]
	public double EndTrimOffset;

	[Token(Token = "0x400474B")]
	[FieldOffset(Offset = "0x38")]
	public double FadeInDuration;

	[Token(Token = "0x400474C")]
	[FieldOffset(Offset = "0x40")]
	public int FadeOutMode;

	[Token(Token = "0x400474D")]
	[FieldOffset(Offset = "0x44")]
	public int FadeInMode;

	[Token(Token = "0x400474E")]
	[FieldOffset(Offset = "0x48")]
	public double FadeOutDuration;

	[Token(Token = "0x400474F")]
	[FieldOffset(Offset = "0x50")]
	public double BeginTrimOffset;

	[Token(Token = "0x4004750")]
	[FieldOffset(Offset = "0x58")]
	public double PlayAt;

	[Token(Token = "0x4004751")]
	[FieldOffset(Offset = "0x60")]
	public WwiseAudioSources wSources;

	[Token(Token = "0x4004752")]
	[FieldOffset(Offset = "0x68")]
	public WwiseAudioSources.SourceInfo source;

	[Token(Token = "0x4004753")]
	[FieldOffset(Offset = "0x70")]
	public bool debug;

	[Token(Token = "0x4004754")]
	[FieldOffset(Offset = "0x74")]
	public float playVolume;

	[Token(Token = "0x4004755")]
	[FieldOffset(Offset = "0x78")]
	public float currentVolume;

	[Token(Token = "0x4004756")]
	[FieldOffset(Offset = "0x7C")]
	public float unityVolume;

	[Token(Token = "0x4004757")]
	[FieldOffset(Offset = "0x80")]
	public float fadeVolume;

	[Token(Token = "0x4004758")]
	[FieldOffset(Offset = "0x84")]
	public float currentTime;

	[Token(Token = "0x4004759")]
	[FieldOffset(Offset = "0x88")]
	private Coroutine envelope;

	[Token(Token = "0x400475A")]
	[FieldOffset(Offset = "0x90")]
	public int priority;

	[Token(Token = "0x400475B")]
	[FieldOffset(Offset = "0x94")]
	public bool isStopping;

	[Token(Token = "0x400475C")]
	[FieldOffset(Offset = "0x98")]
	private float lastVolume;

	[Token(Token = "0x6003E07")]
	[Address(RVA = "0x1585718", Offset = "0x1585718", VA = "0x1585718")]
	public void Play(MusicSegment.PlayInfo info)
	{
	}

	[Token(Token = "0x6003E08")]
	[Address(RVA = "0x158596C", Offset = "0x158596C", VA = "0x158596C")]
	public void SourceWasTaken()
	{
	}

	[Token(Token = "0x6003E09")]
	[Address(RVA = "0x1585AD0", Offset = "0x1585AD0", VA = "0x1585AD0")]
	public bool IsPlaying()
	{
		return default;
	}

	[Token(Token = "0x6003E0A")]
	[Address(RVA = "0x1585BC8", Offset = "0x1585BC8", VA = "0x1585BC8")]
	public void StartStop()
	{
	}

	[Token(Token = "0x6003E0B")]
	[Address(RVA = "0x1585970", Offset = "0x1585970", VA = "0x1585970")]
	public void Stop()
	{
	}

	[Token(Token = "0x6003E0C")]
	[Address(RVA = "0x1585CC4", Offset = "0x1585CC4", VA = "0x1585CC4")]
	public float dbToUnityVolume(float db)
	{
		return default;
	}

	[Token(Token = "0x6003E0D")]
	[Address(RVA = "0x1585CD0", Offset = "0x1585CD0", VA = "0x1585CD0")]
	public float UpdatePlaying(float parentVolume, float parentFadeVolume)
	{
		return default;
	}

	[Token(Token = "0x6003E0E")]
	[Address(RVA = "0x1585E74", Offset = "0x1585E74", VA = "0x1585E74")]
	public double GetLength()
	{
		return default;
	}

	[Token(Token = "0x6003E0F")]
	[Address(RVA = "0x15858C8", Offset = "0x15858C8", VA = "0x15858C8")]
	private IEnumerator Envelope(double start, double end, double startClipTime, double endClipTime, Action OnComplete)
	{
		return null;
	}

	[Token(Token = "0x6003E10")]
	[Address(RVA = "0x1585E90", Offset = "0x1585E90", VA = "0x1585E90")]
	public MusicClip()
	{
	}

	[Token(Token = "0x6003E11")]
	[Address(RVA = "0x1585E98", Offset = "0x1585E98", VA = "0x1585E98")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6C328", Offset = "0x6C328")]
	private void _003CPlay_003Eb__21_0()
	{
	}
}
