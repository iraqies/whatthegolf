using System;
using System.Collections.Generic;
using UnityEngine;

[Serializable]
public class UniSpline : BaseSpline
{
	[Serializable]
	public class UniSplineSegment
	{
		public Vector3 m_startpos;

		public Vector3 m_startctrl;

		public Vector3 m_endctrl;

		public Vector3 m_endpos;

		public float m_startlen;

		public float m_endlen;

		public float m_length;

		public float[] m_params;

		public float[] m_precomps;
	}

	[SerializeField]
	private UniSplineType m_type;

	[SerializeField]
	private List<Vector3> m_points;

	[SerializeField]
	private UniSplineSegment[] m_segments;

	[SerializeField]
	private float m_bias;

	[SerializeField]
	private float m_tension;

	[SerializeField]
	private float m_continuity;

	[SerializeField]
	private float m_precompdiv;

	private Vector3 GetPosition(UniSplineSegment ss, float t)
	{
		return default;
	}

	private Vector3 GetTangent(UniSplineSegment ss, float t)
	{
		return default;
	}

	private float GetReparam(UniSplineSegment ss, float u)
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
