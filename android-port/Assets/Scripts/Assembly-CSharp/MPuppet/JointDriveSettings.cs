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
			this.positionSpring = 0f;
			this.positionDamper = 0f;
			this.maximumForce = 0f;
		}

		public JointDrive GetJointDrive()
		{
			return default;
		}
	}
}
