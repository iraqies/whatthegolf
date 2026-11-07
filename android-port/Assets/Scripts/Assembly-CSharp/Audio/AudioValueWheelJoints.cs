using System.Collections.Generic;
using UnityEngine;

namespace Audio
{
	public class AudioValueWheelJoints : BaseAudioValue
	{
		public enum JointValueListenType
		{
			JointSpeed = 0,
			JointTranslation = 1,
			MotorSpeed = 2,
			MotorMaxTorque = 3
		}

		public GameObject wheelContainer;

		public JointValueListenType listenType;

		public int wheelsJointsFound;

		private List<WheelJoint2D> wheels;

		protected override bool Use2D => false;

		protected override void Initialize()
		{
		}

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
