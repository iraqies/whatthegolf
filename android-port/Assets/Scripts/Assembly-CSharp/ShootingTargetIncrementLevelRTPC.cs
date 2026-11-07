using Core;
using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x20003C6")]
public class ShootingTargetIncrementLevelRTPC : MonoBehaviour
{
	[Token(Token = "0x40014BB")]
	[FieldOffset(Offset = "0x18")]
	public ShootingGalleryTarget[] targets;

	[Token(Token = "0x40014BC")]
	[FieldOffset(Offset = "0x20")]
	public LevelData levelData;

	[Token(Token = "0x40014BD")]
	[FieldOffset(Offset = "0x28")]
	private float startValue;

	[Token(Token = "0x40014BE")]
	[FieldOffset(Offset = "0x2C")]
	private float incrementValue;

	[Token(Token = "0x40014BF")]
	[FieldOffset(Offset = "0x30")]
	private int hits;

	[Token(Token = "0x60011D4")]
	[Address(RVA = "0x16A3A74", Offset = "0x16A3A74", VA = "0x16A3A74")]
	private void Start()
	{
	}

	[Token(Token = "0x60011D5")]
	[Address(RVA = "0x16A3BD0", Offset = "0x16A3BD0", VA = "0x16A3BD0")]
	private void OnAnyHit(Vector3 hit)
	{
	}

	[Token(Token = "0x60011D6")]
	[Address(RVA = "0x16A3C2C", Offset = "0x16A3C2C", VA = "0x16A3C2C")]
	public ShootingTargetIncrementLevelRTPC()
	{
	}
}
