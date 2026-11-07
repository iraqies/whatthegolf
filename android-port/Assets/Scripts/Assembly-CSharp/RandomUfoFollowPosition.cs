using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x200088D")]
public class RandomUfoFollowPosition : MonoBehaviour
{
	[Token(Token = "0x4002EF2")]
	[FieldOffset(Offset = "0x18")]
	public Transform Ufo;

	[Token(Token = "0x4002EF3")]
	[FieldOffset(Offset = "0x20")]
	public float PositionRadius;

	[Token(Token = "0x4002EF4")]
	[FieldOffset(Offset = "0x24")]
	private Vector3 startPos;

	[Token(Token = "0x600277D")]
	[Address(RVA = "0x164003C", Offset = "0x164003C", VA = "0x164003C")]
	private void Start()
	{
	}

	[Token(Token = "0x600277E")]
	[Address(RVA = "0x1640138", Offset = "0x1640138", VA = "0x1640138")]
	private void Update()
	{
	}

	[Token(Token = "0x600277F")]
	[Address(RVA = "0x16400C8", Offset = "0x16400C8", VA = "0x16400C8")]
	private void SetNewPosition()
	{
	}

	[Token(Token = "0x6002780")]
	[Address(RVA = "0x1640220", Offset = "0x1640220", VA = "0x1640220")]
	private void OnDrawGizmosSelected()
	{
	}

	[Token(Token = "0x6002781")]
	[Address(RVA = "0x164025C", Offset = "0x164025C", VA = "0x164025C")]
	public RandomUfoFollowPosition()
	{
	}
}
