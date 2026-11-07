using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x200059B")]
public class ConfettiTrigger : MonoBehaviour
{
	[Token(Token = "0x200059C")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x407A0", Offset = "0x407A0")]
	private sealed class _003CMakeConfetti_003Ed__6 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x4001CB0")]
		[FieldOffset(Offset = "0x10")]
		private int _003C_003E1__state;

		[Token(Token = "0x4001CB1")]
		[FieldOffset(Offset = "0x18")]
		private object _003C_003E2__current;

		[Token(Token = "0x4001CB2")]
		[FieldOffset(Offset = "0x20")]
		public ConfettiTrigger _003C_003E4__this;

		[Token(Token = "0x4001CB3")]
		[FieldOffset(Offset = "0x28")]
		private int _003Ci_003E5__2;

		[Token(Token = "0x4001CB4")]
		[FieldOffset(Offset = "0x2C")]
		private int _003Cc_003E5__3;

		[Token(Token = "0x170002CB")]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002ECurrent
		{
			[Token(Token = "0x6001996")]
			[Address(RVA = "0x178F484", Offset = "0x178F484", VA = "0x178F484", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002Eget_Current();
			}
		}

		[Token(Token = "0x170002CC")]
		private object System_002ECollections_002EIEnumerator_002ECurrent
		{
			[Token(Token = "0x6001998")]
			[Address(RVA = "0x178F4CC", Offset = "0x178F4CC", VA = "0x178F4CC", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return System_002ECollections_002EIEnumerator_002Eget_Current();
			}
		}

		[Token(Token = "0x6001993")]
		[Address(RVA = "0x178F348", Offset = "0x178F348", VA = "0x178F348")]
		[DebuggerHidden]
		public _003CMakeConfetti_003Ed__6(int _003C_003E1__state)
		{
		}

		[Token(Token = "0x6001994")]
		[Address(RVA = "0x178F374", Offset = "0x178F374", VA = "0x178F374", Slot = "5")]
		[DebuggerHidden]
		private void System_002EIDisposable_002EDispose()
		{
		}

		[Token(Token = "0x6001995")]
		[Address(RVA = "0x178F378", Offset = "0x178F378", VA = "0x178F378", Slot = "6")]
		private bool MoveNext()
		{
			return default;
		}

		[Token(Token = "0x6001996")]
		[Address(RVA = "0x178F484", Offset = "0x178F484", VA = "0x178F484", Slot = "4")]
		[DebuggerHidden]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002Eget_Current()
		{
			return null;
		}

		[Token(Token = "0x6001997")]
		[Address(RVA = "0x178F48C", Offset = "0x178F48C", VA = "0x178F48C", Slot = "8")]
		[DebuggerHidden]
		private void System_002ECollections_002EIEnumerator_002EReset()
		{
		}

		[Token(Token = "0x6001998")]
		[Address(RVA = "0x178F4CC", Offset = "0x178F4CC", VA = "0x178F4CC", Slot = "7")]
		[DebuggerHidden]
		private object System_002ECollections_002EIEnumerator_002Eget_Current()
		{
			return null;
		}
	}

	[Token(Token = "0x4001CAB")]
	[FieldOffset(Offset = "0x18")]
	public ConfettiSpawner confetti;

	[Token(Token = "0x4001CAC")]
	[FieldOffset(Offset = "0x20")]
	public Transform spotleft;

	[Token(Token = "0x4001CAD")]
	[FieldOffset(Offset = "0x28")]
	public Transform spotRight;

	[Token(Token = "0x4001CAE")]
	[FieldOffset(Offset = "0x30")]
	public float OfflineTime;

	[Token(Token = "0x4001CAF")]
	[FieldOffset(Offset = "0x34")]
	private float nextConfetti;

	[Token(Token = "0x6001990")]
	[Address(RVA = "0x18ABD50", Offset = "0x18ABD50", VA = "0x18ABD50")]
	private void OnTriggerEnter2D(Collider2D collision)
	{
	}

	[Token(Token = "0x6001991")]
	[Address(RVA = "0x18ABEE4", Offset = "0x18ABEE4", VA = "0x18ABEE4")]
	private IEnumerator MakeConfetti()
	{
		return null;
	}

	[Token(Token = "0x6001992")]
	[Address(RVA = "0x18ABF58", Offset = "0x18ABF58", VA = "0x18ABF58")]
	public ConfettiTrigger()
	{
	}
}
