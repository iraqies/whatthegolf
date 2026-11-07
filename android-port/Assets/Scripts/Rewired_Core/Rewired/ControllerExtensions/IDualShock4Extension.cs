using Il2CppDummyDll;
using Rewired.Interfaces;
using UnityEngine;

namespace Rewired.ControllerExtensions
{
	[Token(Token = "0x20002B8")]
	public interface IDualShock4Extension : IControllerVibrator
	{
		[Token(Token = "0x17000562")]
		int maxTouches
		{
			[Token(Token = "0x60013C1")]
			get;
		}

		[Token(Token = "0x60013BD")]
		Vector3 GetAccelerometerValue();

		[Token(Token = "0x60013BE")]
		Quaternion GetOrientation();

		[Token(Token = "0x60013BF")]
		void ResetOrientation();

		[Token(Token = "0x60013C0")]
		void SetLightColor(Color color);

		[Token(Token = "0x60013C2")]
		int GetTouchId(int index);

		[Token(Token = "0x60013C3")]
		bool GetTouchPosition(int index, out Vector2 position);

		[Token(Token = "0x60013C4")]
		bool IsTouching(int index);

		[Token(Token = "0x60013C5")]
		bool IsTouchingByTouchId(int touchId);
	}
}
