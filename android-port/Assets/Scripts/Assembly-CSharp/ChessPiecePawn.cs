using System.Collections;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x20006C5")]
public class ChessPiecePawn : ChessPiece
{
	[Token(Token = "0x400236B")]
	[FieldOffset(Offset = "0x60")]
	private bool hasMoved;

	[Token(Token = "0x6001F38")]
	[Address(RVA = "0x189A7D0", Offset = "0x189A7D0", VA = "0x189A7D0", Slot = "4")]
	public override List<Vector2> GetValidMoves()
	{
		return null;
	}

	[Token(Token = "0x6001F39")]
	[Address(RVA = "0x189AC54", Offset = "0x189AC54", VA = "0x189AC54", Slot = "5")]
	public override IEnumerator DoMove(Vector2 dest)
	{
		return null;
	}

	[Token(Token = "0x6001F3A")]
	[Address(RVA = "0x189ACE0", Offset = "0x189ACE0", VA = "0x189ACE0")]
	public ChessPiecePawn()
	{
	}
}
