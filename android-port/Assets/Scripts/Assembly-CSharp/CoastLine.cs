using System;
using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x2000594")]
[AttributeAttribute(Name = "RequireComponent", RVA = "0x40718", Offset = "0x40718")]
public class CoastLine : MonoBehaviour
{
	[Serializable]
	[Token(Token = "0x2000595")]
	public class Point
	{
		[Token(Token = "0x4001C82")]
		[FieldOffset(Offset = "0x10")]
		public Vector3 position;

		[Token(Token = "0x4001C83")]
		[FieldOffset(Offset = "0x1C")]
		public Vector3 normal;

		[Token(Token = "0x4001C84")]
		[FieldOffset(Offset = "0x28")]
		public float distance;

		[Token(Token = "0x600196F")]
		[Address(RVA = "0x178E2D0", Offset = "0x178E2D0", VA = "0x178E2D0")]
		public Point()
		{
		}
	}

	[Token(Token = "0x4001C79")]
	[FieldOffset(Offset = "0x18")]
	[SerializeField]
	private float lineWidth;

	[Token(Token = "0x4001C7A")]
	[FieldOffset(Offset = "0x1C")]
	[SerializeField]
	private float frequency;

	[Token(Token = "0x4001C7B")]
	[FieldOffset(Offset = "0x20")]
	[SerializeField]
	private float amplitude;

	[Token(Token = "0x4001C7C")]
	[FieldOffset(Offset = "0x24")]
	[SerializeField]
	private float timeShiftOverDistance;

	[Token(Token = "0x4001C7D")]
	[FieldOffset(Offset = "0x28")]
	[SerializeField]
	private AnimationCurve waveCurve;

	[Token(Token = "0x4001C7E")]
	[FieldOffset(Offset = "0x30")]
	[SerializeField]
	private float normalSize;

	[Token(Token = "0x4001C7F")]
	[FieldOffset(Offset = "0x38")]
	public Point[] points;

	[Token(Token = "0x4001C80")]
	[FieldOffset(Offset = "0x40")]
	private LineRenderer lineRenderer;

	[Token(Token = "0x4001C81")]
	[FieldOffset(Offset = "0x48")]
	private Vector3[] positions;

	[Token(Token = "0x6001969")]
	[Address(RVA = "0x18A6E20", Offset = "0x18A6E20", VA = "0x18A6E20")]
	private void Awake()
	{
	}

	[Token(Token = "0x600196A")]
	[Address(RVA = "0x18A6F8C", Offset = "0x18A6F8C", VA = "0x18A6F8C")]
	private void Update()
	{
	}

	[Token(Token = "0x600196B")]
	[Address(RVA = "0x18A70CC", Offset = "0x18A70CC", VA = "0x18A70CC")]
	private void OnDrawGizmos()
	{
	}

	[Token(Token = "0x600196C")]
	[Address(RVA = "0x18A740C", Offset = "0x18A740C", VA = "0x18A740C")]
	public void SavePoints()
	{
	}

	[Token(Token = "0x600196D")]
	[Address(RVA = "0x18A765C", Offset = "0x18A765C", VA = "0x18A765C")]
	public void GenerateNormals()
	{
	}

	[Token(Token = "0x600196E")]
	[Address(RVA = "0x18A7924", Offset = "0x18A7924", VA = "0x18A7924")]
	public CoastLine()
	{
	}
}
