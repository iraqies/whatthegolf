using Core;
using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x20007AF")]
public class MoveToPointOnAim : MonoBehaviour
{
	[Token(Token = "0x400288A")]
	[FieldOffset(Offset = "0x18")]
	public GolfBallController controller;

	[Token(Token = "0x400288B")]
	[FieldOffset(Offset = "0x20")]
	public Transform target;

	[Token(Token = "0x400288C")]
	[FieldOffset(Offset = "0x28")]
	public float speed;

	[Token(Token = "0x400288D")]
	[FieldOffset(Offset = "0x2C")]
	private Vector3 startPos;

	[Token(Token = "0x6002331")]
	[Address(RVA = "0x15744F0", Offset = "0x15744F0", VA = "0x15744F0")]
	private void Start()
	{
	}

	[Token(Token = "0x6002332")]
	[Address(RVA = "0x157452C", Offset = "0x157452C", VA = "0x157452C")]
	private void Update()
	{
	}

	[Token(Token = "0x6002333")]
	[Address(RVA = "0x157467C", Offset = "0x157467C", VA = "0x157467C")]
	public MoveToPointOnAim()
	{
	}
}
