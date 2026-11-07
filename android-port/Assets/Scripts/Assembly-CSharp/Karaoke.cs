using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using Core;
using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x20007B4")]
public class Karaoke : MonoBehaviour
{
	[Token(Token = "0x20007B5")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x41590", Offset = "0x41590")]
	private sealed class _003C_003Ec__DisplayClass15_0
	{
		[Token(Token = "0x400289F")]
		[FieldOffset(Offset = "0x10")]
		public Karaoke _003C_003E4__this;

		[Token(Token = "0x40028A0")]
		[FieldOffset(Offset = "0x18")]
		public bool didBeginMovment;

		[Token(Token = "0x6002342")]
		[Address(RVA = "0x17CC1D8", Offset = "0x17CC1D8", VA = "0x17CC1D8")]
		public _003C_003Ec__DisplayClass15_0()
		{
		}

		[Token(Token = "0x6002343")]
		[Address(RVA = "0x17CC1E0", Offset = "0x17CC1E0", VA = "0x17CC1E0")]
		internal void _003CStart_003Eb__0(Vector3 v)
		{
		}

		[Token(Token = "0x6002344")]
		[Address(RVA = "0x17CC200", Offset = "0x17CC200", VA = "0x17CC200")]
		internal void _003CStart_003Eb__1()
		{
		}
	}

	[Token(Token = "0x20007B6")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x415A0", Offset = "0x415A0")]
	private sealed class _003CStart_003Ed__15 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x40028A1")]
		[FieldOffset(Offset = "0x10")]
		private int _003C_003E1__state;

		[Token(Token = "0x40028A2")]
		[FieldOffset(Offset = "0x18")]
		private object _003C_003E2__current;

		[Token(Token = "0x40028A3")]
		[FieldOffset(Offset = "0x20")]
		public Karaoke _003C_003E4__this;

		[Token(Token = "0x40028A4")]
		[FieldOffset(Offset = "0x28")]
		private _003C_003Ec__DisplayClass15_0 _003C_003E8__1;

		[Token(Token = "0x170003D9")]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002ECurrent
		{
			[Token(Token = "0x6002348")]
			[Address(RVA = "0x17CC438", Offset = "0x17CC438", VA = "0x17CC438", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002Eget_Current();
			}
		}

		[Token(Token = "0x170003DA")]
		private object System_002ECollections_002EIEnumerator_002ECurrent
		{
			[Token(Token = "0x600234A")]
			[Address(RVA = "0x17CC480", Offset = "0x17CC480", VA = "0x17CC480", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return System_002ECollections_002EIEnumerator_002Eget_Current();
			}
		}

		[Token(Token = "0x6002345")]
		[Address(RVA = "0x17CC20C", Offset = "0x17CC20C", VA = "0x17CC20C")]
		[DebuggerHidden]
		public _003CStart_003Ed__15(int _003C_003E1__state)
		{
		}

		[Token(Token = "0x6002346")]
		[Address(RVA = "0x17CC238", Offset = "0x17CC238", VA = "0x17CC238", Slot = "5")]
		[DebuggerHidden]
		private void System_002EIDisposable_002EDispose()
		{
		}

		[Token(Token = "0x6002347")]
		[Address(RVA = "0x17CC23C", Offset = "0x17CC23C", VA = "0x17CC23C", Slot = "6")]
		private bool MoveNext()
		{
			return default;
		}

		[Token(Token = "0x6002348")]
		[Address(RVA = "0x17CC438", Offset = "0x17CC438", VA = "0x17CC438", Slot = "4")]
		[DebuggerHidden]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002Eget_Current()
		{
			return null;
		}

		[Token(Token = "0x6002349")]
		[Address(RVA = "0x17CC440", Offset = "0x17CC440", VA = "0x17CC440", Slot = "8")]
		[DebuggerHidden]
		private void System_002ECollections_002EIEnumerator_002EReset()
		{
		}

		[Token(Token = "0x600234A")]
		[Address(RVA = "0x17CC480", Offset = "0x17CC480", VA = "0x17CC480", Slot = "7")]
		[DebuggerHidden]
		private object System_002ECollections_002EIEnumerator_002Eget_Current()
		{
			return null;
		}
	}

	[Token(Token = "0x4002891")]
	[FieldOffset(Offset = "0x18")]
	[SerializeField]
	private uint startState;

	[Token(Token = "0x4002892")]
	[FieldOffset(Offset = "0x1C")]
	[SerializeField]
	private float endX;

	[Token(Token = "0x4002893")]
	[FieldOffset(Offset = "0x20")]
	[SerializeField]
	private float boundsY;

	[Token(Token = "0x4002894")]
	[FieldOffset(Offset = "0x28")]
	[SerializeField]
	private KaraokeWord[] words;

	[Token(Token = "0x4002895")]
	[FieldOffset(Offset = "0x30")]
	[SerializeField]
	private GolfGoal golfGoal;

	[Token(Token = "0x4002896")]
	[FieldOffset(Offset = "0x38")]
	[SerializeField]
	private AudioSource loopAudioSource;

	[Token(Token = "0x4002897")]
	[FieldOffset(Offset = "0x40")]
	[SerializeField]
	private GolfBallController golfBallController;

	[Token(Token = "0x4002898")]
	[FieldOffset(Offset = "0x48")]
	[SerializeField]
	private Karaoke2DShooter ball;

	[Token(Token = "0x4002899")]
	[FieldOffset(Offset = "0x50")]
	private Transform ballTransform;

	[Token(Token = "0x400289A")]
	[FieldOffset(Offset = "0x58")]
	private Level level;

	[Token(Token = "0x400289B")]
	[FieldOffset(Offset = "0x60")]
	private bool wasGrounded;

	[Token(Token = "0x400289C")]
	[FieldOffset(Offset = "0x61")]
	private bool hasShot;

	[Token(Token = "0x400289D")]
	[FieldOffset(Offset = "0x68")]
	private KaraokeWord activeWord;

	[Token(Token = "0x400289E")]
	[FieldOffset(Offset = "0x70")]
	private MusicManager music;

	[Token(Token = "0x600233D")]
	[Address(RVA = "0x14F946C", Offset = "0x14F946C", VA = "0x14F946C")]
	private void Awake()
	{
	}

	[Token(Token = "0x600233E")]
	[Address(RVA = "0x14F94C0", Offset = "0x14F94C0", VA = "0x14F94C0")]
	private IEnumerator Start()
	{
		return null;
	}

	[Token(Token = "0x600233F")]
	[Address(RVA = "0x14F9534", Offset = "0x14F9534", VA = "0x14F9534")]
	private void Update()
	{
	}

	[Token(Token = "0x6002340")]
	[Address(RVA = "0x14F979C", Offset = "0x14F979C", VA = "0x14F979C")]
	private KaraokeWord FindWord(float x)
	{
		return null;
	}

	[Token(Token = "0x6002341")]
	[Address(RVA = "0x14F9934", Offset = "0x14F9934", VA = "0x14F9934")]
	public Karaoke()
	{
	}
}
