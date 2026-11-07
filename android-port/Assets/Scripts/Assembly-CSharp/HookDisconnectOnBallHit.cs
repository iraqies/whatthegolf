using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x2000757")]
public class HookDisconnectOnBallHit : MonoBehaviour
{
	[Token(Token = "0x40026FA")]
	[FieldOffset(Offset = "0x18")]
	public LayerMask layermask;

	[Token(Token = "0x40026FB")]
	[FieldOffset(Offset = "0x20")]
	public string[] tags;

	[Token(Token = "0x40026FC")]
	[FieldOffset(Offset = "0x28")]
	private GrapplingHookShooter2D shooter;

	[Token(Token = "0x60021E4")]
	[Address(RVA = "0x14D4778", Offset = "0x14D4778", VA = "0x14D4778")]
	private void Awake()
	{
	}

	[Token(Token = "0x60021E5")]
	[Address(RVA = "0x14D47D4", Offset = "0x14D47D4", VA = "0x14D47D4")]
	private void OnCollisionEnter2D(Collision2D obj)
	{
	}

	[Token(Token = "0x60021E6")]
	[Address(RVA = "0x14D48E0", Offset = "0x14D48E0", VA = "0x14D48E0")]
	public HookDisconnectOnBallHit()
	{
	}
}
