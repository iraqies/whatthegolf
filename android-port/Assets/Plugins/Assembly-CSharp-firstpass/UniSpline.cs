using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

[Serializable]
[Token(Token = "0x2000037")]
public class UniSpline : BaseSpline
{
	[Serializable]
	[Token(Token = "0x2000038")]
	public class UniSplineSegment
	{
		[Token(Token = "0x40000CE")]
		[FieldOffset(Offset = "0x10")]
		public Vector3 m_startpos;

		[Token(Token = "0x40000CF")]
		[FieldOffset(Offset = "0x1C")]
		public Vector3 m_startctrl;

		[Token(Token = "0x40000D0")]
		[FieldOffset(Offset = "0x28")]
		public Vector3 m_endctrl;

		[Token(Token = "0x40000D1")]
		[FieldOffset(Offset = "0x34")]
		public Vector3 m_endpos;

		[Token(Token = "0x40000D2")]
		[FieldOffset(Offset = "0x40")]
		public float m_startlen;

		[Token(Token = "0x40000D3")]
		[FieldOffset(Offset = "0x44")]
		public float m_endlen;

		[Token(Token = "0x40000D4")]
		[FieldOffset(Offset = "0x48")]
		public float m_length;

		[Token(Token = "0x40000D5")]
		[FieldOffset(Offset = "0x50")]
		public float[] m_params;

		[Token(Token = "0x40000D6")]
		[FieldOffset(Offset = "0x58")]
		public float[] m_precomps;

		[Token(Token = "0x60000F4")]
		[Address(RVA = "0x1358950", Offset = "0x1358950", VA = "0x1358950")]
		public UniSplineSegment()
		{
		}
	}

	[Token(Token = "0x40000C7")]
	[FieldOffset(Offset = "0x24")]
	[SerializeField]
	private UniSplineType m_type;

	[Token(Token = "0x40000C8")]
	[FieldOffset(Offset = "0x28")]
	[SerializeField]
	private List<Vector3> m_points;

	[Token(Token = "0x40000C9")]
	[FieldOffset(Offset = "0x30")]
	[SerializeField]
	private UniSplineSegment[] m_segments;

	[Token(Token = "0x40000CA")]
	[FieldOffset(Offset = "0x38")]
	[SerializeField]
	private float m_bias;

	[Token(Token = "0x40000CB")]
	[FieldOffset(Offset = "0x3C")]
	[SerializeField]
	private float m_tension;

	[Token(Token = "0x40000CC")]
	[FieldOffset(Offset = "0x40")]
	[SerializeField]
	private float m_continuity;

	[Token(Token = "0x40000CD")]
	[FieldOffset(Offset = "0x44")]
	[SerializeField]
	private float m_precompdiv;

	[Token(Token = "0x60000E9")]
	[Address(RVA = "0x1325060", Offset = "0x1325060", VA = "0x1325060")]
	private Vector3 GetPosition(UniSplineSegment ss, float t)
	{
		return default;
	}

	[Token(Token = "0x60000EA")]
	[Address(RVA = "0x1325220", Offset = "0x1325220", VA = "0x1325220")]
	private Vector3 GetTangent(UniSplineSegment ss, float t)
	{
		return default;
	}

	[Token(Token = "0x60000EB")]
	[Address(RVA = "0x1325404", Offset = "0x1325404", VA = "0x1325404")]
	private float GetReparam(UniSplineSegment ss, float u)
	{
		return default;
	}

	[Token(Token = "0x60000EC")]
	[Address(RVA = "0x13255A4", Offset = "0x13255A4", VA = "0x13255A4", Slot = "4")]
	public override int GetSegmentCount()
	{
		return default;
	}

	[Token(Token = "0x60000ED")]
	[Address(RVA = "0x13255BC", Offset = "0x13255BC", VA = "0x13255BC", Slot = "5")]
	protected override float GetSegmentLength(int segidx)
	{
		return default;
	}

	[Token(Token = "0x60000EE")]
	[Address(RVA = "0x1325600", Offset = "0x1325600", VA = "0x1325600", Slot = "6")]
	protected override float GetSegmentStartLength(int segidx)
	{
		return default;
	}

	[Token(Token = "0x60000EF")]
	[Address(RVA = "0x1325644", Offset = "0x1325644", VA = "0x1325644", Slot = "7")]
	protected override int FindSegment(float offset)
	{
		return default;
	}

	[Token(Token = "0x60000F0")]
	[Address(RVA = "0x13256C8", Offset = "0x13256C8", VA = "0x13256C8", Slot = "8")]
	protected override Vector3 GetDrawPosition(int segidx, float t)
	{
		return default;
	}

	[Token(Token = "0x60000F1")]
	[Address(RVA = "0x1325704", Offset = "0x1325704", VA = "0x1325704", Slot = "9")]
	protected override Vector3 GetPosition(int segidx, float segpos)
	{
		return default;
	}

	[Token(Token = "0x60000F2")]
	[Address(RVA = "0x1325780", Offset = "0x1325780", VA = "0x1325780", Slot = "10")]
	protected override Vector3 GetTangent(int segidx, float segpos)
	{
		return default;
	}

	[Token(Token = "0x60000F3")]
	[Address(RVA = "0x13257FC", Offset = "0x13257FC", VA = "0x13257FC")]
	public UniSpline()
	{
	}
}
