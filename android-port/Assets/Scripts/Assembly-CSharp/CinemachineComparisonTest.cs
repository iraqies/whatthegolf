using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x2000332")]
public class CinemachineComparisonTest : MonoBehaviour
{
	[Token(Token = "0x40011B0")]
	[FieldOffset(Offset = "0x18")]
	public Transform oldCamera;

	[Token(Token = "0x40011B1")]
	[FieldOffset(Offset = "0x20")]
	public Transform newCamera;

	[Token(Token = "0x40011B2")]
	[FieldOffset(Offset = "0x28")]
	public Transform ball;

	[Token(Token = "0x40011B3")]
	[FieldOffset(Offset = "0x30")]
	public bool isActive;

	[Token(Token = "0x40011B4")]
	[FieldOffset(Offset = "0x34")]
	public float maxError;

	[Token(Token = "0x40011B5")]
	[FieldOffset(Offset = "0x38")]
	public float avgError;

	[Token(Token = "0x40011B6")]
	[FieldOffset(Offset = "0x3C")]
	public float avgErrorWhileMouseDown;

	[Token(Token = "0x40011B7")]
	[FieldOffset(Offset = "0x40")]
	public float currentError;

	[Token(Token = "0x6000EBE")]
	[Address(RVA = "0x189D98C", Offset = "0x189D98C", VA = "0x189D98C")]
	private void Update()
	{
	}

	[Token(Token = "0x6000EBF")]
	[Address(RVA = "0x189DAB0", Offset = "0x189DAB0", VA = "0x189DAB0")]
	private void OnDrawGizmos()
	{
	}

	[Token(Token = "0x6000EC0")]
	[Address(RVA = "0x189DC28", Offset = "0x189DC28", VA = "0x189DC28")]
	public CinemachineComparisonTest()
	{
	}
}
