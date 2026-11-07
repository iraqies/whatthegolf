using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x20006DF")]
public class ChickenSquishDetection : MonoBehaviour
{
	[Token(Token = "0x40023F8")]
	[FieldOffset(Offset = "0x18")]
	public BadlandsChicken Root;

	[Token(Token = "0x40023F9")]
	[FieldOffset(Offset = "0x20")]
	public ParticleSystem DeathParticles;

	[Token(Token = "0x6001FB7")]
	[Address(RVA = "0x189CCF8", Offset = "0x189CCF8", VA = "0x189CCF8")]
	private void OnTriggerEnter(Collider other)
	{
	}

	[Token(Token = "0x6001FB8")]
	[Address(RVA = "0x189CD44", Offset = "0x189CD44", VA = "0x189CD44")]
	public ChickenSquishDetection()
	{
	}
}
