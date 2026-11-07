using System;
using System.Collections.Generic;
using UnityEngine;

[Serializable]
public class BezierSpline : BaseSpline
{
	[Serializable]
	public class BezierSplineSegment
	{
		public Vector3 m_startpos;

		public Vector3 m_endpos;

		public Vector3 m_startctrl;

		public Vector3 m_endctrl;

		public float m_startlen;

		public float m_endlen;

		public float m_length;

		public SplineSegmentType m_type;

		public float[] m_params;

		public float[] m_precomps;
	}

	[Serializable]
	public class BezierSplinePoint
	{
		public Vector3 m_point;

		public Vector3 m_prevctrl;

		public Vector3 m_nextctrl;

		public SplinePointType m_type;
	}

	public List<BezierSplinePoint> m_points;

	[SerializeField]
	private BezierSplineSegment[] m_segments;

	[SerializeField]
	private float m_precompdiv;

	public Vector3 GetPosition(BezierSplineSegment ss, float t)
	{
		return default;
	}

	public Vector3 GetTangent(BezierSplineSegment ss, float t)
	{
		return default;
	}

	private float GetReparam(BezierSplineSegment ss, float u)
	{
		return 0f;
	}

	public override int GetSegmentCount()
	{
		return 0;
	}

	protected override float GetSegmentLength(int segidx)
	{
		return 0f;
	}

	protected override float GetSegmentStartLength(int segidx)
	{
		return 0f;
	}

	protected override int FindSegment(float offset)
	{
		return 0;
	}

	protected override Vector3 GetDrawPosition(int segidx, float t)
	{
		return default;
	}

	protected override Vector3 GetPosition(int segidx, float segpos)
	{
		return default;
	}

	protected override Vector3 GetTangent(int segidx, float segpos)
	{
		return default;
	}
}
