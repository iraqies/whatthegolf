using System.Collections.Generic;
using Core;
using Il2CppDummyDll;
using UnityEngine;
using Utility;

[Token(Token = "0x20008A8")]
public class HorseshoeThrower : GolfBallShooterBase
{
	[Token(Token = "0x20008A9")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x41B80", Offset = "0x41B80")]
	private sealed class _003C_003Ec__DisplayClass16_0
	{
		[Token(Token = "0x4002F9A")]
		[FieldOffset(Offset = "0x10")]
		public Collider[] colliders;

		[Token(Token = "0x4002F9B")]
		[FieldOffset(Offset = "0x18")]
		public HorseshoeThrower _003C_003E4__this;

		[Token(Token = "0x6002805")]
		[Address(RVA = "0x17BF760", Offset = "0x17BF760", VA = "0x17BF760")]
		public _003C_003Ec__DisplayClass16_0()
		{
		}

		[Token(Token = "0x6002806")]
		[Address(RVA = "0x17BF768", Offset = "0x17BF768", VA = "0x17BF768")]
		internal void _003CStart_003Eb__0(GameObject g)
		{
		}
	}

	[Token(Token = "0x4002F8A")]
	[FieldOffset(Offset = "0x60")]
	public GameObject ObjectToSpawn;

	[Token(Token = "0x4002F8B")]
	[FieldOffset(Offset = "0x68")]
	public Transform SpawnPosition;

	[Token(Token = "0x4002F8C")]
	[FieldOffset(Offset = "0x70")]
	public Rigidbody HorseHand;

	[Token(Token = "0x4002F8D")]
	[FieldOffset(Offset = "0x78")]
	public Rigidbody HorseRotator;

	[Token(Token = "0x4002F8E")]
	[FieldOffset(Offset = "0x80")]
	public float ThrowForce;

	[Token(Token = "0x4002F8F")]
	[FieldOffset(Offset = "0x84")]
	public float MinThrowForce;

	[Token(Token = "0x4002F90")]
	[FieldOffset(Offset = "0x88")]
	public float Spin;

	[Token(Token = "0x4002F91")]
	[FieldOffset(Offset = "0x8C")]
	public float Pitch;

	[Token(Token = "0x4002F92")]
	[FieldOffset(Offset = "0x90")]
	public float HandRetractRange;

	[Token(Token = "0x4002F93")]
	[FieldOffset(Offset = "0x94")]
	public Vector3 euler;

	[Token(Token = "0x4002F94")]
	[FieldOffset(Offset = "0xA0")]
	public List<ConstantForce> FrontlegForces;

	[Token(Token = "0x4002F95")]
	[FieldOffset(Offset = "0xA8")]
	private ObjectPool<GameObject> objectPool;

	[Token(Token = "0x4002F96")]
	[FieldOffset(Offset = "0xB0")]
	private Rigidbody currentObject;

	[Token(Token = "0x4002F97")]
	[FieldOffset(Offset = "0xB8")]
	private Vector3 handTargetPosition;

	[Token(Token = "0x4002F98")]
	[FieldOffset(Offset = "0xC4")]
	private float throwTimer;

	[Token(Token = "0x4002F99")]
	[FieldOffset(Offset = "0xC8")]
	private FixedJoint currentJoint;

	[Token(Token = "0x60027FF")]
	[Address(RVA = "0x14D9B08", Offset = "0x14D9B08", VA = "0x14D9B08")]
	private void Start()
	{
	}

	[Token(Token = "0x6002800")]
	[Address(RVA = "0x14D9C68", Offset = "0x14D9C68", VA = "0x14D9C68", Slot = "12")]
	protected override void FixedUpdate()
	{
	}

	[Token(Token = "0x6002801")]
	[Address(RVA = "0x14D9D30", Offset = "0x14D9D30", VA = "0x14D9D30", Slot = "5")]
	public override void OnAimStart()
	{
	}

	[Token(Token = "0x6002802")]
	[Address(RVA = "0x14D9FB0", Offset = "0x14D9FB0", VA = "0x14D9FB0", Slot = "6")]
	public override void OnAimUpdate(Vector3 boost, bool onlyAimArrow)
	{
	}

	[Token(Token = "0x6002803")]
	[Address(RVA = "0x14DA0A4", Offset = "0x14DA0A4", VA = "0x14DA0A4", Slot = "7")]
	public override void OnShoot(Vector3 boost)
	{
	}

	[Token(Token = "0x6002804")]
	[Address(RVA = "0x14DA2B0", Offset = "0x14DA2B0", VA = "0x14DA2B0")]
	public HorseshoeThrower()
	{
	}
}
