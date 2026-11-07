using Audio;
using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x2000D1D")]
public class SnowballMachine : MonoBehaviour
{
	[Token(Token = "0x4004727")]
	[FieldOffset(Offset = "0x18")]
	[SerializeField]
	private ParticleSystem m_snowballParticle;

	[Token(Token = "0x4004728")]
	[FieldOffset(Offset = "0x20")]
	[SerializeField]
	private ClipSettingsCollection m_SpraySfx;

	[Token(Token = "0x6003DE0")]
	[Address(RVA = "0x16BCD70", Offset = "0x16BCD70", VA = "0x16BCD70")]
	private void OnCollisionEnter2D(Collision2D collision)
	{
	}

	[Token(Token = "0x6003DE1")]
	[Address(RVA = "0x16BCE38", Offset = "0x16BCE38", VA = "0x16BCE38")]
	public SnowballMachine()
	{
	}
}
