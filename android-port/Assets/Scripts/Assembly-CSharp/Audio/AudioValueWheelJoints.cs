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

		protected override bool Use2D => true;

		protected override void Initialize()
		{
			wheels = new List<WheelJoint2D>();
			if (wheelContainer != null)
			{
				wheelContainer.GetComponentsInChildren(wheels);
				wheelsJointsFound = wheels.Count;
			}
		}

		private void Update()
		{
			if (wheels != null && wheels.Count > 0)
				SetValue();
		}

		public override string ValueInputName()
		{
			return string.Format("Wheels ({0})", listenType);
		}

		protected override void SetValue()
		{
			if (wheels == null || wheels.Count == 0) return;
			float sum = 0f;
			for (int i = 0; i < wheels.Count; i++)
			{
				var w = wheels[i];
				if (w == null) continue;
				switch (listenType)
				{
				case JointValueListenType.JointSpeed:
					sum += w.jointSpeed;
					break;
				case JointValueListenType.JointTranslation:
					sum += w.jointTranslation;
					break;
				case JointValueListenType.MotorSpeed:
					sum += w.motor.motorSpeed;
					break;
				case JointValueListenType.MotorMaxTorque:
					sum += w.motor.maxMotorTorque;
					break;
				}
			}
			value = sum / wheels.Count;
			base.SetValue();
		}
	}
}
