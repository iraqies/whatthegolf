using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x2000742")]
public class MoveOnInterval : FlagMover
{
	[Token(Token = "0x2000743")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x412F0", Offset = "0x412F0")]
	private sealed class _003CMoveRoutine_003Ed__7 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x4002675")]
		[FieldOffset(Offset = "0x10")]
		private int _003C_003E1__state;

		[Token(Token = "0x4002676")]
		[FieldOffset(Offset = "0x18")]
		private object _003C_003E2__current;

		[Token(Token = "0x4002677")]
		[FieldOffset(Offset = "0x20")]
		public MoveOnInterval _003C_003E4__this;

		[Token(Token = "0x4002678")]
		[FieldOffset(Offset = "0x28")]
		private WaitForSeconds _003C_wait_003E5__2;

		[Token(Token = "0x170003C1")]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002ECurrent
		{
			[Token(Token = "0x600217D")]
			[Address(RVA = "0x17F9D44", Offset = "0x17F9D44", VA = "0x17F9D44", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002Eget_Current();
			}
		}

		[Token(Token = "0x170003C2")]
		private object System_002ECollections_002EIEnumerator_002ECurrent
		{
			[Token(Token = "0x600217F")]
			[Address(RVA = "0x17F9D8C", Offset = "0x17F9D8C", VA = "0x17F9D8C", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return System_002ECollections_002EIEnumerator_002Eget_Current();
			}
		}

		[Token(Token = "0x600217A")]
		[Address(RVA = "0x17F9BC4", Offset = "0x17F9BC4", VA = "0x17F9BC4")]
		[DebuggerHidden]
		public _003CMoveRoutine_003Ed__7(int _003C_003E1__state)
		{
		}

		[Token(Token = "0x600217B")]
		[Address(RVA = "0x17F9BF0", Offset = "0x17F9BF0", VA = "0x17F9BF0", Slot = "5")]
		[DebuggerHidden]
		private void System_002EIDisposable_002EDispose()
		{
		}

		[Token(Token = "0x600217C")]
		[Address(RVA = "0x17F9BF4", Offset = "0x17F9BF4", VA = "0x17F9BF4", Slot = "6")]
		private bool MoveNext()
		{
			return default;
		}

		[Token(Token = "0x600217D")]
		[Address(RVA = "0x17F9D44", Offset = "0x17F9D44", VA = "0x17F9D44", Slot = "4")]
		[DebuggerHidden]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002Eget_Current()
		{
			return null;
		}

		[Token(Token = "0x600217E")]
		[Address(RVA = "0x17F9D4C", Offset = "0x17F9D4C", VA = "0x17F9D4C", Slot = "8")]
		[DebuggerHidden]
		private void System_002ECollections_002EIEnumerator_002EReset()
		{
		}

		[Token(Token = "0x600217F")]
		[Address(RVA = "0x17F9D8C", Offset = "0x17F9D8C", VA = "0x17F9D8C", Slot = "7")]
		[DebuggerHidden]
		private object System_002ECollections_002EIEnumerator_002Eget_Current()
		{
			return null;
		}
	}

	[Token(Token = "0x4002672")]
	[FieldOffset(Offset = "0x20")]
	public float wait;

	[Token(Token = "0x4002673")]
	[FieldOffset(Offset = "0x24")]
	public bool startOnAwake;

	[Token(Token = "0x4002674")]
	[FieldOffset(Offset = "0x25")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x4E99C", Offset = "0x4E99C")]
	private bool Moving__BackingField;

	[Token(Token = "0x170003C0")]
	public bool Moving
	{
		[Token(Token = "0x6002175")]
		[Address(RVA = "0x1573374", Offset = "0x1573374", VA = "0x1573374")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x65C30", Offset = "0x65C30")]
		get
		{
			return default;
		}
		[Token(Token = "0x6002176")]
		[Address(RVA = "0x157337C", Offset = "0x157337C", VA = "0x157337C")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x65C40", Offset = "0x65C40")]
		set
		{
		}
	}

	[Token(Token = "0x6002177")]
	[Address(RVA = "0x1573384", Offset = "0x1573384", VA = "0x1573384", Slot = "4")]
	protected override void Init()
	{
	}

	[Token(Token = "0x6002178")]
	[Address(RVA = "0x1573420", Offset = "0x1573420", VA = "0x1573420")]
	private IEnumerator MoveRoutine()
	{
		return null;
	}

	[Token(Token = "0x6002179")]
	[Address(RVA = "0x1573494", Offset = "0x1573494", VA = "0x1573494")]
	public MoveOnInterval()
	{
	}
}
