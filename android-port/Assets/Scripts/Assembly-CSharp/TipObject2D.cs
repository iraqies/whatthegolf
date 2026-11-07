using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x2000B34")]
public class TipObject2D : TippableObjectBase
{
	[Token(Token = "0x4003E88")]
	[FieldOffset(Offset = "0x20")]
	public float SleepThreshold;

	[Token(Token = "0x4003E89")]
	[FieldOffset(Offset = "0x24")]
	public float DotThreshold;

	[Token(Token = "0x4003E8A")]
	[FieldOffset(Offset = "0x28")]
	public Vector3 AxisToCheck;

	[Token(Token = "0x4003E8B")]
	[FieldOffset(Offset = "0x38")]
	private Rigidbody2D m_rigidbody2D;

	[Token(Token = "0x4003E8C")]
	[FieldOffset(Offset = "0x40")]
	private bool wasMoving;

	[Token(Token = "0x4003E8D")]
	[FieldOffset(Offset = "0x41")]
	private bool hasBeenTipped;

	[Token(Token = "0x6003556")]
	[Address(RVA = "0x1718568", Offset = "0x1718568", VA = "0x1718568")]
	private void Awake()
	{
	}

	[Token(Token = "0x6003557")]
	[Address(RVA = "0x17185C4", Offset = "0x17185C4", VA = "0x17185C4")]
	private void FixedUpdate()
	{
	}

	[Token(Token = "0x6003558")]
	[Address(RVA = "0x1718778", Offset = "0x1718778", VA = "0x1718778")]
	public TipObject2D()
	{
	}
}
