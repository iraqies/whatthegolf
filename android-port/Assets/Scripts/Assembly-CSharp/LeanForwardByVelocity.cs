using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x2000C00")]
public class LeanForwardByVelocity : MonoBehaviour
{
	[Token(Token = "0x4004279")]
	[FieldOffset(Offset = "0x18")]
	public Rigidbody m_rigidbody;

	[Token(Token = "0x400427A")]
	[FieldOffset(Offset = "0x20")]
	public float maxVelocity;

	[Token(Token = "0x400427B")]
	[FieldOffset(Offset = "0x24")]
	public float maxAngle;

	[Token(Token = "0x60039A4")]
	[Address(RVA = "0x1522A7C", Offset = "0x1522A7C", VA = "0x1522A7C")]
	private void FixedUpdate()
	{
	}

	[Token(Token = "0x60039A5")]
	[Address(RVA = "0x1522B80", Offset = "0x1522B80", VA = "0x1522B80")]
	public LeanForwardByVelocity()
	{
	}
}
