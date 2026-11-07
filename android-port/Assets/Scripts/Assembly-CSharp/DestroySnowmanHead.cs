using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x2000CFC")]
public class DestroySnowmanHead : MonoBehaviour
{
	[Token(Token = "0x4004684")]
	[FieldOffset(Offset = "0x18")]
	public GameObject SnowmanHead;

	[Token(Token = "0x4004685")]
	[FieldOffset(Offset = "0x20")]
	public Rigidbody[] ObjectsToBlowAway;

	[Token(Token = "0x4004686")]
	[FieldOffset(Offset = "0x28")]
	public ParticleSystem Particles;

	[Token(Token = "0x4004687")]
	[FieldOffset(Offset = "0x30")]
	private bool destroyed;

	[Token(Token = "0x6003D59")]
	[Address(RVA = "0x18DB9BC", Offset = "0x18DB9BC", VA = "0x18DB9BC")]
	public void DestroyHead()
	{
	}

	[Token(Token = "0x6003D5A")]
	[Address(RVA = "0x18DBB0C", Offset = "0x18DBB0C", VA = "0x18DBB0C")]
	public DestroySnowmanHead()
	{
	}
}
