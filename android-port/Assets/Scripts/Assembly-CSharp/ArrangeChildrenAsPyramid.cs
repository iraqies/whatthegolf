using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x2000BB7")]
[ExecuteInEditMode]
public class ArrangeChildrenAsPyramid : MonoBehaviour
{
	[Token(Token = "0x400413D")]
	[FieldOffset(Offset = "0x18")]
	public Vector3 Direction;

	[Token(Token = "0x400413E")]
	[FieldOffset(Offset = "0x24")]
	public float Spacing;

	[Token(Token = "0x400413F")]
	[FieldOffset(Offset = "0x28")]
	public float ZSpacing;

	[Token(Token = "0x4004140")]
	[FieldOffset(Offset = "0x2C")]
	public float OffsetMod;

	[Token(Token = "0x4004141")]
	[FieldOffset(Offset = "0x30")]
	public int BottomRowCount;

	[Token(Token = "0x6003877")]
	[Address(RVA = "0x1425670", Offset = "0x1425670", VA = "0x1425670")]
	private void Update()
	{
	}

	[Token(Token = "0x6003878")]
	[Address(RVA = "0x1425CD0", Offset = "0x1425CD0", VA = "0x1425CD0")]
	public ArrangeChildrenAsPyramid()
	{
	}
}
