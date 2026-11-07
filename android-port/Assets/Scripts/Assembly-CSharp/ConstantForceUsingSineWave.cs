using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x20002B3")]
[Attribute(Name = "RequireComponent", RVA = "0x3E9D4", Offset = "0x3E9D4")]
public class ConstantForceUsingSineWave : MonoBehaviour
{
	[Token(Token = "0x4000E72")]
	[FieldOffset(Offset = "0x18")]
	public Vector3 ForceAxis;

	[Token(Token = "0x4000E73")]
	[FieldOffset(Offset = "0x24")]
	public Vector3 RelativeForceAxis;

	[Token(Token = "0x4000E74")]
	[FieldOffset(Offset = "0x30")]
	public Vector3 TorqueAxis;

	[Token(Token = "0x4000E75")]
	[FieldOffset(Offset = "0x3C")]
	public Vector3 RelativeTorqueAxis;

	[Token(Token = "0x4000E76")]
	[FieldOffset(Offset = "0x48")]
	public float Speed;

	[Token(Token = "0x4000E77")]
	[FieldOffset(Offset = "0x4C")]
	public float Strength;

	[Token(Token = "0x4000E78")]
	[FieldOffset(Offset = "0x50")]
	public float TimeOffset;

	[Token(Token = "0x4000E79")]
	[FieldOffset(Offset = "0x58")]
	private ConstantForce force;

	[Token(Token = "0x6000C5B")]
	[Address(RVA = "0x18AD494", Offset = "0x18AD494", VA = "0x18AD494")]
	private void Start()
	{
	}

	[Token(Token = "0x6000C5C")]
	[Address(RVA = "0x18AD4F0", Offset = "0x18AD4F0", VA = "0x18AD4F0")]
	private void FixedUpdate()
	{
	}

	[Token(Token = "0x6000C5D")]
	[Address(RVA = "0x18AD5C8", Offset = "0x18AD5C8", VA = "0x18AD5C8")]
	public ConstantForceUsingSineWave()
	{
	}
}
