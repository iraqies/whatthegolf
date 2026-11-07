using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x2000C73")]
public class CollisionBasedParticles : MonoBehaviour
{
	[Token(Token = "0x4004426")]
	[FieldOffset(Offset = "0x18")]
	[SerializeField]
	private List<ParticleSystem> particleSystems;

	[Token(Token = "0x4004427")]
	[FieldOffset(Offset = "0x20")]
	[SerializeField]
	private float minImpuleMagnitude;

	[Token(Token = "0x4004428")]
	[FieldOffset(Offset = "0x24")]
	[SerializeField]
	private int particlesToEmit;

	[Token(Token = "0x4004429")]
	[FieldOffset(Offset = "0x28")]
	[SerializeField]
	private bool rotateWithCollision;

	[Token(Token = "0x400442A")]
	[FieldOffset(Offset = "0x29")]
	[SerializeField]
	private bool moveToCollision;

	[Token(Token = "0x6003B13")]
	[Address(RVA = "0x18A7C7C", Offset = "0x18A7C7C", VA = "0x18A7C7C")]
	private void OnCollisionEnter(Collision c)
	{
	}

	[Token(Token = "0x6003B14")]
	[Address(RVA = "0x18A808C", Offset = "0x18A808C", VA = "0x18A808C")]
	public CollisionBasedParticles()
	{
	}
}
