using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.InteropServices;
using Audio;
using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x2000841")]
public class SuperGolfThrowableWeapon : SuperGolfGun
{
	[Token(Token = "0x2000842")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x41958", Offset = "0x41958")]
	private sealed class _003CStartShooting_003Ed__13 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x4002CCD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int _003C_003E1__state;

		[Token(Token = "0x4002CCE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object _003C_003E2__current;

		[Token(Token = "0x4002CCF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public SuperGolfThrowableWeapon _003C_003E4__this;

		[Token(Token = "0x4002CD0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public Vector3 direction;

		[Token(Token = "0x4002CD1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public Collider shooterCollider;

		[Token(Token = "0x4002CD2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public Action onFinishedShooting;

		[Token(Token = "0x1700041C")]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002ECurrent
		{
			[Token(Token = "0x600261B")]
			[Address(RVA = "0x185D950", Offset = "0x185D950", VA = "0x185D950", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002Eget_Current();
			}
		}

		[Token(Token = "0x1700041D")]
		private object System_002ECollections_002EIEnumerator_002ECurrent
		{
			[Token(Token = "0x600261D")]
			[Address(RVA = "0x185D998", Offset = "0x185D998", VA = "0x185D998", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return System_002ECollections_002EIEnumerator_002Eget_Current();
			}
		}

		[Token(Token = "0x6002618")]
		[Address(RVA = "0x185D78C", Offset = "0x185D78C", VA = "0x185D78C")]
		[DebuggerHidden]
		public _003CStartShooting_003Ed__13(int _003C_003E1__state)
		{
		}

		[Token(Token = "0x6002619")]
		[Address(RVA = "0x185D7B8", Offset = "0x185D7B8", VA = "0x185D7B8", Slot = "5")]
		[DebuggerHidden]
		private void System_002EIDisposable_002EDispose()
		{
		}

		[Token(Token = "0x600261A")]
		[Address(RVA = "0x185D7BC", Offset = "0x185D7BC", VA = "0x185D7BC", Slot = "6")]
		private bool MoveNext()
		{
			return default;
		}

		[Token(Token = "0x600261B")]
		[Address(RVA = "0x185D950", Offset = "0x185D950", VA = "0x185D950", Slot = "4")]
		[DebuggerHidden]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002Eget_Current()
		{
			return null;
		}

		[Token(Token = "0x600261C")]
		[Address(RVA = "0x185D958", Offset = "0x185D958", VA = "0x185D958", Slot = "8")]
		[DebuggerHidden]
		private void System_002ECollections_002EIEnumerator_002EReset()
		{
		}

		[Token(Token = "0x600261D")]
		[Address(RVA = "0x185D998", Offset = "0x185D998", VA = "0x185D998", Slot = "7")]
		[DebuggerHidden]
		private object System_002ECollections_002EIEnumerator_002Eget_Current()
		{
			return null;
		}
	}

	[Token(Token = "0x4002CC0")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
	public ClipSettingsCollection sfxOnHit;

	[Token(Token = "0x4002CC1")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
	public float ThrowForce;

	[Token(Token = "0x4002CC2")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xB4")]
	public float ThrowUpForce;

	[Token(Token = "0x4002CC3")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
	public float KillForce;

	[Token(Token = "0x4002CC4")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
	public List<string> KillTags;

	[Token(Token = "0x4002CC5")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xC8")]
	public bool CanBePickedUpAfterThrown;

	[Token(Token = "0x4002CC6")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xD0")]
	public ParticleSystem DeadlyParticles;

	[Token(Token = "0x4002CC7")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xD8")]
	private Collider shooterCollider;

	[Token(Token = "0x4002CC8")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xE0")]
	private Vector3 throwDirection;

	[Token(Token = "0x4002CC9")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xEC")]
	private int bouncesLeft;

	[Token(Token = "0x4002CCA")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xF0")]
	private Vector3 lastVel;

	[Token(Token = "0x4002CCB")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xFC")]
	private bool ignoreCollision;

	[Token(Token = "0x4002CCC")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xFD")]
	private bool canBeDeadly;

	[Token(Token = "0x600260E")]
	[Address(RVA = "0x16ED150", Offset = "0x16ED150", VA = "0x16ED150", Slot = "6")]
	protected override IEnumerator StartShooting(Collider shooterCollider, Vector3 direction, [Optional] Action onFinishedShooting)
	{
		return null;
	}

	[Token(Token = "0x600260F")]
	[Address(RVA = "0x16ED1FC", Offset = "0x16ED1FC", VA = "0x16ED1FC")]
	private void FixedUpdate()
	{
	}

	[Token(Token = "0x6002610")]
	[Address(RVA = "0x16ED4B8", Offset = "0x16ED4B8", VA = "0x16ED4B8", Slot = "5")]
	public override bool IsEquipped()
	{
		return default;
	}

	[Token(Token = "0x6002611")]
	[Address(RVA = "0x16ED500", Offset = "0x16ED500", VA = "0x16ED500")]
	public bool IsBeingHeld()
	{
		return default;
	}

	[Token(Token = "0x6002612")]
	[Address(RVA = "0x16ED528", Offset = "0x16ED528", VA = "0x16ED528", Slot = "8")]
	public override void DestroyGun([Optional] Collider shooterCollider)
	{
	}

	[Token(Token = "0x6002613")]
	[Address(RVA = "0x16ED52C", Offset = "0x16ED52C", VA = "0x16ED52C", Slot = "9")]
	public override void ThrowGun(Collider shooterCollider)
	{
	}

	[Token(Token = "0x6002614")]
	[Address(RVA = "0x16ED6B8", Offset = "0x16ED6B8", VA = "0x16ED6B8", Slot = "7")]
	protected override void OnCollisionEnter(Collision other)
	{
	}

	[Token(Token = "0x6002615")]
	[Address(RVA = "0x16ED470", Offset = "0x16ED470", VA = "0x16ED470")]
	private bool IsDeadly()
	{
		return default;
	}

	[Token(Token = "0x6002616")]
	[Address(RVA = "0x16ED83C", Offset = "0x16ED83C", VA = "0x16ED83C")]
	public void IgnoreFirstCollision()
	{
	}

	[Token(Token = "0x6002617")]
	[Address(RVA = "0x16ED848", Offset = "0x16ED848", VA = "0x16ED848")]
	public SuperGolfThrowableWeapon()
	{
	}
}
