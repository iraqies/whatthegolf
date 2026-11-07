using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x20002F5")]
public class DonutCountyMovement : MonoBehaviour
{
	[Token(Token = "0x4001057")]
	[FieldOffset(Offset = "0x18")]
	public Transform transformToFollow;

	[Token(Token = "0x4001058")]
	[FieldOffset(Offset = "0x20")]
	public float speed;

	[Token(Token = "0x4001059")]
	[FieldOffset(Offset = "0x28")]
	public Rigidbody rb;

	[Token(Token = "0x400105A")]
	[FieldOffset(Offset = "0x30")]
	private Vector3 smoothPos;

	[Token(Token = "0x6000DA7")]
	[Address(RVA = "0x14322C0", Offset = "0x14322C0", VA = "0x14322C0")]
	private void FixedUpdate()
	{
	}

	[Token(Token = "0x6000DA8")]
	[Address(RVA = "0x1432390", Offset = "0x1432390", VA = "0x1432390")]
	public DonutCountyMovement()
	{
	}
}
