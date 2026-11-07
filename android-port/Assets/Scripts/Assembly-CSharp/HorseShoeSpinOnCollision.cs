using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x2000225")]
public class HorseShoeSpinOnCollision : MonoBehaviour
{
	[Token(Token = "0x4000AC0")]
	[FieldOffset(Offset = "0x18")]
	public LayerMask HitLayers;

	[Token(Token = "0x4000AC1")]
	[FieldOffset(Offset = "0x20")]
	private Rigidbody rigid;

	[Token(Token = "0x4000AC2")]
	[FieldOffset(Offset = "0x28")]
	private bool hasHit;

	[Token(Token = "0x4000AC3")]
	[FieldOffset(Offset = "0x30")]
	private Collider[] colliders;

	[Token(Token = "0x6000993")]
	[Address(RVA = "0x14D8628", Offset = "0x14D8628", VA = "0x14D8628")]
	private void Awake()
	{
	}

	[Token(Token = "0x6000994")]
	[Address(RVA = "0x14D86A8", Offset = "0x14D86A8", VA = "0x14D86A8")]
	private void OnCollisionEnter(Collision other)
	{
	}

	[Token(Token = "0x6000995")]
	[Address(RVA = "0x14D88FC", Offset = "0x14D88FC", VA = "0x14D88FC")]
	public HorseShoeSpinOnCollision()
	{
	}
}
