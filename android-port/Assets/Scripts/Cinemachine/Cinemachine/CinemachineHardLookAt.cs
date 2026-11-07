namespace Cinemachine
{
	public class CinemachineHardLookAt : CinemachineComponentBase
	{
		public override bool IsValid => false;

		public override CinemachineCore.Stage Stage => CinemachineCore.Stage.Body;

		public override void MutateCameraState(ref CameraState curState, float deltaTime)
		{
		}
	}
}
