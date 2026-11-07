using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using Core;
using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x20005E5")]
public class AngryGolfBall : MonoBehaviour
{
	[Token(Token = "0x20005E6")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x408F0", Offset = "0x408F0")]
	private sealed class _003CResetAfterShot_003Ed__18 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x4001E18")]
		[FieldOffset(Offset = "0x10")]
		private int _003C_003E1__state;

		[Token(Token = "0x4001E19")]
		[FieldOffset(Offset = "0x18")]
		private object _003C_003E2__current;

		[Token(Token = "0x4001E1A")]
		[FieldOffset(Offset = "0x20")]
		public AngryGolfBall _003C_003E4__this;

		[Token(Token = "0x4001E1B")]
		[FieldOffset(Offset = "0x28")]
		private float _003Ct_003E5__2;

		[Token(Token = "0x4001E1C")]
		[FieldOffset(Offset = "0x2C")]
		private float _003CelapsedFlyTime_003E5__3;

		[Token(Token = "0x4001E1D")]
		[FieldOffset(Offset = "0x30")]
		private float _003CsqrMagnitude_003E5__4;

		[Token(Token = "0x170002F0")]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002ECurrent
		{
			[Token(Token = "0x6001ADF")]
			[Address(RVA = "0x176AB68", Offset = "0x176AB68", VA = "0x176AB68", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002Eget_Current();
			}
		}

		[Token(Token = "0x170002F1")]
		private object System_002ECollections_002EIEnumerator_002ECurrent
		{
			[Token(Token = "0x6001AE1")]
			[Address(RVA = "0x176ABB0", Offset = "0x176ABB0", VA = "0x176ABB0", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return System_002ECollections_002EIEnumerator_002Eget_Current();
			}
		}

		[Token(Token = "0x6001ADC")]
		[Address(RVA = "0x176A7F4", Offset = "0x176A7F4", VA = "0x176A7F4")]
		[DebuggerHidden]
		public _003CResetAfterShot_003Ed__18(int _003C_003E1__state)
		{
		}

		[Token(Token = "0x6001ADD")]
		[Address(RVA = "0x176A820", Offset = "0x176A820", VA = "0x176A820", Slot = "5")]
		[DebuggerHidden]
		private void System_002EIDisposable_002EDispose()
		{
		}

		[Token(Token = "0x6001ADE")]
		[Address(RVA = "0x176A824", Offset = "0x176A824", VA = "0x176A824", Slot = "6")]
		private bool MoveNext()
		{
			return default;
		}

		[Token(Token = "0x6001ADF")]
		[Address(RVA = "0x176AB68", Offset = "0x176AB68", VA = "0x176AB68", Slot = "4")]
		[DebuggerHidden]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002Eget_Current()
		{
			return null;
		}

		[Token(Token = "0x6001AE0")]
		[Address(RVA = "0x176AB70", Offset = "0x176AB70", VA = "0x176AB70", Slot = "8")]
		[DebuggerHidden]
		private void System_002ECollections_002EIEnumerator_002EReset()
		{
		}

		[Token(Token = "0x6001AE1")]
		[Address(RVA = "0x176ABB0", Offset = "0x176ABB0", VA = "0x176ABB0", Slot = "7")]
		[DebuggerHidden]
		private object System_002ECollections_002EIEnumerator_002Eget_Current()
		{
			return null;
		}
	}

	[Token(Token = "0x4001E09")]
	[FieldOffset(Offset = "0x18")]
	public GolfBallController ballController;

	[Token(Token = "0x4001E0A")]
	[FieldOffset(Offset = "0x20")]
	public Rigidbody2D ballRb;

	[Token(Token = "0x4001E0B")]
	[FieldOffset(Offset = "0x28")]
	public float resetSqrVel;

	[Token(Token = "0x4001E0C")]
	[FieldOffset(Offset = "0x2C")]
	public float waitTime;

	[Token(Token = "0x4001E0D")]
	[FieldOffset(Offset = "0x30")]
	public AudioSource flyAudioSource;

	[Token(Token = "0x4001E0E")]
	[FieldOffset(Offset = "0x38")]
	public float flyAudioDelay;

	[Token(Token = "0x4001E0F")]
	[FieldOffset(Offset = "0x40")]
	public Transform CameraFollow;

	[Token(Token = "0x4001E10")]
	[FieldOffset(Offset = "0x48")]
	public bool lockY;

	[Token(Token = "0x4001E11")]
	[FieldOffset(Offset = "0x4C")]
	public float lockYValue;

	[Token(Token = "0x4001E12")]
	[FieldOffset(Offset = "0x50")]
	public Vector3 followOffset;

	[Token(Token = "0x4001E13")]
	[FieldOffset(Offset = "0x5C")]
	public float SmoothTime;

	[Token(Token = "0x4001E14")]
	[FieldOffset(Offset = "0x60")]
	public ExplosionBarrel2D explosionBarrel;

	[Token(Token = "0x4001E15")]
	[FieldOffset(Offset = "0x68")]
	private Coroutine coroutine;

	[Token(Token = "0x4001E16")]
	[FieldOffset(Offset = "0x70")]
	private Vector3 startPos;

	[Token(Token = "0x4001E17")]
	[FieldOffset(Offset = "0x7C")]
	private Vector3 tmpVel;

	[Token(Token = "0x6001AD6")]
	[Address(RVA = "0x1415F20", Offset = "0x1415F20", VA = "0x1415F20")]
	private void Start()
	{
	}

	[Token(Token = "0x6001AD7")]
	[Address(RVA = "0x141604C", Offset = "0x141604C", VA = "0x141604C")]
	private void BallController_OnReset()
	{
	}

	[Token(Token = "0x6001AD8")]
	[Address(RVA = "0x1416060", Offset = "0x1416060", VA = "0x1416060")]
	private void BallController_OnShoot(Vector3 obj)
	{
	}

	[Token(Token = "0x6001AD9")]
	[Address(RVA = "0x141611C", Offset = "0x141611C", VA = "0x141611C")]
	private IEnumerator ResetAfterShot()
	{
		return null;
	}

	[Token(Token = "0x6001ADA")]
	[Address(RVA = "0x1416190", Offset = "0x1416190", VA = "0x1416190")]
	private void Update()
	{
	}

	[Token(Token = "0x6001ADB")]
	[Address(RVA = "0x14162F0", Offset = "0x14162F0", VA = "0x14162F0")]
	public AngryGolfBall()
	{
	}
}
