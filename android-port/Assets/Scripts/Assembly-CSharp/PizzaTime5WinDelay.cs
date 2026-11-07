using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x2000D0B")]
public class PizzaTime5WinDelay : MonoBehaviour
{
	[Token(Token = "0x2000D0C")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x44678", Offset = "0x44678")]
	private sealed class _003CWinAfterDelay_003Ed__4 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x40046D7")]
		[FieldOffset(Offset = "0x10")]
		private int _003C_003E1__state;

		[Token(Token = "0x40046D8")]
		[FieldOffset(Offset = "0x18")]
		private object _003C_003E2__current;

		[Token(Token = "0x40046D9")]
		[FieldOffset(Offset = "0x20")]
		public float delay;

		[Token(Token = "0x40046DA")]
		[FieldOffset(Offset = "0x28")]
		public PizzaTime5WinDelay _003C_003E4__this;

		[Token(Token = "0x1700064D")]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002ECurrent
		{
			[Token(Token = "0x6003DA0")]
			[Address(RVA = "0x1826420", Offset = "0x1826420", VA = "0x1826420", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002Eget_Current();
			}
		}

		[Token(Token = "0x1700064E")]
		private object System_002ECollections_002EIEnumerator_002ECurrent
		{
			[Token(Token = "0x6003DA2")]
			[Address(RVA = "0x1826468", Offset = "0x1826468", VA = "0x1826468", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return System_002ECollections_002EIEnumerator_002Eget_Current();
			}
		}

		[Token(Token = "0x6003D9D")]
		[Address(RVA = "0x1826288", Offset = "0x1826288", VA = "0x1826288")]
		[DebuggerHidden]
		public _003CWinAfterDelay_003Ed__4(int _003C_003E1__state)
		{
		}

		[Token(Token = "0x6003D9E")]
		[Address(RVA = "0x18262B4", Offset = "0x18262B4", VA = "0x18262B4", Slot = "5")]
		[DebuggerHidden]
		private void System_002EIDisposable_002EDispose()
		{
		}

		[Token(Token = "0x6003D9F")]
		[Address(RVA = "0x18262B8", Offset = "0x18262B8", VA = "0x18262B8", Slot = "6")]
		private bool MoveNext()
		{
			return default;
		}

		[Token(Token = "0x6003DA0")]
		[Address(RVA = "0x1826420", Offset = "0x1826420", VA = "0x1826420", Slot = "4")]
		[DebuggerHidden]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002Eget_Current()
		{
			return null;
		}

		[Token(Token = "0x6003DA1")]
		[Address(RVA = "0x1826428", Offset = "0x1826428", VA = "0x1826428", Slot = "8")]
		[DebuggerHidden]
		private void System_002ECollections_002EIEnumerator_002EReset()
		{
		}

		[Token(Token = "0x6003DA2")]
		[Address(RVA = "0x1826468", Offset = "0x1826468", VA = "0x1826468", Slot = "7")]
		[DebuggerHidden]
		private object System_002ECollections_002EIEnumerator_002Eget_Current()
		{
			return null;
		}
	}

	[Token(Token = "0x40046D4")]
	[FieldOffset(Offset = "0x18")]
	public Transform winSphere;

	[Token(Token = "0x40046D5")]
	[FieldOffset(Offset = "0x20")]
	public ParticleSystem winParticles;

	[Token(Token = "0x40046D6")]
	[FieldOffset(Offset = "0x28")]
	public float winDelay;

	[Token(Token = "0x6003D9A")]
	[Address(RVA = "0x15E3A58", Offset = "0x15E3A58", VA = "0x15E3A58")]
	public void StartWinning()
	{
	}

	[Token(Token = "0x6003D9B")]
	[Address(RVA = "0x15E3AE4", Offset = "0x15E3AE4", VA = "0x15E3AE4")]
	private IEnumerator WinAfterDelay(float delay)
	{
		return null;
	}

	[Token(Token = "0x6003D9C")]
	[Address(RVA = "0x15E3B68", Offset = "0x15E3B68", VA = "0x15E3B68")]
	public PizzaTime5WinDelay()
	{
	}
}
