using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.Events;

[Token(Token = "0x2000D81")]
public class GooBossParticleCollision : MonoBehaviour
{
	[Token(Token = "0x2000D82")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x44A88", Offset = "0x44A88")]
	private sealed class _003CCoolDown_003Ed__11 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x4004974")]
		[FieldOffset(Offset = "0x10")]
		private int _003C_003E1__state;

		[Token(Token = "0x4004975")]
		[FieldOffset(Offset = "0x18")]
		private object _003C_003E2__current;

		[Token(Token = "0x4004976")]
		[FieldOffset(Offset = "0x20")]
		public GooBossParticleCollision _003C_003E4__this;

		[Token(Token = "0x17000677")]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002ECurrent
		{
			[Token(Token = "0x6003F7F")]
			[Address(RVA = "0x17B6D1C", Offset = "0x17B6D1C", VA = "0x17B6D1C", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002Eget_Current();
			}
		}

		[Token(Token = "0x17000678")]
		private object System_002ECollections_002EIEnumerator_002ECurrent
		{
			[Token(Token = "0x6003F81")]
			[Address(RVA = "0x17B6D64", Offset = "0x17B6D64", VA = "0x17B6D64", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return System_002ECollections_002EIEnumerator_002Eget_Current();
			}
		}

		[Token(Token = "0x6003F7C")]
		[Address(RVA = "0x17B6C28", Offset = "0x17B6C28", VA = "0x17B6C28")]
		[DebuggerHidden]
		public _003CCoolDown_003Ed__11(int _003C_003E1__state)
		{
		}

		[Token(Token = "0x6003F7D")]
		[Address(RVA = "0x17B6C54", Offset = "0x17B6C54", VA = "0x17B6C54", Slot = "5")]
		[DebuggerHidden]
		private void System_002EIDisposable_002EDispose()
		{
		}

		[Token(Token = "0x6003F7E")]
		[Address(RVA = "0x17B6C58", Offset = "0x17B6C58", VA = "0x17B6C58", Slot = "6")]
		private bool MoveNext()
		{
			return default;
		}

		[Token(Token = "0x6003F7F")]
		[Address(RVA = "0x17B6D1C", Offset = "0x17B6D1C", VA = "0x17B6D1C", Slot = "4")]
		[DebuggerHidden]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002Eget_Current()
		{
			return null;
		}

		[Token(Token = "0x6003F80")]
		[Address(RVA = "0x17B6D24", Offset = "0x17B6D24", VA = "0x17B6D24", Slot = "8")]
		[DebuggerHidden]
		private void System_002ECollections_002EIEnumerator_002EReset()
		{
		}

		[Token(Token = "0x6003F81")]
		[Address(RVA = "0x17B6D64", Offset = "0x17B6D64", VA = "0x17B6D64", Slot = "7")]
		[DebuggerHidden]
		private object System_002ECollections_002EIEnumerator_002Eget_Current()
		{
			return null;
		}
	}

	[Token(Token = "0x400496B")]
	[FieldOffset(Offset = "0x18")]
	private ParticleSystem part;

	[Token(Token = "0x400496C")]
	[FieldOffset(Offset = "0x20")]
	public SphereCollider playerCollider;

	[Token(Token = "0x400496D")]
	[FieldOffset(Offset = "0x28")]
	public PhysicMaterial noFrictionMaterial;

	[Token(Token = "0x400496E")]
	[FieldOffset(Offset = "0x30")]
	public PhysicMaterial highFrictionMaterial;

	[Token(Token = "0x400496F")]
	[FieldOffset(Offset = "0x38")]
	public ParticleSystem collisionParticles;

	[Token(Token = "0x4004970")]
	[FieldOffset(Offset = "0x40")]
	private bool canPlayCollisionParticles;

	[Token(Token = "0x4004971")]
	[FieldOffset(Offset = "0x48")]
	public List<ParticleCollisionEvent> collisionEvents;

	[Token(Token = "0x4004972")]
	[FieldOffset(Offset = "0x50")]
	public UnityEvent ChangeController;

	[Token(Token = "0x4004973")]
	[FieldOffset(Offset = "0x58")]
	private bool hasControllerChanged;

	[Token(Token = "0x6003F78")]
	[Address(RVA = "0x14A6978", Offset = "0x14A6978", VA = "0x14A6978")]
	private void Start()
	{
	}

	[Token(Token = "0x6003F79")]
	[Address(RVA = "0x14A6A1C", Offset = "0x14A6A1C", VA = "0x14A6A1C")]
	private void OnParticleCollision(GameObject other)
	{
	}

	[Token(Token = "0x6003F7A")]
	[Address(RVA = "0x14A6B7C", Offset = "0x14A6B7C", VA = "0x14A6B7C")]
	private IEnumerator CoolDown()
	{
		return null;
	}

	[Token(Token = "0x6003F7B")]
	[Address(RVA = "0x14A6BF0", Offset = "0x14A6BF0", VA = "0x14A6BF0")]
	public GooBossParticleCollision()
	{
	}
}
