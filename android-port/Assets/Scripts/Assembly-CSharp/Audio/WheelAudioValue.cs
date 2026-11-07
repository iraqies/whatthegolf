using UnityEngine;

namespace Audio
{
	public class WheelAudioValue : BaseAudioValue
	{
		public enum ListenType
		{
			SteerAngle = 0,
			IsGrounded = 1,
			RPM = 2,
			BrakeTorque = 3,
			MotorTorque = 4,
			SuspensionDistance = 5
		}

		public WheelCollider wheel;

		public ListenType listenType;

		protected override bool Use2D => false;

		private void Update()
		{
		}

		public override string ValueInputName()
		{
			return null;
		}

		protected override void SetValue()
		{
		}
	}
}
