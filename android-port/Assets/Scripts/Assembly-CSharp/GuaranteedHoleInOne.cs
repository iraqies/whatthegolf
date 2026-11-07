using Core;
using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x2000759")]
public class GuaranteedHoleInOne : GolfBallShooterBase
{
	[Token(Token = "0x400270A")]
	[FieldOffset(Offset = "0x60")]
	public Transform Target;

	[Token(Token = "0x400270B")]
	[FieldOffset(Offset = "0x68")]
	public float HeightMod;

	[Token(Token = "0x400270C")]
	[FieldOffset(Offset = "0x6C")]
	public float Duration;

	[Token(Token = "0x400270D")]
	[FieldOffset(Offset = "0x70")]
	public int NumberOfJumps;

	[Token(Token = "0x400270E")]
	[FieldOffset(Offset = "0x74")]
	private bool hasShot;

	[Token(Token = "0x400270F")]
	[FieldOffset(Offset = "0x78")]
	private Vector3 startPos;

	[Token(Token = "0x60021EB")]
	[Address(RVA = "0x14BDED0", Offset = "0x14BDED0", VA = "0x14BDED0", Slot = "7")]
	public override void OnShoot(Vector3 boost)
	{
	}

	[Token(Token = "0x60021EC")]
	[Address(RVA = "0x14BDFD4", Offset = "0x14BDFD4", VA = "0x14BDFD4")]
	public GuaranteedHoleInOne()
	{
	}

	[Token(Token = "0x60021ED")]
	[Address(RVA = "0x14BDFF0", Offset = "0x14BDFF0", VA = "0x14BDFF0")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x65CD0", Offset = "0x65CD0")]
	private void _003COnShoot_003Eb__6_0(float t)
	{
	}
}
