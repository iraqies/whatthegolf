using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x2000AFB")]
public class ClampVelocity2D : MonoBehaviour
{
	[Token(Token = "0x4003D1D")]
	[FieldOffset(Offset = "0x18")]
	public float MaxSpeed;

	[Token(Token = "0x4003D1E")]
	[FieldOffset(Offset = "0x1C")]
	public bool HardClamp;

	[Token(Token = "0x4003D1F")]
	[FieldOffset(Offset = "0x20")]
	private Rigidbody2D rigid;

	[Token(Token = "0x4003D20")]
	[FieldOffset(Offset = "0x28")]
	private float sqrMaxSpeed;

	[Token(Token = "0x6003455")]
	[Address(RVA = "0x189F6F0", Offset = "0x189F6F0", VA = "0x189F6F0")]
	private void Awake()
	{
	}

	[Token(Token = "0x6003456")]
	[Address(RVA = "0x189F758", Offset = "0x189F758", VA = "0x189F758")]
	private void FixedUpdate()
	{
	}

	[Token(Token = "0x6003457")]
	[Address(RVA = "0x189F814", Offset = "0x189F814", VA = "0x189F814")]
	public ClampVelocity2D()
	{
	}
}
