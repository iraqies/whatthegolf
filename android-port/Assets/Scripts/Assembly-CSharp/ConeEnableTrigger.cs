using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x2000D68")]
public class ConeEnableTrigger : MonoBehaviour
{
	[Token(Token = "0x40048FF")]
	[FieldOffset(Offset = "0x18")]
	public bool isActivating;

	[Token(Token = "0x4004900")]
	[FieldOffset(Offset = "0x20")]
	private ConeRotateWithOverworldBall cone;

	[Token(Token = "0x6003F1A")]
	[Address(RVA = "0x18AAD84", Offset = "0x18AAD84", VA = "0x18AAD84")]
	private void OnTriggerEnter2D(Collider2D collision)
	{
	}

	[Token(Token = "0x6003F1B")]
	[Address(RVA = "0x18AAE84", Offset = "0x18AAE84", VA = "0x18AAE84")]
	public ConeEnableTrigger()
	{
	}
}
