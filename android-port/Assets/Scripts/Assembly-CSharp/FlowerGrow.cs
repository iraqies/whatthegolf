using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x20007AB")]
public class FlowerGrow : MonoBehaviour
{
	[Token(Token = "0x4002880")]
	[FieldOffset(Offset = "0x18")]
	public Transform flower;

	[Token(Token = "0x4002881")]
	[FieldOffset(Offset = "0x20")]
	public int growthStep;

	[Token(Token = "0x4002882")]
	[FieldOffset(Offset = "0x28")]
	private GrowFlowerChallenge growFlowerChallenge;

	[Token(Token = "0x6002322")]
	[Address(RVA = "0x146CF70", Offset = "0x146CF70", VA = "0x146CF70")]
	private void Start()
	{
	}

	[Token(Token = "0x6002323")]
	[Address(RVA = "0x146CFF4", Offset = "0x146CFF4", VA = "0x146CFF4")]
	private void OnCollisionEnter2D(Collision2D collision)
	{
	}

	[Token(Token = "0x6002324")]
	[Address(RVA = "0x146D070", Offset = "0x146D070", VA = "0x146D070")]
	public FlowerGrow()
	{
	}
}
