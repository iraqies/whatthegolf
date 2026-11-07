using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x2000AE2")]
public class GroundedDrag2D : MonoBehaviour
{
	[Token(Token = "0x4003CB3")]
	[FieldOffset(Offset = "0x18")]
	public float GroundedDrag;

	[Token(Token = "0x4003CB4")]
	[FieldOffset(Offset = "0x1C")]
	public float InAirDrag;

	[Token(Token = "0x4003CB5")]
	[FieldOffset(Offset = "0x20")]
	public LayerMask GroundLayers;

	[Token(Token = "0x4003CB6")]
	[FieldOffset(Offset = "0x28")]
	private Rigidbody2D rigid;

	[Token(Token = "0x60033F8")]
	[Address(RVA = "0x14BD994", Offset = "0x14BD994", VA = "0x14BD994")]
	private void Awake()
	{
	}

	[Token(Token = "0x60033F9")]
	[Address(RVA = "0x14BD9F0", Offset = "0x14BD9F0", VA = "0x14BD9F0")]
	private void OnCollisionStay2D(Collision2D col)
	{
	}

	[Token(Token = "0x60033FA")]
	[Address(RVA = "0x14BDA8C", Offset = "0x14BDA8C", VA = "0x14BDA8C")]
	private void OnCollisionExit2D(Collision2D col)
	{
	}

	[Token(Token = "0x60033FB")]
	[Address(RVA = "0x14BDB28", Offset = "0x14BDB28", VA = "0x14BDB28")]
	public GroundedDrag2D()
	{
	}
}
