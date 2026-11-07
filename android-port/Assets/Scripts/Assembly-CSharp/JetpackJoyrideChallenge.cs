using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x20007A2")]
public class JetpackJoyrideChallenge : MonoBehaviour
{
	[Token(Token = "0x4002857")]
	[FieldOffset(Offset = "0x18")]
	public Rigidbody2D EndChecker;

	[Token(Token = "0x4002858")]
	[FieldOffset(Offset = "0x20")]
	public float Length;

	[Token(Token = "0x4002859")]
	[FieldOffset(Offset = "0x24")]
	public int Countdown;

	[Token(Token = "0x400285A")]
	[FieldOffset(Offset = "0x28")]
	private List<Vector3> startPositions;

	[Token(Token = "0x400285B")]
	[FieldOffset(Offset = "0x30")]
	private List<Rigidbody2D> objectsToMove;

	[Token(Token = "0x6002301")]
	[Address(RVA = "0x14F6A28", Offset = "0x14F6A28", VA = "0x14F6A28")]
	public void Spawn(Vector3 position)
	{
	}

	[Token(Token = "0x6002302")]
	[Address(RVA = "0x14F6D6C", Offset = "0x14F6D6C", VA = "0x14F6D6C")]
	public void Move(float speed, Vector2 endPosition, Action endReached)
	{
	}

	[Token(Token = "0x6002303")]
	[Address(RVA = "0x14F6F68", Offset = "0x14F6F68", VA = "0x14F6F68")]
	public JetpackJoyrideChallenge()
	{
	}
}
