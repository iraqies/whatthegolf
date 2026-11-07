using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x20007E4")]
public class SphericalGravity : MonoBehaviour
{
	[Token(Token = "0x4002A3D")]
	[FieldOffset(Offset = "0x18")]
	[SerializeField]
	private Transform ball;

	[Token(Token = "0x4002A3E")]
	[FieldOffset(Offset = "0x20")]
	[SerializeField]
	private Collider Sphere;

	[Token(Token = "0x4002A3F")]
	[FieldOffset(Offset = "0x28")]
	[SerializeField]
	private float gravityForce;

	[Token(Token = "0x4002A40")]
	[FieldOffset(Offset = "0x2C")]
	private RaycastHit hit;

	[Token(Token = "0x6002447")]
	[Address(RVA = "0x16D1A58", Offset = "0x16D1A58", VA = "0x16D1A58")]
	private void FixedUpdate()
	{
	}

	[Token(Token = "0x6002448")]
	[Address(RVA = "0x16D1BD0", Offset = "0x16D1BD0", VA = "0x16D1BD0")]
	public SphericalGravity()
	{
	}
}
