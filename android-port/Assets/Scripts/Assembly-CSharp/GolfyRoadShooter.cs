using Core;
using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x2000749")]
public class GolfyRoadShooter : RunnerGolfShooter
{
	[Token(Token = "0x4002682")]
	[FieldOffset(Offset = "0xC5")]
	private bool moveForward;

	[Token(Token = "0x4002683")]
	[FieldOffset(Offset = "0xC8")]
	private Vector3 startMovePos;

	[Token(Token = "0x4002684")]
	[FieldOffset(Offset = "0xD8")]
	private GolfBallController controller;

	[Token(Token = "0x600218E")]
	[Address(RVA = "0x14A6710", Offset = "0x14A6710", VA = "0x14A6710", Slot = "11")]
	protected override void Awake()
	{
	}

	[Token(Token = "0x600218F")]
	[Address(RVA = "0x14A6778", Offset = "0x14A6778", VA = "0x14A6778", Slot = "15")]
	protected override void Jump()
	{
	}

	[Token(Token = "0x6002190")]
	[Address(RVA = "0x14A67C8", Offset = "0x14A67C8", VA = "0x14A67C8")]
	protected new void FixedUpdate()
	{
	}

	[Token(Token = "0x6002191")]
	[Address(RVA = "0x14A68B8", Offset = "0x14A68B8", VA = "0x14A68B8")]
	private void OnCollisionEnter(Collision other)
	{
	}

	[Token(Token = "0x6002192")]
	[Address(RVA = "0x14A6970", Offset = "0x14A6970", VA = "0x14A6970")]
	public GolfyRoadShooter()
	{
	}
}
