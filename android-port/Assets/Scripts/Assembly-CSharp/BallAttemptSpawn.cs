using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x2000ED0")]
public class BallAttemptSpawn : MonoBehaviour
{
	[Token(Token = "0x2000ED1")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x45440", Offset = "0x45440")]
	private sealed class _003CSpawningBall_003Ed__7 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x400500B")]
		[FieldOffset(Offset = "0x10")]
		private int _003C_003E1__state;

		[Token(Token = "0x400500C")]
		[FieldOffset(Offset = "0x18")]
		private object _003C_003E2__current;

		[Token(Token = "0x400500D")]
		[FieldOffset(Offset = "0x20")]
		public BallAttemptSpawn _003C_003E4__this;

		[Token(Token = "0x17000725")]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002ECurrent
		{
			[Token(Token = "0x6004527")]
			[Address(RVA = "0x1770DB0", Offset = "0x1770DB0", VA = "0x1770DB0", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002Eget_Current();
			}
		}

		[Token(Token = "0x17000726")]
		private object System_002ECollections_002EIEnumerator_002ECurrent
		{
			[Token(Token = "0x6004529")]
			[Address(RVA = "0x1770DF8", Offset = "0x1770DF8", VA = "0x1770DF8", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return System_002ECollections_002EIEnumerator_002Eget_Current();
			}
		}

		[Token(Token = "0x6004524")]
		[Address(RVA = "0x1770BE0", Offset = "0x1770BE0", VA = "0x1770BE0")]
		[DebuggerHidden]
		public _003CSpawningBall_003Ed__7(int _003C_003E1__state)
		{
		}

		[Token(Token = "0x6004525")]
		[Address(RVA = "0x1770C0C", Offset = "0x1770C0C", VA = "0x1770C0C", Slot = "5")]
		[DebuggerHidden]
		private void System_002EIDisposable_002EDispose()
		{
		}

		[Token(Token = "0x6004526")]
		[Address(RVA = "0x1770C10", Offset = "0x1770C10", VA = "0x1770C10", Slot = "6")]
		private bool MoveNext()
		{
			return default;
		}

		[Token(Token = "0x6004527")]
		[Address(RVA = "0x1770DB0", Offset = "0x1770DB0", VA = "0x1770DB0", Slot = "4")]
		[DebuggerHidden]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002Eget_Current()
		{
			return null;
		}

		[Token(Token = "0x6004528")]
		[Address(RVA = "0x1770DB8", Offset = "0x1770DB8", VA = "0x1770DB8", Slot = "8")]
		[DebuggerHidden]
		private void System_002ECollections_002EIEnumerator_002EReset()
		{
		}

		[Token(Token = "0x6004529")]
		[Address(RVA = "0x1770DF8", Offset = "0x1770DF8", VA = "0x1770DF8", Slot = "7")]
		[DebuggerHidden]
		private object System_002ECollections_002EIEnumerator_002Eget_Current()
		{
			return null;
		}
	}

	[Token(Token = "0x4005005")]
	[FieldOffset(Offset = "0x18")]
	public Rigidbody ballGameObject;

	[Token(Token = "0x4005006")]
	[FieldOffset(Offset = "0x20")]
	public Vector3 spawnOffset;

	[Token(Token = "0x4005007")]
	[FieldOffset(Offset = "0x2C")]
	public Vector3 spawnForce;

	[Token(Token = "0x4005008")]
	[FieldOffset(Offset = "0x38")]
	public float delayBeforeSpawn;

	[Token(Token = "0x4005009")]
	[FieldOffset(Offset = "0x40")]
	private Rigidbody nextBall;

	[Token(Token = "0x400500A")]
	[FieldOffset(Offset = "0x48")]
	private Coroutine spawnNewBallCoroutine;

	[Token(Token = "0x6004521")]
	[Address(RVA = "0x1518034", Offset = "0x1518034", VA = "0x1518034")]
	public void SpawnNewBall()
	{
	}

	[Token(Token = "0x6004522")]
	[Address(RVA = "0x15180C0", Offset = "0x15180C0", VA = "0x15180C0")]
	private IEnumerator SpawningBall()
	{
		return null;
	}

	[Token(Token = "0x6004523")]
	[Address(RVA = "0x1518134", Offset = "0x1518134", VA = "0x1518134")]
	public BallAttemptSpawn()
	{
	}
}
