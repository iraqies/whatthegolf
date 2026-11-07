using System;
using Core;
using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x20007A7")]
public class BadBallChecker : MonoBehaviour
{
	[Token(Token = "0x4002877")]
	[FieldOffset(Offset = "0x18")]
	public GolfBallController hitBall;

	[Token(Token = "0x4002878")]
	[FieldOffset(Offset = "0x20")]
	public Action<GolfBallController> OnHitFlag;

	[Token(Token = "0x6002313")]
	[Address(RVA = "0x1516A7C", Offset = "0x1516A7C", VA = "0x1516A7C")]
	private void OnCollisionEnter(Collision collision)
	{
	}

	[Token(Token = "0x6002314")]
	[Address(RVA = "0x1516B64", Offset = "0x1516B64", VA = "0x1516B64")]
	private void OnCollisionEnter2D(Collision2D collision)
	{
	}

	[Token(Token = "0x6002315")]
	[Address(RVA = "0x1516C4C", Offset = "0x1516C4C", VA = "0x1516C4C")]
	public BadBallChecker()
	{
	}
}
