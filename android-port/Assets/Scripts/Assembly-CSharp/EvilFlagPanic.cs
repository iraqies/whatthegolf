using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using Core;
using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x200073D")]
public class EvilFlagPanic : MonoBehaviour
{
	[Token(Token = "0x200073E")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x412E0", Offset = "0x412E0")]
	private sealed class _003CBehavior_003Ed__13 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x4002664")]
		[FieldOffset(Offset = "0x10")]
		private int _003C_003E1__state;

		[Token(Token = "0x4002665")]
		[FieldOffset(Offset = "0x18")]
		private object _003C_003E2__current;

		[Token(Token = "0x4002666")]
		[FieldOffset(Offset = "0x20")]
		public EvilFlagPanic _003C_003E4__this;

		[Token(Token = "0x170003BE")]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002ECurrent
		{
			[Token(Token = "0x600216A")]
			[Address(RVA = "0x17A13F4", Offset = "0x17A13F4", VA = "0x17A13F4", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002Eget_Current();
			}
		}

		[Token(Token = "0x170003BF")]
		private object System_002ECollections_002EIEnumerator_002ECurrent
		{
			[Token(Token = "0x600216C")]
			[Address(RVA = "0x17A143C", Offset = "0x17A143C", VA = "0x17A143C", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return System_002ECollections_002EIEnumerator_002Eget_Current();
			}
		}

		[Token(Token = "0x6002167")]
		[Address(RVA = "0x17A12E4", Offset = "0x17A12E4", VA = "0x17A12E4")]
		[DebuggerHidden]
		public _003CBehavior_003Ed__13(int _003C_003E1__state)
		{
		}

		[Token(Token = "0x6002168")]
		[Address(RVA = "0x17A1310", Offset = "0x17A1310", VA = "0x17A1310", Slot = "5")]
		[DebuggerHidden]
		private void System_002EIDisposable_002EDispose()
		{
		}

		[Token(Token = "0x6002169")]
		[Address(RVA = "0x17A1314", Offset = "0x17A1314", VA = "0x17A1314", Slot = "6")]
		private bool MoveNext()
		{
			return default;
		}

		[Token(Token = "0x600216A")]
		[Address(RVA = "0x17A13F4", Offset = "0x17A13F4", VA = "0x17A13F4", Slot = "4")]
		[DebuggerHidden]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002Eget_Current()
		{
			return null;
		}

		[Token(Token = "0x600216B")]
		[Address(RVA = "0x17A13FC", Offset = "0x17A13FC", VA = "0x17A13FC", Slot = "8")]
		[DebuggerHidden]
		private void System_002ECollections_002EIEnumerator_002EReset()
		{
		}

		[Token(Token = "0x600216C")]
		[Address(RVA = "0x17A143C", Offset = "0x17A143C", VA = "0x17A143C", Slot = "7")]
		[DebuggerHidden]
		private object System_002ECollections_002EIEnumerator_002Eget_Current()
		{
			return null;
		}
	}

	[Token(Token = "0x4002659")]
	[FieldOffset(Offset = "0x18")]
	public Transform validAreaCenter;

	[Token(Token = "0x400265A")]
	[FieldOffset(Offset = "0x20")]
	public float searchAreaMinRadius;

	[Token(Token = "0x400265B")]
	[FieldOffset(Offset = "0x24")]
	public float searchAreaMaxRadius;

	[Token(Token = "0x400265C")]
	[FieldOffset(Offset = "0x28")]
	public float velocity;

	[Token(Token = "0x400265D")]
	[FieldOffset(Offset = "0x2C")]
	public float changeDirChance;

	[Token(Token = "0x400265E")]
	[FieldOffset(Offset = "0x30")]
	public float awayAngle1;

	[Token(Token = "0x400265F")]
	[FieldOffset(Offset = "0x34")]
	public float awayAngle2;

	[Token(Token = "0x4002660")]
	[FieldOffset(Offset = "0x38")]
	public int maxAttempts;

	[Token(Token = "0x4002661")]
	[FieldOffset(Offset = "0x40")]
	public GolfBallController ball;

	[Token(Token = "0x4002662")]
	[FieldOffset(Offset = "0x48")]
	private Rigidbody rigid;

	[Token(Token = "0x4002663")]
	[FieldOffset(Offset = "0x50")]
	private Vector3 currentTarget;

	[Token(Token = "0x6002160")]
	[Address(RVA = "0x144CD3C", Offset = "0x144CD3C", VA = "0x144CD3C")]
	private void Awake()
	{
	}

	[Token(Token = "0x6002161")]
	[Address(RVA = "0x144CE08", Offset = "0x144CE08", VA = "0x144CE08")]
	private void Ball_OnAimStart()
	{
	}

	[Token(Token = "0x6002162")]
	[Address(RVA = "0x144CEF4", Offset = "0x144CEF4", VA = "0x144CEF4")]
	private IEnumerator Behavior()
	{
		return null;
	}

	[Token(Token = "0x6002163")]
	[Address(RVA = "0x144CF68", Offset = "0x144CF68", VA = "0x144CF68")]
	private Vector3 GetNewTarget(int maxAttempts)
	{
		return default;
	}

	[Token(Token = "0x6002164")]
	[Address(RVA = "0x144D4D0", Offset = "0x144D4D0", VA = "0x144D4D0")]
	private void FixedUpdate()
	{
	}

	[Token(Token = "0x6002165")]
	[Address(RVA = "0x144D5E0", Offset = "0x144D5E0", VA = "0x144D5E0")]
	private void OnDrawGizmos()
	{
	}

	[Token(Token = "0x6002166")]
	[Address(RVA = "0x144DA5C", Offset = "0x144DA5C", VA = "0x144DA5C")]
	public EvilFlagPanic()
	{
	}
}
