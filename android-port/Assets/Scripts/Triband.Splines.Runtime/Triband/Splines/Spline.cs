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
		private List<SplinePoint> m_Points;

		[SerializeField]
		private List<SplineSegment> m_Segments;

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
			get
			{
				return false;
			}
			set
			{
			}
		}

		public bool DrawAlways
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		public List<SplinePoint> Points => null;

		public int PointCount => 0;

		public bool ContinuousEditMode { get; set; }

		public bool UseGrid { get; set; }

		public float GridSize { get; set; }

		internal List<SplinePoint> points => null;

		internal List<SplineSegment> segments => null;

		public int pointCount => 0;

		private void Awake()
		{
		}

		internal void Reset()
		{
		}

		private void InitializeSegments()
		{
		}

		public void MovePoint(int index, Vector3 worldPosition)
		{
		}

		public void MovePoints(IReadOnlyList<int> indices, IReadOnlyList<Vector3> worldPositions)
		{
		}

		public void InsertPoint(int segmentIndex, float t)
		{
		}

		public SplinePoint AddPoint(TangentDirection direction)
		{
			return null;
		}

		private static void SetCurvePreservingTangentsForInsertedPoint(SplineSegment segment, SplinePoint newPoint, float t)
		{
		}

		public void ResetAllPointsToDefaults()
		{
		}

		public void DeletePoint(int index)
		{
		}

		public void DeletePoints(IEnumerable<int> indexes)
		{
		}

		internal void SetDirty()
		{
		}

		public void RefreshSplineAfterMove()
		{
		}

		public void SetPointsDirty()
		{
		}

		public bool IsValid()
		{
			return false;
		}

		public Vector3 GetPointPositionWS(int index)
		{
			return default;
		}

		public void Reset(Vector3[] pointPositionsWS)
		{
		}

		public SplineValue Evaluate(float t, bool useLengthCompensation = true)
		{
			return default;
		}

		public SplineValue Evaluate(float t, Vector3 up, bool useLengthCompensation = true)
		{
			return default;
		}

		public SplineValue EvaluateLength(float length, bool useLengthCompensation = true)
		{
			return default;
		}

		public SplineValue EvaluateLength(float length, Vector3 up, bool useLengthCompensation = true)
		{
			return default;
		}

		public float GetLength()
		{
			return 0f;
		}

		public SplineValue GetClosestPoint(Vector3 positionWS, float stepDistance = 1f)
		{
			return default;
		}

		public SplineSegment GetSplineSegmentAt(float t, bool useLengthCompensation, out float segmentT)
		{
			segmentT = default;
			return null;
		}

		public float GetLength(float t)
		{
			return 0f;
		}

		public float GetT(float length)
		{
			return 0f;
		}

		private void Update()
		{
		}

		public void EndEditing()
		{
		}

		public void OnAfterDeserialize()
		{
		}

		public void OnBeforeSerialize()
		{
		}

		public Vector3 RoundTo(Vector3 value)
		{
			return default;
		}
	}
}
