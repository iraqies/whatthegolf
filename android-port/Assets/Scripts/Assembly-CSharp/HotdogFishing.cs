using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using Core;
using Il2CppDummyDll;
using RootMotion.Demos;
using UnityEngine;

[Token(Token = "0x200025D")]
public class HotdogFishing : UserControlThirdPerson
{
	[Token(Token = "0x200025E")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x3E6F4", Offset = "0x3E6F4")]
	private sealed class _003CThrowBait_003Ed__14 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x4000C47")]
		[FieldOffset(Offset = "0x10")]
		private int _003C_003E1__state;

		[Token(Token = "0x4000C48")]
		[FieldOffset(Offset = "0x18")]
		private object _003C_003E2__current;

		[Token(Token = "0x4000C49")]
		[FieldOffset(Offset = "0x20")]
		public HotdogFishing _003C_003E4__this;

		[Token(Token = "0x4000C4A")]
		[FieldOffset(Offset = "0x28")]
		public Vector3 dir;

		[Token(Token = "0x1700014E")]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002ECurrent
		{
			[Token(Token = "0x6000AAD")]
			[Address(RVA = "0x17BFE40", Offset = "0x17BFE40", VA = "0x17BFE40", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002Eget_Current();
			}
		}

		[Token(Token = "0x1700014F")]
		private object System_002ECollections_002EIEnumerator_002ECurrent
		{
			[Token(Token = "0x6000AAF")]
			[Address(RVA = "0x17BFE88", Offset = "0x17BFE88", VA = "0x17BFE88", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return System_002ECollections_002EIEnumerator_002Eget_Current();
			}
		}

		[Token(Token = "0x6000AAA")]
		[Address(RVA = "0x17BFD28", Offset = "0x17BFD28", VA = "0x17BFD28")]
		[DebuggerHidden]
		public _003CThrowBait_003Ed__14(int _003C_003E1__state)
		{
		}

		[Token(Token = "0x6000AAB")]
		[Address(RVA = "0x17BFD54", Offset = "0x17BFD54", VA = "0x17BFD54", Slot = "5")]
		[DebuggerHidden]
		private void System_002EIDisposable_002EDispose()
		{
		}

		[Token(Token = "0x6000AAC")]
		[Address(RVA = "0x17BFD58", Offset = "0x17BFD58", VA = "0x17BFD58", Slot = "6")]
		private bool MoveNext()
		{
			return default;
		}

		[Token(Token = "0x6000AAD")]
		[Address(RVA = "0x17BFE40", Offset = "0x17BFE40", VA = "0x17BFE40", Slot = "4")]
		[DebuggerHidden]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002Eget_Current()
		{
			return null;
		}

		[Token(Token = "0x6000AAE")]
		[Address(RVA = "0x17BFE48", Offset = "0x17BFE48", VA = "0x17BFE48", Slot = "8")]
		[DebuggerHidden]
		private void System_002ECollections_002EIEnumerator_002EReset()
		{
		}

		[Token(Token = "0x6000AAF")]
		[Address(RVA = "0x17BFE88", Offset = "0x17BFE88", VA = "0x17BFE88", Slot = "7")]
		[DebuggerHidden]
		private object System_002ECollections_002EIEnumerator_002Eget_Current()
		{
			return null;
		}
	}

	[Token(Token = "0x4000C3C")]
	[FieldOffset(Offset = "0x48")]
	public GolfBallController Controller;

	[Token(Token = "0x4000C3D")]
	[FieldOffset(Offset = "0x50")]
	public SpringJoint Spring;

	[Token(Token = "0x4000C3E")]
	[FieldOffset(Offset = "0x58")]
	public float SpringReturnSpeed;

	[Token(Token = "0x4000C3F")]
	[FieldOffset(Offset = "0x60")]
	public Rigidbody Bait;

	[Token(Token = "0x4000C40")]
	[FieldOffset(Offset = "0x68")]
	public float BaitFollowMinDistance;

	[Token(Token = "0x4000C41")]
	[FieldOffset(Offset = "0x6C")]
	public float MaxBaitDistance;

	[Token(Token = "0x4000C42")]
	[FieldOffset(Offset = "0x70")]
	public float BaitThrowMagnitude;

	[Token(Token = "0x4000C43")]
	[FieldOffset(Offset = "0x74")]
	private Vector3 aimDir;

	[Token(Token = "0x4000C44")]
	[FieldOffset(Offset = "0x80")]
	private float targetSpring;

	[Token(Token = "0x4000C45")]
	[FieldOffset(Offset = "0x84")]
	private float baseSpring;

	[Token(Token = "0x4000C46")]
	[FieldOffset(Offset = "0x88")]
	private Vector3 lastBaitVel;

	[Token(Token = "0x6000AA2")]
	[Address(RVA = "0x14DA944", Offset = "0x14DA944", VA = "0x14DA944", Slot = "4")]
	protected override void Start()
	{
	}

	[Token(Token = "0x6000AA3")]
	[Address(RVA = "0x14DAAE4", Offset = "0x14DAAE4", VA = "0x14DAAE4")]
	private void OnAimStart()
	{
	}

	[Token(Token = "0x6000AA4")]
	[Address(RVA = "0x14DAB0C", Offset = "0x14DAB0C", VA = "0x14DAB0C")]
	public void OnShoot(Vector3 boost)
	{
	}

	[Token(Token = "0x6000AA5")]
	[Address(RVA = "0x14DABF0", Offset = "0x14DABF0", VA = "0x14DABF0")]
	private IEnumerator ThrowBait(Vector3 dir)
	{
		return null;
	}

	[Token(Token = "0x6000AA6")]
	[Address(RVA = "0x14DAC88", Offset = "0x14DAC88", VA = "0x14DAC88")]
	public void OnAimUpdate(Vector3 boost, bool onlyAimArrow)
	{
	}

	[Token(Token = "0x6000AA7")]
	[Address(RVA = "0x14DACCC", Offset = "0x14DACCC", VA = "0x14DACCC", Slot = "5")]
	protected override void Update()
	{
	}

	[Token(Token = "0x6000AA8")]
	[Address(RVA = "0x14DB018", Offset = "0x14DB018", VA = "0x14DB018")]
	private void FixedUpdate()
	{
	}

	[Token(Token = "0x6000AA9")]
	[Address(RVA = "0x14DB0A0", Offset = "0x14DB0A0", VA = "0x14DB0A0")]
	public HotdogFishing()
	{
	}
}
