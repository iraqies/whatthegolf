using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using Audio;
using Core;
using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x200020C")]
public class DoubleSwingers : GolfBallShooterBase
{
	[Token(Token = "0x200020D")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x3E450", Offset = "0x3E450")]
	private sealed class _003CStart_003Ed__18 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x4000A21")]
		[FieldOffset(Offset = "0x10")]
		private int _003C_003E1__state;

		[Token(Token = "0x4000A22")]
		[FieldOffset(Offset = "0x18")]
		private object _003C_003E2__current;

		[Token(Token = "0x4000A23")]
		[FieldOffset(Offset = "0x20")]
		public DoubleSwingers _003C_003E4__this;

		[Token(Token = "0x1700011F")]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002ECurrent
		{
			[Token(Token = "0x600092D")]
			[Address(RVA = "0x179DDD4", Offset = "0x179DDD4", VA = "0x179DDD4", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002Eget_Current();
			}
		}

		[Token(Token = "0x17000120")]
		private object System_002ECollections_002EIEnumerator_002ECurrent
		{
			[Token(Token = "0x600092F")]
			[Address(RVA = "0x179DE1C", Offset = "0x179DE1C", VA = "0x179DE1C", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return System_002ECollections_002EIEnumerator_002Eget_Current();
			}
		}

		[Token(Token = "0x600092A")]
		[Address(RVA = "0x179D934", Offset = "0x179D934", VA = "0x179D934")]
		[DebuggerHidden]
		public _003CStart_003Ed__18(int _003C_003E1__state)
		{
		}

		[Token(Token = "0x600092B")]
		[Address(RVA = "0x179D960", Offset = "0x179D960", VA = "0x179D960", Slot = "5")]
		[DebuggerHidden]
		private void System_002EIDisposable_002EDispose()
		{
		}

		[Token(Token = "0x600092C")]
		[Address(RVA = "0x179D964", Offset = "0x179D964", VA = "0x179D964", Slot = "6")]
		private bool MoveNext()
		{
			return default;
		}

		[Token(Token = "0x600092D")]
		[Address(RVA = "0x179DDD4", Offset = "0x179DDD4", VA = "0x179DDD4", Slot = "4")]
		[DebuggerHidden]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002Eget_Current()
		{
			return null;
		}

		[Token(Token = "0x600092E")]
		[Address(RVA = "0x179DDDC", Offset = "0x179DDDC", VA = "0x179DDDC", Slot = "8")]
		[DebuggerHidden]
		private void System_002ECollections_002EIEnumerator_002EReset()
		{
		}

		[Token(Token = "0x600092F")]
		[Address(RVA = "0x179DE1C", Offset = "0x179DE1C", VA = "0x179DE1C", Slot = "7")]
		[DebuggerHidden]
		private object System_002ECollections_002EIEnumerator_002Eget_Current()
		{
			return null;
		}
	}

	[Token(Token = "0x4000A0F")]
	[FieldOffset(Offset = "0x60")]
	public List<Rigidbody> Swingers;

	[Token(Token = "0x4000A10")]
	[FieldOffset(Offset = "0x68")]
	public float RotateSpeed;

	[Token(Token = "0x4000A11")]
	[FieldOffset(Offset = "0x70")]
	public List<Joint> FixedJoints;

	[Token(Token = "0x4000A12")]
	[FieldOffset(Offset = "0x78")]
	public Rigidbody Pole;

	[Token(Token = "0x4000A13")]
	[FieldOffset(Offset = "0x80")]
	public float GroundCheckDist;

	[Token(Token = "0x4000A14")]
	[FieldOffset(Offset = "0x84")]
	public LayerMask GroundMask;

	[Token(Token = "0x4000A15")]
	[FieldOffset(Offset = "0x88")]
	public float SwingWarmupSpeed;

	[Token(Token = "0x4000A16")]
	[FieldOffset(Offset = "0x90")]
	public ClipSettingsCollection SwitchClip;

	[Token(Token = "0x4000A17")]
	[FieldOffset(Offset = "0x98")]
	public ClipSettingsCollection FailClip;

	[Token(Token = "0x4000A18")]
	[FieldOffset(Offset = "0xA0")]
	public AudioSource MoveSource;

	[Token(Token = "0x4000A19")]
	[FieldOffset(Offset = "0xA8")]
	private int currentSwinger;

	[Token(Token = "0x4000A1A")]
	[FieldOffset(Offset = "0xAC")]
	private int swingDirection;

	[Token(Token = "0x4000A1B")]
	[FieldOffset(Offset = "0xB0")]
	private Dictionary<Rigidbody, Quaternion> baseRotations;

	[Token(Token = "0x4000A1C")]
	[FieldOffset(Offset = "0xB8")]
	private Dictionary<Rigidbody, List<Rigidbody>> swingerRigidbodies;

	[Token(Token = "0x4000A1D")]
	[FieldOffset(Offset = "0xC0")]
	private bool isSwinging;

	[Token(Token = "0x4000A1E")]
	[FieldOffset(Offset = "0xC8")]
	private DoubleSwingersPlatform currentPlatform;

	[Token(Token = "0x4000A1F")]
	[FieldOffset(Offset = "0xD0")]
	private Vector3 platformOffset;

	[Token(Token = "0x4000A20")]
	[FieldOffset(Offset = "0xDC")]
	private float swingWarmup;

	[Token(Token = "0x6000924")]
	[Address(RVA = "0x1432BDC", Offset = "0x1432BDC", VA = "0x1432BDC")]
	private IEnumerator Start()
	{
		return null;
	}

	[Token(Token = "0x6000925")]
	[Address(RVA = "0x1432C50", Offset = "0x1432C50", VA = "0x1432C50", Slot = "7")]
	public override void OnShoot(Vector3 boost)
	{
	}

	[Token(Token = "0x6000926")]
	[Address(RVA = "0x1433764", Offset = "0x1433764", VA = "0x1433764", Slot = "12")]
	protected override void FixedUpdate()
	{
	}

	[Token(Token = "0x6000927")]
	[Address(RVA = "0x1433C40", Offset = "0x1433C40", VA = "0x1433C40", Slot = "6")]
	public override void OnAimUpdate(Vector3 boost, bool onlyAimArrow)
	{
	}

	[Token(Token = "0x6000928")]
	[Address(RVA = "0x1432CC4", Offset = "0x1432CC4", VA = "0x1432CC4")]
	private void SwitchSwinger(int nextSwinger)
	{
	}

	[Token(Token = "0x6000929")]
	[Address(RVA = "0x1433D24", Offset = "0x1433D24", VA = "0x1433D24")]
	public DoubleSwingers()
	{
	}
}
