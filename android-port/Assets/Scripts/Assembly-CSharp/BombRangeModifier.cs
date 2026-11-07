using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x20005FC")]
public class BombRangeModifier : MonoBehaviour
{
	[Token(Token = "0x4001EAD")]
	[FieldOffset(Offset = "0x18")]
	public int PinsLeftThreshold;

	[Token(Token = "0x4001EAE")]
	[FieldOffset(Offset = "0x1C")]
	public float RangeIncrease;

	[Token(Token = "0x4001EAF")]
	[FieldOffset(Offset = "0x20")]
	public BowlingShooter Shooter;

	[Token(Token = "0x6001B3A")]
	[Address(RVA = "0x16185FC", Offset = "0x16185FC", VA = "0x16185FC")]
	private void Start()
	{
	}

	[Token(Token = "0x6001B3B")]
	[Address(RVA = "0x16186E0", Offset = "0x16186E0", VA = "0x16186E0")]
	private void BallThrown(GameObject ball)
	{
	}

	[Token(Token = "0x6001B3C")]
	[Address(RVA = "0x1618788", Offset = "0x1618788", VA = "0x1618788")]
	public BombRangeModifier()
	{
	}
}
