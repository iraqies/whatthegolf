using UnityEngine;

namespace Cinemachine
{
	[ExecuteAlways]
	public class CinemachineImpulseListener : CinemachineExtension
	{
		public int m_ChannelMask;

		public float m_Gain;

		public bool m_Use2DDistance;

		protected override void PostPipelineStageCallback(CinemachineVirtualCameraBase vcam, CinemachineCore.Stage stage, ref CameraState state, float deltaTime)
		{
		}
	}
}
