using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x2000B07")]
public class ExtraForceOnHitBall : MonoBehaviour
{
	[Token(Token = "0x4003D97")]
	[FieldOffset(Offset = "0x18")]
	[SerializeField]
	private float force;

	[Token(Token = "0x4003D98")]
	[FieldOffset(Offset = "0x20")]
	private Rigidbody rigid;

	[Token(Token = "0x60034A4")]
	[Address(RVA = "0x1454F04", Offset = "0x1454F04", VA = "0x1454F04")]
	private void Start()
	{
	}

	[Token(Token = "0x60034A5")]
	[Address(RVA = "0x1454F60", Offset = "0x1454F60", VA = "0x1454F60")]
	private void OnCollisionEnter(Collision col)
	{
	}

	[Token(Token = "0x60034A6")]
	[Address(RVA = "0x1455184", Offset = "0x1455184", VA = "0x1455184")]
	public ExtraForceOnHitBall()
	{
	}
}
