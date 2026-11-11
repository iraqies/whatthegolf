using System;
using UnityEngine;

namespace UnitySA.Utility
{
	[Serializable]
	public class CurveCtrlBob
	{
		public float HorizontalBobRange = 0.33f;

		public float VerticalBobRange = 0.33f;

		public AnimationCurve Bobcurve = new AnimationCurve(new Keyframe(0f, 0f), new Keyframe(0.5f, 1f), new Keyframe(1f, 0f), new Keyframe(1.5f, -1f), new Keyframe(2f, 0f));

		public float VerticaltoHorizontalRatio = 1f;

		private float m_CyclePositionX;

		private float m_CyclePositionY;

		private float m_BobBaseInterval;

		private Vector3 m_OriginalCameraPosition;

		private float m_Time;

		public void Setup(Camera camera, float bobBaseInterval)
		{
			m_BobBaseInterval = bobBaseInterval;
			if (camera != null)
			{
				m_OriginalCameraPosition = camera.transform.localPosition;
			}
			if (Bobcurve != null && Bobcurve.length > 0)
			{
				m_Time = Bobcurve[Bobcurve.length - 1].time;
			}
			else
			{
				m_Time = 2f;
			}
		}

		public Vector3 DoHeadBob(float speed)
		{
			float evalX = Bobcurve != null && Bobcurve.length > 0 ? Bobcurve.Evaluate(m_CyclePositionX) : 0f;
			float evalY = Bobcurve != null && Bobcurve.length > 0 ? Bobcurve.Evaluate(m_CyclePositionY) : 0f;
			float xPos = m_OriginalCameraPosition.x + evalX * HorizontalBobRange;
			float yPos = m_OriginalCameraPosition.y + evalY * VerticalBobRange;
			float step = speed * Time.deltaTime / Mathf.Max(0.01f, m_BobBaseInterval);
			m_CyclePositionX += step;
			m_CyclePositionY += step * VerticaltoHorizontalRatio;
			if (m_CyclePositionX > m_Time)
			{
				m_CyclePositionX -= m_Time;
			}
			if (m_CyclePositionY > m_Time)
			{
				m_CyclePositionY -= m_Time;
			}
			return new Vector3(xPos, yPos, 0f);
		}
	}
}
