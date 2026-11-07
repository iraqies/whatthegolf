using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x20008A1")]
public class MovingGalleryTarget : MonoBehaviour
{
	[Token(Token = "0x4002F63")]
	[FieldOffset(Offset = "0x18")]
	public Transform StartPoint;

	[Token(Token = "0x4002F64")]
	[FieldOffset(Offset = "0x20")]
	public Transform EndPoint;

	[Token(Token = "0x4002F65")]
	[FieldOffset(Offset = "0x28")]
	public bool PingPong;

	[Token(Token = "0x4002F66")]
	[FieldOffset(Offset = "0x2C")]
	public float MoveSpeed;

	[Token(Token = "0x4002F67")]
	[FieldOffset(Offset = "0x30")]
	private Rigidbody rigid;

	[Token(Token = "0x4002F68")]
	[FieldOffset(Offset = "0x38")]
	private Transform target;

	[Token(Token = "0x60027DE")]
	[Address(RVA = "0x157761C", Offset = "0x157761C", VA = "0x157761C")]
	private void Awake()
	{
	}

	[Token(Token = "0x60027DF")]
	[Address(RVA = "0x157767C", Offset = "0x157767C", VA = "0x157767C")]
	private void FixedUpdate()
	{
	}

	[Token(Token = "0x60027E0")]
	[Address(RVA = "0x1577888", Offset = "0x1577888", VA = "0x1577888")]
	public MovingGalleryTarget()
	{
	}
}
