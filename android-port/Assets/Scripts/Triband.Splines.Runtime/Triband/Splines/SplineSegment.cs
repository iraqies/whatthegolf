using System;
using Triband.Core.MathUtils;
using UnityEngine;

namespace Triband.Splines
{
	[Serializable]
	public sealed class SplineSegment
	{
		private const int kLengthTableSize = 16;

		[SerializeField]
		private int m_Point0;

		[SerializeField]
		private int m_Point1;

		private float[] m_LengthTable;
		private Spline m_Spline;

		private SplinePoint point0 => m_Spline != null && m_Spline.points != null && m_Point0 >= 0 && m_Point0 < m_Spline.points.Count ? m_Spline.points[m_Point0] : null;
		private SplinePoint point1 => m_Spline != null && m_Spline.points != null && m_Point1 >= 0 && m_Point1 < m_Spline.points.Count ? m_Spline.points[m_Point1] : null;

		public Vector3 p0 => point0 != null ? m_Spline.transform.TransformPoint(point0.position) : Vector3.zero;
		public Vector3 p1 => point0 != null ? m_Spline.transform.TransformPoint(point0.position + point0.rightTangent) : Vector3.zero;
		public Vector3 p2 => point1 != null ? m_Spline.transform.TransformPoint(point1.position + point1.leftTangent) : Vector3.zero;
		public Vector3 p3 => point1 != null ? m_Spline.transform.TransformPoint(point1.position) : Vector3.zero;

		public SplinePoint Point0 => point0;
		public SplinePoint Point1 => point1;

		public bool hasValidLengthTable => m_LengthTable != null && m_LengthTable.Length == kLengthTableSize;

		public float length
		{
			get
			{
				if (!hasValidLengthTable) CalculateLengthTable();
				return m_LengthTable != null && m_LengthTable.Length > 0 ? m_LengthTable[m_LengthTable.Length - 1] : 0f;
			}
		}

		internal Spline spline
		{
			set => m_Spline = value;
		}

		public SplineSegment(Spline spline, int point0, int point1)
		{
			m_Spline = spline;
			m_Point0 = point0;
			m_Point1 = point1;
		}

		internal void SetDirty() => m_LengthTable = null;

		internal SplineValue Evaluate(float t, bool useLengthCompensation = true)
		{
			return Evaluate(t, GetUp(t, useLengthCompensation), useLengthCompensation);
		}

		internal SplineValue Evaluate(float t, Vector3 up, bool useLengthCompensation = true)
		{
			t = Mathf.Clamp01(t);
			float evalT = useLengthCompensation ? GetT(t * length) : t;
			float u = 1f - evalT;
			Vector3 pos = u * u * u * p0 + 3f * u * u * evalT * p1 + 3f * u * evalT * evalT * p2 + evalT * evalT * evalT * p3;
			Vector3 deriv = 3f * u * u * (p1 - p0) + 6f * u * evalT * (p2 - p1) + 3f * evalT * evalT * (p3 - p2);
			Vector3 tan = deriv.sqrMagnitude > 1e-8f ? deriv.normalized : Vector3.forward;
			Vector3 upVec = up.sqrMagnitude > 1e-6f ? up.normalized : Vector3.up;
			Vector3 binorm = Vector3.Cross(upVec, tan).normalized;
			if (binorm.sqrMagnitude < 1e-6f) binorm = Vector3.right;
			Vector3 norm = Vector3.Cross(tan, binorm).normalized;
			Quaternion rot = Quaternion.LookRotation(tan, norm);
			var sv = new SplineValue(pos, rot, norm, tan, binorm);
			sv.t = t;
			return sv;
		}

		internal float GetLength(float t)
		{
			if (!hasValidLengthTable) CalculateLengthTable();
			return m_LengthTable.Sample(Mathf.Clamp01(t));
		}

		internal float GetT(float lengthVal)
		{
			if (!hasValidLengthTable) CalculateLengthTable();
			return m_LengthTable.InverseSample(lengthVal);
		}

		internal Vector3 GetUp(float t, bool useLengthCompensation = true)
		{
			Vector3 u0 = point0 != null ? point0.up : Vector3.up;
			Vector3 u1 = point1 != null ? point1.up : Vector3.up;
			Vector3 localUp = Vector3.Slerp(u0, u1, Mathf.Clamp01(t));
			return m_Spline != null ? m_Spline.transform.TransformDirection(localUp) : localUp;
		}

		private void CalculateLengthTable()
		{
			m_LengthTable = new float[kLengthTableSize];
			Vector3 prev = p0;
			float acc = 0f;
			m_LengthTable[0] = 0f;
			for (int i = 1; i < kLengthTableSize; i++)
			{
				float t = i / (float)(kLengthTableSize - 1);
				float u = 1f - t;
				Vector3 cur = u * u * u * p0 + 3f * u * u * t * p1 + 3f * u * t * t * p2 + t * t * t * p3;
				acc += Vector3.Distance(prev, cur);
				m_LengthTable[i] = acc;
				prev = cur;
			}
		}
	}
}
