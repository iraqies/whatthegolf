using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x2000D0A")]
public class ParticlesOnImpact : MonoBehaviour
{
	[Token(Token = "0x40046CD")]
	[FieldOffset(Offset = "0x18")]
	public ParticleSystem Particles;

	[Token(Token = "0x40046CE")]
	[FieldOffset(Offset = "0x20")]
	public float ImpactVelocityNeeded;

	[Token(Token = "0x40046CF")]
	[FieldOffset(Offset = "0x24")]
	public bool useTrigger;

	[Token(Token = "0x40046D0")]
	[FieldOffset(Offset = "0x28")]
	public string otherTriggerTag;

	[Token(Token = "0x40046D1")]
	[FieldOffset(Offset = "0x30")]
	public string tagForCollision;

	[Token(Token = "0x40046D2")]
	[FieldOffset(Offset = "0x38")]
	public bool moveToCollisionPoint;

	[Token(Token = "0x40046D3")]
	[FieldOffset(Offset = "0x39")]
	public bool ignoreY;

	[Token(Token = "0x6003D97")]
	[Address(RVA = "0x15DC438", Offset = "0x15DC438", VA = "0x15DC438")]
	private void OnCollisionEnter(Collision collision)
	{
	}

	[Token(Token = "0x6003D98")]
	[Address(RVA = "0x15DC628", Offset = "0x15DC628", VA = "0x15DC628")]
	private void OnTriggerEnter(Collider other)
	{
	}

	[Token(Token = "0x6003D99")]
	[Address(RVA = "0x15DC690", Offset = "0x15DC690", VA = "0x15DC690")]
	public ParticlesOnImpact()
	{
	}
}
