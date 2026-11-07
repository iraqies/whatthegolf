using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x2000DBD")]
public class OverworldComputerChangePersonalityOnHit : MonoBehaviour
{
	[Token(Token = "0x2000DBE")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x44C90", Offset = "0x44C90")]
	private sealed class _003CHit_003Ed__6 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x4004AF4")]
		[FieldOffset(Offset = "0x10")]
		private int _003C_003E1__state;

		[Token(Token = "0x4004AF5")]
		[FieldOffset(Offset = "0x18")]
		private object _003C_003E2__current;

		[Token(Token = "0x4004AF6")]
		[FieldOffset(Offset = "0x20")]
		public OverworldComputerChangePersonalityOnHit _003C_003E4__this;

		[Token(Token = "0x170006A6")]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002ECurrent
		{
			[Token(Token = "0x60040BC")]
			[Address(RVA = "0x180F114", Offset = "0x180F114", VA = "0x180F114", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002Eget_Current();
			}
		}

		[Token(Token = "0x170006A7")]
		private object System_002ECollections_002EIEnumerator_002ECurrent
		{
			[Token(Token = "0x60040BE")]
			[Address(RVA = "0x180F15C", Offset = "0x180F15C", VA = "0x180F15C", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return System_002ECollections_002EIEnumerator_002Eget_Current();
			}
		}

		[Token(Token = "0x60040B9")]
		[Address(RVA = "0x180EF74", Offset = "0x180EF74", VA = "0x180EF74")]
		[DebuggerHidden]
		public _003CHit_003Ed__6(int _003C_003E1__state)
		{
		}

		[Token(Token = "0x60040BA")]
		[Address(RVA = "0x180EFA0", Offset = "0x180EFA0", VA = "0x180EFA0", Slot = "5")]
		[DebuggerHidden]
		private void System_002EIDisposable_002EDispose()
		{
		}

		[Token(Token = "0x60040BB")]
		[Address(RVA = "0x180EFA4", Offset = "0x180EFA4", VA = "0x180EFA4", Slot = "6")]
		private bool MoveNext()
		{
			return default;
		}

		[Token(Token = "0x60040BC")]
		[Address(RVA = "0x180F114", Offset = "0x180F114", VA = "0x180F114", Slot = "4")]
		[DebuggerHidden]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002Eget_Current()
		{
			return null;
		}

		[Token(Token = "0x60040BD")]
		[Address(RVA = "0x180F11C", Offset = "0x180F11C", VA = "0x180F11C", Slot = "8")]
		[DebuggerHidden]
		private void System_002ECollections_002EIEnumerator_002EReset()
		{
		}

		[Token(Token = "0x60040BE")]
		[Address(RVA = "0x180F15C", Offset = "0x180F15C", VA = "0x180F15C", Slot = "7")]
		[DebuggerHidden]
		private object System_002ECollections_002EIEnumerator_002Eget_Current()
		{
			return null;
		}
	}

	[Token(Token = "0x4004AF0")]
	[FieldOffset(Offset = "0x18")]
	[SerializeField]
	private Animator _face;

	[Token(Token = "0x4004AF1")]
	[FieldOffset(Offset = "0x20")]
	[SerializeField]
	private float _duration;

	[Token(Token = "0x4004AF2")]
	[FieldOffset(Offset = "0x0")]
	private static readonly int PersonalityState;

	[Token(Token = "0x4004AF3")]
	[FieldOffset(Offset = "0x4")]
	private static readonly int ScanLines;

	[Token(Token = "0x60040B4")]
	[Address(RVA = "0x15B038C", Offset = "0x15B038C", VA = "0x15B038C")]
	private void Start()
	{
	}

	[Token(Token = "0x60040B5")]
	[Address(RVA = "0x15B041C", Offset = "0x15B041C", VA = "0x15B041C")]
	private void OnCollisionEnter2D(Collision2D col)
	{
	}

	[Token(Token = "0x60040B6")]
	[Address(RVA = "0x15B0550", Offset = "0x15B0550", VA = "0x15B0550")]
	private IEnumerator Hit()
	{
		return null;
	}

	[Token(Token = "0x60040B7")]
	[Address(RVA = "0x15B05C4", Offset = "0x15B05C4", VA = "0x15B05C4")]
	public OverworldComputerChangePersonalityOnHit()
	{
	}
}
