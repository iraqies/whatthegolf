using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using Core;
using Il2CppDummyDll;
using RootMotion.Demos;
using RootMotion.Dynamics;
using UnityEngine;

[Token(Token = "0x200027A")]
public class WrestlerController : UserControlThirdPerson
{
	[Token(Token = "0x200027B")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x3E784", Offset = "0x3E784")]
	private sealed class _003CRegainPinDelayed_003Ed__14 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x4000D12")]
		[FieldOffset(Offset = "0x10")]
		private int _003C_003E1__state;

		[Token(Token = "0x4000D13")]
		[FieldOffset(Offset = "0x18")]
		private object _003C_003E2__current;

		[Token(Token = "0x4000D14")]
		[FieldOffset(Offset = "0x20")]
		public WrestlerController _003C_003E4__this;

		[Token(Token = "0x17000158")]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002ECurrent
		{
			[Token(Token = "0x6000B3A")]
			[Address(RVA = "0x187A0FC", Offset = "0x187A0FC", VA = "0x187A0FC", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002Eget_Current();
			}
		}

		[Token(Token = "0x17000159")]
		private object System_002ECollections_002EIEnumerator_002ECurrent
		{
			[Token(Token = "0x6000B3C")]
			[Address(RVA = "0x187A144", Offset = "0x187A144", VA = "0x187A144", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return System_002ECollections_002EIEnumerator_002Eget_Current();
			}
		}

		[Token(Token = "0x6000B37")]
		[Address(RVA = "0x1879FB8", Offset = "0x1879FB8", VA = "0x1879FB8")]
		[DebuggerHidden]
		public _003CRegainPinDelayed_003Ed__14(int _003C_003E1__state)
		{
		}

		[Token(Token = "0x6000B38")]
		[Address(RVA = "0x1879FE4", Offset = "0x1879FE4", VA = "0x1879FE4", Slot = "5")]
		[DebuggerHidden]
		private void System_002EIDisposable_002EDispose()
		{
		}

		[Token(Token = "0x6000B39")]
		[Address(RVA = "0x1879FE8", Offset = "0x1879FE8", VA = "0x1879FE8", Slot = "6")]
		private bool MoveNext()
		{
			return default;
		}

		[Token(Token = "0x6000B3A")]
		[Address(RVA = "0x187A0FC", Offset = "0x187A0FC", VA = "0x187A0FC", Slot = "4")]
		[DebuggerHidden]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002Eget_Current()
		{
			return null;
		}

		[Token(Token = "0x6000B3B")]
		[Address(RVA = "0x187A104", Offset = "0x187A104", VA = "0x187A104", Slot = "8")]
		[DebuggerHidden]
		private void System_002ECollections_002EIEnumerator_002EReset()
		{
		}

		[Token(Token = "0x6000B3C")]
		[Address(RVA = "0x187A144", Offset = "0x187A144", VA = "0x187A144", Slot = "7")]
		[DebuggerHidden]
		private object System_002ECollections_002EIEnumerator_002Eget_Current()
		{
			return null;
		}
	}

	[Token(Token = "0x4000D08")]
	[FieldOffset(Offset = "0x48")]
	public GolfBallController Controller;

	[Token(Token = "0x4000D09")]
	[FieldOffset(Offset = "0x50")]
	public float JumpTime;

	[Token(Token = "0x4000D0A")]
	[FieldOffset(Offset = "0x58")]
	public CharacterPuppet Puppet;

	[Token(Token = "0x4000D0B")]
	[FieldOffset(Offset = "0x60")]
	public PuppetMaster puppetMaster;

	[Token(Token = "0x4000D0C")]
	[FieldOffset(Offset = "0x68")]
	public Transform[] arms;

	[Token(Token = "0x4000D0D")]
	[FieldOffset(Offset = "0x70")]
	public Muscle.Props inJumpArmProperties;

	[Token(Token = "0x4000D0E")]
	[FieldOffset(Offset = "0x78")]
	private Vector3 aimDir;

	[Token(Token = "0x4000D0F")]
	[FieldOffset(Offset = "0x84")]
	private float jumpTimer;

	[Token(Token = "0x4000D10")]
	[FieldOffset(Offset = "0x88")]
	private Rigidbody controllerRigidbody;

	[Token(Token = "0x4000D11")]
	[FieldOffset(Offset = "0x90")]
	private Dictionary<Muscle, Muscle.Props> defaultPinInfo;

	[Token(Token = "0x6000B30")]
	[Address(RVA = "0x175B698", Offset = "0x175B698", VA = "0x175B698", Slot = "4")]
	protected override void Start()
	{
	}

	[Token(Token = "0x6000B31")]
	[Address(RVA = "0x175B8FC", Offset = "0x175B8FC", VA = "0x175B8FC")]
	public void OnShoot(Vector3 boost)
	{
	}

	[Token(Token = "0x6000B32")]
	[Address(RVA = "0x175B9C0", Offset = "0x175B9C0", VA = "0x175B9C0")]
	private void SetWeights(bool setToDefault)
	{
	}

	[Token(Token = "0x6000B33")]
	[Address(RVA = "0x175BB50", Offset = "0x175BB50", VA = "0x175BB50")]
	private IEnumerator RegainPinDelayed(float delay)
	{
		return null;
	}

	[Token(Token = "0x6000B34")]
	[Address(RVA = "0x175BBC4", Offset = "0x175BBC4", VA = "0x175BBC4")]
	public void OnAimUpdate(Vector3 boost, bool onlyAimArrow)
	{
	}

	[Token(Token = "0x6000B35")]
	[Address(RVA = "0x175BC00", Offset = "0x175BC00", VA = "0x175BC00", Slot = "5")]
	protected override void Update()
	{
	}

	[Token(Token = "0x6000B36")]
	[Address(RVA = "0x175BDE4", Offset = "0x175BDE4", VA = "0x175BDE4")]
	public WrestlerController()
	{
	}
}
