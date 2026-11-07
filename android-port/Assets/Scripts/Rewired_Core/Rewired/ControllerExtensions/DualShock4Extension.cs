using Rewired.Drivers.Interfaces;
using Rewired.Interfaces;
using Rewired.Utils.Classes.Utility;
using UnityEngine;

namespace Rewired.ControllerExtensions
{
	public sealed class DualShock4Extension : Controller.Extension, IControllerVibrator, IDualShock4Extension
	{
		private class zGbxhXXgFWMcqcJRuIauEwjeRofV : IControllerExtensionSource
		{
			public readonly IDriver_DualShock4 UVnyPZOPqXebrkDwGURsMwQhOdVT;

			public readonly bool BMKmLgTjByiExXMvsepaerGfBiXH;

			public readonly int IvQuNSqDypWdalUGYcleYiqEVPmd;
		}

		private zGbxhXXgFWMcqcJRuIauEwjeRofV eyyVWBZaxsCJCQMmwhCWcagfYfzWA;

		private bool OfwbAYIoZdGfvbuKLWzFcjGDPogfc;

		private TimerAbs[] IfVBCqaFujeIzJMUNQBcBKnduRXLA;

		public int vibrationMotorCount => 0;

		public int maxTouches => 0;

		private DualShock4Extension(DualShock4Extension P_0)
			: base((IControllerExtensionSource)null)
		{
		}

		public void SetVibration(int motorIndex, float motorLevel, float duration)
		{
		}

		public void SetVibration(int motorIndex, float motorLevel, bool stopOtherMotors)
		{
		}

		public void SetVibration(int motorIndex, float motorLevel, float duration, bool stopOtherMotors)
		{
		}

		public void StopVibration()
		{
		}

		public void SetVibration(DualShock4MotorType motor, float motorLevel, float duration, bool stopOtherMotors)
		{
		}

		public void SetLightColor(Color color)
		{
		}

		public void SetLightFlash(float onDuration, float offDuration)
		{
		}

		public void StopLightFlash()
		{
		}

		public Vector3 GetAccelerometerValue()
		{
			return default;
		}

		public Quaternion GetOrientation()
		{
			return default;
		}

		public void ResetOrientation()
		{
		}

		public int GetTouchId(int index)
		{
			return 0;
		}

		public bool GetTouchPosition(int index, out Vector2 position)
		{
			position = default;
			return false;
		}

		public bool IsTouching(int index)
		{
			return false;
		}

		public bool IsTouchingByTouchId(int touchId)
		{
			return false;
		}

		internal override void UpdateData(UpdateLoopType P_0)
		{
		}

		internal override void SourceUpdated(IControllerExtensionSource P_0)
		{
		}

		internal override Controller.Extension Clone()
		{
			return null;
		}

		private void RkjJWtCPffqNHKYZiSpumVKUPDFy()
		{
		}

		private void uLJgIUZWcYRvIJfnwylMTtjINIBA(DualShock4MotorType P_0, float P_1, float P_2)
		{
		}
	}
}
