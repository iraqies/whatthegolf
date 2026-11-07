using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using Core;
using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x200070D")]
public class ArrowShootRagdoll : MonoBehaviour
{
	[Token(Token = "0x200070E")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x41220", Offset = "0x41220")]
	private sealed class _003CStart_003Ed__3 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x400251E")]
		[FieldOffset(Offset = "0x10")]
		private int _003C_003E1__state;

		[Token(Token = "0x400251F")]
		[FieldOffset(Offset = "0x18")]
		private object _003C_003E2__current;

		[Token(Token = "0x4002520")]
		[FieldOffset(Offset = "0x20")]
		public ArrowShootRagdoll _003C_003E4__this;

		[Token(Token = "0x170003B3")]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002ECurrent
		{
			[Token(Token = "0x600208F")]
			[Address(RVA = "0x176F150", Offset = "0x176F150", VA = "0x176F150", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002Eget_Current();
			}
		}

		[Token(Token = "0x170003B4")]
		private object System_002ECollections_002EIEnumerator_002ECurrent
		{
			[Token(Token = "0x6002091")]
			[Address(RVA = "0x176F198", Offset = "0x176F198", VA = "0x176F198", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return System_002ECollections_002EIEnumerator_002Eget_Current();
			}
		}

		[Token(Token = "0x600208C")]
		[Address(RVA = "0x176F014", Offset = "0x176F014", VA = "0x176F014")]
		[DebuggerHidden]
		public _003CStart_003Ed__3(int _003C_003E1__state)
		{
		}

		[Token(Token = "0x600208D")]
		[Address(RVA = "0x176F040", Offset = "0x176F040", VA = "0x176F040", Slot = "5")]
		[DebuggerHidden]
		private void System_002EIDisposable_002EDispose()
		{
		}

		[Token(Token = "0x600208E")]
		[Address(RVA = "0x176F044", Offset = "0x176F044", VA = "0x176F044", Slot = "6")]
		private bool MoveNext()
		{
			return default;
		}

		[Token(Token = "0x600208F")]
		[Address(RVA = "0x176F150", Offset = "0x176F150", VA = "0x176F150", Slot = "4")]
		[DebuggerHidden]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002Eget_Current()
		{
			return null;
		}

		[Token(Token = "0x6002090")]
		[Address(RVA = "0x176F158", Offset = "0x176F158", VA = "0x176F158", Slot = "8")]
		[DebuggerHidden]
		private void System_002ECollections_002EIEnumerator_002EReset()
		{
		}

		[Token(Token = "0x6002091")]
		[Address(RVA = "0x176F198", Offset = "0x176F198", VA = "0x176F198", Slot = "7")]
		[DebuggerHidden]
		private object System_002ECollections_002EIEnumerator_002Eget_Current()
		{
			return null;
		}
	}

	[Token(Token = "0x400251B")]
	[FieldOffset(Offset = "0x18")]
	public GameObject ragdoll;

	[Token(Token = "0x400251C")]
	[FieldOffset(Offset = "0x20")]
	public GolfBallController ragdollController;

	[Token(Token = "0x400251D")]
	[FieldOffset(Offset = "0x28")]
	public GolfBallController archerController;

	[Token(Token = "0x6002089")]
	[Address(RVA = "0x142884C", Offset = "0x142884C", VA = "0x142884C")]
	private IEnumerator Start()
	{
		return null;
	}

	[Token(Token = "0x600208A")]
	[Address(RVA = "0x14288C0", Offset = "0x14288C0", VA = "0x14288C0")]
	private void Controller_OnPreShoot(Vector3 boost)
	{
	}

	[Token(Token = "0x600208B")]
	[Address(RVA = "0x1428A20", Offset = "0x1428A20", VA = "0x1428A20")]
	public ArrowShootRagdoll()
	{
	}
}
