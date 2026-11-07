using System;
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
