using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x2000E0F")]
public class ClampBananaVelocity : MonoBehaviour
{
	[Token(Token = "0x4004C6D")]
	[FieldOffset(Offset = "0x18")]
	public float MaxSpeed;

	[Token(Token = "0x4004C6E")]
	[FieldOffset(Offset = "0x20")]
	private Rigidbody rigid;

	[Token(Token = "0x4004C6F")]
	[FieldOffset(Offset = "0x28")]
	private float sqrMaxSpeed;

	[Token(Token = "0x6004217")]
	[Address(RVA = "0x189F47C", Offset = "0x189F47C", VA = "0x189F47C")]
	private void Awake()
	{
	}

	[Token(Token = "0x6004218")]
	[Address(RVA = "0x189F4E4", Offset = "0x189F4E4", VA = "0x189F4E4")]
	private void FixedUpdate()
	{
	}

	[Token(Token = "0x6004219")]
	[Address(RVA = "0x189F5D0", Offset = "0x189F5D0", VA = "0x189F5D0")]
	public ClampBananaVelocity()
	{
	}
}
