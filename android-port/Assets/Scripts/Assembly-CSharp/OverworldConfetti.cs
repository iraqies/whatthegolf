using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x20009F9")]
public class OverworldConfetti : MonoBehaviour
{
	[Token(Token = "0x20009FA")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x42898", Offset = "0x42898")]
	private sealed class _003CDelayedSpawn_003Ed__4 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x40036F2")]
		[FieldOffset(Offset = "0x10")]
		private int _003C_003E1__state;

		[Token(Token = "0x40036F3")]
		[FieldOffset(Offset = "0x18")]
		private object _003C_003E2__current;

		[Token(Token = "0x40036F4")]
		[FieldOffset(Offset = "0x20")]
		public OverworldConfetti _003C_003E4__this;

		[Token(Token = "0x40036F5")]
		[FieldOffset(Offset = "0x28")]
		public OverworldGoal overworldGoal;

		[Token(Token = "0x40036F6")]
		[FieldOffset(Offset = "0x30")]
		public bool isCrown;

		[Token(Token = "0x170004D9")]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002ECurrent
		{
			[Token(Token = "0x6002F40")]
			[Address(RVA = "0x180F2E8", Offset = "0x180F2E8", VA = "0x180F2E8", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002Eget_Current();
			}
		}

		[Token(Token = "0x170004DA")]
		private object System_002ECollections_002EIEnumerator_002ECurrent
		{
			[Token(Token = "0x6002F42")]
			[Address(RVA = "0x180F330", Offset = "0x180F330", VA = "0x180F330", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return System_002ECollections_002EIEnumerator_002Eget_Current();
			}
		}

		[Token(Token = "0x6002F3D")]
		[Address(RVA = "0x180F164", Offset = "0x180F164", VA = "0x180F164")]
		[DebuggerHidden]
		public _003CDelayedSpawn_003Ed__4(int _003C_003E1__state)
		{
		}

		[Token(Token = "0x6002F3E")]
		[Address(RVA = "0x180F190", Offset = "0x180F190", VA = "0x180F190", Slot = "5")]
		[DebuggerHidden]
		private void System_002EIDisposable_002EDispose()
		{
		}

		[Token(Token = "0x6002F3F")]
		[Address(RVA = "0x180F194", Offset = "0x180F194", VA = "0x180F194", Slot = "6")]
		private bool MoveNext()
		{
			return default;
		}

		[Token(Token = "0x6002F40")]
		[Address(RVA = "0x180F2E8", Offset = "0x180F2E8", VA = "0x180F2E8", Slot = "4")]
		[DebuggerHidden]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002Eget_Current()
		{
			return null;
		}

		[Token(Token = "0x6002F41")]
		[Address(RVA = "0x180F2F0", Offset = "0x180F2F0", VA = "0x180F2F0", Slot = "8")]
		[DebuggerHidden]
		private void System_002ECollections_002EIEnumerator_002EReset()
		{
		}

		[Token(Token = "0x6002F42")]
		[Address(RVA = "0x180F330", Offset = "0x180F330", VA = "0x180F330", Slot = "7")]
		[DebuggerHidden]
		private object System_002ECollections_002EIEnumerator_002Eget_Current()
		{
			return null;
		}
	}

	[Token(Token = "0x40036F0")]
	[FieldOffset(Offset = "0x18")]
	public OverworldManager2d Manager;

	[Token(Token = "0x40036F1")]
	[FieldOffset(Offset = "0x20")]
	public ConfettiSpawner Spawner;

	[Token(Token = "0x6002F39")]
	[Address(RVA = "0x15B066C", Offset = "0x15B066C", VA = "0x15B066C")]
	private void Start()
	{
	}

	[Token(Token = "0x6002F3A")]
	[Address(RVA = "0x15B0794", Offset = "0x15B0794", VA = "0x15B0794")]
	private void OnlevelCompleted(OverworldGoal overworldGoal, bool parUnlocked)
	{
	}

	[Token(Token = "0x6002F3B")]
	[Address(RVA = "0x15B08A0", Offset = "0x15B08A0", VA = "0x15B08A0")]
	private IEnumerator DelayedSpawn(OverworldGoal overworldGoal, bool isCrown)
	{
		return null;
	}

	[Token(Token = "0x6002F3C")]
	[Address(RVA = "0x15B0928", Offset = "0x15B0928", VA = "0x15B0928")]
	public OverworldConfetti()
	{
	}
}
