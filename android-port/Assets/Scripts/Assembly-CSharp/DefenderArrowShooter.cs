using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using Core;
using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x20007BF")]
public class DefenderArrowShooter : GolfBallShooterBase
{
	[Token(Token = "0x20007C0")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x415C0", Offset = "0x415C0")]
	private sealed class _003CStart_003Ed__10 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x4002903")]
		[FieldOffset(Offset = "0x10")]
		private int _003C_003E1__state;

		[Token(Token = "0x4002904")]
		[FieldOffset(Offset = "0x18")]
		private object _003C_003E2__current;

		[Token(Token = "0x4002905")]
		[FieldOffset(Offset = "0x20")]
		public DefenderArrowShooter _003C_003E4__this;

		[Token(Token = "0x170003E1")]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002ECurrent
		{
			[Token(Token = "0x600237D")]
			[Address(RVA = "0x179AE0C", Offset = "0x179AE0C", VA = "0x179AE0C", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002Eget_Current();
			}
		}

		[Token(Token = "0x170003E2")]
		private object System_002ECollections_002EIEnumerator_002ECurrent
		{
			[Token(Token = "0x600237F")]
			[Address(RVA = "0x179AE54", Offset = "0x179AE54", VA = "0x179AE54", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return System_002ECollections_002EIEnumerator_002Eget_Current();
			}
		}

		[Token(Token = "0x600237A")]
		[Address(RVA = "0x179AAB0", Offset = "0x179AAB0", VA = "0x179AAB0")]
		[DebuggerHidden]
		public _003CStart_003Ed__10(int _003C_003E1__state)
		{
		}

		[Token(Token = "0x600237B")]
		[Address(RVA = "0x179AADC", Offset = "0x179AADC", VA = "0x179AADC", Slot = "5")]
		[DebuggerHidden]
		private void System_002EIDisposable_002EDispose()
		{
		}

		[Token(Token = "0x600237C")]
		[Address(RVA = "0x179AAE0", Offset = "0x179AAE0", VA = "0x179AAE0", Slot = "6")]
		private bool MoveNext()
		{
			return default;
		}

		[Token(Token = "0x600237D")]
		[Address(RVA = "0x179AE0C", Offset = "0x179AE0C", VA = "0x179AE0C", Slot = "4")]
		[DebuggerHidden]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002Eget_Current()
		{
			return null;
		}

		[Token(Token = "0x600237E")]
		[Address(RVA = "0x179AE14", Offset = "0x179AE14", VA = "0x179AE14", Slot = "8")]
		[DebuggerHidden]
		private void System_002ECollections_002EIEnumerator_002EReset()
		{
		}

		[Token(Token = "0x600237F")]
		[Address(RVA = "0x179AE54", Offset = "0x179AE54", VA = "0x179AE54", Slot = "7")]
		[DebuggerHidden]
		private object System_002ECollections_002EIEnumerator_002Eget_Current()
		{
			return null;
		}
	}

	[Token(Token = "0x40028FA")]
	[FieldOffset(Offset = "0x60")]
	public Transform ColliderObject;

	[Token(Token = "0x40028FB")]
	[FieldOffset(Offset = "0x68")]
	public float MaxColliderLength;

	[Token(Token = "0x40028FC")]
	[FieldOffset(Offset = "0x6C")]
	public LayerMask GroundLayer;

	[Token(Token = "0x40028FD")]
	[FieldOffset(Offset = "0x70")]
	public float GroundCheckSize;

	[Token(Token = "0x40028FE")]
	[FieldOffset(Offset = "0x74")]
	public Vector2 ColliderResizeRange;

	[Token(Token = "0x40028FF")]
	[FieldOffset(Offset = "0x7C")]
	public float SmoothedPhysicsSpeed;

	[Token(Token = "0x4002900")]
	[FieldOffset(Offset = "0x80")]
	public float CapsuleColliderMod;

	[Token(Token = "0x4002901")]
	[FieldOffset(Offset = "0x88")]
	private CapsuleCollider spawnedCollider;

	[Token(Token = "0x4002902")]
	[FieldOffset(Offset = "0x90")]
	private bool initialized;

	[Token(Token = "0x6002374")]
	[Address(RVA = "0x18D8EE8", Offset = "0x18D8EE8", VA = "0x18D8EE8", Slot = "11")]
	protected override void Awake()
	{
	}

	[Token(Token = "0x6002375")]
	[Address(RVA = "0x18D8EF0", Offset = "0x18D8EF0", VA = "0x18D8EF0")]
	private IEnumerator Start()
	{
		return null;
	}

	[Token(Token = "0x6002376")]
	[Address(RVA = "0x18D8F64", Offset = "0x18D8F64", VA = "0x18D8F64", Slot = "12")]
	protected override void FixedUpdate()
	{
	}

	[Token(Token = "0x6002377")]
	[Address(RVA = "0x18D90CC", Offset = "0x18D90CC", VA = "0x18D90CC", Slot = "5")]
	public override void OnAimStart()
	{
	}

	[Token(Token = "0x6002378")]
	[Address(RVA = "0x18D9138", Offset = "0x18D9138", VA = "0x18D9138", Slot = "6")]
	public override void OnAimUpdate(Vector3 dir, bool onlyAimArrow)
	{
	}

	[Token(Token = "0x6002379")]
	[Address(RVA = "0x18D9178", Offset = "0x18D9178", VA = "0x18D9178")]
	public DefenderArrowShooter()
	{
	}
}
