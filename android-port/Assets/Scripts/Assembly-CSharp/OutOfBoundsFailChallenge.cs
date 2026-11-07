using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x2000458")]
public class OutOfBoundsFailChallenge : MonoBehaviour
{
	[Token(Token = "0x40017AA")]
	[FieldOffset(Offset = "0x18")]
	public Challenge ChallengeToFail;

	[Token(Token = "0x600145D")]
	[Address(RVA = "0x159E984", Offset = "0x159E984", VA = "0x159E984")]
	private void OnTriggerEnter(Collider other)
	{
	}

	[Token(Token = "0x600145E")]
	[Address(RVA = "0x159EA5C", Offset = "0x159EA5C", VA = "0x159EA5C")]
	public OutOfBoundsFailChallenge()
	{
	}
}
