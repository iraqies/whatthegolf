using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x20000B5")]
public class ArenaCharacters : MonoBehaviour
{
	[Serializable]
	[Token(Token = "0x20000B6")]
	public class ProgressAvatar
	{
		[Token(Token = "0x40002E3")]
		[FieldOffset(Offset = "0x10")]
		public PlayerColors.AvatarIDs ID;

		[Token(Token = "0x40002E4")]
		[FieldOffset(Offset = "0x18")]
		public Animator Animator;

		[Token(Token = "0x6000321")]
		[Address(RVA = "0x176EB88", Offset = "0x176EB88", VA = "0x176EB88")]
		public ProgressAvatar()
		{
		}
	}

	[Token(Token = "0x20000B7")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x3D810", Offset = "0x3D810")]
	private sealed class _003C_003Ec__DisplayClass14_0
	{
		[Token(Token = "0x40002E5")]
		[FieldOffset(Offset = "0x10")]
		public MultiplayerConfiguration.PlayerInfo player;

		[Token(Token = "0x6000322")]
		[Address(RVA = "0x176E2E4", Offset = "0x176E2E4", VA = "0x176E2E4")]
		public _003C_003Ec__DisplayClass14_0()
		{
		}

		[Token(Token = "0x6000323")]
		[Address(RVA = "0x176E2EC", Offset = "0x176E2EC", VA = "0x176E2EC")]
		internal bool _003CInit_003Eb__1(ProgressAvatar a)
		{
			return default;
		}

		[Token(Token = "0x6000324")]
		[Address(RVA = "0x176E324", Offset = "0x176E324", VA = "0x176E324")]
		internal bool _003CInit_003Eb__2(ProgressAvatar a)
		{
			return default;
		}

		[Token(Token = "0x6000325")]
		[Address(RVA = "0x176E35C", Offset = "0x176E35C", VA = "0x176E35C")]
		internal bool _003CInit_003Eb__3(ProgressAvatar a)
		{
			return default;
		}

		[Token(Token = "0x6000326")]
		[Address(RVA = "0x176E394", Offset = "0x176E394", VA = "0x176E394")]
		internal bool _003CInit_003Eb__4(ProgressAvatar a)
		{
			return default;
		}
	}

	[Serializable]
	[Token(Token = "0x20000B8")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x3D820", Offset = "0x3D820")]
	private sealed class _003C_003Ec
	{
		[Token(Token = "0x40002E6")]
		[FieldOffset(Offset = "0x0")]
		public static readonly _003C_003Ec _003C_003E9;

		[Token(Token = "0x40002E7")]
		[FieldOffset(Offset = "0x8")]
		public static Action<ProgressAvatar> _003C_003E9__14_0;

		[Token(Token = "0x40002E8")]
		[FieldOffset(Offset = "0x10")]
		public static Func<ProgressAvatar, bool> _003C_003E9__18_0;

		[Token(Token = "0x6000328")]
		[Address(RVA = "0x176E278", Offset = "0x176E278", VA = "0x176E278")]
		public _003C_003Ec()
		{
		}

		[Token(Token = "0x6000329")]
		[Address(RVA = "0x176E280", Offset = "0x176E280", VA = "0x176E280")]
		internal void _003CInit_003Eb__14_0(ProgressAvatar a)
		{
		}

		[Token(Token = "0x600032A")]
		[Address(RVA = "0x176E2B4", Offset = "0x176E2B4", VA = "0x176E2B4")]
		internal bool _003CDoAction_003Eb__18_0(ProgressAvatar a)
		{
			return default;
		}
	}

	[Token(Token = "0x20000B9")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x3D830", Offset = "0x3D830")]
	private sealed class _003CDoAction_003Ed__18 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x40002E9")]
		[FieldOffset(Offset = "0x10")]
		private int _003C_003E1__state;

		[Token(Token = "0x40002EA")]
		[FieldOffset(Offset = "0x18")]
		private object _003C_003E2__current;

		[Token(Token = "0x40002EB")]
		[FieldOffset(Offset = "0x20")]
		public ArenaCharacters _003C_003E4__this;

		[Token(Token = "0x17000083")]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002ECurrent
		{
			[Token(Token = "0x600032E")]
			[Address(RVA = "0x176EB38", Offset = "0x176EB38", VA = "0x176EB38", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002Eget_Current();
			}
		}

		[Token(Token = "0x17000084")]
		private object System_002ECollections_002EIEnumerator_002ECurrent
		{
			[Token(Token = "0x6000330")]
			[Address(RVA = "0x176EB80", Offset = "0x176EB80", VA = "0x176EB80", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return System_002ECollections_002EIEnumerator_002Eget_Current();
			}
		}

		[Token(Token = "0x600032B")]
		[Address(RVA = "0x176E8EC", Offset = "0x176E8EC", VA = "0x176E8EC")]
		[DebuggerHidden]
		public _003CDoAction_003Ed__18(int _003C_003E1__state)
		{
		}

		[Token(Token = "0x600032C")]
		[Address(RVA = "0x176E918", Offset = "0x176E918", VA = "0x176E918", Slot = "5")]
		[DebuggerHidden]
		private void System_002EIDisposable_002EDispose()
		{
		}

		[Token(Token = "0x600032D")]
		[Address(RVA = "0x176E91C", Offset = "0x176E91C", VA = "0x176E91C", Slot = "6")]
		private bool MoveNext()
		{
			return default;
		}

		[Token(Token = "0x600032E")]
		[Address(RVA = "0x176EB38", Offset = "0x176EB38", VA = "0x176EB38", Slot = "4")]
		[DebuggerHidden]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002Eget_Current()
		{
			return null;
		}

		[Token(Token = "0x600032F")]
		[Address(RVA = "0x176EB40", Offset = "0x176EB40", VA = "0x176EB40", Slot = "8")]
		[DebuggerHidden]
		private void System_002ECollections_002EIEnumerator_002EReset()
		{
		}

		[Token(Token = "0x6000330")]
		[Address(RVA = "0x176EB80", Offset = "0x176EB80", VA = "0x176EB80", Slot = "7")]
		[DebuggerHidden]
		private object System_002ECollections_002EIEnumerator_002Eget_Current()
		{
			return null;
		}
	}

	[Token(Token = "0x20000BA")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x3D840", Offset = "0x3D840")]
	private sealed class _003CCharacterAnimationsRoutine_003Ed__19 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x40002EC")]
		[FieldOffset(Offset = "0x10")]
		private int _003C_003E1__state;

		[Token(Token = "0x40002ED")]
		[FieldOffset(Offset = "0x18")]
		private object _003C_003E2__current;

		[Token(Token = "0x40002EE")]
		[FieldOffset(Offset = "0x20")]
		public ArenaCharacters _003C_003E4__this;

		[Token(Token = "0x17000085")]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002ECurrent
		{
			[Token(Token = "0x6000334")]
			[Address(RVA = "0x176E89C", Offset = "0x176E89C", VA = "0x176E89C", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002Eget_Current();
			}
		}

		[Token(Token = "0x17000086")]
		private object System_002ECollections_002EIEnumerator_002ECurrent
		{
			[Token(Token = "0x6000336")]
			[Address(RVA = "0x176E8E4", Offset = "0x176E8E4", VA = "0x176E8E4", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return System_002ECollections_002EIEnumerator_002Eget_Current();
			}
		}

		[Token(Token = "0x6000331")]
		[Address(RVA = "0x176E3CC", Offset = "0x176E3CC", VA = "0x176E3CC")]
		[DebuggerHidden]
		public _003CCharacterAnimationsRoutine_003Ed__19(int _003C_003E1__state)
		{
		}

		[Token(Token = "0x6000332")]
		[Address(RVA = "0x176E3F8", Offset = "0x176E3F8", VA = "0x176E3F8", Slot = "5")]
		[DebuggerHidden]
		private void System_002EIDisposable_002EDispose()
		{
		}

		[Token(Token = "0x6000333")]
		[Address(RVA = "0x176E3FC", Offset = "0x176E3FC", VA = "0x176E3FC", Slot = "6")]
		private bool MoveNext()
		{
			return default;
		}

		[Token(Token = "0x6000334")]
		[Address(RVA = "0x176E89C", Offset = "0x176E89C", VA = "0x176E89C", Slot = "4")]
		[DebuggerHidden]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002Eget_Current()
		{
			return null;
		}

		[Token(Token = "0x6000335")]
		[Address(RVA = "0x176E8A4", Offset = "0x176E8A4", VA = "0x176E8A4", Slot = "8")]
		[DebuggerHidden]
		private void System_002ECollections_002EIEnumerator_002EReset()
		{
		}

		[Token(Token = "0x6000336")]
		[Address(RVA = "0x176E8E4", Offset = "0x176E8E4", VA = "0x176E8E4", Slot = "7")]
		[DebuggerHidden]
		private object System_002ECollections_002EIEnumerator_002Eget_Current()
		{
			return null;
		}
	}

	[Token(Token = "0x40002D5")]
	[FieldOffset(Offset = "0x18")]
	public Animator SequenceAnimator;

	[Token(Token = "0x40002D6")]
	[FieldOffset(Offset = "0x20")]
	public List<ProgressAvatar> Player1Characters;

	[Token(Token = "0x40002D7")]
	[FieldOffset(Offset = "0x28")]
	public List<ProgressAvatar> Player2Characters;

	[Token(Token = "0x40002D8")]
	[FieldOffset(Offset = "0x30")]
	public List<ProgressAvatar> Player3Characters;

	[Token(Token = "0x40002D9")]
	[FieldOffset(Offset = "0x38")]
	public List<ProgressAvatar> Player4Characters;

	[Token(Token = "0x40002DA")]
	[FieldOffset(Offset = "0x40")]
	public Animator[] AnimatorsP1;

	[Token(Token = "0x40002DB")]
	[FieldOffset(Offset = "0x48")]
	public Animator[] AnimatorsP2;

	[Token(Token = "0x40002DC")]
	[FieldOffset(Offset = "0x50")]
	public Animator[] AnimatorsP3;

	[Token(Token = "0x40002DD")]
	[FieldOffset(Offset = "0x58")]
	public Animator[] AnimatorsP4;

	[Token(Token = "0x40002DE")]
	[FieldOffset(Offset = "0x60")]
	public float PreDelay;

	[Token(Token = "0x40002DF")]
	[FieldOffset(Offset = "0x64")]
	public float DelayBetweenCharacters;

	[Token(Token = "0x40002E0")]
	[FieldOffset(Offset = "0x68")]
	public bool OnlyRandomCharacter;

	[Token(Token = "0x40002E1")]
	[FieldOffset(Offset = "0x70")]
	private List<ProgressAvatar> allCharacters;

	[Token(Token = "0x40002E2")]
	[FieldOffset(Offset = "0x78")]
	public int DebugCharacter;

	[Token(Token = "0x600031B")]
	[Address(RVA = "0x142055C", Offset = "0x142055C", VA = "0x142055C")]
	public void Init(List<MultiplayerConfiguration.PlayerInfo> players)
	{
	}

	[Token(Token = "0x600031C")]
	[Address(RVA = "0x1420B40", Offset = "0x1420B40", VA = "0x1420B40")]
	public void StartSequence()
	{
	}

	[Token(Token = "0x600031D")]
	[Address(RVA = "0x1420C6C", Offset = "0x1420C6C", VA = "0x1420C6C")]
	[AttributeAttribute(Name = "ContextMenu", RVA = "0x5DEF0", Offset = "0x5DEF0")]
	private void DebugSequence()
	{
	}

	[Token(Token = "0x600031E")]
	[Address(RVA = "0x1420BF8", Offset = "0x1420BF8", VA = "0x1420BF8")]
	private IEnumerator DoAction()
	{
		return null;
	}

	[Token(Token = "0x600031F")]
	[Address(RVA = "0x1420E34", Offset = "0x1420E34", VA = "0x1420E34")]
	private IEnumerator CharacterAnimationsRoutine()
	{
		return null;
	}

	[Token(Token = "0x6000320")]
	[Address(RVA = "0x1420EA8", Offset = "0x1420EA8", VA = "0x1420EA8")]
	public ArenaCharacters()
	{
	}
}
