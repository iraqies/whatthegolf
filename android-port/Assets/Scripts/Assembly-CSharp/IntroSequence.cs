using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x20000ED")]
public class IntroSequence : MonoBehaviour
{
	[Serializable]
	[Token(Token = "0x20000EE")]
	public class IntroSequenceCharacter
	{
		[Token(Token = "0x40003EA")]
		[FieldOffset(Offset = "0x10")]
		public PlayerColors.AvatarIDs ID;

		[Token(Token = "0x40003EB")]
		[FieldOffset(Offset = "0x18")]
		public GameObject UIContainer;

		[Token(Token = "0x40003EC")]
		[FieldOffset(Offset = "0x20")]
		public GameObject Name;

		[Token(Token = "0x6000416")]
		[Address(RVA = "0x17C9294", Offset = "0x17C9294", VA = "0x17C9294")]
		public IntroSequenceCharacter()
		{
		}
	}

	[Token(Token = "0x20000EF")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x3DA40", Offset = "0x3DA40")]
	private sealed class _003C_003Ec__DisplayClass13_0
	{
		[Token(Token = "0x40003ED")]
		[FieldOffset(Offset = "0x10")]
		public MultiplayerLobby.LobbyPlayer player;

		[Token(Token = "0x6000417")]
		[Address(RVA = "0x17C921C", Offset = "0x17C921C", VA = "0x17C921C")]
		public _003C_003Ec__DisplayClass13_0()
		{
		}

		[Token(Token = "0x6000418")]
		[Address(RVA = "0x17C9224", Offset = "0x17C9224", VA = "0x17C9224")]
		internal bool _003COnMatchStarting_003Eb__1(IntroSequenceCharacter l)
		{
			return default;
		}

		[Token(Token = "0x6000419")]
		[Address(RVA = "0x17C925C", Offset = "0x17C925C", VA = "0x17C925C")]
		internal bool _003COnMatchStarting_003Eb__3(IntroSequenceCharacter l)
		{
			return default;
		}
	}

	[Serializable]
	[Token(Token = "0x20000F0")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x3DA50", Offset = "0x3DA50")]
	private sealed class _003C_003Ec
	{
		[Token(Token = "0x40003EE")]
		[FieldOffset(Offset = "0x0")]
		public static readonly _003C_003Ec _003C_003E9;

		[Token(Token = "0x40003EF")]
		[FieldOffset(Offset = "0x8")]
		public static Action<IntroSequenceCharacter> _003C_003E9__13_0;

		[Token(Token = "0x40003F0")]
		[FieldOffset(Offset = "0x10")]
		public static Action<IntroSequenceCharacter> _003C_003E9__13_2;

		[Token(Token = "0x600041B")]
		[Address(RVA = "0x17C9184", Offset = "0x17C9184", VA = "0x17C9184")]
		public _003C_003Ec()
		{
		}

		[Token(Token = "0x600041C")]
		[Address(RVA = "0x17C918C", Offset = "0x17C918C", VA = "0x17C918C")]
		internal void _003COnMatchStarting_003Eb__13_0(IntroSequenceCharacter c)
		{
		}

		[Token(Token = "0x600041D")]
		[Address(RVA = "0x17C91D4", Offset = "0x17C91D4", VA = "0x17C91D4")]
		internal void _003COnMatchStarting_003Eb__13_2(IntroSequenceCharacter c)
		{
		}
	}

	[Token(Token = "0x20000F1")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x3DA60", Offset = "0x3DA60")]
	private sealed class _003C_003COnLevelStarted_003Eg__DelayedSequenceExit_007C12_0_003Ed : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x40003F1")]
		[FieldOffset(Offset = "0x10")]
		private int _003C_003E1__state;

		[Token(Token = "0x40003F2")]
		[FieldOffset(Offset = "0x18")]
		private object _003C_003E2__current;

		[Token(Token = "0x40003F3")]
		[FieldOffset(Offset = "0x20")]
		public IntroSequence _003C_003E4__this;

		[Token(Token = "0x17000096")]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002ECurrent
		{
			[Token(Token = "0x6000421")]
			[Address(RVA = "0x17C90D4", Offset = "0x17C90D4", VA = "0x17C90D4", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002Eget_Current();
			}
		}

		[Token(Token = "0x17000097")]
		private object System_002ECollections_002EIEnumerator_002ECurrent
		{
			[Token(Token = "0x6000423")]
			[Address(RVA = "0x17C911C", Offset = "0x17C911C", VA = "0x17C911C", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return System_002ECollections_002EIEnumerator_002Eget_Current();
			}
		}

		[Token(Token = "0x600041E")]
		[Address(RVA = "0x17C8FB8", Offset = "0x17C8FB8", VA = "0x17C8FB8")]
		[DebuggerHidden]
		public _003C_003COnLevelStarted_003Eg__DelayedSequenceExit_007C12_0_003Ed(int _003C_003E1__state)
		{
		}

		[Token(Token = "0x600041F")]
		[Address(RVA = "0x17C8FE4", Offset = "0x17C8FE4", VA = "0x17C8FE4", Slot = "5")]
		[DebuggerHidden]
		private void System_002EIDisposable_002EDispose()
		{
		}

		[Token(Token = "0x6000420")]
		[Address(RVA = "0x17C8FE8", Offset = "0x17C8FE8", VA = "0x17C8FE8", Slot = "6")]
		private bool MoveNext()
		{
			return default;
		}

		[Token(Token = "0x6000421")]
		[Address(RVA = "0x17C90D4", Offset = "0x17C90D4", VA = "0x17C90D4", Slot = "4")]
		[DebuggerHidden]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002Eget_Current()
		{
			return null;
		}

		[Token(Token = "0x6000422")]
		[Address(RVA = "0x17C90DC", Offset = "0x17C90DC", VA = "0x17C90DC", Slot = "8")]
		[DebuggerHidden]
		private void System_002ECollections_002EIEnumerator_002EReset()
		{
		}

		[Token(Token = "0x6000423")]
		[Address(RVA = "0x17C911C", Offset = "0x17C911C", VA = "0x17C911C", Slot = "7")]
		[DebuggerHidden]
		private object System_002ECollections_002EIEnumerator_002Eget_Current()
		{
			return null;
		}
	}

	[Token(Token = "0x40003E0")]
	[FieldOffset(Offset = "0x18")]
	public MultiplayerLobby Lobby;

	[Token(Token = "0x40003E1")]
	[FieldOffset(Offset = "0x20")]
	public Animator SequenceAnimator;

	[Token(Token = "0x40003E2")]
	[FieldOffset(Offset = "0x28")]
	public List<IntroSequenceCharacter> LeftCharacters;

	[Token(Token = "0x40003E3")]
	[FieldOffset(Offset = "0x30")]
	public List<IntroSequenceCharacter> RightCharacters;

	[Token(Token = "0x40003E4")]
	[FieldOffset(Offset = "0x38")]
	public SVGImage LeftBackground;

	[Token(Token = "0x40003E5")]
	[FieldOffset(Offset = "0x40")]
	public SVGImage RightBackground;

	[Token(Token = "0x40003E6")]
	[FieldOffset(Offset = "0x48")]
	public Canvas Canvas;

	[Token(Token = "0x40003E7")]
	[FieldOffset(Offset = "0x50")]
	public Action OnSequenceStarting;

	[Token(Token = "0x40003E8")]
	[FieldOffset(Offset = "0x58")]
	public Action OnSequenceEnding;

	[Token(Token = "0x40003E9")]
	[FieldOffset(Offset = "0x60")]
	private bool firstLevel;

	[Token(Token = "0x6000411")]
	[Address(RVA = "0x14F34CC", Offset = "0x14F34CC", VA = "0x14F34CC")]
	private void Awake()
	{
	}

	[Token(Token = "0x6000412")]
	[Address(RVA = "0x14F3648", Offset = "0x14F3648", VA = "0x14F3648")]
	private void OnLevelStarted(List<MultiplayerConfiguration.PlayerInfo> obj)
	{
	}

	[Token(Token = "0x6000413")]
	[Address(RVA = "0x14F3758", Offset = "0x14F3758", VA = "0x14F3758")]
	private void OnMatchStarting(List<MultiplayerLobby.LobbyPlayer> players)
	{
	}

	[Token(Token = "0x6000414")]
	[Address(RVA = "0x14F3DCC", Offset = "0x14F3DCC", VA = "0x14F3DCC")]
	public IntroSequence()
	{
	}

	[Token(Token = "0x6000415")]
	[Address(RVA = "0x14F36E4", Offset = "0x14F36E4", VA = "0x14F36E4")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x5E238", Offset = "0x5E238")]
	private IEnumerator _003COnLevelStarted_003Eg__DelayedSequenceExit_007C12_0()
	{
		return null;
	}
}
