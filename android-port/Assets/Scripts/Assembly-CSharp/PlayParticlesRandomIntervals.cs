using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.Events;

[Token(Token = "0x2000E24")]
public class PlayParticlesRandomIntervals : MonoBehaviour
{
	[Token(Token = "0x2000E25")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x44E98", Offset = "0x44E98")]
	private sealed class _003CPlayingParticles_003Ed__7 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x4004CC6")]
		[FieldOffset(Offset = "0x10")]
		private int _003C_003E1__state;

		[Token(Token = "0x4004CC7")]
		[FieldOffset(Offset = "0x18")]
		private object _003C_003E2__current;

		[Token(Token = "0x4004CC8")]
		[FieldOffset(Offset = "0x20")]
		public PlayParticlesRandomIntervals _003C_003E4__this;

		[Token(Token = "0x170006CE")]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002ECurrent
		{
			[Token(Token = "0x6004261")]
			[Address(RVA = "0x1828CC4", Offset = "0x1828CC4", VA = "0x1828CC4", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002Eget_Current();
			}
		}

		[Token(Token = "0x170006CF")]
		private object System_002ECollections_002EIEnumerator_002ECurrent
		{
			[Token(Token = "0x6004263")]
			[Address(RVA = "0x1828D0C", Offset = "0x1828D0C", VA = "0x1828D0C", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return System_002ECollections_002EIEnumerator_002Eget_Current();
			}
		}

		[Token(Token = "0x600425E")]
		[Address(RVA = "0x1828BA4", Offset = "0x1828BA4", VA = "0x1828BA4")]
		[DebuggerHidden]
		public _003CPlayingParticles_003Ed__7(int _003C_003E1__state)
		{
		}

		[Token(Token = "0x600425F")]
		[Address(RVA = "0x1828BD0", Offset = "0x1828BD0", VA = "0x1828BD0", Slot = "5")]
		[DebuggerHidden]
		private void System_002EIDisposable_002EDispose()
		{
		}

		[Token(Token = "0x6004260")]
		[Address(RVA = "0x1828BD4", Offset = "0x1828BD4", VA = "0x1828BD4", Slot = "6")]
		private bool MoveNext()
		{
			return default;
		}

		[Token(Token = "0x6004261")]
		[Address(RVA = "0x1828CC4", Offset = "0x1828CC4", VA = "0x1828CC4", Slot = "4")]
		[DebuggerHidden]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002Eget_Current()
		{
			return null;
		}

		[Token(Token = "0x6004262")]
		[Address(RVA = "0x1828CCC", Offset = "0x1828CCC", VA = "0x1828CCC", Slot = "8")]
		[DebuggerHidden]
		private void System_002ECollections_002EIEnumerator_002EReset()
		{
		}

		[Token(Token = "0x6004263")]
		[Address(RVA = "0x1828D0C", Offset = "0x1828D0C", VA = "0x1828D0C", Slot = "7")]
		[DebuggerHidden]
		private object System_002ECollections_002EIEnumerator_002Eget_Current()
		{
			return null;
		}
	}

	[Token(Token = "0x4004CC1")]
	[FieldOffset(Offset = "0x18")]
	private ParticleSystem particles;

	[Token(Token = "0x4004CC2")]
	[FieldOffset(Offset = "0x20")]
	private bool canPlay;

	[Token(Token = "0x4004CC3")]
	[FieldOffset(Offset = "0x24")]
	public float minInterval;

	[Token(Token = "0x4004CC4")]
	[FieldOffset(Offset = "0x28")]
	public float maxInterval;

	[Token(Token = "0x4004CC5")]
	[FieldOffset(Offset = "0x30")]
	public UnityEvent OnPlay;

	[Token(Token = "0x600425A")]
	[Address(RVA = "0x15F4B00", Offset = "0x15F4B00", VA = "0x15F4B00")]
	private void Start()
	{
	}

	[Token(Token = "0x600425B")]
	[Address(RVA = "0x15F4B5C", Offset = "0x15F4B5C", VA = "0x15F4B5C")]
	private void Update()
	{
	}

	[Token(Token = "0x600425C")]
	[Address(RVA = "0x15F4BF4", Offset = "0x15F4BF4", VA = "0x15F4BF4")]
	private IEnumerator PlayingParticles()
	{
		return null;
	}

	[Token(Token = "0x600425D")]
	[Address(RVA = "0x15F4C68", Offset = "0x15F4C68", VA = "0x15F4C68")]
	public PlayParticlesRandomIntervals()
	{
	}
}
