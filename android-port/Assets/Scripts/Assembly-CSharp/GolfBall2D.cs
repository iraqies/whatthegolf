using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x20007E9")]
public class GolfBall2D : MonoBehaviour
{
	[Token(Token = "0x4002A65")]
	[FieldOffset(Offset = "0x18")]
	private GolfBall2DSurface surface;

	[Token(Token = "0x4002A66")]
	[FieldOffset(Offset = "0x20")]
	private List<GolfBall2DSurface> surfaces;

	[Token(Token = "0x4002A67")]
	[FieldOffset(Offset = "0x28")]
	private Rigidbody2D rigidbody2D;

	[Token(Token = "0x4002A68")]
	[FieldOffset(Offset = "0x30")]
	private float radius;

	[Token(Token = "0x4002A69")]
	[FieldOffset(Offset = "0x34")]
	private float alignedWithGroundAngleMax;

	[Token(Token = "0x4002A6A")]
	[FieldOffset(Offset = "0x38")]
	private float angularVelocityFrictionLimit;

	[Token(Token = "0x4002A6B")]
	[FieldOffset(Offset = "0x3C")]
	private float sleepTolerance;

	[Token(Token = "0x6002458")]
	[Address(RVA = "0x1490104", Offset = "0x1490104", VA = "0x1490104")]
	private void Awake()
	{
	}

	[Token(Token = "0x6002459")]
	[Address(RVA = "0x1490180", Offset = "0x1490180", VA = "0x1490180")]
	private void FixedUpdate()
	{
	}

	[Token(Token = "0x600245A")]
	[Address(RVA = "0x149050C", Offset = "0x149050C", VA = "0x149050C")]
	private void RefeshActiveSurface()
	{
	}

	[Token(Token = "0x600245B")]
	[Address(RVA = "0x149057C", Offset = "0x149057C", VA = "0x149057C")]
	private void OnTriggerEnter2D(Collider2D collision)
	{
	}

	[Token(Token = "0x600245C")]
	[Address(RVA = "0x14906C4", Offset = "0x14906C4", VA = "0x14906C4")]
	private void OnTriggerExit2D(Collider2D collision)
	{
	}

	[Token(Token = "0x600245D")]
	[Address(RVA = "0x149080C", Offset = "0x149080C", VA = "0x149080C")]
	public GolfBall2D()
	{
	}
}
