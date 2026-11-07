using Core;
using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x2000BBC")]
public class BlockIfNotNearStuff : MonoBehaviour
{
	[Token(Token = "0x400415A")]
	[FieldOffset(Offset = "0x18")]
	[SerializeField]
	private LayerMask groundMask;

	[Token(Token = "0x400415B")]
	[FieldOffset(Offset = "0x1C")]
	[SerializeField]
	private float CheckRadius;

	[Token(Token = "0x400415C")]
	[FieldOffset(Offset = "0x20")]
	[SerializeField]
	private bool is2D;

	[Token(Token = "0x400415D")]
	[FieldOffset(Offset = "0x21")]
	[SerializeField]
	public bool isBlocked;

	[Token(Token = "0x400415E")]
	[FieldOffset(Offset = "0x28")]
	private GolfBallController controller;

	[Token(Token = "0x600388B")]
	[Address(RVA = "0x1612DD0", Offset = "0x1612DD0", VA = "0x1612DD0")]
	private void Awake()
	{
	}

	[Token(Token = "0x600388C")]
	[Address(RVA = "0x1612E2C", Offset = "0x1612E2C", VA = "0x1612E2C")]
	private void FixedUpdate()
	{
	}

	[Token(Token = "0x600388D")]
	[Address(RVA = "0x1612FC0", Offset = "0x1612FC0", VA = "0x1612FC0")]
	public BlockIfNotNearStuff()
	{
	}
}
