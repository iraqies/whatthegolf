using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using Core;
using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x2000262")]
public class RattleSnakeShooter : GolfBallShooterStandard
{
	[Token(Token = "0x2000263")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x3E704", Offset = "0x3E704")]
	private sealed class _003CMakeDynamic_003Ed__12 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x4000C66")]
		[FieldOffset(Offset = "0x10")]
		private int _003C_003E1__state;

		[Token(Token = "0x4000C67")]
		[FieldOffset(Offset = "0x18")]
		private object _003C_003E2__current;

		[Token(Token = "0x4000C68")]
		[FieldOffset(Offset = "0x20")]
		public float delay;

		[Token(Token = "0x4000C69")]
		[FieldOffset(Offset = "0x28")]
		public RattleSnakeShooter _003C_003E4__this;

		[Token(Token = "0x17000150")]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002ECurrent
		{
			[Token(Token = "0x6000ACA")]
			[Address(RVA = "0x18309C8", Offset = "0x18309C8", VA = "0x18309C8", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002Eget_Current();
			}
		}

		[Token(Token = "0x17000151")]
		private object System_002ECollections_002EIEnumerator_002ECurrent
		{
			[Token(Token = "0x6000ACC")]
			[Address(RVA = "0x1830A10", Offset = "0x1830A10", VA = "0x1830A10", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return System_002ECollections_002EIEnumerator_002Eget_Current();
			}
		}

		[Token(Token = "0x6000AC7")]
		[Address(RVA = "0x18308C8", Offset = "0x18308C8", VA = "0x18308C8")]
		[DebuggerHidden]
		public _003CMakeDynamic_003Ed__12(int _003C_003E1__state)
		{
		}

		[Token(Token = "0x6000AC8")]
		[Address(RVA = "0x18308F4", Offset = "0x18308F4", VA = "0x18308F4", Slot = "5")]
		[DebuggerHidden]
		private void System_002EIDisposable_002EDispose()
		{
		}

		[Token(Token = "0x6000AC9")]
		[Address(RVA = "0x18308F8", Offset = "0x18308F8", VA = "0x18308F8", Slot = "6")]
		private bool MoveNext()
		{
			return default;
		}

		[Token(Token = "0x6000ACA")]
		[Address(RVA = "0x18309C8", Offset = "0x18309C8", VA = "0x18309C8", Slot = "4")]
		[DebuggerHidden]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002Eget_Current()
		{
			return null;
		}

		[Token(Token = "0x6000ACB")]
		[Address(RVA = "0x18309D0", Offset = "0x18309D0", VA = "0x18309D0", Slot = "8")]
		[DebuggerHidden]
		private void System_002ECollections_002EIEnumerator_002EReset()
		{
		}

		[Token(Token = "0x6000ACC")]
		[Address(RVA = "0x1830A10", Offset = "0x1830A10", VA = "0x1830A10", Slot = "7")]
		[DebuggerHidden]
		private object System_002ECollections_002EIEnumerator_002Eget_Current()
		{
			return null;
		}
	}

	[Token(Token = "0x2000264")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x3E714", Offset = "0x3E714")]
	private sealed class _003C_003Ec__DisplayClass14_0
	{
		[Token(Token = "0x4000C6A")]
		[FieldOffset(Offset = "0x10")]
		public RattleSnakeShooter _003C_003E4__this;

		[Token(Token = "0x4000C6B")]
		[FieldOffset(Offset = "0x18")]
		public Vector3 startPos;

		[Token(Token = "0x4000C6C")]
		[FieldOffset(Offset = "0x24")]
		public Vector3 headPos;

		[Token(Token = "0x4000C6D")]
		[FieldOffset(Offset = "0x30")]
		public Quaternion startRot;

		[Token(Token = "0x6000ACD")]
		[Address(RVA = "0x1830798", Offset = "0x1830798", VA = "0x1830798")]
		public _003C_003Ec__DisplayClass14_0()
		{
		}

		[Token(Token = "0x6000ACE")]
		[Address(RVA = "0x18307A0", Offset = "0x18307A0", VA = "0x18307A0")]
		internal void _003CToStandingPose_003Eb__0(float t)
		{
		}
	}

	[Token(Token = "0x4000C5C")]
	[FieldOffset(Offset = "0x68")]
	[SerializeField]
	private int length;

	[Token(Token = "0x4000C5D")]
	[FieldOffset(Offset = "0x6C")]
	[SerializeField]
	private bool _inPose;

	[Token(Token = "0x4000C5E")]
	[FieldOffset(Offset = "0x70")]
	[SerializeField]
	private Vector3 _poseHeadOffset;

	[Token(Token = "0x4000C5F")]
	[FieldOffset(Offset = "0x7C")]
	[SerializeField]
	private Vector3 _bodyPartOffset;

	[Token(Token = "0x4000C60")]
	[FieldOffset(Offset = "0x88")]
	[SerializeField]
	private Rigidbody _snakeBodyPrefab;

	[Token(Token = "0x4000C61")]
	[FieldOffset(Offset = "0x90")]
	[SerializeField]
	private Rigidbody _snakeBodyConePrefab;

	[Token(Token = "0x4000C62")]
	[FieldOffset(Offset = "0x98")]
	[SerializeField]
	private AudioSource _hissAudio;

	[Token(Token = "0x4000C63")]
	[FieldOffset(Offset = "0xA0")]
	[SerializeField]
	private AudioSource _shootAudio;

	[Token(Token = "0x4000C64")]
	[FieldOffset(Offset = "0xA8")]
	private Coroutine _poseTween;

	[Token(Token = "0x4000C65")]
	[FieldOffset(Offset = "0xB0")]
	private float lastShootTime;

	[Token(Token = "0x6000ABA")]
	[Address(RVA = "0x16411F0", Offset = "0x16411F0", VA = "0x16411F0", Slot = "11")]
	protected override void Awake()
	{
	}

	[Token(Token = "0x6000ABB")]
	[Address(RVA = "0x1641684", Offset = "0x1641684", VA = "0x1641684")]
	[AttributeAttribute(Name = "ContextMenu", RVA = "0x5FD94", Offset = "0x5FD94")]
	private void EatCone()
	{
	}

	[Token(Token = "0x6000ABC")]
	[Address(RVA = "0x16418C8", Offset = "0x16418C8", VA = "0x16418C8")]
	private IEnumerator MakeDynamic(float delay)
	{
		return null;
	}

	[Token(Token = "0x6000ABD")]
	[Address(RVA = "0x164194C", Offset = "0x164194C", VA = "0x164194C")]
	private void OnCollisionEnter(Collision collision)
	{
	}

	[Token(Token = "0x6000ABE")]
	[Address(RVA = "0x1641A38", Offset = "0x1641A38", VA = "0x1641A38")]
	private void ToStandingPose()
	{
	}

	[Token(Token = "0x6000ABF")]
	[Address(RVA = "0x1641BF8", Offset = "0x1641BF8", VA = "0x1641BF8", Slot = "6")]
	public override void OnAimUpdate(Vector3 boost, bool onlyAimArrow)
	{
	}

	[Token(Token = "0x6000AC0")]
	[Address(RVA = "0x1641CA0", Offset = "0x1641CA0", VA = "0x1641CA0")]
	private void BreakStandingPose()
	{
	}

	[Token(Token = "0x6000AC1")]
	[Address(RVA = "0x1641D7C", Offset = "0x1641D7C", VA = "0x1641D7C")]
	private void Update()
	{
	}

	[Token(Token = "0x6000AC2")]
	[Address(RVA = "0x1641DC4", Offset = "0x1641DC4", VA = "0x1641DC4", Slot = "13")]
	protected override bool IsBlocking()
	{
		return default;
	}

	[Token(Token = "0x6000AC3")]
	[Address(RVA = "0x16413A0", Offset = "0x16413A0", VA = "0x16413A0")]
	private void ResetSnake()
	{
	}

	[Token(Token = "0x6000AC4")]
	[Address(RVA = "0x1641E4C", Offset = "0x1641E4C", VA = "0x1641E4C", Slot = "9")]
	public override void OnReset()
	{
	}

	[Token(Token = "0x6000AC5")]
	[Address(RVA = "0x1641E74", Offset = "0x1641E74", VA = "0x1641E74", Slot = "7")]
	public override void OnShoot(Vector3 boost)
	{
	}

	[Token(Token = "0x6000AC6")]
	[Address(RVA = "0x1641F08", Offset = "0x1641F08", VA = "0x1641F08")]
	public RattleSnakeShooter()
	{
	}
}
