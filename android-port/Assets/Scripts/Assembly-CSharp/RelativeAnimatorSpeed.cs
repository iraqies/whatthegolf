using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x2000A70")]
public class RelativeAnimatorSpeed : MonoBehaviour
{
	[Token(Token = "0x40039C9")]
	[FieldOffset(Offset = "0x18")]
	public float Speed;

	[Token(Token = "0x40039CA")]
	[FieldOffset(Offset = "0x20")]
	private Animator animator;

	[Token(Token = "0x40039CB")]
	[FieldOffset(Offset = "0x28")]
	private Rigidbody2D ball;

	[Token(Token = "0x60031CA")]
	[Address(RVA = "0x16487B0", Offset = "0x16487B0", VA = "0x16487B0")]
	private void Start()
	{
	}

	[Token(Token = "0x60031CB")]
	[Address(RVA = "0x16488C4", Offset = "0x16488C4", VA = "0x16488C4")]
	private void Instance_OnNewBall(Transmogrif.BALLSHAPES newShape)
	{
	}

	[Token(Token = "0x60031CC")]
	[Address(RVA = "0x164892C", Offset = "0x164892C", VA = "0x164892C")]
	private void Update()
	{
	}

	[Token(Token = "0x60031CD")]
	[Address(RVA = "0x1648994", Offset = "0x1648994", VA = "0x1648994")]
	public RelativeAnimatorSpeed()
	{
	}
}
