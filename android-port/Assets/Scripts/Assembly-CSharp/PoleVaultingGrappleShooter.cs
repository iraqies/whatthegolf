using System;
using System.Collections.Generic;
using Core;
using Il2CppDummyDll;
using RootMotion.Dynamics;
using UnityEngine;

[Token(Token = "0x20001DB")]
public class PoleVaultingGrappleShooter : GolfBallShooterBase
{
	[Serializable]
	[Token(Token = "0x20001DC")]
	public class Spiderhook
	{
		[Token(Token = "0x40008BF")]
		[FieldOffset(Offset = "0x10")]
		public Rigidbody HookRigid;

		[Token(Token = "0x40008C0")]
		[FieldOffset(Offset = "0x18")]
		public Rigidbody HookAttach;

		[Token(Token = "0x40008C1")]
		[FieldOffset(Offset = "0x20")]
		public bool HasHit;

		[Token(Token = "0x40008C2")]
		[FieldOffset(Offset = "0x21")]
		public bool Enabled;

		[Token(Token = "0x40008C3")]
		[FieldOffset(Offset = "0x22")]
		public bool OnlyThisActive;

		[Token(Token = "0x40008C4")]
		[FieldOffset(Offset = "0x24")]
		public float HitDotResult;

		[Token(Token = "0x40008C5")]
		[FieldOffset(Offset = "0x28")]
		private SpringJoint spring;

		[Token(Token = "0x6000858")]
		[Address(RVA = "0x1829F00", Offset = "0x1829F00", VA = "0x1829F00")]
		public SpringJoint GetSpring()
		{
			return null;
		}

		[Token(Token = "0x6000859")]
		[Address(RVA = "0x1829FB4", Offset = "0x1829FB4", VA = "0x1829FB4")]
		public Spiderhook()
		{
		}
	}

	[Serializable]
	[Token(Token = "0x20001DD")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x3E2F0", Offset = "0x3E2F0")]
	private sealed class _003C_003Ec
	{
		[Token(Token = "0x40008C6")]
		[FieldOffset(Offset = "0x0")]
		public static readonly _003C_003Ec _003C_003E9;

		[Token(Token = "0x40008C7")]
		[FieldOffset(Offset = "0x8")]
		public static Func<Spiderhook, bool> _003C_003E9__16_0;

		[Token(Token = "0x600085B")]
		[Address(RVA = "0x1829EE0", Offset = "0x1829EE0", VA = "0x1829EE0")]
		public _003C_003Ec()
		{
		}

		[Token(Token = "0x600085C")]
		[Address(RVA = "0x1829EE8", Offset = "0x1829EE8", VA = "0x1829EE8")]
		internal bool _003CStart_003Eb__16_0(Spiderhook h)
		{
			return default;
		}
	}

	[Token(Token = "0x40008B0")]
	[FieldOffset(Offset = "0x60")]
	public List<Spiderhook> SpiderHooks;

	[Token(Token = "0x40008B1")]
	[FieldOffset(Offset = "0x68")]
	public float HookForwardMovement;

	[Token(Token = "0x40008B2")]
	[FieldOffset(Offset = "0x6C")]
	public float HookSpeed;

	[Token(Token = "0x40008B3")]
	[FieldOffset(Offset = "0x70")]
	public float HookLength;

	[Token(Token = "0x40008B4")]
	[FieldOffset(Offset = "0x74")]
	public float SpringTotalPullForce;

	[Token(Token = "0x40008B5")]
	[FieldOffset(Offset = "0x78")]
	public float ExtraUpwardsPullForce;

	[Token(Token = "0x40008B6")]
	[FieldOffset(Offset = "0x7C")]
	public float HookBreakThreshold;

	[Token(Token = "0x40008B7")]
	[FieldOffset(Offset = "0x80")]
	public LayerMask HitLayer;

	[Token(Token = "0x40008B8")]
	[FieldOffset(Offset = "0x88")]
	public PuppetMaster Puppet;

	[Token(Token = "0x40008B9")]
	[FieldOffset(Offset = "0x90")]
	public Rigidbody PuppetRoot;

	[Token(Token = "0x40008BA")]
	[FieldOffset(Offset = "0x98")]
	public List<AudioClip> ShootClip;

	[Token(Token = "0x40008BB")]
	[FieldOffset(Offset = "0xA0")]
	public List<AudioClip> ShootHitClip;

	[Token(Token = "0x40008BC")]
	[FieldOffset(Offset = "0xA8")]
	public List<AudioClip> RopeCutClip;

	[Token(Token = "0x40008BD")]
	[FieldOffset(Offset = "0xB0")]
	private int curHandIndex;

	[Token(Token = "0x40008BE")]
	[FieldOffset(Offset = "0xB4")]
	private float resetTimer;

	[Token(Token = "0x6000852")]
	[Address(RVA = "0x1605EB0", Offset = "0x1605EB0", VA = "0x1605EB0")]
	private void Start()
	{
	}

	[Token(Token = "0x6000853")]
	[Address(RVA = "0x1606180", Offset = "0x1606180", VA = "0x1606180", Slot = "7")]
	public override void OnShoot(Vector3 boost)
	{
	}

	[Token(Token = "0x6000854")]
	[Address(RVA = "0x1606478", Offset = "0x1606478", VA = "0x1606478", Slot = "12")]
	protected override void FixedUpdate()
	{
	}

	[Token(Token = "0x6000855")]
	[Address(RVA = "0x1606DE8", Offset = "0x1606DE8", VA = "0x1606DE8", Slot = "9")]
	public override void OnReset()
	{
	}

	[Token(Token = "0x6000856")]
	[Address(RVA = "0x1606BE4", Offset = "0x1606BE4", VA = "0x1606BE4")]
	private void Reset()
	{
	}

	[Token(Token = "0x6000857")]
	[Address(RVA = "0x1606E10", Offset = "0x1606E10", VA = "0x1606E10")]
	public PoleVaultingGrappleShooter()
	{
	}
}
