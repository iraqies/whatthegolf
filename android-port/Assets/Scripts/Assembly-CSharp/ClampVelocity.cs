using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x2000AFA")]
public class ClampVelocity : MonoBehaviour
{
	[Token(Token = "0x4003D1A")]
	[FieldOffset(Offset = "0x18")]
	public float MaxSpeed;

	[Token(Token = "0x4003D1B")]
	[FieldOffset(Offset = "0x20")]
	private Rigidbody rigid;

	[Token(Token = "0x4003D1C")]
	[FieldOffset(Offset = "0x28")]
	private float sqrMaxSpeed;

	[Token(Token = "0x6003452")]
	[Address(RVA = "0x189F5E0", Offset = "0x189F5E0", VA = "0x189F5E0")]
	private void Awake()
	{
	}

	[Token(Token = "0x6003453")]
	[Address(RVA = "0x189F648", Offset = "0x189F648", VA = "0x189F648")]
	private void FixedUpdate()
	{
	}

	[Token(Token = "0x6003454")]
	[Address(RVA = "0x189F6E0", Offset = "0x189F6E0", VA = "0x189F6E0")]
	public ClampVelocity()
	{
	}
}
