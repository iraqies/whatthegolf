using Audio;
using Core;
using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x20005EC")]
public class BeachBall : MonoBehaviour
{
	[Token(Token = "0x4001E50")]
	[FieldOffset(Offset = "0x18")]
	[SerializeField]
	private GolfBallController Controller;

	[Token(Token = "0x4001E51")]
	[FieldOffset(Offset = "0x20")]
	[SerializeField]
	private ParticleSystem explosionParticleSystem;

	[Token(Token = "0x4001E52")]
	[FieldOffset(Offset = "0x28")]
	[SerializeField]
	private RandomAudioClips bangClips;

	[Token(Token = "0x4001E53")]
	[FieldOffset(Offset = "0x30")]
	[SerializeField]
	private float popOnCollisionThreshold;

	[Token(Token = "0x4001E54")]
	[FieldOffset(Offset = "0x34")]
	[SerializeField]
	private bool failOnPopped;

	[Token(Token = "0x4001E55")]
	[FieldOffset(Offset = "0x35")]
	[SerializeField]
	private bool instantiateParticleSystem;

	[Token(Token = "0x4001E56")]
	[FieldOffset(Offset = "0x36")]
	private bool popped;

	[Token(Token = "0x4001E57")]
	[FieldOffset(Offset = "0x38")]
	private Level level;

	[Token(Token = "0x6001AF7")]
	[Address(RVA = "0x160B104", Offset = "0x160B104", VA = "0x160B104")]
	private void Awake()
	{
	}

	[Token(Token = "0x6001AF8")]
	[Address(RVA = "0x160B12C", Offset = "0x160B12C", VA = "0x160B12C")]
	public void Bang()
	{
	}

	[Token(Token = "0x6001AF9")]
	[Address(RVA = "0x160B3C0", Offset = "0x160B3C0", VA = "0x160B3C0")]
	private void OnCollisionEnter(Collision other)
	{
	}

	[Token(Token = "0x6001AFA")]
	[Address(RVA = "0x160B434", Offset = "0x160B434", VA = "0x160B434")]
	public BeachBall()
	{
	}
}
