using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x2000F0B")]
public class DPIDieShootRandom : BaseDailyPrizeInteractions
{
	[Token(Token = "0x4005129")]
	[FieldOffset(Offset = "0x28")]
	public Rigidbody dieRb;

	[Token(Token = "0x400512A")]
	[FieldOffset(Offset = "0x30")]
	public float forceMultiplier;

	[Token(Token = "0x400512B")]
	[FieldOffset(Offset = "0x34")]
	private Vector3 randomVector;

	[Token(Token = "0x6004655")]
	[Address(RVA = "0x18C7E50", Offset = "0x18C7E50", VA = "0x18C7E50", Slot = "8")]
	public override void OnShootNotWrapped(Vector3 b)
	{
	}

	[Token(Token = "0x6004656")]
	[Address(RVA = "0x18C7FC8", Offset = "0x18C7FC8", VA = "0x18C7FC8")]
	public DPIDieShootRandom()
	{
	}
}
