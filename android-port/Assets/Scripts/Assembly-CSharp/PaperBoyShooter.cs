using Core;
using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x200012B")]
public class PaperBoyShooter : GolfBallShooterBase
{
	[Token(Token = "0x4000530")]
	[FieldOffset(Offset = "0x60")]
	public GameObject PaperPrefab;

	[Token(Token = "0x4000531")]
	[FieldOffset(Offset = "0x68")]
	public float ForceMultiplier;

	[Token(Token = "0x4000532")]
	[FieldOffset(Offset = "0x70")]
	private Transform BikePlayerTransform;

	[Token(Token = "0x6000521")]
	[Address(RVA = "0x15D8400", Offset = "0x15D8400", VA = "0x15D8400", Slot = "7")]
	public override void OnShoot(Vector3 boost)
	{
	}

	[Token(Token = "0x6000522")]
	[Address(RVA = "0x15D85C8", Offset = "0x15D85C8", VA = "0x15D85C8")]
	public PaperBoyShooter()
	{
	}
}
