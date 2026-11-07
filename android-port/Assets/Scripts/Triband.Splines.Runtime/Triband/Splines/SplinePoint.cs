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
		private Quaternion m_Rotation;

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
		private Vector3 m_Up;

		private Spline m_Spline;

		public Spline spline
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public Vector3 position
		{
			get
			{
				return default;
			}
			set
			{
			}
		}

		public Vector3 leftTangent
		{
			get
			{
				return default;
			}
			set
			{
			}
		}

		public Vector3 rightTangent
		{
			get
			{
				return default;
			}
			set
			{
			}
		}

		public HandleMode handleMode
		{
			get
			{
				return HandleMode.Smooth;
			}
			set
			{
			}
		}

		public TangentMode leftTangentMode
		{
			get
			{
				return TangentMode.Linear;
			}
			set
			{
			}
		}

		public TangentMode rightTangentMode
		{
			get
			{
				return TangentMode.Linear;
			}
			set
			{
			}
		}

		public Vector3 up => default;

		internal SplinePoint(Spline spline, Vector3 position, Quaternion rotation, Vector3 leftTangent, Vector3 rightTangent, Vector3 up)
		{
		}

		internal SplinePoint(Spline spline, Vector3 position, Quaternion rotation, Vector3 leftTangent, Vector3 rightTangent, Vector3 up, HandleMode handleMode, TangentMode leftTangentMode, TangentMode rightTangentMode)
		{
		}

		public Vector3 GetTangent(TangentDirection direction)
		{
			return default;
		}

		public SplinePoint GetPreviousPoint()
		{
			return null;
		}

		public SplinePoint GetNextPoint()
		{
			return null;
		}

		public Vector3 GetLinearTangent(TangentDirection direction)
		{
			return default;
		}

		private void UpdatePosition(Vector3 position)
		{
		}

		private void UpdateTangent(Vector3 value, TangentDirection direction)
		{
		}

		private void UpdateHandleMode(HandleMode mode)
		{
		}

		private void UpdateTangentMode(TangentMode mode, TangentDirection direction)
		{
		}

		internal void RecursivelyAutoSmoothTangents()
		{
		}

		public bool AutoSmoothTangents()
		{
			return false;
		}

		public void AutoSmoothTangentsOnPreviousPoint(SplinePoint recursionOrigin)
		{
		}

		public void AutoSmoothTangentsOnNextPoint(SplinePoint recursionOrigin)
		{
		}
	}
}
