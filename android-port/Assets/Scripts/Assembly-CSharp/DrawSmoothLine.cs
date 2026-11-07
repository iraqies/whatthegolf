using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x2000C74")]
public class DrawSmoothLine : MonoBehaviour
{
	[Token(Token = "0x400442B")]
	[FieldOffset(Offset = "0x18")]
	public bool UpdateAutomatically;

	[Token(Token = "0x400442C")]
	[FieldOffset(Offset = "0x20")]
	public LineRenderer brush;

	[Token(Token = "0x400442D")]
	[FieldOffset(Offset = "0x28")]
	[Attribute(Name = "RangeAttribute", RVA = "0x5123C", Offset = "0x5123C")]
	public float StepDetail;

	[Token(Token = "0x400442E")]
	[FieldOffset(Offset = "0x2C")]
	public bool UseBezier;

	[Token(Token = "0x400442F")]
	[FieldOffset(Offset = "0x2D")]
	public bool UseEndPointAsStartPoint;

	[Token(Token = "0x4004430")]
	[FieldOffset(Offset = "0x30")]
	public Vector3 Offset;

	[Token(Token = "0x4004431")]
	[FieldOffset(Offset = "0x3C")]
	private float t;

	[Token(Token = "0x4004432")]
	[FieldOffset(Offset = "0x40")]
	private int[] controlIndex;

	[Token(Token = "0x4004433")]
	[FieldOffset(Offset = "0x48")]
	private int[] endIndex;

	[Token(Token = "0x4004434")]
	[FieldOffset(Offset = "0x50")]
	private float detail;

	[Token(Token = "0x4004435")]
	[FieldOffset(Offset = "0x58")]
	private Transform start;

	[Token(Token = "0x4004436")]
	[FieldOffset(Offset = "0x60")]
	private Transform end;

	[Token(Token = "0x4004437")]
	[FieldOffset(Offset = "0x68")]
	private Transform control;

	[Token(Token = "0x6003B15")]
	[Address(RVA = "0x1435FF4", Offset = "0x1435FF4", VA = "0x1435FF4")]
	private void UpdateLine()
	{
	}

	[Token(Token = "0x6003B16")]
	[Address(RVA = "0x1436844", Offset = "0x1436844", VA = "0x1436844")]
	private float DetermineLength()
	{
		return default;
	}

	[Token(Token = "0x6003B17")]
	[Address(RVA = "0x14369D8", Offset = "0x14369D8", VA = "0x14369D8")]
	private void OnDrawGizmos()
	{
	}

	[Token(Token = "0x6003B18")]
	[Address(RVA = "0x1436700", Offset = "0x1436700", VA = "0x1436700")]
	private void UpdateIndexes()
	{
	}

	[Token(Token = "0x6003B19")]
	[Address(RVA = "0x14369DC", Offset = "0x14369DC", VA = "0x14369DC")]
	public DrawSmoothLine()
	{
	}
}
