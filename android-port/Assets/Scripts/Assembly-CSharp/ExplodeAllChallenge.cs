using System.Collections.Generic;
using Core;
using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x2000406")]
public class ExplodeAllChallenge : Challenge
{
	[Token(Token = "0x40015F5")]
	[FieldOffset(Offset = "0xA8")]
	public List<ExplosionBarrel> explosionBarrels;

	[Token(Token = "0x40015F6")]
	[FieldOffset(Offset = "0xB0")]
	public List<ExplosionBarrel2D> explosionBarrel2Ds;

	[Token(Token = "0x40015F7")]
	[FieldOffset(Offset = "0xB8")]
	private int maxCount;

	[Token(Token = "0x40015F8")]
	[FieldOffset(Offset = "0xBC")]
	private int explodedCount;

	[Token(Token = "0x40015F9")]
	[FieldOffset(Offset = "0xC0")]
	private GolfBallController controller;

	[Token(Token = "0x60012EA")]
	[Address(RVA = "0x144F194", Offset = "0x144F194", VA = "0x144F194", Slot = "8")]
	protected override void Activate()
	{
	}

	[Token(Token = "0x60012EB")]
	[Address(RVA = "0x144F6FC", Offset = "0x144F6FC", VA = "0x144F6FC")]
	private void B_OnExplode(Collider2D obj)
	{
	}

	[Token(Token = "0x60012EC")]
	[Address(RVA = "0x144F7A4", Offset = "0x144F7A4", VA = "0x144F7A4")]
	private void OnExplode3D(Collider arg1, ExplosionBarrel arg2)
	{
	}

	[Token(Token = "0x60012ED")]
	[Address(RVA = "0x144F700", Offset = "0x144F700", VA = "0x144F700")]
	private void CheckCompletion()
	{
	}

	[Token(Token = "0x60012EE")]
	[Address(RVA = "0x144F7A8", Offset = "0x144F7A8", VA = "0x144F7A8")]
	public ExplodeAllChallenge()
	{
	}
}
