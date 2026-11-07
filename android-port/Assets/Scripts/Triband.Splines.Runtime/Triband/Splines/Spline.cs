using System.Collections.Generic;
using UnityEngine;

namespace Triband.Splines
{
	[ExecuteInEditMode]
	public sealed class Spline : MonoBehaviour, ISerializationCallbackReceiver
	{
		public delegate void OnChangeDelegate();

		[SerializeField]
		private bool m_Loop;

		[SerializeField]
		private List<SplinePoint> m_Points = new List<SplinePoint>();

		[SerializeField]
		private List<SplineSegment> m_Segments = new List<SplineSegment>();

		[SerializeField]
		private bool m_drawAlways;

		[SerializeField]
		private bool m_RebuildWhenTransformChanges;

		public OnChangeDelegate onSplineChanged;
		public OnChangeDelegate onSplineChangeCompleted;
		internal OnChangeDelegate onSplinePointsChanged;

		public HandleMode defaultHandleMode;
		public TangentMode defaultTangent;

		public bool Loop
		{
			get => m_Loop;
			set { m_Loop = value; InitializeSegments(); SetDirty(); }
		}

		public bool DrawAlways
		{
			get => m_drawAlways;
			set => m_drawAlways = value;
		}

		public List<SplinePoint> Points => m_Points;
		public int PointCount => m_Points != null ? m_Points.Count : 0;
		public bool ContinuousEditMode { get; set; }
		public bool UseGrid { get; set; }
		public float GridSize { get; set; }
		internal List<SplinePoint> points => m_Points;
		internal List<SplineSegment> segments
		{
			get
			{
				if (m_Segments == null || m_Segments.Count == 0)
					InitializeSegments();
				return m_Segments;
			}
		}
		public int pointCount => PointCount;

		private void Awake() => InitializeSegments();

		internal void Reset() => InitializeSegments();

		private void InitializeSegments()
		{
			if (m_Points == null) m_Points = new List<SplinePoint>();
			foreach (var p in m_Points)
			{
				if (p != null) p.spline = this;
			}
			if (m_Segments == null) m_Segments = new List<SplineSegment>();
			int expected = m_Points.Count > 1 ? (m_Loop ? m_Points.Count : m_Points.Count - 1) : 0;
			if (m_Segments.Count != expected)
			{
				m_Segments.Clear();
				for (int i = 0; i < expected; i++)
					m_Segments.Add(new SplineSegment(this, i, (i + 1) % m_Points.Count));
			}
			else
			{
				foreach (var s in m_Segments)
				{
					if (s != null) { s.spline = this; s.SetDirty(); }
				}
			}
		}

		public void MovePoint(int index, Vector3 worldPosition)
		{
			if (m_Points != null && index >= 0 && index < m_Points.Count)
			{
				m_Points[index].position = transform.InverseTransformPoint(worldPosition);
				SetPointsDirty();
			}
		}

		public void MovePoints(IReadOnlyList<int> indices, IReadOnlyList<Vector3> worldPositions)
		{
			if (indices == null || worldPositions == null) return;
			for (int i = 0; i < indices.Count && i < worldPositions.Count; i++)
				MovePoint(indices[i], worldPositions[i]);
		}

		public void InsertPoint(int segmentIndex, float t) { }
		public SplinePoint AddPoint(TangentDirection direction) => null;
		private static void SetCurvePreservingTangentsForInsertedPoint(SplineSegment segment, SplinePoint newPoint, float t) { }
		public void ResetAllPointsToDefaults() { }
		public void DeletePoint(int index) { }
		public void DeletePoints(IEnumerable<int> indexes) { }

		internal void SetDirty()
		{
			if (m_Segments != null)
			{
				foreach (var s in m_Segments) s?.SetDirty();
			}
			onSplineChanged?.Invoke();
		}

		public void RefreshSplineAfterMove() => SetDirty();

		public void SetPointsDirty()
		{
			SetDirty();
			onSplinePointsChanged?.Invoke();
		}

		public bool IsValid() => m_Points != null && m_Points.Count >= 2;

		public Vector3 GetPointPositionWS(int index)
		{
			if (m_Points == null || index < 0 || index >= m_Points.Count) return transform.position;
			return transform.TransformPoint(m_Points[index].position);
		}

		public void Reset(Vector3[] pointPositionsWS)
		{
			if (m_Points == null) m_Points = new List<SplinePoint>();
			m_Points.Clear();
			if (pointPositionsWS != null)
			{
				foreach (var ws in pointPositionsWS)
				{
					var lp = transform.InverseTransformPoint(ws);
					m_Points.Add(new SplinePoint(this, lp, Quaternion.identity, Vector3.zero, Vector3.zero, Vector3.up));
				}
			}
			InitializeSegments();
		}

		public SplineValue Evaluate(float t, bool useLengthCompensation = true)
		{
			var seg = GetSplineSegmentAt(t, useLengthCompensation, out float segT);
			if (seg == null)
				return new SplineValue(transform.position, transform.rotation, transform.up, transform.forward, transform.right);
			var sv = seg.Evaluate(segT, useLengthCompensation);
			sv.t = Mathf.Clamp01(t);
			return sv;
		}

		public SplineValue Evaluate(float t, Vector3 up, bool useLengthCompensation = true)
		{
			var seg = GetSplineSegmentAt(t, useLengthCompensation, out float segT);
			if (seg == null)
				return new SplineValue(transform.position, transform.rotation, up, transform.forward, transform.right);
			var sv = seg.Evaluate(segT, up, useLengthCompensation);
			sv.t = Mathf.Clamp01(t);
			return sv;
		}

		public SplineValue EvaluateLength(float lengthVal, bool useLengthCompensation = true)
		{
			return Evaluate(GetT(lengthVal), useLengthCompensation);
		}

		public SplineValue EvaluateLength(float lengthVal, Vector3 up, bool useLengthCompensation = true)
		{
			return Evaluate(GetT(lengthVal), up, useLengthCompensation);
		}

		public float GetLength()
		{
			var segs = segments;
			if (segs == null) return 0f;
			float sum = 0f;
			for (int i = 0; i < segs.Count; i++)
				if (segs[i] != null) sum += segs[i].length;
			return sum;
		}

		public SplineValue GetClosestPoint(Vector3 positionWS, float stepDistance = 1f)
		{
			float total = GetLength();
			int steps = Mathf.Clamp(Mathf.CeilToInt(total / Mathf.Max(0.1f, stepDistance)), 8, 128);
			float bestDist = float.MaxValue;
			SplineValue best = Evaluate(0f);
			for (int i = 0; i <= steps; i++)
			{
				float t = i / (float)steps;
				var sv = Evaluate(t);
				float d = (sv.position - positionWS).sqrMagnitude;
				if (d < bestDist)
				{
					bestDist = d;
					best = sv;
				}
			}
			return best;
		}

		public SplineSegment GetSplineSegmentAt(float t, bool useLengthCompensation, out float segmentT)
		{
			segmentT = 0f;
			var segs = segments;
			if (segs == null || segs.Count == 0) return null;
			t = Mathf.Clamp01(t);
			if (!useLengthCompensation)
			{
				float scaled = t * segs.Count;
				int idx = Mathf.Min(Mathf.FloorToInt(scaled), segs.Count - 1);
				segmentT = scaled - idx;
				return segs[idx];
			}
			float targetLen = t * GetLength();
			float acc = 0f;
			for (int i = 0; i < segs.Count; i++)
			{
				float sl = segs[i].length;
				if (acc + sl >= targetLen || i == segs.Count - 1)
				{
					segmentT = sl > 1e-6f ? Mathf.Clamp01((targetLen - acc) / sl) : 0f;
					return segs[i];
				}
				acc += sl;
			}
			return segs[segs.Count - 1];
		}

		public float GetLength(float t) => Mathf.Clamp01(t) * GetLength();

		public float GetT(float lengthVal)
		{
			float total = GetLength();
			return total > 1e-6f ? Mathf.Clamp01(lengthVal / total) : 0f;
		}

		private void Update() { }
		public void EndEditing() => onSplineChangeCompleted?.Invoke();

		public void OnAfterDeserialize() => InitializeSegments();
		public void OnBeforeSerialize() { }
		public Vector3 RoundTo(Vector3 value) => value;
	}
}
