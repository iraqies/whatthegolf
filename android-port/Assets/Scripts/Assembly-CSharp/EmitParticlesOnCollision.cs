using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x20001F2")]
public class EmitParticlesOnCollision : MonoBehaviour
{
	[Token(Token = "0x4000966")]
	[FieldOffset(Offset = "0x18")]
	public LayerMask CollisionLayers;

	[Token(Token = "0x4000967")]
	[FieldOffset(Offset = "0x20")]
	public ParticleSystem Particles;

	[Token(Token = "0x4000968")]
	[FieldOffset(Offset = "0x28")]
	public int ParticlesEmitted;

	[Token(Token = "0x60008BB")]
	[Address(RVA = "0x1441E1C", Offset = "0x1441E1C", VA = "0x1441E1C")]
	private void OnCollisionEnter(Collision other)
	{
	}

	[Token(Token = "0x60008BC")]
	[Address(RVA = "0x1441E8C", Offset = "0x1441E8C", VA = "0x1441E8C")]
	public EmitParticlesOnCollision()
	{
	}
}
