using UnityEngine;

namespace Cinemachine
{
	public class CinemachineSameAsFollowTarget : CinemachineComponentBase
	{
		public float m_Damping;

		private Quaternion m_PreviousReferenceOrientation;

		public override bool IsValid => false;

		public override CinemachineCore.Stage Stage => CinemachineCore.Stage.Body;

		public override void MutateCameraState(ref CameraState curState, float deltaTime)
		{
		}
	}
}
