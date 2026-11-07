using System.Collections.Generic;
using Core;
using Il2CppDummyDll;
using UnityEngine;
using Utility;

[Token(Token = "0x20008A3")]
public class HitscanShooter2D : GolfBall2DShooterBase
{
	[Token(Token = "0x4002F6D")]
	[FieldOffset(Offset = "0x48")]
	public Transform ShootOrigin;

	[Token(Token = "0x4002F6E")]
	[FieldOffset(Offset = "0x50")]
	public GameObject ProjectilePrefab;

	[Token(Token = "0x4002F6F")]
	[FieldOffset(Offset = "0x58")]
	public Transform Torso;

	[Token(Token = "0x4002F70")]
	[FieldOffset(Offset = "0x60")]
	public List<BottleTarget> bottleTargets;

	[Token(Token = "0x4002F71")]
	[FieldOffset(Offset = "0x68")]
	public bool winOnAllTargetsHit;

	[Token(Token = "0x4002F72")]
	[FieldOffset(Offset = "0x70")]
	private ObjectPool<GameObject> projectiles;

	[Token(Token = "0x60027E8")]
	[Address(RVA = "0x14CE1D4", Offset = "0x14CE1D4", VA = "0x14CE1D4")]
	private void Start()
	{
	}

	[Token(Token = "0x60027E9")]
	[Address(RVA = "0x14CE25C", Offset = "0x14CE25C", VA = "0x14CE25C", Slot = "6")]
	public override void OnAimUpdate(Vector3 boost, bool onlyAimArrow)
	{
	}

	[Token(Token = "0x60027EA")]
	[Address(RVA = "0x14CE310", Offset = "0x14CE310", VA = "0x14CE310", Slot = "5")]
	public override void OnAimStart()
	{
	}

	[Token(Token = "0x60027EB")]
	[Address(RVA = "0x14CE550", Offset = "0x14CE550", VA = "0x14CE550", Slot = "7")]
	public override void OnShoot(Vector3 boost)
	{
	}

	[Token(Token = "0x60027EC")]
	[Address(RVA = "0x14CE698", Offset = "0x14CE698", VA = "0x14CE698")]
	private void OnTargetHit(IHitscanTarget obj)
	{
	}

	[Token(Token = "0x60027ED")]
	[Address(RVA = "0x14CE804", Offset = "0x14CE804", VA = "0x14CE804")]
	public HitscanShooter2D()
	{
	}
}
