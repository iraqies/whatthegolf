using System.Collections.Generic;
using Core;
using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x2000CD9")]
public class SpawnHoleOnShot : MonoBehaviour
{
	[Token(Token = "0x40045E4")]
	[FieldOffset(Offset = "0x18")]
	public List<GameObject> sequence;

	[Token(Token = "0x40045E5")]
	[FieldOffset(Offset = "0x20")]
	public GolfBallController ball;

	[Token(Token = "0x40045E6")]
	[FieldOffset(Offset = "0x28")]
	private int currentIndex;

	[Token(Token = "0x6003CD4")]
	[Address(RVA = "0x16C73DC", Offset = "0x16C73DC", VA = "0x16C73DC")]
	private void Start()
	{
	}

	[Token(Token = "0x6003CD5")]
	[Address(RVA = "0x16C748C", Offset = "0x16C748C", VA = "0x16C748C")]
	private void Ball_OnShoot(Vector3 aim)
	{
	}

	[Token(Token = "0x6003CD6")]
	[Address(RVA = "0x16C755C", Offset = "0x16C755C", VA = "0x16C755C")]
	public SpawnHoleOnShot()
	{
	}
}
