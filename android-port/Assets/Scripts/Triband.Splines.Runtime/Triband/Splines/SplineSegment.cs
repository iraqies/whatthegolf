using System;
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

		private SplinePoint point0 => null;

		private SplinePoint point1 => null;

		public Vector3 p0 => default;

		public Vector3 p1 => default;

		public Vector3 p2 => default;

		public Vector3 p3 => default;

		public SplinePoint Point0 => null;

		public SplinePoint Point1 => null;

		public bool hasValidLengthTable => false;

		public float length => 0f;

		internal Spline spline
		{
			set
			{
			}
		}

		public SplineSegment(Spline spline, int point0, int point1)
		{
		}

		internal void SetDirty()
		{
		}

		internal SplineValue Evaluate(float t, bool useLengthCompensation = true)
		{
			return default;
		}

		internal SplineValue Evaluate(float t, Vector3 up, bool useLengthCompensation = true)
		{
			return default;
		}

		internal float GetLength(float t)
		{
			return 0f;
		}

		internal float GetT(float length)
		{
			return 0f;
		}

		internal Vector3 GetUp(float t, bool useLengthCompensation = true)
		{
			return default;
		}

		private void CalculateLengthTable()
		{
		}
	}
}
