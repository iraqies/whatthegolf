using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using CameraStack;
using Core;
using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x200044C")]
public class CrabDancePhase : MonoBehaviour
{
	[Token(Token = "0x200044D")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x3FACC", Offset = "0x3FACC")]
	private sealed class _003CDanceRoutine_003Ed__6 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x4001763")]
		[FieldOffset(Offset = "0x10")]
		private int _003C_003E1__state;

		[Token(Token = "0x4001764")]
		[FieldOffset(Offset = "0x18")]
		private object _003C_003E2__current;

		[Token(Token = "0x4001765")]
		[FieldOffset(Offset = "0x20")]
		public CBFollow follow;

		[Token(Token = "0x4001766")]
		[FieldOffset(Offset = "0x28")]
		public CrabDancePhase _003C_003E4__this;

		[Token(Token = "0x4001767")]
		[FieldOffset(Offset = "0x30")]
		private float _003CstartElevation_003E5__2;

		[Token(Token = "0x4001768")]
		[FieldOffset(Offset = "0x34")]
		private float _003Ctimer_003E5__3;

		[Token(Token = "0x1700023C")]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002ECurrent
		{
			[Token(Token = "0x600142A")]
			[Address(RVA = "0x179146C", Offset = "0x179146C", VA = "0x179146C", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002Eget_Current();
			}
		}

		[Token(Token = "0x1700023D")]
		private object System_002ECollections_002EIEnumerator_002ECurrent
		{
			[Token(Token = "0x600142C")]
			[Address(RVA = "0x17914B4", Offset = "0x17914B4", VA = "0x17914B4", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return System_002ECollections_002EIEnumerator_002Eget_Current();
			}
		}

		[Token(Token = "0x6001427")]
		[Address(RVA = "0x1791354", Offset = "0x1791354", VA = "0x1791354")]
		[DebuggerHidden]
		public _003CDanceRoutine_003Ed__6(int _003C_003E1__state)
		{
		}

		[Token(Token = "0x6001428")]
		[Address(RVA = "0x1791380", Offset = "0x1791380", VA = "0x1791380", Slot = "5")]
		[DebuggerHidden]
		private void System_002EIDisposable_002EDispose()
		{
		}

		[Token(Token = "0x6001429")]
		[Address(RVA = "0x1791384", Offset = "0x1791384", VA = "0x1791384", Slot = "6")]
		private bool MoveNext()
		{
			return default;
		}

		[Token(Token = "0x600142A")]
		[Address(RVA = "0x179146C", Offset = "0x179146C", VA = "0x179146C", Slot = "4")]
		[DebuggerHidden]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002Eget_Current()
		{
			return null;
		}

		[Token(Token = "0x600142B")]
		[Address(RVA = "0x1791474", Offset = "0x1791474", VA = "0x1791474", Slot = "8")]
		[DebuggerHidden]
		private void System_002ECollections_002EIEnumerator_002EReset()
		{
		}

		[Token(Token = "0x600142C")]
		[Address(RVA = "0x17914B4", Offset = "0x17914B4", VA = "0x17914B4", Slot = "7")]
		[DebuggerHidden]
		private object System_002ECollections_002EIEnumerator_002Eget_Current()
		{
			return null;
		}
	}

	[Token(Token = "0x400175E")]
	[FieldOffset(Offset = "0x18")]
	public Rigidbody crabRigidbody;

	[Token(Token = "0x400175F")]
	[FieldOffset(Offset = "0x20")]
	public GolfBallController controller;

	[Token(Token = "0x4001760")]
	[FieldOffset(Offset = "0x28")]
	public Transform crabHead;

	[Token(Token = "0x4001761")]
	[FieldOffset(Offset = "0x30")]
	public float endElevation;

	[Token(Token = "0x4001762")]
	[FieldOffset(Offset = "0x34")]
	public float time;

	[Token(Token = "0x6001424")]
	[Address(RVA = "0x18BAF98", Offset = "0x18BAF98", VA = "0x18BAF98")]
	public void StartDanceRoutine()
	{
	}

	[Token(Token = "0x6001425")]
	[Address(RVA = "0x18BB0AC", Offset = "0x18BB0AC", VA = "0x18BB0AC")]
	private IEnumerator DanceRoutine(CBFollow follow)
	{
		return null;
	}

	[Token(Token = "0x6001426")]
	[Address(RVA = "0x18BB124", Offset = "0x18BB124", VA = "0x18BB124")]
	public CrabDancePhase()
	{
	}
}
