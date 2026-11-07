using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x200087B")]
public class EmitParticles : MonoBehaviour
{
	[Token(Token = "0x4002E7E")]
	[FieldOffset(Offset = "0x18")]
	public int particleCount;

	[Token(Token = "0x4002E7F")]
	[FieldOffset(Offset = "0x1C")]
	public int totalEmitCount;

	[Token(Token = "0x4002E80")]
	[FieldOffset(Offset = "0x20")]
	private ParticleSystem particles;

	[Token(Token = "0x4002E81")]
	[FieldOffset(Offset = "0x28")]
	private int currentCount;

	[Token(Token = "0x6002722")]
	[Address(RVA = "0x1441CD0", Offset = "0x1441CD0", VA = "0x1441CD0")]
	private void Start()
	{
	}

	[Token(Token = "0x6002723")]
	[Address(RVA = "0x1441D2C", Offset = "0x1441D2C", VA = "0x1441D2C")]
	private void OnCollisionEnter(Collision other)
	{
	}

	[Token(Token = "0x6002724")]
	[Address(RVA = "0x1441E0C", Offset = "0x1441E0C", VA = "0x1441E0C")]
	public EmitParticles()
	{
	}
}
