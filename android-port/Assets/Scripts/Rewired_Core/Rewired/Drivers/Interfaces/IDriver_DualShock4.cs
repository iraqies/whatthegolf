using UnityEngine;

namespace Rewired.Drivers.Interfaces
{
	internal interface IDriver_DualShock4
	{
		float LeftMotor { set; }

		float RightMotor { set; }

		float LightColorR { set; }

		float LightColorG { set; }

		float LightColorB { set; }

		float LightFlashOnDuration { set; }

		float LightFlashOffDuration { set; }

		Vector3 AccelerometerValue { get; }

		Quaternion Orientation { get; }

		int MaxTouches { get; }

		void ResetOrientation();

		bool IsTouchingAtTouchId(int touchId);

		bool IsTouchingAtIndex(int index);

		int GetTouchIdAtIndex(int index);

		bool GetTouchPositionByIndex(int index, out Vector2 position);

		void StopLightFlash();

		void StopVibration();
	}
}
