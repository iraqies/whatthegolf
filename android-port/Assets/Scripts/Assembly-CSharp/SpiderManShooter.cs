using System;
using System.Collections.Generic;
using Core;
using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x200086E")]
public class SpiderManShooter : GolfBallShooterBase
{
	[Serializable]
	[Token(Token = "0x200086F")]
	public class Spiderhook
	{
		[Token(Token = "0x4002E34")]
		[FieldOffset(Offset = "0x10")]
		public Rigidbody HookRigid;

		[Token(Token = "0x4002E35")]
		[FieldOffset(Offset = "0x18")]
		public Transform HookAttach;

		[Token(Token = "0x4002E36")]
		[FieldOffset(Offset = "0x20")]
		public bool HasHit;

		[Token(Token = "0x4002E37")]
		[FieldOffset(Offset = "0x21")]
		public bool Enabled;

		[Token(Token = "0x4002E38")]
		[FieldOffset(Offset = "0x22")]
		public bool OnlyThisActive;

		[Token(Token = "0x60026F1")]
		[Address(RVA = "0x1859588", Offset = "0x1859588", VA = "0x1859588")]
		public Spiderhook()
		{
		}
	}

	[Serializable]
	[Token(Token = "0x2000870")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x41AB0", Offset = "0x41AB0")]
	private sealed class _003C_003Ec
	{
		[Token(Token = "0x4002E39")]
		[FieldOffset(Offset = "0x0")]
		public static readonly _003C_003Ec _003C_003E9;

		[Token(Token = "0x4002E3A")]
		[FieldOffset(Offset = "0x8")]
		public static Func<Spiderhook, bool> _003C_003E9__13_0;

		[Token(Token = "0x60026F3")]
		[Address(RVA = "0x1859568", Offset = "0x1859568", VA = "0x1859568")]
		public _003C_003Ec()
		{
		}

		[Token(Token = "0x60026F4")]
		[Address(RVA = "0x1859570", Offset = "0x1859570", VA = "0x1859570")]
		internal bool _003CStart_003Eb__13_0(Spiderhook h)
		{
			return default;
		}
	}

	[Token(Token = "0x4002E28")]
	[FieldOffset(Offset = "0x60")]
	public List<Spiderhook> SpiderHooks;

	[Token(Token = "0x4002E29")]
	[FieldOffset(Offset = "0x68")]
	public float HookSpeed;

	[Token(Token = "0x4002E2A")]
	[FieldOffset(Offset = "0x6C")]
	public float HookHeight;

	[Token(Token = "0x4002E2B")]
	[FieldOffset(Offset = "0x70")]
	public float HookUpBoost;

	[Token(Token = "0x4002E2C")]
	[FieldOffset(Offset = "0x74")]
	public float SpringTotalPullForce;

	[Token(Token = "0x4002E2D")]
	[FieldOffset(Offset = "0x78")]
	public LayerMask KillLayers;

	[Token(Token = "0x4002E2E")]
	[FieldOffset(Offset = "0x80")]
	public List<AudioClip> ShootClip;

	[Token(Token = "0x4002E2F")]
	[FieldOffset(Offset = "0x88")]
	public List<AudioClip> ShootHitClip;

	[Token(Token = "0x4002E30")]
	[FieldOffset(Offset = "0x90")]
	public List<AudioClip> SwingClip;

	[Token(Token = "0x4002E31")]
	[FieldOffset(Offset = "0x98")]
	public List<AudioClip> DropClip;

	[Token(Token = "0x4002E32")]
	[FieldOffset(Offset = "0xA0")]
	private int curHandIndex;

	[Token(Token = "0x4002E33")]
	[FieldOffset(Offset = "0xA8")]
	private List<Spiderhook> allHooks;

	[Token(Token = "0x60026E8")]
	[Address(RVA = "0x16D4FF0", Offset = "0x16D4FF0", VA = "0x16D4FF0")]
	private void Start()
	{
	}

	[Token(Token = "0x60026E9")]
	[Address(RVA = "0x16D5318", Offset = "0x16D5318", VA = "0x16D5318", Slot = "7")]
	public override void OnShoot(Vector3 boost)
	{
	}

	[Token(Token = "0x60026EA")]
	[Address(RVA = "0x16D55CC", Offset = "0x16D55CC", VA = "0x16D55CC")]
	public void ReenableAllHooks()
	{
	}

	[Token(Token = "0x60026EB")]
	[Address(RVA = "0x16D571C", Offset = "0x16D571C", VA = "0x16D571C")]
	public void ShootTowardsPoint(Transform point)
	{
	}

	[Token(Token = "0x60026EC")]
	[Address(RVA = "0x16D5A04", Offset = "0x16D5A04", VA = "0x16D5A04", Slot = "12")]
	protected override void FixedUpdate()
	{
	}

	[Token(Token = "0x60026ED")]
	[Address(RVA = "0x16D5D44", Offset = "0x16D5D44", VA = "0x16D5D44", Slot = "9")]
	public override void OnReset()
	{
	}

	[Token(Token = "0x60026EE")]
	[Address(RVA = "0x16D5D6C", Offset = "0x16D5D6C", VA = "0x16D5D6C")]
	private void Reset()
	{
	}

	[Token(Token = "0x60026EF")]
	[Address(RVA = "0x16D5F44", Offset = "0x16D5F44", VA = "0x16D5F44")]
	private void OnCollisionEnter(Collision other)
	{
	}

	[Token(Token = "0x60026F0")]
	[Address(RVA = "0x16D6014", Offset = "0x16D6014", VA = "0x16D6014")]
	public SpiderManShooter()
	{
	}
}
