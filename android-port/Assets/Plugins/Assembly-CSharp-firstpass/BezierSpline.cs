using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

[Serializable]
[Token(Token = "0x200002E")]
public class BezierSpline : BaseSpline
{
	[Serializable]
	[Token(Token = "0x200002F")]
	public class BezierSplineSegment
	{
		[Token(Token = "0x4000083")]
		[FieldOffset(Offset = "0x10")]
		public Vector3 m_startpos;

		[Token(Token = "0x4000084")]
		[FieldOffset(Offset = "0x1C")]
		public Vector3 m_endpos;

		[Token(Token = "0x4000085")]
		[FieldOffset(Offset = "0x28")]
		public Vector3 m_startctrl;

		[Token(Token = "0x4000086")]
		[FieldOffset(Offset = "0x34")]
		public Vector3 m_endctrl;

		[Token(Token = "0x4000087")]
		[FieldOffset(Offset = "0x40")]
		public float m_startlen;

		[Token(Token = "0x4000088")]
		[FieldOffset(Offset = "0x44")]
		public float m_endlen;

		[Token(Token = "0x4000089")]
		[FieldOffset(Offset = "0x48")]
		public float m_length;

		[Token(Token = "0x400008A")]
		[FieldOffset(Offset = "0x4C")]
		public SplineSegmentType m_type;

		[Token(Token = "0x400008B")]
		[FieldOffset(Offset = "0x50")]
		public float[] m_params;

		[Token(Token = "0x400008C")]
		[FieldOffset(Offset = "0x58")]
		public float[] m_precomps;

		[Token(Token = "0x60000B2")]
		[Address(RVA = "0x1338B10", Offset = "0x1338B10", VA = "0x1338B10")]
		public BezierSplineSegment()
		{
		}
	}

	[Serializable]
	[Token(Token = "0x2000030")]
	public class BezierSplinePoint
	{
		[Token(Token = "0x400008D")]
		[FieldOffset(Offset = "0x10")]
		public Vector3 m_point;

		[Token(Token = "0x400008E")]
		[FieldOffset(Offset = "0x1C")]
		public Vector3 m_prevctrl;

		[Token(Token = "0x400008F")]
		[FieldOffset(Offset = "0x28")]
		public Vector3 m_nextctrl;

		[Token(Token = "0x4000090")]
		[FieldOffset(Offset = "0x34")]
		public SplinePointType m_type;
	}

	[Token(Token = "0x4000080")]
	[FieldOffset(Offset = "0x28")]
	public List<BezierSplinePoint> m_points;

	[Token(Token = "0x4000081")]
	[FieldOffset(Offset = "0x30")]
	[SerializeField]
	private BezierSplineSegment[] m_segments;

	[Token(Token = "0x4000082")]
	[FieldOffset(Offset = "0x38")]
	[SerializeField]
	private float m_precompdiv;

	[Token(Token = "0x60000A7")]
	[Address(RVA = "0x13005B4", Offset = "0x13005B4", VA = "0x13005B4")]
	public Vector3 GetPosition(BezierSplineSegment ss, float t)
	{
		return default;
	}

	[Token(Token = "0x60000A8")]
	[Address(RVA = "0x13006EC", Offset = "0x13006EC", VA = "0x13006EC")]
	public Vector3 GetTangent(BezierSplineSegment ss, float t)
	{
		return default;
	}

	[Token(Token = "0x60000A9")]
	[Address(RVA = "0x13007F8", Offset = "0x13007F8", VA = "0x13007F8")]
	private float GetReparam(BezierSplineSegment ss, float u)
	{
		return default;
	}

	[Token(Token = "0x60000AA")]
	[Address(RVA = "0x1300998", Offset = "0x1300998", VA = "0x1300998", Slot = "4")]
	public override int GetSegmentCount()
	{
		return default;
	}

	[Token(Token = "0x60000AB")]
	[Address(RVA = "0x13009B0", Offset = "0x13009B0", VA = "0x13009B0", Slot = "5")]
	protected override float GetSegmentLength(int segidx)
	{
		return default;
	}

	[Token(Token = "0x60000AC")]
	[Address(RVA = "0x13009F4", Offset = "0x13009F4", VA = "0x13009F4", Slot = "6")]
	protected override float GetSegmentStartLength(int segidx)
	{
		return default;
	}

	[Token(Token = "0x60000AD")]
	[Address(RVA = "0x1300A38", Offset = "0x1300A38", VA = "0x1300A38", Slot = "7")]
	protected override int FindSegment(float offset)
	{
		return default;
	}

	[Token(Token = "0x60000AE")]
	[Address(RVA = "0x1300ABC", Offset = "0x1300ABC", VA = "0x1300ABC", Slot = "8")]
	protected override Vector3 GetDrawPosition(int segidx, float t)
	{
		return default;
	}

	[Token(Token = "0x60000AF")]
	[Address(RVA = "0x1300AF8", Offset = "0x1300AF8", VA = "0x1300AF8", Slot = "9")]
	protected override Vector3 GetPosition(int segidx, float segpos)
	{
		return default;
	}

	[Token(Token = "0x60000B0")]
	[Address(RVA = "0x1300B6C", Offset = "0x1300B6C", VA = "0x1300B6C", Slot = "10")]
	protected override Vector3 GetTangent(int segidx, float segpos)
	{
		return default;
	}

	[Token(Token = "0x60000B1")]
	[Address(RVA = "0x1300BE0", Offset = "0x1300BE0", VA = "0x1300BE0")]
	public BezierSpline()
	{
	}
}
