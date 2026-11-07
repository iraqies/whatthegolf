using UnityEngine;

namespace Cinemachine
{
	public class CinemachinePOV : CinemachineComponentBase
	{
		public enum RecenterTargetMode
		{
			None = 0,
			FollowTargetForward = 1,
			LookAtTargetForward = 2
		}

		public bool m_ApplyBeforeBody;

		public RecenterTargetMode m_RecenterTarget;

		public AxisState m_VerticalAxis;

		public AxisState.Recentering m_VerticalRecentering;

		public AxisState m_HorizontalAxis;

		public AxisState.Recentering m_HorizontalRecentering;

		public override bool IsValid => false;

		public override CinemachineCore.Stage Stage => CinemachineCore.Stage.Body;

		private void OnValidate()
		{
		}

		public override void PrePipelineMutateCameraState(ref CameraState curState, float deltaTime)
		{
		}

		public override void MutateCameraState(ref CameraState curState, float deltaTime)
		{
		}

		private void ApplyPOV(ref CameraState curState, float deltaTime)
		{
		}

		public Vector2 GetRecenterTarget()
		{
			return default;
		}

		public override bool OnTransitionFromCamera(ICinemachineCamera fromCam, Vector3 worldUp, float deltaTime, ref CinemachineVirtualCameraBase.TransitionParams transitionParams)
		{
			return false;
		}
	}
}
