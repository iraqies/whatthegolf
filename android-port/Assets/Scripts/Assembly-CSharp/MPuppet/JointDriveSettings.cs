using System;
using UnityEngine;

namespace MPuppet
{
	[Serializable]
	public struct JointDriveSettings
	{
		public float positionSpring;

		public float positionDamper;

		public float maximumForce;

		public JointDriveSettings(float positionSpring, float positionDamper, float maximumForce)
		{
			this.positionSpring = positionSpring;
			this.positionDamper = positionDamper;
			this.maximumForce = maximumForce;
		}

		public JointDrive GetJointDrive()
		{
			return new JointDrive
			{
				positionSpring = positionSpring,
				positionDamper = positionDamper,
				maximumForce = maximumForce
			};
		}
	}
}
