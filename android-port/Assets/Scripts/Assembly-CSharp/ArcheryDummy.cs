using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x200070B")]
public class ArcheryDummy : MonoBehaviour
{
	[Token(Token = "0x4002508")]
	[FieldOffset(Offset = "0x18")]
	public int breakJointCount;

	[Token(Token = "0x4002509")]
	[FieldOffset(Offset = "0x1C")]
	public float breakDistance;

	[Token(Token = "0x400250A")]
	[FieldOffset(Offset = "0x20")]
	private Joint2D joint;

	[Token(Token = "0x400250B")]
	[FieldOffset(Offset = "0x28")]
	private int count;

	[Token(Token = "0x400250C")]
	[FieldOffset(Offset = "0x2C")]
	private bool didBreak;

	[Token(Token = "0x400250D")]
	[FieldOffset(Offset = "0x30")]
	private Vector3 basePos;

	[Token(Token = "0x400250E")]
	[FieldOffset(Offset = "0x3C")]
	public float breakMass;

	[Token(Token = "0x400250F")]
	[FieldOffset(Offset = "0x40")]
	public float breakDrag;

	[Token(Token = "0x4002510")]
	[FieldOffset(Offset = "0x44")]
	public bool breakOnAngle;

	[Token(Token = "0x600207E")]
	[Address(RVA = "0x141FFDC", Offset = "0x141FFDC", VA = "0x141FFDC")]
	private void OnEnable()
	{
	}

	[Token(Token = "0x600207F")]
	[Address(RVA = "0x1420054", Offset = "0x1420054", VA = "0x1420054")]
	private void Update()
	{
	}

	[Token(Token = "0x6002080")]
	[Address(RVA = "0x1420158", Offset = "0x1420158", VA = "0x1420158")]
	private void BreakJoint()
	{
	}

	[Token(Token = "0x6002081")]
	[Address(RVA = "0x142024C", Offset = "0x142024C", VA = "0x142024C")]
	private void OnTriggerEnter2D(Collider2D collision)
	{
	}

	[Token(Token = "0x6002082")]
	[Address(RVA = "0x142033C", Offset = "0x142033C", VA = "0x142033C")]
	public ArcheryDummy()
	{
	}
}
