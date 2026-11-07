using UnityEngine;

namespace Cinemachine
{
	public class CinemachineHardLockToTarget : CinemachineComponentBase
	{
		public float m_Damping;

		private Vector3 m_PreviousTargetPosition;

		public override bool IsValid => false;

		public override CinemachineCore.Stage Stage => CinemachineCore.Stage.Body;

		public override void MutateCameraState(ref CameraState curState, float deltaTime)
		{
		}
	}
}
