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

		protected override bool Use2D => component3D == null;

		private void Update()
		{
			if (component2D == null && component3D == null)
				return;
			SetValue();
		}

		protected override void SetValue()
		{
			switch (listenType)
			{
			case SpringJointValueListenType.SPRING:
			case SpringJointValueListenType.SPRING_DELTA:
				value = (!Use2D && component3D != null) ? component3D.spring : (component2D != null ? component2D.frequency : 0f);
				break;
			case SpringJointValueListenType.CURRENT_FORCE:
				value = (!Use2D && component3D != null) ? component3D.currentForce.magnitude : 0f;
				break;
			case SpringJointValueListenType.CURRENT_TORQUE:
				value = (!Use2D && component3D != null) ? component3D.currentTorque.magnitude : 0f;
				break;
			}
			base.SetValue();
		}
	}
}
