using Audio;
using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x2000265")]
public class ParticlesOnTriggerEnter : MonoBehaviour
{
	[Token(Token = "0x4000C6E")]
	[FieldOffset(Offset = "0x18")]
	public ParticleSystem particles;

	[Token(Token = "0x4000C6F")]
	[FieldOffset(Offset = "0x20")]
	public ClipSettingsCollection sfx;

	[Token(Token = "0x4000C70")]
	[FieldOffset(Offset = "0x28")]
	public bool onlyTriggerOnPlayerTag;

	[Token(Token = "0x6000ACF")]
	[Address(RVA = "0x15DC708", Offset = "0x15DC708", VA = "0x15DC708")]
	private void Start()
	{
	}

	[Token(Token = "0x6000AD0")]
	[Address(RVA = "0x15DC7B0", Offset = "0x15DC7B0", VA = "0x15DC7B0")]
	private void OnTriggerEnter(Collider other)
	{
	}

	[Token(Token = "0x6000AD1")]
	[Address(RVA = "0x15DC88C", Offset = "0x15DC88C", VA = "0x15DC88C")]
	public ParticlesOnTriggerEnter()
	{
	}
}
