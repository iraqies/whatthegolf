using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x2000221")]
public class HandBallObject : MonoBehaviour
{
	[Token(Token = "0x4000AB4")]
	[FieldOffset(Offset = "0x18")]
	public Transform LeftHold;

	[Token(Token = "0x4000AB5")]
	[FieldOffset(Offset = "0x20")]
	public Transform RightHold;

	[Token(Token = "0x4000AB6")]
	[FieldOffset(Offset = "0x28")]
	private List<Joint> joints;

	[Token(Token = "0x4000AB7")]
	[FieldOffset(Offset = "0x30")]
	private Rigidbody rigid;

	[Token(Token = "0x6000985")]
	[Address(RVA = "0x14C3804", Offset = "0x14C3804", VA = "0x14C3804")]
	private void Awake()
	{
	}

	[Token(Token = "0x6000986")]
	[Address(RVA = "0x14C3860", Offset = "0x14C3860", VA = "0x14C3860")]
	public void AddJointTo(Rigidbody holder, Transform holdPos)
	{
	}

	[Token(Token = "0x6000987")]
	[Address(RVA = "0x14C3948", Offset = "0x14C3948", VA = "0x14C3948")]
	public void Release()
	{
	}

	[Token(Token = "0x6000988")]
	[Address(RVA = "0x14C3ABC", Offset = "0x14C3ABC", VA = "0x14C3ABC")]
	public void Throw(Vector3 force)
	{
	}

	[Token(Token = "0x6000989")]
	[Address(RVA = "0x14C3670", Offset = "0x14C3670", VA = "0x14C3670")]
	public void PrepareForShot()
	{
	}

	[Token(Token = "0x600098A")]
	[Address(RVA = "0x14C3B6C", Offset = "0x14C3B6C", VA = "0x14C3B6C")]
	public HandBallObject()
	{
	}
}
