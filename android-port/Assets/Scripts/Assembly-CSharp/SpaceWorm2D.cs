using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x2000AE6")]
public class SpaceWorm2D : MonoBehaviour
{
	[Token(Token = "0x4003CCA")]
	[FieldOffset(Offset = "0x18")]
	public ConstantForce2D Force;

	[Token(Token = "0x4003CCB")]
	[FieldOffset(Offset = "0x20")]
	public Vector2 ForceChangeSpeed;

	[Token(Token = "0x4003CCC")]
	[FieldOffset(Offset = "0x28")]
	public Vector2 ForceSize;

	[Token(Token = "0x4003CCD")]
	[FieldOffset(Offset = "0x30")]
	public Vector2 BaseForce;

	[Token(Token = "0x600340A")]
	[Address(RVA = "0x16C44D0", Offset = "0x16C44D0", VA = "0x16C44D0")]
	private void Update()
	{
	}

	[Token(Token = "0x600340B")]
	[Address(RVA = "0x16C4568", Offset = "0x16C4568", VA = "0x16C4568")]
	public SpaceWorm2D()
	{
	}
}
