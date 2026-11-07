using UnityEngine;

namespace Cinemachine.Utility
{
	public class PositionPredictor
	{
		private Vector3 m_Position;

		private GaussianWindow1D_Vector3 m_Velocity;

		private GaussianWindow1D_Vector3 m_Accel;

		private float mLastVelAddedTime;

		private const float kSmoothingDefault = 10f;

		private float mSmoothing;

		public float Smoothing
		{
			set
			{
			}
		}

		public bool IsEmpty => false;

		public void ApplyTransformDelta(Vector3 positionDelta)
		{
		}

		public void Reset()
		{
		}

		public void AddPosition(Vector3 pos, float deltaTime, float lookaheadTime)
		{
		}

		public Vector3 PredictPositionDelta(float lookaheadTime)
		{
			return default;
		}
	}
}
