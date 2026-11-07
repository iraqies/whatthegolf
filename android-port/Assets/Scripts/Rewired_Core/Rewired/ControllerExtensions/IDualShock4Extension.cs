using Rewired.Interfaces;
using UnityEngine;

namespace Rewired.ControllerExtensions
{
	public interface IDualShock4Extension : IControllerVibrator
	{
		int maxTouches { get; }

		Vector3 GetAccelerometerValue();

		Quaternion GetOrientation();

		void ResetOrientation();

		void SetLightColor(Color color);

		int GetTouchId(int index);

		bool GetTouchPosition(int index, out Vector2 position);

		bool IsTouching(int index);

		bool IsTouchingByTouchId(int touchId);
	}
}
