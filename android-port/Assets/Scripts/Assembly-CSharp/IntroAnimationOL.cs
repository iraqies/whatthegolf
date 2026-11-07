using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x2000286")]
public class IntroAnimationOL : MonoBehaviour
{
	[Token(Token = "0x2000287")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x3E7B4", Offset = "0x3E7B4")]
	private sealed class _003C_003Ec__DisplayClass6_0
	{
		[Token(Token = "0x4000D4D")]
		[FieldOffset(Offset = "0x10")]
		public bool isWaitingForDoor;

		[Token(Token = "0x6000B7B")]
		[Address(RVA = "0x17C8944", Offset = "0x17C8944", VA = "0x17C8944")]
		public _003C_003Ec__DisplayClass6_0()
		{
		}

		[Token(Token = "0x6000B7C")]
		[Address(RVA = "0x17C894C", Offset = "0x17C894C", VA = "0x17C894C")]
		internal void _003CSetSaveOkay_003Eb__0()
		{
		}
	}

	[Token(Token = "0x2000288")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x3E7C4", Offset = "0x3E7C4")]
	private sealed class _003CSetSaveOkay_003Ed__6 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x4000D4E")]
		[FieldOffset(Offset = "0x10")]
		private int _003C_003E1__state;

		[Token(Token = "0x4000D4F")]
		[FieldOffset(Offset = "0x18")]
		private object _003C_003E2__current;

		[Token(Token = "0x4000D50")]
		[FieldOffset(Offset = "0x20")]
		public IntroAnimationOL _003C_003E4__this;

		[Token(Token = "0x4000D51")]
		[FieldOffset(Offset = "0x28")]
		private _003C_003Ec__DisplayClass6_0 _003C_003E8__1;

		[Token(Token = "0x4000D52")]
		[FieldOffset(Offset = "0x30")]
		private float _003CmaxWait_003E5__2;

		[Token(Token = "0x17000161")]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002ECurrent
		{
			[Token(Token = "0x6000B80")]
			[Address(RVA = "0x17C8C4C", Offset = "0x17C8C4C", VA = "0x17C8C4C", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002Eget_Current();
			}
		}

		[Token(Token = "0x17000162")]
		private object System_002ECollections_002EIEnumerator_002ECurrent
		{
			[Token(Token = "0x6000B82")]
			[Address(RVA = "0x17C8C94", Offset = "0x17C8C94", VA = "0x17C8C94", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return System_002ECollections_002EIEnumerator_002Eget_Current();
			}
		}

		[Token(Token = "0x6000B7D")]
		[Address(RVA = "0x17C8954", Offset = "0x17C8954", VA = "0x17C8954")]
		[DebuggerHidden]
		public _003CSetSaveOkay_003Ed__6(int _003C_003E1__state)
		{
		}

		[Token(Token = "0x6000B7E")]
		[Address(RVA = "0x17C8980", Offset = "0x17C8980", VA = "0x17C8980", Slot = "5")]
		[DebuggerHidden]
		private void System_002EIDisposable_002EDispose()
		{
		}

		[Token(Token = "0x6000B7F")]
		[Address(RVA = "0x17C8984", Offset = "0x17C8984", VA = "0x17C8984", Slot = "6")]
		private bool MoveNext()
		{
			return default;
		}

		[Token(Token = "0x6000B80")]
		[Address(RVA = "0x17C8C4C", Offset = "0x17C8C4C", VA = "0x17C8C4C", Slot = "4")]
		[DebuggerHidden]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002Eget_Current()
		{
			return null;
		}

		[Token(Token = "0x6000B81")]
		[Address(RVA = "0x17C8C54", Offset = "0x17C8C54", VA = "0x17C8C54", Slot = "8")]
		[DebuggerHidden]
		private void System_002ECollections_002EIEnumerator_002EReset()
		{
		}

		[Token(Token = "0x6000B82")]
		[Address(RVA = "0x17C8C94", Offset = "0x17C8C94", VA = "0x17C8C94", Slot = "7")]
		[DebuggerHidden]
		private object System_002ECollections_002EIEnumerator_002Eget_Current()
		{
			return null;
		}
	}

	[Token(Token = "0x4000D49")]
	[FieldOffset(Offset = "0x18")]
	public OverworldButton2D door;

	[Token(Token = "0x4000D4A")]
	[FieldOffset(Offset = "0x20")]
	public SaveSpot save;

	[Token(Token = "0x4000D4B")]
	[FieldOffset(Offset = "0x28")]
	public IntroTunnelInOverworld intro;

	[Token(Token = "0x4000D4C")]
	[FieldOffset(Offset = "0x30")]
	private bool didEnableSave;

	[Token(Token = "0x6000B76")]
	[Address(RVA = "0x14F1AF4", Offset = "0x14F1AF4", VA = "0x14F1AF4")]
	private void Start()
	{
	}

	[Token(Token = "0x6000B77")]
	[Address(RVA = "0x14F1C9C", Offset = "0x14F1C9C", VA = "0x14F1C9C")]
	private void Intro_OnAtEndOfTunnel()
	{
	}

	[Token(Token = "0x6000B78")]
	[Address(RVA = "0x14F1D18", Offset = "0x14F1D18", VA = "0x14F1D18")]
	public IEnumerator SetSaveOkay()
	{
		return null;
	}

	[Token(Token = "0x6000B79")]
	[Address(RVA = "0x14F1D8C", Offset = "0x14F1D8C", VA = "0x14F1D8C")]
	private void UpdateSave()
	{
	}

	[Token(Token = "0x6000B7A")]
	[Address(RVA = "0x14F1DF8", Offset = "0x14F1DF8", VA = "0x14F1DF8")]
	public IntroAnimationOL()
	{
	}
}
