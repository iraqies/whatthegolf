using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x2000B22")]
public class RotateAxis2D : MonoBehaviour
{
	[Token(Token = "0x4003E45")]
	[FieldOffset(Offset = "0x18")]
	public bool UsePhysics;

	[Token(Token = "0x4003E46")]
	[FieldOffset(Offset = "0x1C")]
	public Vector3 Axis;

	[Token(Token = "0x4003E47")]
	[FieldOffset(Offset = "0x28")]
	public float Speed;

	[Token(Token = "0x4003E48")]
	[FieldOffset(Offset = "0x30")]
	private Rigidbody2D rigid;

	[Token(Token = "0x4003E49")]
	[FieldOffset(Offset = "0x38")]
	private Transform t;

	[Token(Token = "0x600351A")]
	[Address(RVA = "0x165ED88", Offset = "0x165ED88", VA = "0x165ED88")]
	private void Awake()
	{
	}

	[Token(Token = "0x600351B")]
	[Address(RVA = "0x165EDF4", Offset = "0x165EDF4", VA = "0x165EDF4")]
	private void Update()
	{
	}

	[Token(Token = "0x600351C")]
	[Address(RVA = "0x165EEAC", Offset = "0x165EEAC", VA = "0x165EEAC")]
	private void FixedUpdate()
	{
	}

	[Token(Token = "0x600351D")]
	[Address(RVA = "0x165EF98", Offset = "0x165EF98", VA = "0x165EF98")]
	public RotateAxis2D()
	{
	}
}
