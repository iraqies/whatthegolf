using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using Core;
using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x200080B")]
public class GolferAndBallShooter : GolfBallShooterBase
{
	[Token(Token = "0x200080C")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x41760", Offset = "0x41760")]
	private sealed class _003C_003Ec__DisplayClass14_0
	{
		[Token(Token = "0x4002B49")]
		[FieldOffset(Offset = "0x10")]
		public GolferAndBallShooter _003C_003E4__this;

		[Token(Token = "0x4002B4A")]
		[FieldOffset(Offset = "0x18")]
		public float from;

		[Token(Token = "0x60024FC")]
		[Address(RVA = "0x17B60AC", Offset = "0x17B60AC", VA = "0x17B60AC")]
		public _003C_003Ec__DisplayClass14_0()
		{
		}

		[Token(Token = "0x60024FD")]
		[Address(RVA = "0x17B60B4", Offset = "0x17B60B4", VA = "0x17B60B4")]
		internal void _003CPlayShootSequence_003Eb__0(float t)
		{
		}
	}

	[Token(Token = "0x200080D")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x41770", Offset = "0x41770")]
	private sealed class _003CPlayShootSequence_003Ed__14 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x4002B4B")]
		[FieldOffset(Offset = "0x10")]
		private int _003C_003E1__state;

		[Token(Token = "0x4002B4C")]
		[FieldOffset(Offset = "0x18")]
		private object _003C_003E2__current;

		[Token(Token = "0x4002B4D")]
		[FieldOffset(Offset = "0x20")]
		public GolferAndBallShooter _003C_003E4__this;

		[Token(Token = "0x4002B4E")]
		[FieldOffset(Offset = "0x28")]
		public Vector3 boost;

		[Token(Token = "0x17000404")]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002ECurrent
		{
			[Token(Token = "0x6002501")]
			[Address(RVA = "0x17B63DC", Offset = "0x17B63DC", VA = "0x17B63DC", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002Eget_Current();
			}
		}

		[Token(Token = "0x17000405")]
		private object System_002ECollections_002EIEnumerator_002ECurrent
		{
			[Token(Token = "0x6002503")]
			[Address(RVA = "0x17B6424", Offset = "0x17B6424", VA = "0x17B6424", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return System_002ECollections_002EIEnumerator_002Eget_Current();
			}
		}

		[Token(Token = "0x60024FE")]
		[Address(RVA = "0x17B6148", Offset = "0x17B6148", VA = "0x17B6148")]
		[DebuggerHidden]
		public _003CPlayShootSequence_003Ed__14(int _003C_003E1__state)
		{
		}

		[Token(Token = "0x60024FF")]
		[Address(RVA = "0x17B6174", Offset = "0x17B6174", VA = "0x17B6174", Slot = "5")]
		[DebuggerHidden]
		private void System_002EIDisposable_002EDispose()
		{
		}

		[Token(Token = "0x6002500")]
		[Address(RVA = "0x17B6178", Offset = "0x17B6178", VA = "0x17B6178", Slot = "6")]
		private bool MoveNext()
		{
			return default;
		}

		[Token(Token = "0x6002501")]
		[Address(RVA = "0x17B63DC", Offset = "0x17B63DC", VA = "0x17B63DC", Slot = "4")]
		[DebuggerHidden]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002Eget_Current()
		{
			return null;
		}

		[Token(Token = "0x6002502")]
		[Address(RVA = "0x17B63E4", Offset = "0x17B63E4", VA = "0x17B63E4", Slot = "8")]
		[DebuggerHidden]
		private void System_002ECollections_002EIEnumerator_002EReset()
		{
		}

		[Token(Token = "0x6002503")]
		[Address(RVA = "0x17B6424", Offset = "0x17B6424", VA = "0x17B6424", Slot = "7")]
		[DebuggerHidden]
		private object System_002ECollections_002EIEnumerator_002Eget_Current()
		{
			return null;
		}
	}

	[Token(Token = "0x4002B3E")]
	[FieldOffset(Offset = "0x60")]
	[SerializeField]
	private Rigidbody ball;

	[Token(Token = "0x4002B3F")]
	[FieldOffset(Offset = "0x68")]
	[SerializeField]
	private Rigidbody golfer;

	[Token(Token = "0x4002B40")]
	[FieldOffset(Offset = "0x70")]
	[SerializeField]
	private float fullVelocity;

	[Token(Token = "0x4002B41")]
	[FieldOffset(Offset = "0x74")]
	[SerializeField]
	private float fullPitch;

	[Token(Token = "0x4002B42")]
	[FieldOffset(Offset = "0x78")]
	[SerializeField]
	private float fullSpin;

	[Token(Token = "0x4002B43")]
	[FieldOffset(Offset = "0x7C")]
	[SerializeField]
	private float golferRunSpeed;

	[Token(Token = "0x4002B44")]
	[FieldOffset(Offset = "0x80")]
	private bool hasBall;

	[Token(Token = "0x4002B45")]
	[FieldOffset(Offset = "0x88")]
	private Animator golfAnimator;

	[Token(Token = "0x4002B46")]
	[FieldOffset(Offset = "0x90")]
	private bool isShooting;

	[Token(Token = "0x4002B47")]
	[FieldOffset(Offset = "0x94")]
	private Vector3 ballOffset;

	[Token(Token = "0x4002B48")]
	[FieldOffset(Offset = "0xA0")]
	private NearestVertGravity ballGravity;

	[Token(Token = "0x60024F5")]
	[Address(RVA = "0x14A4AC0", Offset = "0x14A4AC0", VA = "0x14A4AC0", Slot = "11")]
	protected override void Awake()
	{
	}

	[Token(Token = "0x60024F6")]
	[Address(RVA = "0x14A4BC0", Offset = "0x14A4BC0", VA = "0x14A4BC0", Slot = "7")]
	public override void OnShoot(Vector3 boost)
	{
	}

	[Token(Token = "0x60024F7")]
	[Address(RVA = "0x14A4E14", Offset = "0x14A4E14", VA = "0x14A4E14", Slot = "6")]
	public override void OnAimUpdate(Vector3 boost, bool onlyAimArrow)
	{
	}

	[Token(Token = "0x60024F8")]
	[Address(RVA = "0x14A4D7C", Offset = "0x14A4D7C", VA = "0x14A4D7C")]
	private IEnumerator PlayShootSequence(Vector3 boost)
	{
		return null;
	}

	[Token(Token = "0x60024F9")]
	[Address(RVA = "0x14A4FA0", Offset = "0x14A4FA0", VA = "0x14A4FA0")]
	private Vector3 PitchBoost(Vector3 boost)
	{
		return default;
	}

	[Token(Token = "0x60024FA")]
	[Address(RVA = "0x14A5064", Offset = "0x14A5064", VA = "0x14A5064")]
	private void OnTriggerEnter(Collider other)
	{
	}

	[Token(Token = "0x60024FB")]
	[Address(RVA = "0x14A5260", Offset = "0x14A5260", VA = "0x14A5260")]
	public GolferAndBallShooter()
	{
	}
}
