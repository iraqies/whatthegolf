using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using CameraStack;
using Core;
using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x2000454")]
public class MarioPipeTrigger : ChallengeTriggerBase
{
	[Token(Token = "0x2000455")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x3FAFC", Offset = "0x3FAFC")]
	private sealed class _003CPipeRoutine_003Ed__10 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x40017A1")]
		[FieldOffset(Offset = "0x10")]
		private int _003C_003E1__state;

		[Token(Token = "0x40017A2")]
		[FieldOffset(Offset = "0x18")]
		private object _003C_003E2__current;

		[Token(Token = "0x40017A3")]
		[FieldOffset(Offset = "0x20")]
		public MarioPipeTrigger _003C_003E4__this;

		[Token(Token = "0x40017A4")]
		[FieldOffset(Offset = "0x28")]
		private Rigidbody _003Crb_003E5__2;

		[Token(Token = "0x40017A5")]
		[FieldOffset(Offset = "0x30")]
		private float _003Ct_003E5__3;

		[Token(Token = "0x1700023E")]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002ECurrent
		{
			[Token(Token = "0x6001454")]
			[Address(RVA = "0x17F3AB4", Offset = "0x17F3AB4", VA = "0x17F3AB4", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002Eget_Current();
			}
		}

		[Token(Token = "0x1700023F")]
		private object System_002ECollections_002EIEnumerator_002ECurrent
		{
			[Token(Token = "0x6001456")]
			[Address(RVA = "0x17F3AFC", Offset = "0x17F3AFC", VA = "0x17F3AFC", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return System_002ECollections_002EIEnumerator_002Eget_Current();
			}
		}

		[Token(Token = "0x6001451")]
		[Address(RVA = "0x17F35F0", Offset = "0x17F35F0", VA = "0x17F35F0")]
		[DebuggerHidden]
		public _003CPipeRoutine_003Ed__10(int _003C_003E1__state)
		{
		}

		[Token(Token = "0x6001452")]
		[Address(RVA = "0x17F361C", Offset = "0x17F361C", VA = "0x17F361C", Slot = "5")]
		[DebuggerHidden]
		private void System_002EIDisposable_002EDispose()
		{
		}

		[Token(Token = "0x6001453")]
		[Address(RVA = "0x17F3620", Offset = "0x17F3620", VA = "0x17F3620", Slot = "6")]
		private bool MoveNext()
		{
			return default;
		}

		[Token(Token = "0x6001454")]
		[Address(RVA = "0x17F3AB4", Offset = "0x17F3AB4", VA = "0x17F3AB4", Slot = "4")]
		[DebuggerHidden]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002Eget_Current()
		{
			return null;
		}

		[Token(Token = "0x6001455")]
		[Address(RVA = "0x17F3ABC", Offset = "0x17F3ABC", VA = "0x17F3ABC", Slot = "8")]
		[DebuggerHidden]
		private void System_002ECollections_002EIEnumerator_002EReset()
		{
		}

		[Token(Token = "0x6001456")]
		[Address(RVA = "0x17F3AFC", Offset = "0x17F3AFC", VA = "0x17F3AFC", Slot = "7")]
		[DebuggerHidden]
		private object System_002ECollections_002EIEnumerator_002Eget_Current()
		{
			return null;
		}
	}

	[Token(Token = "0x400179B")]
	[FieldOffset(Offset = "0x20")]
	public Vector3 downDirection;

	[Token(Token = "0x400179C")]
	[FieldOffset(Offset = "0x30")]
	public Transform midPointTop;

	[Token(Token = "0x400179D")]
	[FieldOffset(Offset = "0x38")]
	public Collider midCollider;

	[Token(Token = "0x400179E")]
	[FieldOffset(Offset = "0x40")]
	public Collider[] ignoreWith;

	[Token(Token = "0x400179F")]
	[FieldOffset(Offset = "0x48")]
	public CameraBehavior overrideCameraBehaviour;

	[Token(Token = "0x40017A0")]
	[FieldOffset(Offset = "0x50")]
	private GolfBallShooterBase shooter;

	[Token(Token = "0x600144B")]
	[Address(RVA = "0x155E66C", Offset = "0x155E66C", VA = "0x155E66C")]
	private void Awake()
	{
	}

	[Token(Token = "0x600144C")]
	[Address(RVA = "0x155E714", Offset = "0x155E714", VA = "0x155E714")]
	private void OnCollisionEnter(Collision collision)
	{
	}

	[Token(Token = "0x600144D")]
	[Address(RVA = "0x155E84C", Offset = "0x155E84C", VA = "0x155E84C")]
	private void OnCollisionExit(Collision collision)
	{
	}

	[Token(Token = "0x600144E")]
	[Address(RVA = "0x155E9B4", Offset = "0x155E9B4", VA = "0x155E9B4")]
	private void OnShoot(Vector3 obj)
	{
	}

	[Token(Token = "0x600144F")]
	[Address(RVA = "0x155EB2C", Offset = "0x155EB2C", VA = "0x155EB2C")]
	private IEnumerator PipeRoutine()
	{
		return null;
	}

	[Token(Token = "0x6001450")]
	[Address(RVA = "0x155EBA0", Offset = "0x155EBA0", VA = "0x155EBA0")]
	public MarioPipeTrigger()
	{
	}
}
