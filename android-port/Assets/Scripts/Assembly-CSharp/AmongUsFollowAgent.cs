using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.AI;
using UnityEngine.Events;

[Token(Token = "0x2000E04")]
public class AmongUsFollowAgent : MonoBehaviour
{
	[Token(Token = "0x2000E05")]
	private enum GooseState
	{
		[Token(Token = "0x4004C4D")]
		CHASE = 0,
		[Token(Token = "0x4004C4E")]
		KICK = 1
	}

	[Token(Token = "0x2000E06")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x44E28", Offset = "0x44E28")]
	private sealed class _003CTryKickBall_003Ed__14 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x4004C4F")]
		[FieldOffset(Offset = "0x10")]
		private int _003C_003E1__state;

		[Token(Token = "0x4004C50")]
		[FieldOffset(Offset = "0x18")]
		private object _003C_003E2__current;

		[Token(Token = "0x4004C51")]
		[FieldOffset(Offset = "0x20")]
		public AmongUsFollowAgent _003C_003E4__this;

		[Token(Token = "0x170006C6")]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002ECurrent
		{
			[Token(Token = "0x60041F7")]
			[Address(RVA = "0x176A12C", Offset = "0x176A12C", VA = "0x176A12C", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002Eget_Current();
			}
		}

		[Token(Token = "0x170006C7")]
		private object System_002ECollections_002EIEnumerator_002ECurrent
		{
			[Token(Token = "0x60041F9")]
			[Address(RVA = "0x176A174", Offset = "0x176A174", VA = "0x176A174", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return System_002ECollections_002EIEnumerator_002Eget_Current();
			}
		}

		[Token(Token = "0x60041F4")]
		[Address(RVA = "0x1769E88", Offset = "0x1769E88", VA = "0x1769E88")]
		[DebuggerHidden]
		public _003CTryKickBall_003Ed__14(int _003C_003E1__state)
		{
		}

		[Token(Token = "0x60041F5")]
		[Address(RVA = "0x1769EB4", Offset = "0x1769EB4", VA = "0x1769EB4", Slot = "5")]
		[DebuggerHidden]
		private void System_002EIDisposable_002EDispose()
		{
		}

		[Token(Token = "0x60041F6")]
		[Address(RVA = "0x1769EB8", Offset = "0x1769EB8", VA = "0x1769EB8", Slot = "6")]
		private bool MoveNext()
		{
			return default;
		}

		[Token(Token = "0x60041F7")]
		[Address(RVA = "0x176A12C", Offset = "0x176A12C", VA = "0x176A12C", Slot = "4")]
		[DebuggerHidden]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002Eget_Current()
		{
			return null;
		}

		[Token(Token = "0x60041F8")]
		[Address(RVA = "0x176A134", Offset = "0x176A134", VA = "0x176A134", Slot = "8")]
		[DebuggerHidden]
		private void System_002ECollections_002EIEnumerator_002EReset()
		{
		}

		[Token(Token = "0x60041F9")]
		[Address(RVA = "0x176A174", Offset = "0x176A174", VA = "0x176A174", Slot = "7")]
		[DebuggerHidden]
		private object System_002ECollections_002EIEnumerator_002Eget_Current()
		{
			return null;
		}
	}

	[Token(Token = "0x4004C42")]
	[FieldOffset(Offset = "0x18")]
	private GooseState currentState;

	[Token(Token = "0x4004C43")]
	[FieldOffset(Offset = "0x20")]
	[SerializeField]
	private NavMeshAgent agent;

	[Token(Token = "0x4004C44")]
	[FieldOffset(Offset = "0x28")]
	[SerializeField]
	private float yeetForce;

	[Token(Token = "0x4004C45")]
	[FieldOffset(Offset = "0x2C")]
	[SerializeField]
	private float attackRange;

	[Token(Token = "0x4004C46")]
	[FieldOffset(Offset = "0x30")]
	public Transform chaseTarget;

	[Token(Token = "0x4004C47")]
	[FieldOffset(Offset = "0x38")]
	private Vector3 lastPlayerPos;

	[Token(Token = "0x4004C48")]
	[FieldOffset(Offset = "0x44")]
	private float baseSpeed;

	[Token(Token = "0x4004C49")]
	[FieldOffset(Offset = "0x48")]
	private Vector3 startingPos;

	[Token(Token = "0x4004C4A")]
	[FieldOffset(Offset = "0x54")]
	private Quaternion startingRot;

	[Token(Token = "0x4004C4B")]
	[FieldOffset(Offset = "0x68")]
	public UnityEvent OnHit;

	[Token(Token = "0x60041ED")]
	[Address(RVA = "0x140F798", Offset = "0x140F798", VA = "0x140F798")]
	private void Start()
	{
	}

	[Token(Token = "0x60041EE")]
	[Address(RVA = "0x140F80C", Offset = "0x140F80C", VA = "0x140F80C")]
	private void Update()
	{
	}

	[Token(Token = "0x60041EF")]
	[Address(RVA = "0x140F9B8", Offset = "0x140F9B8", VA = "0x140F9B8")]
	public void Chase()
	{
	}

	[Token(Token = "0x60041F0")]
	[Address(RVA = "0x140F944", Offset = "0x140F944", VA = "0x140F944")]
	private IEnumerator TryKickBall()
	{
		return null;
	}

	[Token(Token = "0x60041F1")]
	[Address(RVA = "0x140FB20", Offset = "0x140FB20", VA = "0x140FB20")]
	public void StartChasing(Transform target)
	{
	}

	[Token(Token = "0x60041F2")]
	[Address(RVA = "0x140FB6C", Offset = "0x140FB6C", VA = "0x140FB6C")]
	public void UpdateChaseTarget(Transform target)
	{
	}

	[Token(Token = "0x60041F3")]
	[Address(RVA = "0x140FBB4", Offset = "0x140FBB4", VA = "0x140FBB4")]
	public AmongUsFollowAgent()
	{
	}
}
