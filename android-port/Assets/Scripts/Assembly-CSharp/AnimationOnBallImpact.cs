using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x2000285")]
public class AnimationOnBallImpact : MonoBehaviour
{
	[Token(Token = "0x4000D47")]
	[FieldOffset(Offset = "0x18")]
	public Animator animator;

	[Token(Token = "0x4000D48")]
	[FieldOffset(Offset = "0x20")]
	public string triggerString;

	[Token(Token = "0x6000B74")]
	[Address(RVA = "0x14182AC", Offset = "0x14182AC", VA = "0x14182AC")]
	private void OnCollisionEnter2D(Collision2D collision)
	{
	}

	[Token(Token = "0x6000B75")]
	[Address(RVA = "0x14182D0", Offset = "0x14182D0", VA = "0x14182D0")]
	public AnimationOnBallImpact()
	{
	}
}
