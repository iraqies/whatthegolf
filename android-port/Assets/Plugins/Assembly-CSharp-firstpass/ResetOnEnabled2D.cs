using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x2000040")]
public class ResetOnEnabled2D : MonoBehaviour
{
	[Token(Token = "0x40000F2")]
	[FieldOffset(Offset = "0x18")]
	private Vector3 startPos;

	[Token(Token = "0x40000F3")]
	[FieldOffset(Offset = "0x28")]
	private Rigidbody2D rigid;

	[Token(Token = "0x40000F4")]
	[FieldOffset(Offset = "0x30")]
	private SpringJoint2D joint;

	[Token(Token = "0x40000F5")]
	[FieldOffset(Offset = "0x38")]
	private float spring;

	[Token(Token = "0x6000113")]
	[Address(RVA = "0x13DBE8C", Offset = "0x13DBE8C", VA = "0x13DBE8C")]
	private void Awake()
	{
	}

	[Token(Token = "0x6000114")]
	[Address(RVA = "0x13DBF40", Offset = "0x13DBF40", VA = "0x13DBF40")]
	private void OnEnable()
	{
	}

	[Token(Token = "0x6000115")]
	[Address(RVA = "0x13DBFBC", Offset = "0x13DBFBC", VA = "0x13DBFBC")]
	public ResetOnEnabled2D()
	{
	}
}
