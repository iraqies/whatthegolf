using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x2000B16")]
public class OrbitAroundObject : MonoBehaviour
{
	[Token(Token = "0x4003E01")]
	[FieldOffset(Offset = "0x18")]
	public Transform OrbitObject;

	[Token(Token = "0x4003E02")]
	[FieldOffset(Offset = "0x20")]
	public Vector2 SpeedRange;

	[Token(Token = "0x4003E03")]
	[FieldOffset(Offset = "0x28")]
	private Rigidbody rigid;

	[Token(Token = "0x4003E04")]
	[FieldOffset(Offset = "0x30")]
	private float speed;

	[Token(Token = "0x60034ED")]
	[Address(RVA = "0x159D490", Offset = "0x159D490", VA = "0x159D490")]
	private void Start()
	{
	}

	[Token(Token = "0x60034EE")]
	[Address(RVA = "0x159D528", Offset = "0x159D528", VA = "0x159D528")]
	private void Update()
	{
	}

	[Token(Token = "0x60034EF")]
	[Address(RVA = "0x159D55C", Offset = "0x159D55C", VA = "0x159D55C")]
	private void FixedUpdate()
	{
	}

	[Token(Token = "0x60034F0")]
	[Address(RVA = "0x159D5B0", Offset = "0x159D5B0", VA = "0x159D5B0")]
	public OrbitAroundObject()
	{
	}
}
