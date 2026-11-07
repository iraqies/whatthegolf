using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using Il2CppDummyDll;
using RootMotion.Dynamics;
using UnityEngine;

[Token(Token = "0x200023A")]
public class DeliverGasToLawnMover : MonoBehaviour
{
	[Token(Token = "0x200023B")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x3E634", Offset = "0x3E634")]
	private sealed class _003C_003Ec__DisplayClass7_0
	{
		[Token(Token = "0x4000B68")]
		[FieldOffset(Offset = "0x10")]
		public PuppetMasterProp prop;

		[Token(Token = "0x6000A02")]
		[Address(RVA = "0x179AFAC", Offset = "0x179AFAC", VA = "0x179AFAC")]
		public _003C_003Ec__DisplayClass7_0()
		{
		}

		[Token(Token = "0x6000A03")]
		[Address(RVA = "0x179AFB4", Offset = "0x179AFB4", VA = "0x179AFB4")]
		internal void _003CMatchPropAndAnimation_003Eb__0(float t)
		{
		}
	}

	[Token(Token = "0x200023C")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x3E644", Offset = "0x3E644")]
	private sealed class _003CMatchPropAndAnimation_003Ed__7 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x4000B69")]
		[FieldOffset(Offset = "0x10")]
		private int _003C_003E1__state;

		[Token(Token = "0x4000B6A")]
		[FieldOffset(Offset = "0x18")]
		private object _003C_003E2__current;

		[Token(Token = "0x4000B6B")]
		[FieldOffset(Offset = "0x20")]
		public PuppetMasterProp prop;

		[Token(Token = "0x4000B6C")]
		[FieldOffset(Offset = "0x28")]
		public DeliverGasToLawnMover _003C_003E4__this;

		[Token(Token = "0x4000B6D")]
		[FieldOffset(Offset = "0x30")]
		private Collider _003Cc_003E5__2;

		[Token(Token = "0x17000139")]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002ECurrent
		{
			[Token(Token = "0x6000A07")]
			[Address(RVA = "0x179B35C", Offset = "0x179B35C", VA = "0x179B35C", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002Eget_Current();
			}
		}

		[Token(Token = "0x1700013A")]
		private object System_002ECollections_002EIEnumerator_002ECurrent
		{
			[Token(Token = "0x6000A09")]
			[Address(RVA = "0x179B3A4", Offset = "0x179B3A4", VA = "0x179B3A4", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return System_002ECollections_002EIEnumerator_002Eget_Current();
			}
		}

		[Token(Token = "0x6000A04")]
		[Address(RVA = "0x179B110", Offset = "0x179B110", VA = "0x179B110")]
		[DebuggerHidden]
		public _003CMatchPropAndAnimation_003Ed__7(int _003C_003E1__state)
		{
		}

		[Token(Token = "0x6000A05")]
		[Address(RVA = "0x179B13C", Offset = "0x179B13C", VA = "0x179B13C", Slot = "5")]
		[DebuggerHidden]
		private void System_002EIDisposable_002EDispose()
		{
		}

		[Token(Token = "0x6000A06")]
		[Address(RVA = "0x179B140", Offset = "0x179B140", VA = "0x179B140", Slot = "6")]
		private bool MoveNext()
		{
			return default;
		}

		[Token(Token = "0x6000A07")]
		[Address(RVA = "0x179B35C", Offset = "0x179B35C", VA = "0x179B35C", Slot = "4")]
		[DebuggerHidden]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002Eget_Current()
		{
			return null;
		}

		[Token(Token = "0x6000A08")]
		[Address(RVA = "0x179B364", Offset = "0x179B364", VA = "0x179B364", Slot = "8")]
		[DebuggerHidden]
		private void System_002ECollections_002EIEnumerator_002EReset()
		{
		}

		[Token(Token = "0x6000A09")]
		[Address(RVA = "0x179B3A4", Offset = "0x179B3A4", VA = "0x179B3A4", Slot = "7")]
		[DebuggerHidden]
		private object System_002ECollections_002EIEnumerator_002Eget_Current()
		{
			return null;
		}
	}

	[Token(Token = "0x4000B64")]
	[FieldOffset(Offset = "0x18")]
	public Animator Animator;

	[Token(Token = "0x4000B65")]
	[FieldOffset(Offset = "0x20")]
	public Transform PropAnimationAnchor;

	[Token(Token = "0x4000B66")]
	[FieldOffset(Offset = "0x28")]
	public PuppetMaster PlayerPuppet;

	[Token(Token = "0x4000B67")]
	[FieldOffset(Offset = "0x30")]
	private bool hasDelivered;

	[Token(Token = "0x60009FD")]
	[Address(RVA = "0x18D98F0", Offset = "0x18D98F0", VA = "0x18D98F0")]
	private void Start()
	{
	}

	[Token(Token = "0x60009FE")]
	[Address(RVA = "0x18D99DC", Offset = "0x18D99DC", VA = "0x18D99DC")]
	private void OnDropProp(PuppetMasterProp prop)
	{
	}

	[Token(Token = "0x60009FF")]
	[Address(RVA = "0x18D9AD4", Offset = "0x18D9AD4", VA = "0x18D9AD4")]
	private void OnTriggerEnter(Collider other)
	{
	}

	[Token(Token = "0x6000A00")]
	[Address(RVA = "0x18D9A5C", Offset = "0x18D9A5C", VA = "0x18D9A5C")]
	private IEnumerator MatchPropAndAnimation(PuppetMasterProp prop)
	{
		return null;
	}

	[Token(Token = "0x6000A01")]
	[Address(RVA = "0x18D9C3C", Offset = "0x18D9C3C", VA = "0x18D9C3C")]
	public DeliverGasToLawnMover()
	{
	}
}
