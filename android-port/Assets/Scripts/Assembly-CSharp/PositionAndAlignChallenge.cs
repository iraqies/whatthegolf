using CameraStack;
using Core;
using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x2000418")]
public class PositionAndAlignChallenge : Challenge
{
	[Token(Token = "0x4001666")]
	[FieldOffset(Offset = "0xA8")]
	public GameObject[] deactivatedObjects;

	[Token(Token = "0x4001667")]
	[FieldOffset(Offset = "0xB0")]
	private GolfBallController _golfBallController;

	[Token(Token = "0x4001668")]
	[FieldOffset(Offset = "0xB8")]
	private CBFollow _cbFollow;

	[Token(Token = "0x4001669")]
	[FieldOffset(Offset = "0xC0")]
	public Transform positionTarget;

	[Token(Token = "0x400166A")]
	[FieldOffset(Offset = "0xC8")]
	public float minimumDistance;

	[Token(Token = "0x400166B")]
	[FieldOffset(Offset = "0xCC")]
	public float minimumUpAngle;

	[Token(Token = "0x400166C")]
	[FieldOffset(Offset = "0xD0")]
	public float minimumForwardAngle;

	[Token(Token = "0x6001346")]
	[Address(RVA = "0x161D7A4", Offset = "0x161D7A4", VA = "0x161D7A4", Slot = "8")]
	protected override void Activate()
	{
	}

	[Token(Token = "0x6001347")]
	[Address(RVA = "0x161D900", Offset = "0x161D900", VA = "0x161D900", Slot = "9")]
	protected override void ChallengeUpdate()
	{
	}

	[Token(Token = "0x6001348")]
	[Address(RVA = "0x161DAD0", Offset = "0x161DAD0", VA = "0x161DAD0")]
	public PositionAndAlignChallenge()
	{
	}
}
