using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x20005EB")]
public class BallConveyorBelt : MonoBehaviour
{
	[Token(Token = "0x4001E4A")]
	[FieldOffset(Offset = "0x18")]
	public Transform BeltStart;

	[Token(Token = "0x4001E4B")]
	[FieldOffset(Offset = "0x20")]
	public Transform BeltEnd;

	[Token(Token = "0x4001E4C")]
	[FieldOffset(Offset = "0x28")]
	public GameObject BeltTransporter;

	[Token(Token = "0x4001E4D")]
	[FieldOffset(Offset = "0x30")]
	public float Spacing;

	[Token(Token = "0x4001E4E")]
	[FieldOffset(Offset = "0x34")]
	public float MoveSpeed;

	[Token(Token = "0x4001E4F")]
	[FieldOffset(Offset = "0x38")]
	private List<Rigidbody> transporters;

	[Token(Token = "0x6001AF4")]
	[Address(RVA = "0x1518630", Offset = "0x1518630", VA = "0x1518630")]
	private void Start()
	{
	}

	[Token(Token = "0x6001AF5")]
	[Address(RVA = "0x15188C0", Offset = "0x15188C0", VA = "0x15188C0")]
	private void FixedUpdate()
	{
	}

	[Token(Token = "0x6001AF6")]
	[Address(RVA = "0x1518BB4", Offset = "0x1518BB4", VA = "0x1518BB4")]
	public BallConveyorBelt()
	{
	}
}
