using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using Core;
using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x2000312")]
public class PawShooter : GolfBallShooterBase
{
	[Token(Token = "0x2000313")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x3EF08", Offset = "0x3EF08")]
	private sealed class _003C_003Ec__DisplayClass20_0
	{
		[Token(Token = "0x40010FF")]
		[FieldOffset(Offset = "0x10")]
		public PawShooter _003C_003E4__this;

		[Token(Token = "0x4001100")]
		[FieldOffset(Offset = "0x18")]
		public Vector3 rP;

		[Token(Token = "0x4001101")]
		[FieldOffset(Offset = "0x24")]
		public Vector3 dir;

		[Token(Token = "0x4001102")]
		[FieldOffset(Offset = "0x30")]
		public Quaternion rR;

		[Token(Token = "0x6000E2B")]
		[Address(RVA = "0x18225DC", Offset = "0x18225DC", VA = "0x18225DC")]
		public _003C_003Ec__DisplayClass20_0()
		{
		}

		[Token(Token = "0x6000E2C")]
		[Address(RVA = "0x18225E4", Offset = "0x18225E4", VA = "0x18225E4")]
		internal void _003CResetPosition_003Eb__0(float t)
		{
		}

		[Token(Token = "0x6000E2D")]
		[Address(RVA = "0x18226B4", Offset = "0x18226B4", VA = "0x18226B4")]
		internal void _003CResetPosition_003Eb__1(float t)
		{
		}
	}

	[Token(Token = "0x2000314")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x3EF18", Offset = "0x3EF18")]
	private sealed class _003CResetPosition_003Ed__20 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x4001103")]
		[FieldOffset(Offset = "0x10")]
		private int _003C_003E1__state;

		[Token(Token = "0x4001104")]
		[FieldOffset(Offset = "0x18")]
		private object _003C_003E2__current;

		[Token(Token = "0x4001105")]
		[FieldOffset(Offset = "0x20")]
		public PawShooter _003C_003E4__this;

		[Token(Token = "0x4001106")]
		[FieldOffset(Offset = "0x28")]
		private _003C_003Ec__DisplayClass20_0 _003C_003E8__1;

		[Token(Token = "0x170001AA")]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002ECurrent
		{
			[Token(Token = "0x6000E31")]
			[Address(RVA = "0x1822B54", Offset = "0x1822B54", VA = "0x1822B54", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002Eget_Current();
			}
		}

		[Token(Token = "0x170001AB")]
		private object System_002ECollections_002EIEnumerator_002ECurrent
		{
			[Token(Token = "0x6000E33")]
			[Address(RVA = "0x1822B9C", Offset = "0x1822B9C", VA = "0x1822B9C", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return System_002ECollections_002EIEnumerator_002Eget_Current();
			}
		}

		[Token(Token = "0x6000E2E")]
		[Address(RVA = "0x182278C", Offset = "0x182278C", VA = "0x182278C")]
		[DebuggerHidden]
		public _003CResetPosition_003Ed__20(int _003C_003E1__state)
		{
		}

		[Token(Token = "0x6000E2F")]
		[Address(RVA = "0x18227B8", Offset = "0x18227B8", VA = "0x18227B8", Slot = "5")]
		[DebuggerHidden]
		private void System_002EIDisposable_002EDispose()
		{
		}

		[Token(Token = "0x6000E30")]
		[Address(RVA = "0x18227BC", Offset = "0x18227BC", VA = "0x18227BC", Slot = "6")]
		private bool MoveNext()
		{
			return default;
		}

		[Token(Token = "0x6000E31")]
		[Address(RVA = "0x1822B54", Offset = "0x1822B54", VA = "0x1822B54", Slot = "4")]
		[DebuggerHidden]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002Eget_Current()
		{
			return null;
		}

		[Token(Token = "0x6000E32")]
		[Address(RVA = "0x1822B5C", Offset = "0x1822B5C", VA = "0x1822B5C", Slot = "8")]
		[DebuggerHidden]
		private void System_002ECollections_002EIEnumerator_002EReset()
		{
		}

		[Token(Token = "0x6000E33")]
		[Address(RVA = "0x1822B9C", Offset = "0x1822B9C", VA = "0x1822B9C", Slot = "7")]
		[DebuggerHidden]
		private object System_002ECollections_002EIEnumerator_002Eget_Current()
		{
			return null;
		}
	}

	[Token(Token = "0x40010F0")]
	[FieldOffset(Offset = "0x60")]
	public float pawReach;

	[Token(Token = "0x40010F1")]
	[FieldOffset(Offset = "0x64")]
	public float pawKickSpeed;

	[Token(Token = "0x40010F2")]
	[FieldOffset(Offset = "0x68")]
	public float upForce;

	[Token(Token = "0x40010F3")]
	[FieldOffset(Offset = "0x6C")]
	public float forwardForce;

	[Token(Token = "0x40010F4")]
	[FieldOffset(Offset = "0x70")]
	public float pawSpeed;

	[Token(Token = "0x40010F5")]
	[FieldOffset(Offset = "0x74")]
	public float resetVelocity;

	[Token(Token = "0x40010F6")]
	[FieldOffset(Offset = "0x78")]
	public ParticleSystem interactParticles;

	[Token(Token = "0x40010F7")]
	[FieldOffset(Offset = "0x80")]
	private float boostMagnitude;

	[Token(Token = "0x40010F8")]
	[FieldOffset(Offset = "0x84")]
	private Vector3 basePosition;

	[Token(Token = "0x40010F9")]
	[FieldOffset(Offset = "0x90")]
	private Quaternion baseRotation;

	[Token(Token = "0x40010FA")]
	[FieldOffset(Offset = "0xA0")]
	private Rigidbody rb;

	[Token(Token = "0x40010FB")]
	[FieldOffset(Offset = "0xA8")]
	private Vector3 currentBoost;

	[Token(Token = "0x40010FC")]
	[FieldOffset(Offset = "0xB4")]
	private bool IsResetCRRunning;

	[Token(Token = "0x40010FD")]
	[FieldOffset(Offset = "0xB8")]
	private Coroutine ResetCR;

	[Token(Token = "0x40010FE")]
	[FieldOffset(Offset = "0xC0")]
	internal bool isPlacingSpeaker;

	[Token(Token = "0x6000E24")]
	[Address(RVA = "0x15DD35C", Offset = "0x15DD35C", VA = "0x15DD35C")]
	private void Start()
	{
	}

	[Token(Token = "0x6000E25")]
	[Address(RVA = "0x15DD3FC", Offset = "0x15DD3FC", VA = "0x15DD3FC", Slot = "6")]
	public override void OnAimUpdate(Vector3 boost, bool onlyAimArrow)
	{
	}

	[Token(Token = "0x6000E26")]
	[Address(RVA = "0x15DD508", Offset = "0x15DD508", VA = "0x15DD508")]
	private void OnCollisionEnter(Collision collision)
	{
	}

	[Token(Token = "0x6000E27")]
	[Address(RVA = "0x15DD50C", Offset = "0x15DD50C", VA = "0x15DD50C")]
	private bool Blocked()
	{
		return default;
	}

	[Token(Token = "0x6000E28")]
	[Address(RVA = "0x15DD52C", Offset = "0x15DD52C", VA = "0x15DD52C", Slot = "7")]
	public override void OnShoot(Vector3 boost)
	{
	}

	[Token(Token = "0x6000E29")]
	[Address(RVA = "0x15DD654", Offset = "0x15DD654", VA = "0x15DD654")]
	private IEnumerator ResetPosition()
	{
		return null;
	}

	[Token(Token = "0x6000E2A")]
	[Address(RVA = "0x15DD6C8", Offset = "0x15DD6C8", VA = "0x15DD6C8")]
	public PawShooter()
	{
	}
}
