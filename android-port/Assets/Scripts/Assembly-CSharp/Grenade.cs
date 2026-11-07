using System.Collections.Generic;
using Chronos;
using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x2000828")]
public class Grenade : MonoBehaviour
{
	[Token(Token = "0x4002BF5")]
	[FieldOffset(Offset = "0x18")]
	public float Timer;

	[Token(Token = "0x4002BF6")]
	[FieldOffset(Offset = "0x1C")]
	public bool Armed;

	[Token(Token = "0x4002BF7")]
	[FieldOffset(Offset = "0x20")]
	public float Force;

	[Token(Token = "0x4002BF8")]
	[FieldOffset(Offset = "0x24")]
	public float UpwardsForce;

	[Token(Token = "0x4002BF9")]
	[FieldOffset(Offset = "0x28")]
	public float Radius;

	[Token(Token = "0x4002BFA")]
	[FieldOffset(Offset = "0x30")]
	public ParticleSystem Particles;

	[Token(Token = "0x4002BFB")]
	[FieldOffset(Offset = "0x38")]
	public ParticleSystem ArmedParticles;

	[Token(Token = "0x4002BFC")]
	[FieldOffset(Offset = "0x40")]
	private Timeline timeline;

	[Token(Token = "0x4002BFD")]
	[FieldOffset(Offset = "0x48")]
	private List<Rigidbody> affectedObjects;

	[Token(Token = "0x6002586")]
	[Address(RVA = "0x14B8EC0", Offset = "0x14B8EC0", VA = "0x14B8EC0")]
	private void Start()
	{
	}

	[Token(Token = "0x6002587")]
	[Address(RVA = "0x14B8F64", Offset = "0x14B8F64", VA = "0x14B8F64")]
	private void Update()
	{
	}

	[Token(Token = "0x6002588")]
	[Address(RVA = "0x14B93BC", Offset = "0x14B93BC", VA = "0x14B93BC")]
	private void OnDrawGizmosSelected()
	{
	}

	[Token(Token = "0x6002589")]
	[Address(RVA = "0x14B93F8", Offset = "0x14B93F8", VA = "0x14B93F8")]
	public void WeaponShot()
	{
	}

	[Token(Token = "0x600258A")]
	[Address(RVA = "0x14B9430", Offset = "0x14B9430", VA = "0x14B9430")]
	public Grenade()
	{
	}
}
