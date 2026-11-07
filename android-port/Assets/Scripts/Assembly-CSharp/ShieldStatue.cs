using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using Core;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.AI;

[Token(Token = "0x2000945")]
public class ShieldStatue : MonoBehaviour
{
	[Token(Token = "0x2000946")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x42180", Offset = "0x42180")]
	private sealed class _003CScheduleTarget_003Ed__21 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x40032D9")]
		[FieldOffset(Offset = "0x10")]
		private int _003C_003E1__state;

		[Token(Token = "0x40032DA")]
		[FieldOffset(Offset = "0x18")]
		private object _003C_003E2__current;

		[Token(Token = "0x40032DB")]
		[FieldOffset(Offset = "0x20")]
		public ShieldStatue _003C_003E4__this;

		[Token(Token = "0x1700046E")]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002ECurrent
		{
			[Token(Token = "0x6002B2C")]
			[Address(RVA = "0x1849618", Offset = "0x1849618", VA = "0x1849618", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002Eget_Current();
			}
		}

		[Token(Token = "0x1700046F")]
		private object System_002ECollections_002EIEnumerator_002ECurrent
		{
			[Token(Token = "0x6002B2E")]
			[Address(RVA = "0x1849660", Offset = "0x1849660", VA = "0x1849660", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return System_002ECollections_002EIEnumerator_002Eget_Current();
			}
		}

		[Token(Token = "0x6002B29")]
		[Address(RVA = "0x1849034", Offset = "0x1849034", VA = "0x1849034")]
		[DebuggerHidden]
		public _003CScheduleTarget_003Ed__21(int _003C_003E1__state)
		{
		}

		[Token(Token = "0x6002B2A")]
		[Address(RVA = "0x1849060", Offset = "0x1849060", VA = "0x1849060", Slot = "5")]
		[DebuggerHidden]
		private void System_002EIDisposable_002EDispose()
		{
		}

		[Token(Token = "0x6002B2B")]
		[Address(RVA = "0x1849064", Offset = "0x1849064", VA = "0x1849064", Slot = "6")]
		private bool MoveNext()
		{
			return default;
		}

		[Token(Token = "0x6002B2C")]
		[Address(RVA = "0x1849618", Offset = "0x1849618", VA = "0x1849618", Slot = "4")]
		[DebuggerHidden]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002Eget_Current()
		{
			return null;
		}

		[Token(Token = "0x6002B2D")]
		[Address(RVA = "0x1849620", Offset = "0x1849620", VA = "0x1849620", Slot = "8")]
		[DebuggerHidden]
		private void System_002ECollections_002EIEnumerator_002EReset()
		{
		}

		[Token(Token = "0x6002B2E")]
		[Address(RVA = "0x1849660", Offset = "0x1849660", VA = "0x1849660", Slot = "7")]
		[DebuggerHidden]
		private object System_002ECollections_002EIEnumerator_002Eget_Current()
		{
			return null;
		}
	}

	[Token(Token = "0x40032C6")]
	[FieldOffset(Offset = "0x18")]
	public GolfBallController ballController;

	[Token(Token = "0x40032C7")]
	[FieldOffset(Offset = "0x20")]
	public Rigidbody ballRb;

	[Token(Token = "0x40032C8")]
	[FieldOffset(Offset = "0x28")]
	public float upKickForce;

	[Token(Token = "0x40032C9")]
	[FieldOffset(Offset = "0x2C")]
	public float forwardKickForce;

	[Token(Token = "0x40032CA")]
	[FieldOffset(Offset = "0x30")]
	public float reactDistance;

	[Token(Token = "0x40032CB")]
	[FieldOffset(Offset = "0x34")]
	public float maxMoveDist;

	[Token(Token = "0x40032CC")]
	[FieldOffset(Offset = "0x38")]
	public float playerMaxSqrVelBeforeMove;

	[Token(Token = "0x40032CD")]
	[FieldOffset(Offset = "0x40")]
	public Collider vulnerableCollider;

	[Token(Token = "0x40032CE")]
	[FieldOffset(Offset = "0x48")]
	public float minBreakForce;

	[Token(Token = "0x40032CF")]
	[FieldOffset(Offset = "0x4C")]
	public float targetSearchRadius;

	[Token(Token = "0x40032D0")]
	[FieldOffset(Offset = "0x50")]
	public int targetSearchAttempts;

	[Token(Token = "0x40032D1")]
	[FieldOffset(Offset = "0x54")]
	public float moveSpeed;

	[Token(Token = "0x40032D2")]
	[FieldOffset(Offset = "0x58")]
	public float rotationSpeed;

	[Token(Token = "0x40032D3")]
	[FieldOffset(Offset = "0x0")]
	public static List<ShieldStatue> existingStatues;

	[Token(Token = "0x40032D4")]
	[FieldOffset(Offset = "0x60")]
	private Coroutine move;

	[Token(Token = "0x40032D5")]
	[FieldOffset(Offset = "0x68")]
	private Vector3 startPosition;

	[Token(Token = "0x40032D6")]
	[FieldOffset(Offset = "0x74")]
	public Vector3 targetPosition;

	[Token(Token = "0x40032D7")]
	[FieldOffset(Offset = "0x80")]
	private NavMeshAgent navAgent;

	[Token(Token = "0x40032D8")]
	[FieldOffset(Offset = "0x88")]
	public Color debugColor;

	[Token(Token = "0x6002B1C")]
	[Address(RVA = "0x169EFA8", Offset = "0x169EFA8", VA = "0x169EFA8")]
	[AttributeAttribute(Name = "RuntimeInitializeOnLoadMethodAttribute", RVA = "0x67A30", Offset = "0x67A30")]
	private static void Init()
	{
	}

	[Token(Token = "0x6002B1D")]
	[Address(RVA = "0x169F050", Offset = "0x169F050", VA = "0x169F050")]
	private void Start()
	{
	}

	[Token(Token = "0x6002B1E")]
	[Address(RVA = "0x169F224", Offset = "0x169F224", VA = "0x169F224")]
	private void MoveTowardsPlayer(Vector3 playerShootDir)
	{
	}

	[Token(Token = "0x6002B1F")]
	[Address(RVA = "0x169F32C", Offset = "0x169F32C", VA = "0x169F32C")]
	private IEnumerator ScheduleTarget()
	{
		return null;
	}

	[Token(Token = "0x6002B20")]
	[Address(RVA = "0x169F3A0", Offset = "0x169F3A0", VA = "0x169F3A0")]
	private void OnDisable()
	{
	}

	[Token(Token = "0x6002B21")]
	[Address(RVA = "0x169F5A0", Offset = "0x169F5A0", VA = "0x169F5A0")]
	private void BackToStart()
	{
	}

	[Token(Token = "0x6002B22")]
	[Address(RVA = "0x169F5B4", Offset = "0x169F5B4", VA = "0x169F5B4")]
	private void FixedUpdate()
	{
	}

	[Token(Token = "0x6002B23")]
	[Address(RVA = "0x169F670", Offset = "0x169F670", VA = "0x169F670")]
	private void OnCollisionEnter(Collision collision)
	{
	}

	[Token(Token = "0x6002B24")]
	[Address(RVA = "0x169F808", Offset = "0x169F808", VA = "0x169F808")]
	private void DoKick(Rigidbody other)
	{
	}

	[Token(Token = "0x6002B25")]
	[Address(RVA = "0x169F8B8", Offset = "0x169F8B8", VA = "0x169F8B8")]
	private void OnDrawGizmos()
	{
	}

	[Token(Token = "0x6002B26")]
	[Address(RVA = "0x169F8F4", Offset = "0x169F8F4", VA = "0x169F8F4")]
	public ShieldStatue()
	{
	}

	[Token(Token = "0x6002B28")]
	[Address(RVA = "0x169F9F4", Offset = "0x169F9F4", VA = "0x169F9F4")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x67A44", Offset = "0x67A44")]
	private bool _003CScheduleTarget_003Eb__21_0()
	{
		return default;
	}
}
