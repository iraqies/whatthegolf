using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x20007E7")]
public class MovingHole : MonoBehaviour
{
	[Token(Token = "0x4002A5B")]
	[FieldOffset(Offset = "0x18")]
	[SerializeField]
	private Transform collisionBoxHigh;

	[Token(Token = "0x4002A5C")]
	[FieldOffset(Offset = "0x20")]
	[SerializeField]
	private Transform collisionBoxLow;

	[Token(Token = "0x4002A5D")]
	[FieldOffset(Offset = "0x28")]
	[SerializeField]
	private Transform pivotTransform;

	[Token(Token = "0x4002A5E")]
	[FieldOffset(Offset = "0x30")]
	[SerializeField]
	private float targetLengthLow;

	[Token(Token = "0x4002A5F")]
	[FieldOffset(Offset = "0x34")]
	[SerializeField]
	private float centerLow;

	[Token(Token = "0x4002A60")]
	[FieldOffset(Offset = "0x38")]
	[Attribute(Name = "RangeAttribute", RVA = "0x4EFC4", Offset = "0x4EFC4")]
	public float PositionRatio;

	[Token(Token = "0x6002453")]
	[Address(RVA = "0x1577898", Offset = "0x1577898", VA = "0x1577898")]
	private void Update()
	{
	}

	[Token(Token = "0x6002454")]
	[Address(RVA = "0x157795C", Offset = "0x157795C", VA = "0x157795C")]
	public MovingHole()
	{
	}
}
