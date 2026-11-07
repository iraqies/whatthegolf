using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x2000266")]
public class StopParticlesOnTriggerEnter : MonoBehaviour
{
	[Token(Token = "0x4000C71")]
	[FieldOffset(Offset = "0x18")]
	public ParticleSystem particles;

	[Token(Token = "0x4000C72")]
	[FieldOffset(Offset = "0x20")]
	public bool onlyTriggerOnPlayerTag;

	[Token(Token = "0x6000AD2")]
	[Address(RVA = "0x16E232C", Offset = "0x16E232C", VA = "0x16E232C")]
	private void Start()
	{
	}

	[Token(Token = "0x6000AD3")]
	[Address(RVA = "0x16E23D4", Offset = "0x16E23D4", VA = "0x16E23D4")]
	private void OnTriggerEnter(Collider other)
	{
	}

	[Token(Token = "0x6000AD4")]
	[Address(RVA = "0x16E247C", Offset = "0x16E247C", VA = "0x16E247C")]
	public StopParticlesOnTriggerEnter()
	{
	}
}
