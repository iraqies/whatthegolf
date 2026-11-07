using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x2000E8F")]
public class ParticlesOnHit : MonoBehaviour
{
	[Token(Token = "0x4004EAE")]
	[FieldOffset(Offset = "0x18")]
	[SerializeField]
	private string m_acceptedTag;

	[Token(Token = "0x4004EAF")]
	[FieldOffset(Offset = "0x20")]
	[SerializeField]
	private ParticleSystem m_hitParticles;

	[Token(Token = "0x6004400")]
	[Address(RVA = "0x15DC328", Offset = "0x15DC328", VA = "0x15DC328")]
	private void OnCollisionEnter(Collision collision)
	{
	}

	[Token(Token = "0x6004401")]
	[Address(RVA = "0x15DC430", Offset = "0x15DC430", VA = "0x15DC430")]
	public ParticlesOnHit()
	{
	}
}
