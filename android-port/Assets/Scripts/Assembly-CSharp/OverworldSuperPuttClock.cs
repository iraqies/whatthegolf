using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x2000B1B")]
public class OverworldSuperPuttClock : MonoBehaviour
{
	[Token(Token = "0x4003E17")]
	[FieldOffset(Offset = "0x18")]
	public Rigidbody2D large;

	[Token(Token = "0x4003E18")]
	[FieldOffset(Offset = "0x20")]
	public Rigidbody2D minor;

	[Token(Token = "0x4003E19")]
	[FieldOffset(Offset = "0x28")]
	public float largeSpeed;

	[Token(Token = "0x4003E1A")]
	[FieldOffset(Offset = "0x2C")]
	public float minorSpeed;

	[Token(Token = "0x4003E1B")]
	[FieldOffset(Offset = "0x30")]
	private Rigidbody2D ball;

	[Token(Token = "0x4003E1C")]
	[FieldOffset(Offset = "0x38")]
	private Vector2 lastBallPos;

	[Token(Token = "0x4003E1D")]
	[FieldOffset(Offset = "0x40")]
	private float totalBallMovement;

	[Token(Token = "0x6003502")]
	[Address(RVA = "0x15CC89C", Offset = "0x15CC89C", VA = "0x15CC89C")]
	private void Start()
	{
	}

	[Token(Token = "0x6003503")]
	[Address(RVA = "0x15CC98C", Offset = "0x15CC98C", VA = "0x15CC98C")]
	private void Instance_OnNewBall(Transmogrif.BALLSHAPES newShape)
	{
	}

	[Token(Token = "0x6003504")]
	[Address(RVA = "0x15CC9F4", Offset = "0x15CC9F4", VA = "0x15CC9F4")]
	private void FixedUpdate()
	{
	}

	[Token(Token = "0x6003505")]
	[Address(RVA = "0x15CCB74", Offset = "0x15CCB74", VA = "0x15CCB74")]
	public OverworldSuperPuttClock()
	{
	}
}
