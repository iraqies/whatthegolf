using System.Collections.Generic;
using UnityEngine;

namespace Cinemachine
{
	[ExecuteAlways]
	public class CinemachineConfiner : CinemachineExtension
	{
		public enum Mode
		{
			Confine2D = 0,
			Confine3D = 1
		}

		private class VcamExtraState
		{
			public Vector3 m_previousDisplacement;

			public float confinerDisplacement;
		}

		public Mode m_ConfineMode;

		public Collider m_BoundingVolume;

		public Collider2D m_BoundingShape2D;

		public bool m_ConfineScreenEdges;

		public float m_Damping;

		private List<List<Vector2>> m_pathCache;

		private int m_pathTotalPointCount;

		public bool IsValid => false;

		public bool CameraWasDisplaced(CinemachineVirtualCameraBase vcam)
		{
			return false;
		}

		private void OnValidate()
		{
		}

		protected override void PostPipelineStageCallback(CinemachineVirtualCameraBase vcam, CinemachineCore.Stage stage, ref CameraState state, float deltaTime)
		{
		}

		public void InvalidatePathCache()
		{
		}

		private bool ValidatePathCache()
		{
			return false;
		}

		private Vector3 ConfinePoint(Vector3 camPos)
		{
			return default;
		}

		private Vector3 ConfineScreenEdges(CinemachineVirtualCameraBase vcam, ref CameraState state)
		{
			return default;
		}
	}
}
