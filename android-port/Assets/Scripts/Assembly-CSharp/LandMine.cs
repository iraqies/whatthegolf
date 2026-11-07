using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x20007BC")]
public class LandMine : MonoBehaviour
{
	[Token(Token = "0x40028E6")]
	[FieldOffset(Offset = "0x18")]
	public float radius;

	[Token(Token = "0x40028E7")]
	[FieldOffset(Offset = "0x1C")]
	public float power;

	[Token(Token = "0x40028E8")]
	[FieldOffset(Offset = "0x20")]
	private ParticleSystem particle;

	[Token(Token = "0x40028E9")]
	[FieldOffset(Offset = "0x28")]
	private Renderer rend;

	[Token(Token = "0x40028EA")]
	[FieldOffset(Offset = "0x30")]
	private Collider col;

	[Token(Token = "0x40028EB")]
	[FieldOffset(Offset = "0x38")]
	private AudioSource audio;

	[Token(Token = "0x600236A")]
	[Address(RVA = "0x1501B50", Offset = "0x1501B50", VA = "0x1501B50")]
	private void Start()
	{
	}

	[Token(Token = "0x600236B")]
	[Address(RVA = "0x1501C20", Offset = "0x1501C20", VA = "0x1501C20")]
	private void OnCollisionEnter(Collision other)
	{
	}

	[Token(Token = "0x600236C")]
	[Address(RVA = "0x1501DDC", Offset = "0x1501DDC", VA = "0x1501DDC")]
	public LandMine()
	{
	}
}
