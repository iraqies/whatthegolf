using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x2000BC5")]
[ExecuteInEditMode]
public class Build2DWire : MonoBehaviour
{
	[Token(Token = "0x4004196")]
	[FieldOffset(Offset = "0x18")]
	public GameObject LineSegment;

	[Token(Token = "0x4004197")]
	[FieldOffset(Offset = "0x20")]
	public float MassPerLine;

	[Token(Token = "0x4004198")]
	[FieldOffset(Offset = "0x24")]
	public float SegmentsLength;

	[Token(Token = "0x4004199")]
	[FieldOffset(Offset = "0x28")]
	public Transform LineStart;

	[Token(Token = "0x400419A")]
	[FieldOffset(Offset = "0x30")]
	public Transform LineEnd;

	[Token(Token = "0x400419B")]
	[FieldOffset(Offset = "0x38")]
	public bool BuildLinesNow;

	[Token(Token = "0x400419C")]
	[FieldOffset(Offset = "0x40")]
	private List<GameObject> lines;

	[Token(Token = "0x400419D")]
	[FieldOffset(Offset = "0x48")]
	private Transform container;

	[Token(Token = "0x60038B1")]
	[Address(RVA = "0x170ABA4", Offset = "0x170ABA4", VA = "0x170ABA4")]
	private void Update()
	{
	}

	[Token(Token = "0x60038B2")]
	[Address(RVA = "0x170ABC0", Offset = "0x170ABC0", VA = "0x170ABC0")]
	private void BuildLines(Transform previousMast, Transform currentMast)
	{
	}

	[Token(Token = "0x60038B3")]
	[Address(RVA = "0x170B2C0", Offset = "0x170B2C0", VA = "0x170B2C0")]
	public Build2DWire()
	{
	}
}
