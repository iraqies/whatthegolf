using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x2000ADE")]
public class CustomGravityFromNearestVert : MonoBehaviour
{
	[Token(Token = "0x4003CA7")]
	[FieldOffset(Offset = "0x18")]
	public List<Collider2D> GravityColliders;

	[Token(Token = "0x4003CA8")]
	[FieldOffset(Offset = "0x20")]
	public Collider2D Collider;

	[Token(Token = "0x4003CA9")]
	[FieldOffset(Offset = "0x28")]
	public float GravityForce;

	[Token(Token = "0x4003CAA")]
	[FieldOffset(Offset = "0x2C")]
	public bool AutoAlignObject;

	[Token(Token = "0x4003CAB")]
	[FieldOffset(Offset = "0x30")]
	private ConstantForce2D gravityForce;

	[Token(Token = "0x60033ED")]
	[Address(RVA = "0x18C7244", Offset = "0x18C7244", VA = "0x18C7244")]
	private void Start()
	{
	}

	[Token(Token = "0x60033EE")]
	[Address(RVA = "0x18C72A0", Offset = "0x18C72A0", VA = "0x18C72A0")]
	private void FixedUpdate()
	{
	}

	[Token(Token = "0x60033EF")]
	[Address(RVA = "0x18C7518", Offset = "0x18C7518", VA = "0x18C7518")]
	public CustomGravityFromNearestVert()
	{
	}
}
