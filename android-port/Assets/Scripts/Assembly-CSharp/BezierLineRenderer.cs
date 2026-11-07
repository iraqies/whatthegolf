using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x20002AD")]
[ExecuteInEditMode]
public class BezierLineRenderer : MonoBehaviour
{
	[Token(Token = "0x4000E54")]
	[FieldOffset(Offset = "0x18")]
	public Transform point1;

	[Token(Token = "0x4000E55")]
	[FieldOffset(Offset = "0x20")]
	public Transform point2;

	[Token(Token = "0x4000E56")]
	[FieldOffset(Offset = "0x28")]
	public Transform point3;

	[Token(Token = "0x4000E57")]
	[FieldOffset(Offset = "0x30")]
	public LineRenderer lineRenderer;

	[Token(Token = "0x4000E58")]
	[FieldOffset(Offset = "0x38")]
	public int vertexCount;

	[Token(Token = "0x6000C4D")]
	[Address(RVA = "0x160D884", Offset = "0x160D884", VA = "0x160D884")]
	private void Update()
	{
	}

	[Token(Token = "0x6000C4E")]
	[Address(RVA = "0x160DC00", Offset = "0x160DC00", VA = "0x160DC00")]
	public BezierLineRenderer()
	{
	}
}
