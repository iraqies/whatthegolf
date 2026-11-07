using Il2CppDummyDll;
using UnityEngine;

namespace Rewired.Drivers.Interfaces
{
	[Token(Token = "0x2000170")]
	internal interface IDriver_DualShock4
	{
		[Token(Token = "0x17000356")]
		float LeftMotor
		{
			[Token(Token = "0x6000C12")]
			set;
		}

		[Token(Token = "0x17000357")]
		float RightMotor
		{
			[Token(Token = "0x6000C13")]
			set;
		}

		[Token(Token = "0x17000358")]
		float LightColorR
		{
			[Token(Token = "0x6000C14")]
			set;
		}

		[Token(Token = "0x17000359")]
		float LightColorG
		{
			[Token(Token = "0x6000C15")]
			set;
		}

		[Token(Token = "0x1700035A")]
		float LightColorB
		{
			[Token(Token = "0x6000C16")]
			set;
		}

		[Token(Token = "0x1700035B")]
		float LightFlashOnDuration
		{
			[Token(Token = "0x6000C17")]
			set;
		}

		[Token(Token = "0x1700035C")]
		float LightFlashOffDuration
		{
			[Token(Token = "0x6000C18")]
			set;
		}

		[Token(Token = "0x1700035D")]
		Vector3 AccelerometerValue
		{
			[Token(Token = "0x6000C19")]
			get;
		}

		[Token(Token = "0x1700035E")]
		Quaternion Orientation
		{
			[Token(Token = "0x6000C1A")]
			get;
		}

		[Token(Token = "0x1700035F")]
		int MaxTouches
		{
			[Token(Token = "0x6000C1C")]
			get;
		}

		[Token(Token = "0x6000C1B")]
		void ResetOrientation();

		[Token(Token = "0x6000C1D")]
		bool IsTouchingAtTouchId(int touchId);

		[Token(Token = "0x6000C1E")]
		bool IsTouchingAtIndex(int index);

		[Token(Token = "0x6000C1F")]
		int GetTouchIdAtIndex(int index);

		[Token(Token = "0x6000C20")]
		bool GetTouchPositionByIndex(int index, out Vector2 position);

		[Token(Token = "0x6000C21")]
		void StopLightFlash();

		[Token(Token = "0x6000C22")]
		void StopVibration();
	}
}
