using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x200038F")]
public class BossStageMusic : MonoBehaviour
{
	[Token(Token = "0x2000390")]
	public enum MusicStartTime
	{
		[Token(Token = "0x40013A7")]
		WhenPreviousFlagHit = 0,
		[Token(Token = "0x40013A8")]
		WhenHatched = 1
	}

	[Token(Token = "0x2000391")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x3F634", Offset = "0x3F634")]
	private sealed class _003CSlowFixedUpdate_003Ed__21 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x40013A9")]
		[FieldOffset(Offset = "0x10")]
		private int _003C_003E1__state;

		[Token(Token = "0x40013AA")]
		[FieldOffset(Offset = "0x18")]
		private object _003C_003E2__current;

		[Token(Token = "0x40013AB")]
		[FieldOffset(Offset = "0x20")]
		public BossStageMusic _003C_003E4__this;

		[Token(Token = "0x40013AC")]
		[FieldOffset(Offset = "0x28")]
		private WaitForSecondsRealtime _003Cwait_003E5__2;

		[Token(Token = "0x40013AD")]
		[FieldOffset(Offset = "0x30")]
		private int _003CdelayInMs_003E5__3;

		[Token(Token = "0x40013AE")]
		[FieldOffset(Offset = "0x34")]
		private float _003Celapsed_003E5__4;

		[Token(Token = "0x17000201")]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002ECurrent
		{
			[Token(Token = "0x60010E3")]
			[Address(RVA = "0x177A658", Offset = "0x177A658", VA = "0x177A658", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002Eget_Current();
			}
		}

		[Token(Token = "0x17000202")]
		private object System_002ECollections_002EIEnumerator_002ECurrent
		{
			[Token(Token = "0x60010E5")]
			[Address(RVA = "0x177A6A0", Offset = "0x177A6A0", VA = "0x177A6A0", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return System_002ECollections_002EIEnumerator_002Eget_Current();
			}
		}

		[Token(Token = "0x60010E0")]
		[Address(RVA = "0x177A380", Offset = "0x177A380", VA = "0x177A380")]
		[DebuggerHidden]
		public _003CSlowFixedUpdate_003Ed__21(int _003C_003E1__state)
		{
		}

		[Token(Token = "0x60010E1")]
		[Address(RVA = "0x177A3AC", Offset = "0x177A3AC", VA = "0x177A3AC", Slot = "5")]
		[DebuggerHidden]
		private void System_002EIDisposable_002EDispose()
		{
		}

		[Token(Token = "0x60010E2")]
		[Address(RVA = "0x177A3B0", Offset = "0x177A3B0", VA = "0x177A3B0", Slot = "6")]
		private bool MoveNext()
		{
			return default;
		}

		[Token(Token = "0x60010E3")]
		[Address(RVA = "0x177A658", Offset = "0x177A658", VA = "0x177A658", Slot = "4")]
		[DebuggerHidden]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002Eget_Current()
		{
			return null;
		}

		[Token(Token = "0x60010E4")]
		[Address(RVA = "0x177A660", Offset = "0x177A660", VA = "0x177A660", Slot = "8")]
		[DebuggerHidden]
		private void System_002ECollections_002EIEnumerator_002EReset()
		{
		}

		[Token(Token = "0x60010E5")]
		[Address(RVA = "0x177A6A0", Offset = "0x177A6A0", VA = "0x177A6A0", Slot = "7")]
		[DebuggerHidden]
		private object System_002ECollections_002EIEnumerator_002Eget_Current()
		{
			return null;
		}
	}

	[Token(Token = "0x4001395")]
	[FieldOffset(Offset = "0x18")]
	public Transform player;

	[Token(Token = "0x4001396")]
	[FieldOffset(Offset = "0x20")]
	public Transform flag;

	[Token(Token = "0x4001397")]
	[FieldOffset(Offset = "0x28")]
	public MusicStartTime musicStartTimeMode;

	[Token(Token = "0x4001398")]
	[FieldOffset(Offset = "0x2C")]
	public uint wwiseStateID;

	[Token(Token = "0x4001399")]
	[FieldOffset(Offset = "0x30")]
	public uint rtpcID;

	[Token(Token = "0x400139A")]
	[FieldOffset(Offset = "0x34")]
	public float startValue;

	[Token(Token = "0x400139B")]
	[FieldOffset(Offset = "0x38")]
	public float endValue;

	[Token(Token = "0x400139C")]
	[FieldOffset(Offset = "0x3C")]
	public bool IncrementDistanceRTPC;

	[Token(Token = "0x400139D")]
	[FieldOffset(Offset = "0x3D")]
	public bool IncrementNormalRTPC_ByDistance;

	[Token(Token = "0x400139E")]
	[FieldOffset(Offset = "0x3E")]
	public bool SetMaxDistanceByInitialDistance;

	[Token(Token = "0x400139F")]
	[FieldOffset(Offset = "0x40")]
	public float minDistance;

	[Token(Token = "0x40013A0")]
	[FieldOffset(Offset = "0x44")]
	public float MaxDistance;

	[Token(Token = "0x40013A1")]
	[FieldOffset(Offset = "0x48")]
	public bool IncrementNormalRTPC_ByTime;

	[Token(Token = "0x40013A2")]
	[FieldOffset(Offset = "0x4C")]
	public float incrementOverTime;

	[Token(Token = "0x40013A3")]
	private const float slowUpdateDelay = 0.1f;

	[Token(Token = "0x40013A4")]
	[FieldOffset(Offset = "0x50")]
	private BossPlayerEgg hatchingEgg;

	[Token(Token = "0x40013A5")]
	[FieldOffset(Offset = "0x58")]
	private float m_maxDistance;

	[Token(Token = "0x60010DB")]
	[Address(RVA = "0x1700AB0", Offset = "0x1700AB0", VA = "0x1700AB0")]
	public void StartStageMusic()
	{
	}

	[Token(Token = "0x60010DC")]
	[Address(RVA = "0x1700C00", Offset = "0x1700C00", VA = "0x1700C00")]
	public void OnCanMove()
	{
	}

	[Token(Token = "0x60010DD")]
	[Address(RVA = "0x1700DD0", Offset = "0x1700DD0", VA = "0x1700DD0")]
	public void EndMusic()
	{
	}

	[Token(Token = "0x60010DE")]
	[Address(RVA = "0x1700D5C", Offset = "0x1700D5C", VA = "0x1700D5C")]
	private IEnumerator SlowFixedUpdate()
	{
		return null;
	}

	[Token(Token = "0x60010DF")]
	[Address(RVA = "0x1700E7C", Offset = "0x1700E7C", VA = "0x1700E7C")]
	public BossStageMusic()
	{
	}
}
