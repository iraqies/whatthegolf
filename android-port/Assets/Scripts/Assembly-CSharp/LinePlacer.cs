using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x2000C01")]
public class LinePlacer : MonoBehaviour
{
	[Token(Token = "0x2000C02")]
	private struct PointDistance
	{
		[Token(Token = "0x4004282")]
		[FieldOffset(Offset = "0x0")]
		public Vector3 point;

		[Token(Token = "0x4004283")]
		[FieldOffset(Offset = "0xC")]
		public float distance;

		[Token(Token = "0x4004284")]
		[FieldOffset(Offset = "0x10")]
		public Vector3 lookDir;

		[Token(Token = "0x60039AB")]
		[Address(RVA = "0x17E925C", Offset = "0x17E925C", VA = "0x17E925C")]
		public PointDistance(Vector3 point, float distance, Vector3 lookDir)
		{
		}
	}

	[Token(Token = "0x400427C")]
	[FieldOffset(Offset = "0x18")]
	public Transform[] drawingPoints;

	[Token(Token = "0x400427D")]
	[FieldOffset(Offset = "0x20")]
	public GameObject brush;

	[Token(Token = "0x400427E")]
	[FieldOffset(Offset = "0x28")]
	public int segmentMeasuringSamples;

	[Token(Token = "0x400427F")]
	[FieldOffset(Offset = "0x2C")]
	public float brushSize;

	[Token(Token = "0x4004280")]
	[FieldOffset(Offset = "0x30")]
	public float orientationSampleDistance;

	[Token(Token = "0x4004281")]
	[FieldOffset(Offset = "0x38")]
	private List<PointDistance> table;

	[Token(Token = "0x60039A6")]
	[Address(RVA = "0x1532A64", Offset = "0x1532A64", VA = "0x1532A64")]
	private void Start()
	{
	}

	[Token(Token = "0x60039A7")]
	[Address(RVA = "0x1532E50", Offset = "0x1532E50", VA = "0x1532E50")]
	private void ComputeReparametrizationTable(Vector3 start, Vector3 end, Vector3 control, int samples, List<PointDistance> table)
	{
	}

	[Token(Token = "0x60039A8")]
	[Address(RVA = "0x153321C", Offset = "0x153321C", VA = "0x153321C")]
	private void SampleTable(List<PointDistance> table, float distance, out PointDistance point)
	{
	}

	[Token(Token = "0x60039A9")]
	[Address(RVA = "0x1533544", Offset = "0x1533544", VA = "0x1533544")]
	private void OnDrawGizmos()
	{
	}

	[Token(Token = "0x60039AA")]
	[Address(RVA = "0x15338E8", Offset = "0x15338E8", VA = "0x15338E8")]
	public LinePlacer()
	{
	}
}
