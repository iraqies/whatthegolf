using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x20008A7")]
public class HorseshoeSpinOnGoalCollision : MonoBehaviour
{
	[Token(Token = "0x4002F87")]
	[FieldOffset(Offset = "0x18")]
	private Rigidbody rigid;

	[Token(Token = "0x4002F88")]
	[FieldOffset(Offset = "0x20")]
	private bool hasHit;

	[Token(Token = "0x4002F89")]
	[FieldOffset(Offset = "0x28")]
	private Collider[] colliders;

	[Token(Token = "0x60027FC")]
	[Address(RVA = "0x14D980C", Offset = "0x14D980C", VA = "0x14D980C")]
	private void Awake()
	{
	}

	[Token(Token = "0x60027FD")]
	[Address(RVA = "0x14D988C", Offset = "0x14D988C", VA = "0x14D988C")]
	private void OnCollisionEnter(Collision other)
	{
	}

	[Token(Token = "0x60027FE")]
	[Address(RVA = "0x14D9B00", Offset = "0x14D9B00", VA = "0x14D9B00")]
	public HorseshoeSpinOnGoalCollision()
	{
	}
}
