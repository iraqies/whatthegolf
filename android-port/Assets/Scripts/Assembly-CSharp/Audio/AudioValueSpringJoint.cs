using UnityEngine;

namespace Audio
{
	public class AudioValueSpringJoint : BaseAudioValue
	{
		public enum SpringJointValueListenType
		{
			SPRING = 0,
			SPRING_DELTA = 1,
			CURRENT_FORCE = 2,
			CURRENT_TORQUE = 3
		}

		public SpringJoint component3D;

		public SpringJoint2D component2D;

		public SpringJointValueListenType listenType;

		protected override bool Use2D => false;

		private void Update()
		{
		}

		protected override void SetValue()
		{
		}
	}
}
