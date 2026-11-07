using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using Core;
using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x2000110")]
public class PlayerHit : MonoBehaviour
{
	[Token(Token = "0x2000111")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x3DB30", Offset = "0x3DB30")]
	private sealed class _003CFreezeFrame_003Ed__14 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x40004B3")]
		[FieldOffset(Offset = "0x10")]
		private int _003C_003E1__state;

		[Token(Token = "0x40004B4")]
		[FieldOffset(Offset = "0x18")]
		private object _003C_003E2__current;

		[Token(Token = "0x40004B5")]
		[FieldOffset(Offset = "0x20")]
		private TimeControl _003Ct_003E5__2;

		[Token(Token = "0x170000A7")]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002ECurrent
		{
			[Token(Token = "0x60004B7")]
			[Address(RVA = "0x182902C", Offset = "0x182902C", VA = "0x182902C", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002Eget_Current();
			}
		}

		[Token(Token = "0x170000A8")]
		private object System_002ECollections_002EIEnumerator_002ECurrent
		{
			[Token(Token = "0x60004B9")]
			[Address(RVA = "0x1829074", Offset = "0x1829074", VA = "0x1829074", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return System_002ECollections_002EIEnumerator_002Eget_Current();
			}
		}

		[Token(Token = "0x60004B4")]
		[Address(RVA = "0x1828EE4", Offset = "0x1828EE4", VA = "0x1828EE4")]
		[DebuggerHidden]
		public _003CFreezeFrame_003Ed__14(int _003C_003E1__state)
		{
		}

		[Token(Token = "0x60004B5")]
		[Address(RVA = "0x1828F10", Offset = "0x1828F10", VA = "0x1828F10", Slot = "5")]
		[DebuggerHidden]
		private void System_002EIDisposable_002EDispose()
		{
		}

		[Token(Token = "0x60004B6")]
		[Address(RVA = "0x1828F14", Offset = "0x1828F14", VA = "0x1828F14", Slot = "6")]
		private bool MoveNext()
		{
			return default;
		}

		[Token(Token = "0x60004B7")]
		[Address(RVA = "0x182902C", Offset = "0x182902C", VA = "0x182902C", Slot = "4")]
		[DebuggerHidden]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002Eget_Current()
		{
			return null;
		}

		[Token(Token = "0x60004B8")]
		[Address(RVA = "0x1829034", Offset = "0x1829034", VA = "0x1829034", Slot = "8")]
		[DebuggerHidden]
		private void System_002ECollections_002EIEnumerator_002EReset()
		{
		}

		[Token(Token = "0x60004B9")]
		[Address(RVA = "0x1829074", Offset = "0x1829074", VA = "0x1829074", Slot = "7")]
		[DebuggerHidden]
		private object System_002ECollections_002EIEnumerator_002Eget_Current()
		{
			return null;
		}
	}

	[Token(Token = "0x40004AB")]
	[FieldOffset(Offset = "0x18")]
	public FinalLevel FinalLevel;

	[Token(Token = "0x40004AC")]
	[FieldOffset(Offset = "0x20")]
	public SuperGolfShooter Shooter;

	[Token(Token = "0x40004AD")]
	[FieldOffset(Offset = "0x28")]
	public ParticleSystem Particles;

	[Token(Token = "0x40004AE")]
	[FieldOffset(Offset = "0x30")]
	public Rigidbody Rigidbody;

	[Token(Token = "0x40004AF")]
	[FieldOffset(Offset = "0x38")]
	public float InvisibilityDuration;

	[Token(Token = "0x40004B0")]
	[FieldOffset(Offset = "0x3C")]
	private float baseDrag;

	[Token(Token = "0x40004B1")]
	[FieldOffset(Offset = "0x40")]
	private float invisibilityTimer;

	[Token(Token = "0x40004B2")]
	[FieldOffset(Offset = "0x44")]
	private bool ignoreFirstReset;

	[Token(Token = "0x60004AC")]
	[Address(RVA = "0x15F86A0", Offset = "0x15F86A0", VA = "0x15F86A0")]
	private void Awake()
	{
	}

	[Token(Token = "0x60004AD")]
	[Address(RVA = "0x15F8798", Offset = "0x15F8798", VA = "0x15F8798")]
	private void Start()
	{
	}

	[Token(Token = "0x60004AE")]
	[Address(RVA = "0x15F8834", Offset = "0x15F8834", VA = "0x15F8834")]
	private void OnOnReset()
	{
	}

	[Token(Token = "0x60004AF")]
	[Address(RVA = "0x15F8848", Offset = "0x15F8848", VA = "0x15F8848")]
	private void Update()
	{
	}

	[Token(Token = "0x60004B0")]
	[Address(RVA = "0x15F8888", Offset = "0x15F8888", VA = "0x15F8888")]
	public void OnDeath(SuperGolfShooter obj)
	{
	}

	[Token(Token = "0x60004B1")]
	[Address(RVA = "0x15F88A0", Offset = "0x15F88A0", VA = "0x15F88A0")]
	public void OnDeath(GolfBallController obj)
	{
	}

	[Token(Token = "0x60004B2")]
	[Address(RVA = "0x15F894C", Offset = "0x15F894C", VA = "0x15F894C")]
	private IEnumerator FreezeFrame()
	{
		return null;
	}

	[Token(Token = "0x60004B3")]
	[Address(RVA = "0x15F89A8", Offset = "0x15F89A8", VA = "0x15F89A8")]
	public PlayerHit()
	{
	}
}
