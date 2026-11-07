using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x20005A3")]
public class OnParticleCollisionEffect : MonoBehaviour
{
	[Token(Token = "0x4001CD4")]
	[FieldOffset(Offset = "0x18")]
	public ParticleSystem ParticlesToSpawn;

	[Token(Token = "0x4001CD5")]
	[FieldOffset(Offset = "0x20")]
	public LayerMask AcceptedLayers;

	[Token(Token = "0x4001CD6")]
	[FieldOffset(Offset = "0x28")]
	private ParticleSystem part;

	[Token(Token = "0x4001CD7")]
	[FieldOffset(Offset = "0x30")]
	private List<ParticleCollisionEvent> collisionEvents;

	[Token(Token = "0x60019B0")]
	[Address(RVA = "0x1599DDC", Offset = "0x1599DDC", VA = "0x1599DDC")]
	private void Start()
	{
	}

	[Token(Token = "0x60019B1")]
	[Address(RVA = "0x1599E80", Offset = "0x1599E80", VA = "0x1599E80")]
	private void OnParticleCollision(GameObject other)
	{
	}

	[Token(Token = "0x60019B2")]
	[Address(RVA = "0x159A17C", Offset = "0x159A17C", VA = "0x159A17C")]
	public OnParticleCollisionEffect()
	{
	}
}
