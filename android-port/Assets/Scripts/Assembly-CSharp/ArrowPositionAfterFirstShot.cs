using Core;
using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x2000E6C")]
public class ArrowPositionAfterFirstShot : MonoBehaviour
{
	[Token(Token = "0x4004E0F")]
	[FieldOffset(Offset = "0x18")]
	[SerializeField]
	private Transform position;

	[Token(Token = "0x4004E10")]
	[FieldOffset(Offset = "0x20")]
	[SerializeField]
	private GolfBallController controller;

	[Token(Token = "0x600436E")]
	[Address(RVA = "0x1428618", Offset = "0x1428618", VA = "0x1428618")]
	private void Start()
	{
	}

	[Token(Token = "0x600436F")]
	[Address(RVA = "0x1428780", Offset = "0x1428780", VA = "0x1428780")]
	private void ChangeArrowPosition(Vector3 v)
	{
	}

	[Token(Token = "0x6004370")]
	[Address(RVA = "0x1428844", Offset = "0x1428844", VA = "0x1428844")]
	public ArrowPositionAfterFirstShot()
	{
	}
}
