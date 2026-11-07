using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x2000352")]
public class ResetLevel : MonoBehaviour
{
	[Serializable]
	[Token(Token = "0x2000353")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x3F1E0", Offset = "0x3F1E0")]
	private sealed class _003C_003Ec
	{
		[Token(Token = "0x4001254")]
		[FieldOffset(Offset = "0x0")]
		public static readonly _003C_003Ec _003C_003E9;

		[Token(Token = "0x4001255")]
		[FieldOffset(Offset = "0x8")]
		public static Action _003C_003E9__1_0;

		[Token(Token = "0x4001256")]
		[FieldOffset(Offset = "0x10")]
		public static Action _003C_003E9__2_0;

		[Token(Token = "0x6000F69")]
		[Address(RVA = "0x1833DD0", Offset = "0x1833DD0", VA = "0x1833DD0")]
		public _003C_003Ec()
		{
		}

		[Token(Token = "0x6000F6A")]
		[Address(RVA = "0x1833DD8", Offset = "0x1833DD8", VA = "0x1833DD8")]
		internal void _003CResetLevelFn_003Eb__1_0()
		{
		}

		[Token(Token = "0x6000F6B")]
		[Address(RVA = "0x1833E74", Offset = "0x1833E74", VA = "0x1833E74")]
		internal void _003CReloadLevelFn_003Eb__2_0()
		{
		}
	}

	[Token(Token = "0x2000354")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x3F1F0", Offset = "0x3F1F0")]
	private sealed class _003CAfterDelay_003Ed__3 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x4001257")]
		[FieldOffset(Offset = "0x10")]
		private int _003C_003E1__state;

		[Token(Token = "0x4001258")]
		[FieldOffset(Offset = "0x18")]
		private object _003C_003E2__current;

		[Token(Token = "0x4001259")]
		[FieldOffset(Offset = "0x20")]
		public ResetLevel _003C_003E4__this;

		[Token(Token = "0x400125A")]
		[FieldOffset(Offset = "0x28")]
		public Action a;

		[Token(Token = "0x170001CE")]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002ECurrent
		{
			[Token(Token = "0x6000F6F")]
			[Address(RVA = "0x1834004", Offset = "0x1834004", VA = "0x1834004", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002Eget_Current();
			}
		}

		[Token(Token = "0x170001CF")]
		private object System_002ECollections_002EIEnumerator_002ECurrent
		{
			[Token(Token = "0x6000F71")]
			[Address(RVA = "0x183404C", Offset = "0x183404C", VA = "0x183404C", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return System_002ECollections_002EIEnumerator_002Eget_Current();
			}
		}

		[Token(Token = "0x6000F6C")]
		[Address(RVA = "0x1833F10", Offset = "0x1833F10", VA = "0x1833F10")]
		[DebuggerHidden]
		public _003CAfterDelay_003Ed__3(int _003C_003E1__state)
		{
		}

		[Token(Token = "0x6000F6D")]
		[Address(RVA = "0x1833F3C", Offset = "0x1833F3C", VA = "0x1833F3C", Slot = "5")]
		[DebuggerHidden]
		private void System_002EIDisposable_002EDispose()
		{
		}

		[Token(Token = "0x6000F6E")]
		[Address(RVA = "0x1833F40", Offset = "0x1833F40", VA = "0x1833F40", Slot = "6")]
		private bool MoveNext()
		{
			return default;
		}

		[Token(Token = "0x6000F6F")]
		[Address(RVA = "0x1834004", Offset = "0x1834004", VA = "0x1834004", Slot = "4")]
		[DebuggerHidden]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002Eget_Current()
		{
			return null;
		}

		[Token(Token = "0x6000F70")]
		[Address(RVA = "0x183400C", Offset = "0x183400C", VA = "0x183400C", Slot = "8")]
		[DebuggerHidden]
		private void System_002ECollections_002EIEnumerator_002EReset()
		{
		}

		[Token(Token = "0x6000F71")]
		[Address(RVA = "0x183404C", Offset = "0x183404C", VA = "0x183404C", Slot = "7")]
		[DebuggerHidden]
		private object System_002ECollections_002EIEnumerator_002Eget_Current()
		{
			return null;
		}
	}

	[Token(Token = "0x4001253")]
	[FieldOffset(Offset = "0x18")]
	[SerializeField]
	private float delay;

	[Token(Token = "0x6000F64")]
	[Address(RVA = "0x164A5D0", Offset = "0x164A5D0", VA = "0x164A5D0")]
	public void ResetLevelFn()
	{
	}

	[Token(Token = "0x6000F65")]
	[Address(RVA = "0x164A79C", Offset = "0x164A79C", VA = "0x164A79C")]
	public void ReloadLevelFn()
	{
	}

	[Token(Token = "0x6000F66")]
	[Address(RVA = "0x164A724", Offset = "0x164A724", VA = "0x164A724")]
	private IEnumerator AfterDelay(Action a)
	{
		return null;
	}

	[Token(Token = "0x6000F67")]
	[Address(RVA = "0x164A8F0", Offset = "0x164A8F0", VA = "0x164A8F0")]
	public ResetLevel()
	{
	}
}
