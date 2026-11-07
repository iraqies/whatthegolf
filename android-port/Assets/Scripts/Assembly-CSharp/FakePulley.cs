using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x2000AE1")]
public class FakePulley : MonoBehaviour
{
	[Token(Token = "0x4003CAE")]
	[FieldOffset(Offset = "0x18")]
	public Vector3 Axis;

	[Token(Token = "0x4003CAF")]
	[FieldOffset(Offset = "0x24")]
	public float Dampen;

	[Token(Token = "0x4003CB0")]
	[FieldOffset(Offset = "0x28")]
	public SpringJoint ThisEnd;

	[Token(Token = "0x4003CB1")]
	[FieldOffset(Offset = "0x30")]
	public SpringJoint OtherEnd;

	[Token(Token = "0x4003CB2")]
	[FieldOffset(Offset = "0x38")]
	public Vector2 ValidSpringRange;

	[Token(Token = "0x60033F6")]
	[Address(RVA = "0x145C620", Offset = "0x145C620", VA = "0x145C620")]
	private void OnCollisionEnter(Collision other)
	{
	}

	[Token(Token = "0x60033F7")]
	[Address(RVA = "0x145C76C", Offset = "0x145C76C", VA = "0x145C76C")]
	public FakePulley()
	{
	}
}
