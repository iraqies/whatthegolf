using UnityEngine;

namespace GolfGames.Pinball
{
	public class PinballFlipper : MonoBehaviour
	{
		[SerializeField]
		public PinballFlipperType Type;

		[SerializeField]
		public HingeJoint2D Joint;

		public float startMotorSpeed;

		private void Start()
		{
			if (Joint != null)
			{
				startMotorSpeed = Joint.motor.motorSpeed;
			}
		}

		public void Toggle(bool isFlipped)
		{
			if (Joint != null)
			{
				JointMotor2D motor = Joint.motor;
				motor.motorSpeed = isFlipped ? (-startMotorSpeed) : startMotorSpeed;
				Joint.motor = motor;
			}
		}
	}
}
