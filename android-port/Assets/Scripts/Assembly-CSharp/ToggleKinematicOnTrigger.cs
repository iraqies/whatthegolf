using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x2000B37")]
public class ToggleKinematicOnTrigger : MonoBehaviour
{
	[Token(Token = "0x2000B38")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x43740", Offset = "0x43740")]
	private sealed class _003CDelayedToggle_003Ed__4 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x4003E9C")]
		[FieldOffset(Offset = "0x10")]
		private int _003C_003E1__state;

		[Token(Token = "0x4003E9D")]
		[FieldOffset(Offset = "0x18")]
		private object _003C_003E2__current;

		[Token(Token = "0x4003E9E")]
		[FieldOffset(Offset = "0x20")]
		public ToggleKinematicOnTrigger _003C_003E4__this;

		[Token(Token = "0x4003E9F")]
		[FieldOffset(Offset = "0x28")]
		public Rigidbody rigid;

		[Token(Token = "0x1700056F")]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002ECurrent
		{
			[Token(Token = "0x6003568")]
			[Address(RVA = "0x1868FA8", Offset = "0x1868FA8", VA = "0x1868FA8", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002Eget_Current();
			}
		}

		[Token(Token = "0x17000570")]
		private object System_002ECollections_002EIEnumerator_002ECurrent
		{
			[Token(Token = "0x600356A")]
			[Address(RVA = "0x1868FF0", Offset = "0x1868FF0", VA = "0x1868FF0", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return System_002ECollections_002EIEnumerator_002Eget_Current();
			}
		}

		[Token(Token = "0x6003565")]
		[Address(RVA = "0x1868EAC", Offset = "0x1868EAC", VA = "0x1868EAC")]
		[DebuggerHidden]
		public _003CDelayedToggle_003Ed__4(int _003C_003E1__state)
		{
		}

		[Token(Token = "0x6003566")]
		[Address(RVA = "0x1868ED8", Offset = "0x1868ED8", VA = "0x1868ED8", Slot = "5")]
		[DebuggerHidden]
		private void System_002EIDisposable_002EDispose()
		{
		}

		[Token(Token = "0x6003567")]
		[Address(RVA = "0x1868EDC", Offset = "0x1868EDC", VA = "0x1868EDC", Slot = "6")]
		private bool MoveNext()
		{
			return default;
		}

		[Token(Token = "0x6003568")]
		[Address(RVA = "0x1868FA8", Offset = "0x1868FA8", VA = "0x1868FA8", Slot = "4")]
		[DebuggerHidden]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002Eget_Current()
		{
			return null;
		}

		[Token(Token = "0x6003569")]
		[Address(RVA = "0x1868FB0", Offset = "0x1868FB0", VA = "0x1868FB0", Slot = "8")]
		[DebuggerHidden]
		private void System_002ECollections_002EIEnumerator_002EReset()
		{
		}

		[Token(Token = "0x600356A")]
		[Address(RVA = "0x1868FF0", Offset = "0x1868FF0", VA = "0x1868FF0", Slot = "7")]
		[DebuggerHidden]
		private object System_002ECollections_002EIEnumerator_002Eget_Current()
		{
			return null;
		}
	}

	[Token(Token = "0x4003E99")]
	[FieldOffset(Offset = "0x18")]
	[SerializeField]
	private LayerMask layerMask;

	[Token(Token = "0x4003E9A")]
	[FieldOffset(Offset = "0x1C")]
	[SerializeField]
	private bool kinematicState;

	[Token(Token = "0x4003E9B")]
	[FieldOffset(Offset = "0x20")]
	[SerializeField]
	private float delay;

	[Token(Token = "0x6003562")]
	[Address(RVA = "0x171B5A0", Offset = "0x171B5A0", VA = "0x171B5A0")]
	private void OnTriggerEnter(Collider other)
	{
	}

	[Token(Token = "0x6003563")]
	[Address(RVA = "0x171B72C", Offset = "0x171B72C", VA = "0x171B72C")]
	private IEnumerator DelayedToggle(Rigidbody rigid)
	{
		return null;
	}

	[Token(Token = "0x6003564")]
	[Address(RVA = "0x171B7A4", Offset = "0x171B7A4", VA = "0x171B7A4")]
	public ToggleKinematicOnTrigger()
	{
	}
}
