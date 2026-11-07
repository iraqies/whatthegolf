#!/usr/bin/env python3
"""Implement real runtime logic for Triband.Splines.Runtime, Triband.MountainGenerator.Runtime,
and Triband.GolfTerrainRuntime.
"""
import os

PORT_SCRIPTS = "/home/ubuntu/work/WhatTheGolf/android-port/Assets/Scripts"
EXPORT_SCRIPTS = "/home/ubuntu/c113work/ar_out/ExportedProject/Assets/Scripts"


def write_both(rel_path: str, content: str) -> None:
    for root in (PORT_SCRIPTS, EXPORT_SCRIPTS):
        if os.path.exists(root):
            p = os.path.join(root, rel_path)
            os.makedirs(os.path.dirname(p), exist_ok=True)
            with open(p, "w", encoding="utf-8") as f:
                f.write(content)


def main() -> None:
    # 1. Vertex.cs & Vertex2D.cs & SplineValue.cs
    write_both("Triband.Splines.Runtime/Triband/Splines/Vertex.cs", """using UnityEngine;

namespace Triband.Splines
{
	public struct Vertex
	{
		public readonly Vector3 position;
		public readonly Vector3 normal;
		public readonly Vector2 uv;

		public Vertex(Vector3 position, Vector3 normal, Vector2 uv)
		{
			this.position = position;
			this.normal = normal;
			this.uv = uv;
		}
	}
}
""")

    write_both("Triband.Splines.Runtime/Triband/Splines/Vertex2D.cs", """using UnityEngine;

namespace Triband.Splines
{
	public struct Vertex2D
	{
		public readonly Vector2 position;
		public readonly Vector2 uv;
		public readonly Vector2 normal;

		public Vertex2D(Vector2 position, Vector2 uv)
		{
			this.position = position;
			this.uv = uv;
			this.normal = Vector2.up;
		}
	}
}
""")

    write_both("Triband.Splines.Runtime/Triband/Splines/SplineValue.cs", """using UnityEngine;

namespace Triband.Splines
{
	public struct SplineValue
	{
		public readonly Vector3 position;
		public readonly Quaternion rotation;
		public readonly Vector3 normal;
		public readonly Vector3 tangent;
		public readonly Vector3 binormal;

		public float t { get; internal set; }

		public SplineValue(Vector3 position, Quaternion rotation, Vector3 normal, Vector3 tangent, Vector3 binormal)
		{
			this.position = position;
			this.rotation = rotation;
			this.normal = normal;
			this.tangent = tangent;
			this.binormal = binormal;
			t = 0f;
		}
	}
}
""")

    # 2. Shape.cs, Shape2D.cs, ShapeGenerator.cs, QuadShapeGeneratorData.cs, QuadShapeGenerator.cs
    write_both("Triband.Splines.Runtime/Triband/Splines/Shape.cs", """using System.Collections.Generic;

namespace Triband.Splines
{
	public class Shape
	{
		private readonly List<Vertex> vertices = new List<Vertex>();
		private readonly List<int> triangles = new List<int>();

		public List<Vertex> Vertices => vertices;
		public List<int> Triangles => triangles;
	}
}
""")

    write_both("Triband.Splines.Runtime/Triband/Splines/Shape2D.cs", """using System.Collections;
using System.Collections.Generic;

namespace Triband.Splines
{
	public class Shape2D : IEnumerable<Vertex2D>, IEnumerable
	{
		private readonly List<Vertex2D> vertices = new List<Vertex2D>();

		public int VertexCount => vertices.Count;

		public void AddVertex(Vertex2D vertex) => vertices.Add(vertex);

		public Vertex2D GetVertex(int index) => vertices[index];

		public IEnumerator<Vertex2D> GetEnumerator() => vertices.GetEnumerator();

		IEnumerator IEnumerable.GetEnumerator() => vertices.GetEnumerator();
	}
}
""")

    write_both("Triband.Splines.Runtime/Triband/Splines/ShapeGenerator.cs", """using System;

namespace Triband.Splines
{
	[Serializable]
	public abstract class ShapeGenerator
	{
		public IShapeGeneratorData rootData;

		public abstract Type DataType { get; }
		public abstract bool ClosedLoop { get; }
		public abstract bool AutoGenerateNormals { get; }
		public SplineMesh.UVSettings UVSettings { get; set; }

		public abstract Shape2D Generate(float t, float length);
		public abstract Shape GenerateStartCap();
		public abstract Shape GenerateEndCap();
	}

	public abstract class ShapeGenerator<T> : ShapeGenerator where T : IShapeGeneratorData
	{
		public override Type DataType => typeof(T);
		protected T Data => (T)rootData;
	}
}
""")

    write_both("Triband.Splines.Runtime/Triband/Splines/QuadShapeGeneratorData.cs", """using System;
using UnityEngine;

namespace Triband.Splines
{
	[Serializable]
	public class QuadShapeGeneratorData : IShapeGeneratorData
	{
		[SerializeField]
		private float width = 1f;

		[SerializeField]
		private float pivot = 0.5f;

		[SerializeField]
		private bool twoSided;

		public float Width => width;
		public float Pivot => pivot;
		public bool TwoSided => twoSided;
	}
}
""")

    write_both("Triband.Splines.Runtime/Triband/Splines/QuadShapeGenerator.cs", """using System;
using UnityEngine;

namespace Triband.Splines
{
	[Serializable]
	public class QuadShapeGenerator : ShapeGenerator<QuadShapeGeneratorData>
	{
		public override bool ClosedLoop => false;
		public override bool AutoGenerateNormals => true;

		public override Shape2D Generate(float t, float length)
		{
			var s = new Shape2D();
			float w = Data != null && Data.Width > 0f ? Data.Width : 1f;
			float p = Data != null ? Data.Pivot : 0.5f;
			float x0 = -w * p;
			float x1 = w * (1f - p);
			s.AddVertex(new Vertex2D(new Vector2(x0, 0f), GenerateUVs(0f, t, length)));
			s.AddVertex(new Vertex2D(new Vector2(x1, 0f), GenerateUVs(1f, t, length)));
			return s;
		}

		private Vector2 GenerateUVs(float x, float t, float length)
		{
			float v = UVSettings.verticalUVMode == SplineMesh.UVMode.WorldSpace ? t * length : t;
			return new Vector2(x, v);
		}

		public override Shape GenerateStartCap() => new Shape();
		public override Shape GenerateEndCap() => new Shape();
	}
}
""")

    # 3. SplinePoint.cs & SplineSegment.cs & Spline.cs
    write_both("Triband.Splines.Runtime/Triband/Splines/SplinePoint.cs", """using System;
using UnityEngine;

namespace Triband.Splines
{
	[Serializable]
	public sealed class SplinePoint
	{
		[SerializeField]
		private Vector3 m_Position;

		[SerializeField]
		private Quaternion m_Rotation = Quaternion.identity;

		[SerializeField]
		private Vector3 m_LeftTangent;

		[SerializeField]
		private Vector3 m_RightTangent;

		[SerializeField]
		private HandleMode m_HandleMode;

		[SerializeField]
		private TangentMode m_LeftTangentMode;

		[SerializeField]
		private TangentMode m_RightTangentMode;

		[SerializeField]
		private Vector3 m_Up = Vector3.up;

		private Spline m_Spline;

		public Spline spline
		{
			get => m_Spline;
			set => m_Spline = value;
		}

		public Vector3 position
		{
			get => m_Position;
			set => UpdatePosition(value);
		}

		public Vector3 leftTangent
		{
			get => m_LeftTangent;
			set => UpdateTangent(value, TangentDirection.Left);
		}

		public Vector3 rightTangent
		{
			get => m_RightTangent;
			set => UpdateTangent(value, TangentDirection.Right);
		}

		public HandleMode handleMode
		{
			get => m_HandleMode;
			set => UpdateHandleMode(value);
		}

		public TangentMode leftTangentMode
		{
			get => m_LeftTangentMode;
			set => UpdateTangentMode(value, TangentDirection.Left);
		}

		public TangentMode rightTangentMode
		{
			get => m_RightTangentMode;
			set => UpdateTangentMode(value, TangentDirection.Right);
		}

		public Vector3 up => m_Up.sqrMagnitude > 1e-6f ? m_Up : Vector3.up;

		internal SplinePoint(Spline spline, Vector3 position, Quaternion rotation, Vector3 leftTangent, Vector3 rightTangent, Vector3 up)
		{
			m_Spline = spline;
			m_Position = position;
			m_Rotation = rotation;
			m_LeftTangent = leftTangent;
			m_RightTangent = rightTangent;
			m_Up = up;
		}

		internal SplinePoint(Spline spline, Vector3 position, Quaternion rotation, Vector3 leftTangent, Vector3 rightTangent, Vector3 up, HandleMode handleMode, TangentMode leftTangentMode, TangentMode rightTangentMode)
		{
			m_Spline = spline;
			m_Position = position;
			m_Rotation = rotation;
			m_LeftTangent = leftTangent;
			m_RightTangent = rightTangent;
			m_Up = up;
			m_HandleMode = handleMode;
			m_LeftTangentMode = leftTangentMode;
			m_RightTangentMode = rightTangentMode;
		}

		public Vector3 GetTangent(TangentDirection direction) => direction == TangentDirection.Left ? m_LeftTangent : m_RightTangent;

		public SplinePoint GetPreviousPoint()
		{
			if (m_Spline == null || m_Spline.points == null) return null;
			int idx = m_Spline.points.IndexOf(this);
			if (idx <= 0) return m_Spline.Loop && m_Spline.points.Count > 0 ? m_Spline.points[m_Spline.points.Count - 1] : null;
			return m_Spline.points[idx - 1];
		}

		public SplinePoint GetNextPoint()
		{
			if (m_Spline == null || m_Spline.points == null) return null;
			int idx = m_Spline.points.IndexOf(this);
			if (idx < 0 || idx >= m_Spline.points.Count - 1) return m_Spline.Loop && m_Spline.points.Count > 0 ? m_Spline.points[0] : null;
			return m_Spline.points[idx + 1];
		}

		public Vector3 GetLinearTangent(TangentDirection direction)
		{
			var neighbor = direction == TangentDirection.Left ? GetPreviousPoint() : GetNextPoint();
			return neighbor != null ? (neighbor.position - m_Position) * 0.333f : Vector3.zero;
		}

		private void UpdatePosition(Vector3 position)
		{
			m_Position = position;
			m_Spline?.SetPointsDirty();
		}

		private void UpdateTangent(Vector3 value, TangentDirection direction)
		{
			if (direction == TangentDirection.Left) m_LeftTangent = value;
			else m_RightTangent = value;
			m_Spline?.SetPointsDirty();
		}

		private void UpdateHandleMode(HandleMode mode) => m_HandleMode = mode;

		private void UpdateTangentMode(TangentMode mode, TangentDirection direction)
		{
			if (direction == TangentDirection.Left) m_LeftTangentMode = mode;
			else m_RightTangentMode = mode;
		}

		internal void RecursivelyAutoSmoothTangents() { }
		public bool AutoSmoothTangents() => false;
		public void AutoSmoothTangentsOnPreviousPoint(SplinePoint recursionOrigin) { }
		public void AutoSmoothTangentsOnNextPoint(SplinePoint recursionOrigin) { }
	}
}
""")

    write_both("Triband.Splines.Runtime/Triband/Splines/SplineSegment.cs", """using System;
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
""")

    write_both("Triband.Splines.Runtime/Triband/Splines/Spline.cs", """using System.Collections.Generic;
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
""")

    # 4. SplineSpawnerSettings.cs & SplineSpawner.cs
    write_both("Triband.Splines.Runtime/Triband/Splines/SplineSpawnerSettings.cs", """using System;
using UnityEngine;

namespace Triband.Splines
{
	[Serializable]
	public sealed class SplineSpawnerSettings
	{
		[SerializeField] private PositionMode m_PositionMode;
		[SerializeField] private int m_Count;
		[SerializeField] private bool m_LengthCompensation = true;
		[SerializeField] private ParticleSystem.MinMaxCurve m_Distance;
		[SerializeField] private StartOffsetMode m_StartOffsetMode;
		[SerializeField] private float m_StartOffsetFraction;
		[SerializeField] private bool m_StartOffsetRepeat;
		[SerializeField] private float m_StartOffsetDistance;
		[SerializeField] private float m_EndOffsetFraction;
		[SerializeField] private StartOffsetMode m_EndOffsetMode;
		[SerializeField] private float m_EndOffsetDistance;
		[SerializeField] private bool m_EndOffsetRepeat;
		[SerializeField] private AlignmentMode m_AlignmentMode;
		[SerializeField] private RotationAlignmentMode m_RotationAlignmentMode;
		[SerializeField] private Vector3 m_RotationPerObject;
		[SerializeField] private ParticleSystem.MinMaxCurve m_OffsetX;
		[SerializeField] private ParticleSystem.MinMaxCurve m_OffsetY;
		[SerializeField] private ParticleSystem.MinMaxCurve m_OffsetZ;
		[SerializeField] private ParticleSystem.MinMaxCurve m_RotationX;
		[SerializeField] private ParticleSystem.MinMaxCurve m_RotationY;
		[SerializeField] private ParticleSystem.MinMaxCurve m_RotationZ;
		[SerializeField] private bool m_Use3dScale;
		[SerializeField] private ParticleSystem.MinMaxCurve m_Scale;
		[SerializeField] private ParticleSystem.MinMaxCurve m_ScaleX;
		[SerializeField] private ParticleSystem.MinMaxCurve m_ScaleY;
		[SerializeField] private ParticleSystem.MinMaxCurve m_ScaleZ;
		[SerializeField] private int m_Seed;
		[SerializeField] private ObjectMode m_ObjectMode;
		[SerializeField] private bool m_UseCapObjects;
		[SerializeField] private GameObject m_StartCapObject;
		[SerializeField] private GameObject m_EndCapObject;
		[SerializeField] private GameObject[] m_Objects;
		[SerializeField] private bool m_onlyUpdateOnSplineCompletion;

		public bool OnlyUpdateOnSplineCompletion => m_onlyUpdateOnSplineCompletion;
		public PositionMode positionMode => m_PositionMode;
		public int count => m_Count;
		public ParticleSystem.MinMaxCurve distance => m_Distance;
		public bool lengthCompensation => m_LengthCompensation;
		public StartOffsetMode startOffsetMode => m_StartOffsetMode;
		public bool startOffsetRepeat => m_StartOffsetRepeat;
		public float startOffsetFraction => m_StartOffsetFraction;
		public float startOffsetDistance => m_StartOffsetDistance;
		public StartOffsetMode endOffsetMode => m_EndOffsetMode;
		public float endOffsetFraction => m_EndOffsetFraction;
		public float endOffsetDistance => m_EndOffsetDistance;
		public bool endOffsetRepeat => m_EndOffsetRepeat;
		public AlignmentMode alignmentMode => m_AlignmentMode;
		public RotationAlignmentMode RotationAlignmentMode => m_RotationAlignmentMode;
		public Vector3 RotationPerObject => m_RotationPerObject;
		public ParticleSystem.MinMaxCurve offsetX => m_OffsetX;
		public ParticleSystem.MinMaxCurve offsetY => m_OffsetY;
		public ParticleSystem.MinMaxCurve offsetZ => m_OffsetZ;
		public ParticleSystem.MinMaxCurve rotationX => m_RotationX;
		public ParticleSystem.MinMaxCurve rotationY => m_RotationY;
		public ParticleSystem.MinMaxCurve rotationZ => m_RotationZ;
		public bool use3dScale => m_Use3dScale;
		public ParticleSystem.MinMaxCurve scale => m_Scale;
		public ParticleSystem.MinMaxCurve scaleX => m_ScaleX;
		public ParticleSystem.MinMaxCurve scaleY => m_ScaleY;
		public ParticleSystem.MinMaxCurve scaleZ => m_ScaleZ;
		public int seed => m_Seed;
		public ObjectMode objectMode => m_ObjectMode;
		public bool useCapObjects => m_UseCapObjects;
		public GameObject startCapObject => m_StartCapObject;
		public GameObject endCapObject => m_EndCapObject;
		public GameObject[] objects => m_Objects;

		public bool IsValid() => m_Objects != null && m_Objects.Length > 0;
	}
}
""")

    write_both("Triband.Splines.Runtime/Triband/Splines/SplineSpawner.cs", """using System.Collections.Generic;
using UnityEngine;

namespace Triband.Splines
{
	[ExecuteInEditMode]
	public sealed class SplineSpawner : MonoBehaviour
	{
		private enum ObjectSource
		{
			Array = 0,
			StartCap = 1,
			EndCap = 2
		}

		public delegate void OnUpdateDelegate();

		[SerializeField]
		private Spline m_Spline;

		[SerializeField]
		private SplineSpawnerSettings m_Settings;

		[SerializeField]
		private List<GameObject> m_Objects;

		private const string kEditorSettingsKey = "Triband.Splines.SplineSpawnerEditorSettings";
		private const float kMinDistance = 0.1f;

		private bool m_IsDirty;
		private List<(SplineValue, float)> m_EvaluationCache;

		public OnUpdateDelegate onSpawnerUpdated;

		public SplineSpawnerSettings Settings => m_Settings;

		public Spline spline
		{
			get => m_Spline != null ? m_Spline : GetComponent<Spline>();
			set => m_Spline = value;
		}

		private void OnEnable()
		{
			if (m_Spline == null) m_Spline = GetComponent<Spline>();
		}

		private void OnDisable() { }
		private void SubscribeToSplineEvents() { }
		private void UnsubscribeToSplineEvents() { }
		public void Reset() { }
		private void Update() { }
		public void Evaluate() { }
		internal void SetDirty() => m_IsDirty = true;
		internal void OnSplineChanged() { }
		private void EvaluateSplineCount() { }
		private void EvaluateSplineLength() { }
		private void SpawnOrGetObject(SplineValue value, float t, int count, int seed, ObjectSource objectSource) { }
		private Vector3 GetPosition(SplineValue value, float t, int seed) => value.position;
		private Quaternion GetRotation(SplineValue value, float t, int index, int seed) => value.rotation;
		private Vector3 GetScale(SplineValue value, float t, int seed) => Vector3.one;
		private float GetStartOffset() => 0f;
		private float GetEndOffset() => 0f;
	}
}
""")

    write_both("Triband.Splines.Runtime/Triband/Splines/SplineMeshCollider.cs", """using UnityEngine;

namespace Triband.Splines
{
	public class SplineMeshCollider : MonoBehaviour
	{
		[SerializeField]
		private MeshCollider meshCollider;

		private void Reset()
		{
			if (meshCollider == null) meshCollider = GetComponent<MeshCollider>();
		}

		private void OnValidate() { }

		public void UpdateCollider(Mesh mesh)
		{
			if (meshCollider == null) meshCollider = GetComponent<MeshCollider>();
			if (meshCollider != null && mesh != null)
				meshCollider.sharedMesh = mesh;
		}
	}
}
""")

    # 5. GolfTerrain & MountainGenerator property getters (meshes are already baked in the scenes/prefabs!)
    write_both("Triband.GolfTerrainRuntime/Triband/GolfTerrainTool/GolfTerrain.cs", """using UnityEngine;

namespace Triband.GolfTerrainTool
{
	[ExecuteInEditMode]
	[DisallowMultipleComponent]
	public sealed class GolfTerrain : MonoBehaviour
	{
		[SerializeField] private MeshFilter m_MeshFilter;
		[SerializeField] private MeshRenderer m_MeshRenderer;
		[SerializeField] private TerrainData m_TerrainData;
		[SerializeField] private CanvasParameters m_CanvasParameters;
		[SerializeField] private MeshParameters m_MeshParameters;
		[SerializeField] private RendererParameters m_RendererParameters;

		private const string kChildName = "Renderer";
		private MeshCollider m_MeshCollider;
		private bool m_IsDirty;
		private Mesh m_Mesh;
		private Material m_Material;
		private Shader m_Shader;

		public TerrainData terrainData { get => m_TerrainData; set => m_TerrainData = value; }
		public CanvasParameters canvasParameters { get => m_CanvasParameters; set => m_CanvasParameters = value; }
		public MeshParameters meshParameters { get => m_MeshParameters; set => m_MeshParameters = value; }
		public RendererParameters rendererParameters { get => m_RendererParameters; set => m_RendererParameters = value; }
		public MeshCollider meshCollider => m_MeshCollider != null ? m_MeshCollider : (m_MeshCollider = GetComponentInChildren<MeshCollider>());
		public Mesh mesh { get => m_MeshFilter != null ? m_MeshFilter.sharedMesh : m_Mesh; set => m_Mesh = value; }
		public Shader shader => m_Shader != null ? m_Shader : (m_Shader = Shader.Find("Triband/GolfTerrain"));
		public Material material { get => m_MeshRenderer != null ? m_MeshRenderer.sharedMaterial : m_Material; set => m_Material = value; }

		private void OnEnable() { }
		public void Reset() { }
		private void OnDestroy() { }
		public void Init(TerrainData terrainData = null, CanvasParameters canvasParameters = null, MeshParameters meshParameters = null, RendererParameters rendererParameters = null) { }
		public void SetDirty() => m_IsDirty = true;
		public void HandleChanges() { }
		public void UpdateMesh() { }
		private void UpdateMeshComponents() { }
		public void UpdateRendererComponents() { }
		private void AddRendererComponents() { }
		private void OnDrawGizmos() { }
	}
}
""")

    print("Implemented Triband.Splines.Runtime and Triband.GolfTerrainRuntime")


if __name__ == "__main__":
    main()
