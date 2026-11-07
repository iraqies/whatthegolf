using UnityEngine;

namespace Cinemachine
{
	[ExecuteAlways]
	public class CinemachineFollowZoom : CinemachineExtension
	{
		private class VcamExtraState
		{
			public float m_previousFrameZoom;
		}

		public float m_Width;

		public float m_Damping;

		public float m_MinFOV;

		public float m_MaxFOV;

		private void OnValidate()
		{
		}

		protected override void PostPipelineStageCallback(CinemachineVirtualCameraBase vcam, CinemachineCore.Stage stage, ref CameraState state, float deltaTime)
		{
		}
	}
}
