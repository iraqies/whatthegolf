using UnityEngine;

namespace Cinemachine
{
	public class CinemachineBasicMultiChannelPerlin : CinemachineComponentBase
	{
		public NoiseSettings m_NoiseProfile;

		public Vector3 m_PivotOffset;

		public float m_AmplitudeGain;

		public float m_FrequencyGain;

		private bool mInitialized;

		private float mNoiseTime;

		[SerializeField]
		private Vector3 mNoiseOffsets;

		public override bool IsValid => false;

		public override CinemachineCore.Stage Stage => CinemachineCore.Stage.Body;

		public override void MutateCameraState(ref CameraState curState, float deltaTime)
		{
		}

		public void ReSeed()
		{
		}

		private void Initialize()
		{
		}
	}
}
