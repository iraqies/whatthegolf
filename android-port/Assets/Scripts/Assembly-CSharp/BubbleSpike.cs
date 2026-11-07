using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x20005DC")]
public class BubbleSpike : MonoBehaviour
{
	[Token(Token = "0x4001DD5")]
	[FieldOffset(Offset = "0x18")]
	[SerializeField]
	private Transform burstPointTransform;

	[Token(Token = "0x4001DD6")]
	[FieldOffset(Offset = "0x20")]
	[SerializeField]
	private float burstPointCheckRadius;

	[Token(Token = "0x4001DD7")]
	[FieldOffset(Offset = "0x24")]
	[SerializeField]
	private float burstPointAngle;

	[Token(Token = "0x4001DD8")]
	[FieldOffset(Offset = "0x28")]
	[SerializeField]
	private bool failOnBurst;

	[Token(Token = "0x6001AB7")]
	[Address(RVA = "0x170A8DC", Offset = "0x170A8DC", VA = "0x170A8DC")]
	private void OnCollisionEnter2D(Collision2D collision)
	{
	}

	[Token(Token = "0x6001AB8")]
	[Address(RVA = "0x170AB8C", Offset = "0x170AB8C", VA = "0x170AB8C")]
	public BubbleSpike()
	{
	}
}
