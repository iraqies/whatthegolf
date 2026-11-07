using Core;
using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x2000C50")]
public class StopVelocityOnAimStart : MonoBehaviour
{
	[Token(Token = "0x400439B")]
	[FieldOffset(Offset = "0x18")]
	public GolfBallController Controller;

	[Token(Token = "0x400439C")]
	[FieldOffset(Offset = "0x20")]
	private Rigidbody rigid;

	[Token(Token = "0x6003A91")]
	[Address(RVA = "0x16E2758", Offset = "0x16E2758", VA = "0x16E2758")]
	private void Start()
	{
	}

	[Token(Token = "0x6003A92")]
	[Address(RVA = "0x16E2818", Offset = "0x16E2818", VA = "0x16E2818")]
	private void OnAimStart()
	{
	}

	[Token(Token = "0x6003A93")]
	[Address(RVA = "0x16E28C0", Offset = "0x16E28C0", VA = "0x16E28C0")]
	public StopVelocityOnAimStart()
	{
	}
}
