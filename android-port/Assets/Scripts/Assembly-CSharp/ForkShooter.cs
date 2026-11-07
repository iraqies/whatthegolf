using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using Core;
using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x2000E83")]
public class ForkShooter : GolfBallShooterBase
{
	[Token(Token = "0x2000E84")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x450B8", Offset = "0x450B8")]
	private sealed class _003CStickCooldownRoutine_003Ed__25 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x4004E7A")]
		[FieldOffset(Offset = "0x10")]
		private int _003C_003E1__state;

		[Token(Token = "0x4004E7B")]
		[FieldOffset(Offset = "0x18")]
		private object _003C_003E2__current;

		[Token(Token = "0x4004E7C")]
		[FieldOffset(Offset = "0x20")]
		public ForkShooter _003C_003E4__this;

		[Token(Token = "0x4004E7D")]
		[FieldOffset(Offset = "0x28")]
		public Vector3 shootDir;

		[Token(Token = "0x170006F2")]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002ECurrent
		{
			[Token(Token = "0x60043D7")]
			[Address(RVA = "0x17A99F0", Offset = "0x17A99F0", VA = "0x17A99F0", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002Eget_Current();
			}
		}

		[Token(Token = "0x170006F3")]
		private object System_002ECollections_002EIEnumerator_002ECurrent
		{
			[Token(Token = "0x60043D9")]
			[Address(RVA = "0x17A9A38", Offset = "0x17A9A38", VA = "0x17A9A38", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return System_002ECollections_002EIEnumerator_002Eget_Current();
			}
		}

		[Token(Token = "0x60043D4")]
		[Address(RVA = "0x17A981C", Offset = "0x17A981C", VA = "0x17A981C")]
		[DebuggerHidden]
		public _003CStickCooldownRoutine_003Ed__25(int _003C_003E1__state)
		{
		}

		[Token(Token = "0x60043D5")]
		[Address(RVA = "0x17A9848", Offset = "0x17A9848", VA = "0x17A9848", Slot = "5")]
		[DebuggerHidden]
		private void System_002EIDisposable_002EDispose()
		{
		}

		[Token(Token = "0x60043D6")]
		[Address(RVA = "0x17A984C", Offset = "0x17A984C", VA = "0x17A984C", Slot = "6")]
		private bool MoveNext()
		{
			return default;
		}

		[Token(Token = "0x60043D7")]
		[Address(RVA = "0x17A99F0", Offset = "0x17A99F0", VA = "0x17A99F0", Slot = "4")]
		[DebuggerHidden]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002Eget_Current()
		{
			return null;
		}

		[Token(Token = "0x60043D8")]
		[Address(RVA = "0x17A99F8", Offset = "0x17A99F8", VA = "0x17A99F8", Slot = "8")]
		[DebuggerHidden]
		private void System_002ECollections_002EIEnumerator_002EReset()
		{
		}

		[Token(Token = "0x60043D9")]
		[Address(RVA = "0x17A9A38", Offset = "0x17A9A38", VA = "0x17A9A38", Slot = "7")]
		[DebuggerHidden]
		private object System_002ECollections_002EIEnumerator_002Eget_Current()
		{
			return null;
		}
	}

	[Token(Token = "0x4004E68")]
	[FieldOffset(Offset = "0x60")]
	[SerializeField]
	public float minShootVelocity;

	[Token(Token = "0x4004E69")]
	[FieldOffset(Offset = "0x64")]
	[SerializeField]
	public float fullShootVelocity;

	[Token(Token = "0x4004E6A")]
	[FieldOffset(Offset = "0x68")]
	[SerializeField]
	public float pitch;

	[Token(Token = "0x4004E6B")]
	[FieldOffset(Offset = "0x6C")]
	[SerializeField]
	public float spin;

	[Token(Token = "0x4004E6C")]
	[FieldOffset(Offset = "0x70")]
	[SerializeField]
	protected bool lookInShotDirection;

	[Token(Token = "0x4004E6D")]
	[FieldOffset(Offset = "0x71")]
	public bool lookInAimDirection;

	[Token(Token = "0x4004E6E")]
	[FieldOffset(Offset = "0x72")]
	[SerializeField]
	protected bool onlyLookWhenChargingOnController;

	[Token(Token = "0x4004E6F")]
	[FieldOffset(Offset = "0x74")]
	public float LookInAimDirectionSpeed;

	[Token(Token = "0x4004E70")]
	[FieldOffset(Offset = "0x78")]
	[SerializeField]
	protected bool dontLookInAimDirectionWhenBlocked;

	[Token(Token = "0x4004E71")]
	[FieldOffset(Offset = "0x79")]
	[SerializeField]
	protected bool useLocalUp;

	[Token(Token = "0x4004E72")]
	[FieldOffset(Offset = "0x7A")]
	[SerializeField]
	public bool zeroPitchIfNotGrouneded;

	[Token(Token = "0x4004E73")]
	[FieldOffset(Offset = "0x7C")]
	[SerializeField]
	private float depthOfStabbing;

	[Token(Token = "0x4004E74")]
	[FieldOffset(Offset = "0x80")]
	[SerializeField]
	private float SecondsBeforeSticking;

	[Token(Token = "0x4004E75")]
	[FieldOffset(Offset = "0x88")]
	private Coroutine stickCooldown;

	[Token(Token = "0x4004E76")]
	[FieldOffset(Offset = "0x90")]
	private FixedJoint stickJoint;

	[Token(Token = "0x4004E77")]
	[FieldOffset(Offset = "0x98")]
	private Rigidbody collisionRb;

	[Token(Token = "0x4004E78")]
	[FieldOffset(Offset = "0xA0")]
	private bool isAiming;

	[Token(Token = "0x4004E79")]
	[FieldOffset(Offset = "0xA1")]
	private bool canStick;

	[Token(Token = "0x60043CC")]
	[Address(RVA = "0x1471F14", Offset = "0x1471F14", VA = "0x1471F14")]
	private void Start()
	{
	}

	[Token(Token = "0x60043CD")]
	[Address(RVA = "0x1471F38", Offset = "0x1471F38", VA = "0x1471F38", Slot = "6")]
	public override void OnAimUpdate(Vector3 boost, bool onlyAimArrow)
	{
	}

	[Token(Token = "0x60043CE")]
	[Address(RVA = "0x14721A0", Offset = "0x14721A0", VA = "0x14721A0")]
	private void Update()
	{
	}

	[Token(Token = "0x60043CF")]
	[Address(RVA = "0x1472250", Offset = "0x1472250", VA = "0x1472250", Slot = "8")]
	public override void OnCancel()
	{
	}

	[Token(Token = "0x60043D0")]
	[Address(RVA = "0x1472258", Offset = "0x1472258", VA = "0x1472258", Slot = "7")]
	public override void OnShoot(Vector3 boost)
	{
	}

	[Token(Token = "0x60043D1")]
	[Address(RVA = "0x14725D4", Offset = "0x14725D4", VA = "0x14725D4")]
	private void OnCollisionStay(Collision collision)
	{
	}

	[Token(Token = "0x60043D2")]
	[Address(RVA = "0x147253C", Offset = "0x147253C", VA = "0x147253C")]
	private IEnumerator StickCooldownRoutine(Vector3 shootDir)
	{
		return null;
	}

	[Token(Token = "0x60043D3")]
	[Address(RVA = "0x147284C", Offset = "0x147284C", VA = "0x147284C")]
	public ForkShooter()
	{
	}
}
