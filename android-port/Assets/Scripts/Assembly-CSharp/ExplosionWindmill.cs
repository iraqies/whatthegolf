using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using Audio;
using Core;
using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x2000B05")]
public class ExplosionWindmill : MonoBehaviour
{
	[Token(Token = "0x2000B06")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x43460", Offset = "0x43460")]
	private sealed class _003CBoom_003Ed__11 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x4003D95")]
		[FieldOffset(Offset = "0x10")]
		private int _003C_003E1__state;

		[Token(Token = "0x4003D96")]
		[FieldOffset(Offset = "0x18")]
		private object _003C_003E2__current;

		[Token(Token = "0x17000566")]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002ECurrent
		{
			[Token(Token = "0x60034A1")]
			[Address(RVA = "0x17A1AE0", Offset = "0x17A1AE0", VA = "0x17A1AE0", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002Eget_Current();
			}
		}

		[Token(Token = "0x17000567")]
		private object System_002ECollections_002EIEnumerator_002ECurrent
		{
			[Token(Token = "0x60034A3")]
			[Address(RVA = "0x17A1B28", Offset = "0x17A1B28", VA = "0x17A1B28", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return System_002ECollections_002EIEnumerator_002Eget_Current();
			}
		}

		[Token(Token = "0x600349E")]
		[Address(RVA = "0x17A19C8", Offset = "0x17A19C8", VA = "0x17A19C8")]
		[DebuggerHidden]
		public _003CBoom_003Ed__11(int _003C_003E1__state)
		{
		}

		[Token(Token = "0x600349F")]
		[Address(RVA = "0x17A19F4", Offset = "0x17A19F4", VA = "0x17A19F4", Slot = "5")]
		[DebuggerHidden]
		private void System_002EIDisposable_002EDispose()
		{
		}

		[Token(Token = "0x60034A0")]
		[Address(RVA = "0x17A19F8", Offset = "0x17A19F8", VA = "0x17A19F8", Slot = "6")]
		private bool MoveNext()
		{
			return default;
		}

		[Token(Token = "0x60034A1")]
		[Address(RVA = "0x17A1AE0", Offset = "0x17A1AE0", VA = "0x17A1AE0", Slot = "4")]
		[DebuggerHidden]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002Eget_Current()
		{
			return null;
		}

		[Token(Token = "0x60034A2")]
		[Address(RVA = "0x17A1AE8", Offset = "0x17A1AE8", VA = "0x17A1AE8", Slot = "8")]
		[DebuggerHidden]
		private void System_002ECollections_002EIEnumerator_002EReset()
		{
		}

		[Token(Token = "0x60034A3")]
		[Address(RVA = "0x17A1B28", Offset = "0x17A1B28", VA = "0x17A1B28", Slot = "7")]
		[DebuggerHidden]
		private object System_002ECollections_002EIEnumerator_002Eget_Current()
		{
			return null;
		}
	}

	[Token(Token = "0x4003D8C")]
	[FieldOffset(Offset = "0x18")]
	public ExplosionBarrel barrel;

	[Token(Token = "0x4003D8D")]
	[FieldOffset(Offset = "0x20")]
	public Rigidbody wings;

	[Token(Token = "0x4003D8E")]
	[FieldOffset(Offset = "0x28")]
	public Rigidbody main;

	[Token(Token = "0x4003D8F")]
	[FieldOffset(Offset = "0x30")]
	public Collider mainCollider;

	[Token(Token = "0x4003D90")]
	[FieldOffset(Offset = "0x38")]
	public RotateAxis rotator;

	[Token(Token = "0x4003D91")]
	[FieldOffset(Offset = "0x40")]
	public ClipSettingsCollection explosionSweetenerSFX;

	[Token(Token = "0x4003D92")]
	[FieldOffset(Offset = "0x48")]
	public bool failLevelOnExplode;

	[Token(Token = "0x4003D93")]
	[FieldOffset(Offset = "0x4C")]
	private float delayTimer;

	[Token(Token = "0x4003D94")]
	[FieldOffset(Offset = "0x50")]
	private GolfBallController controller;

	[Token(Token = "0x600349A")]
	[Address(RVA = "0x1453F64", Offset = "0x1453F64", VA = "0x1453F64")]
	private void Start()
	{
	}

	[Token(Token = "0x600349B")]
	[Address(RVA = "0x145407C", Offset = "0x145407C", VA = "0x145407C")]
	private void Barrel_OnExplode(Collider arg1, ExplosionBarrel arg2)
	{
	}

	[Token(Token = "0x600349C")]
	[Address(RVA = "0x145431C", Offset = "0x145431C", VA = "0x145431C")]
	private IEnumerator Boom()
	{
		return null;
	}

	[Token(Token = "0x600349D")]
	[Address(RVA = "0x1454378", Offset = "0x1454378", VA = "0x1454378")]
	public ExplosionWindmill()
	{
	}
}
