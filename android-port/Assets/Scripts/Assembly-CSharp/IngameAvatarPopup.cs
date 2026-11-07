using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x20000E9")]
public class IngameAvatarPopup : MonoBehaviour
{
	[Token(Token = "0x20000EA")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x3DA10", Offset = "0x3DA10")]
	private sealed class _003C_003Ec__DisplayClass11_0
	{
		[Token(Token = "0x40003D7")]
		[FieldOffset(Offset = "0x10")]
		public int bestScore;

		[Token(Token = "0x6000403")]
		[Address(RVA = "0x17C5EE0", Offset = "0x17C5EE0", VA = "0x17C5EE0")]
		public _003C_003Ec__DisplayClass11_0()
		{
		}

		[Token(Token = "0x6000404")]
		[Address(RVA = "0x17C5EE8", Offset = "0x17C5EE8", VA = "0x17C5EE8")]
		internal bool _003CTrackStrokes_003Eb__0(MultiplayerConfiguration.PlayerInfo p)
		{
			return default;
		}
	}

	[Token(Token = "0x20000EB")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x3DA20", Offset = "0x3DA20")]
	private sealed class _003CTrackStrokes_003Ed__11 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x40003D8")]
		[FieldOffset(Offset = "0x10")]
		private int _003C_003E1__state;

		[Token(Token = "0x40003D9")]
		[FieldOffset(Offset = "0x18")]
		private object _003C_003E2__current;

		[Token(Token = "0x40003DA")]
		[FieldOffset(Offset = "0x20")]
		public List<MultiplayerConfiguration.PlayerInfo> players;

		[Token(Token = "0x40003DB")]
		[FieldOffset(Offset = "0x28")]
		public IngameAvatarPopup _003C_003E4__this;

		[Token(Token = "0x17000092")]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002ECurrent
		{
			[Token(Token = "0x6000408")]
			[Address(RVA = "0x17C62C0", Offset = "0x17C62C0", VA = "0x17C62C0", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002Eget_Current();
			}
		}

		[Token(Token = "0x17000093")]
		private object System_002ECollections_002EIEnumerator_002ECurrent
		{
			[Token(Token = "0x600040A")]
			[Address(RVA = "0x17C6308", Offset = "0x17C6308", VA = "0x17C6308", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return System_002ECollections_002EIEnumerator_002Eget_Current();
			}
		}

		[Token(Token = "0x6000405")]
		[Address(RVA = "0x17C5F6C", Offset = "0x17C5F6C", VA = "0x17C5F6C")]
		[DebuggerHidden]
		public _003CTrackStrokes_003Ed__11(int _003C_003E1__state)
		{
		}

		[Token(Token = "0x6000406")]
		[Address(RVA = "0x17C5F98", Offset = "0x17C5F98", VA = "0x17C5F98", Slot = "5")]
		[DebuggerHidden]
		private void System_002EIDisposable_002EDispose()
		{
		}

		[Token(Token = "0x6000407")]
		[Address(RVA = "0x17C5F9C", Offset = "0x17C5F9C", VA = "0x17C5F9C", Slot = "6")]
		private bool MoveNext()
		{
			return default;
		}

		[Token(Token = "0x6000408")]
		[Address(RVA = "0x17C62C0", Offset = "0x17C62C0", VA = "0x17C62C0", Slot = "4")]
		[DebuggerHidden]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002Eget_Current()
		{
			return null;
		}

		[Token(Token = "0x6000409")]
		[Address(RVA = "0x17C62C8", Offset = "0x17C62C8", VA = "0x17C62C8", Slot = "8")]
		[DebuggerHidden]
		private void System_002ECollections_002EIEnumerator_002EReset()
		{
		}

		[Token(Token = "0x600040A")]
		[Address(RVA = "0x17C6308", Offset = "0x17C6308", VA = "0x17C6308", Slot = "7")]
		[DebuggerHidden]
		private object System_002ECollections_002EIEnumerator_002Eget_Current()
		{
			return null;
		}
	}

	[Token(Token = "0x20000EC")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x3DA30", Offset = "0x3DA30")]
	private sealed class _003C_003CDisplayForPlayer_003Eg__displayRoutine_007C12_0_003Ed : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x40003DC")]
		[FieldOffset(Offset = "0x10")]
		private int _003C_003E1__state;

		[Token(Token = "0x40003DD")]
		[FieldOffset(Offset = "0x18")]
		private object _003C_003E2__current;

		[Token(Token = "0x40003DE")]
		[FieldOffset(Offset = "0x20")]
		public IngameAvatarPopup _003C_003E4__this;

		[Token(Token = "0x40003DF")]
		[FieldOffset(Offset = "0x28")]
		public int playerIndex;

		[Token(Token = "0x17000094")]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002ECurrent
		{
			[Token(Token = "0x600040E")]
			[Address(RVA = "0x17C5E90", Offset = "0x17C5E90", VA = "0x17C5E90", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002Eget_Current();
			}
		}

		[Token(Token = "0x17000095")]
		private object System_002ECollections_002EIEnumerator_002ECurrent
		{
			[Token(Token = "0x6000410")]
			[Address(RVA = "0x17C5ED8", Offset = "0x17C5ED8", VA = "0x17C5ED8", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return System_002ECollections_002EIEnumerator_002Eget_Current();
			}
		}

		[Token(Token = "0x600040B")]
		[Address(RVA = "0x17C5CF0", Offset = "0x17C5CF0", VA = "0x17C5CF0")]
		[DebuggerHidden]
		public _003C_003CDisplayForPlayer_003Eg__displayRoutine_007C12_0_003Ed(int _003C_003E1__state)
		{
		}

		[Token(Token = "0x600040C")]
		[Address(RVA = "0x17C5D1C", Offset = "0x17C5D1C", VA = "0x17C5D1C", Slot = "5")]
		[DebuggerHidden]
		private void System_002EIDisposable_002EDispose()
		{
		}

		[Token(Token = "0x600040D")]
		[Address(RVA = "0x17C5D20", Offset = "0x17C5D20", VA = "0x17C5D20", Slot = "6")]
		private bool MoveNext()
		{
			return default;
		}

		[Token(Token = "0x600040E")]
		[Address(RVA = "0x17C5E90", Offset = "0x17C5E90", VA = "0x17C5E90", Slot = "4")]
		[DebuggerHidden]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002Eget_Current()
		{
			return null;
		}

		[Token(Token = "0x600040F")]
		[Address(RVA = "0x17C5E98", Offset = "0x17C5E98", VA = "0x17C5E98", Slot = "8")]
		[DebuggerHidden]
		private void System_002ECollections_002EIEnumerator_002EReset()
		{
		}

		[Token(Token = "0x6000410")]
		[Address(RVA = "0x17C5ED8", Offset = "0x17C5ED8", VA = "0x17C5ED8", Slot = "7")]
		[DebuggerHidden]
		private object System_002ECollections_002EIEnumerator_002Eget_Current()
		{
			return null;
		}
	}

	[Token(Token = "0x40003D0")]
	[FieldOffset(Offset = "0x18")]
	public List<Animator> Animators;

	[Token(Token = "0x40003D1")]
	[FieldOffset(Offset = "0x20")]
	public float PopupStayTimeOnStart;

	[Token(Token = "0x40003D2")]
	[FieldOffset(Offset = "0x24")]
	public float PopupStayTimeOnFinished;

	[Token(Token = "0x40003D3")]
	[FieldOffset(Offset = "0x28")]
	public MultiplayerLobby Lobby;

	[Token(Token = "0x40003D4")]
	[FieldOffset(Offset = "0x30")]
	private Dictionary<int, float> stayTimes;

	[Token(Token = "0x40003D5")]
	[FieldOffset(Offset = "0x38")]
	private Coroutine strokeTrackingRoutine;

	[Token(Token = "0x40003D6")]
	[FieldOffset(Offset = "0x40")]
	private StrokeCounter strokeCounter;

	[Token(Token = "0x60003FB")]
	[Address(RVA = "0x14ED0DC", Offset = "0x14ED0DC", VA = "0x14ED0DC")]
	private void Awake()
	{
	}

	[Token(Token = "0x60003FC")]
	[Address(RVA = "0x14ED340", Offset = "0x14ED340", VA = "0x14ED340")]
	private void MatchAborted(List<MultiplayerConfiguration.PlayerInfo> obj)
	{
	}

	[Token(Token = "0x60003FD")]
	[Address(RVA = "0x14ED354", Offset = "0x14ED354", VA = "0x14ED354")]
	private void PlayerFinished(MultiplayerConfiguration.PlayerInfo player, List<MultiplayerConfiguration.PlayerInfo> players)
	{
	}

	[Token(Token = "0x60003FE")]
	[Address(RVA = "0x14ED358", Offset = "0x14ED358", VA = "0x14ED358")]
	private void LevelStarted(List<MultiplayerConfiguration.PlayerInfo> players)
	{
	}

	[Token(Token = "0x60003FF")]
	[Address(RVA = "0x14ED3F4", Offset = "0x14ED3F4", VA = "0x14ED3F4")]
	private IEnumerator TrackStrokes(List<MultiplayerConfiguration.PlayerInfo> players)
	{
		return null;
	}

	[Token(Token = "0x6000400")]
	[Address(RVA = "0x14ED46C", Offset = "0x14ED46C", VA = "0x14ED46C")]
	public void DisplayForPlayer(int i, float duration)
	{
	}

	[Token(Token = "0x6000401")]
	[Address(RVA = "0x14ED6D0", Offset = "0x14ED6D0", VA = "0x14ED6D0")]
	public IngameAvatarPopup()
	{
	}

	[Token(Token = "0x6000402")]
	[Address(RVA = "0x14ED654", Offset = "0x14ED654", VA = "0x14ED654")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x5E188", Offset = "0x5E188")]
	private IEnumerator _003CDisplayForPlayer_003Eg__displayRoutine_007C12_0(int playerIndex)
	{
		return null;
	}
}
