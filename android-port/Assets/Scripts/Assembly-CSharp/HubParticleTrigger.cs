using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x2000093")]
public class HubParticleTrigger : MonoBehaviour
{
	[Token(Token = "0x4000236")]
	[FieldOffset(Offset = "0x18")]
	[SerializeField]
	private ParticleSystem _particleSystem;

	[Token(Token = "0x4000237")]
	[FieldOffset(Offset = "0x0")]
	private static bool _hasBeenLoadedBefore;

	[Token(Token = "0x600027B")]
	[Address(RVA = "0x14DE480", Offset = "0x14DE480", VA = "0x14DE480")]
	private void OnTriggerEnter2D(Collider2D other)
	{
	}

	[Token(Token = "0x600027C")]
	[Address(RVA = "0x14DE504", Offset = "0x14DE504", VA = "0x14DE504")]
	public HubParticleTrigger()
	{
	}
}
