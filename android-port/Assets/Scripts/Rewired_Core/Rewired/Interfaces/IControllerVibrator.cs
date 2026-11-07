using Il2CppDummyDll;

namespace Rewired.Interfaces
{
	[Token(Token = "0x200017C")]
	public interface IControllerVibrator
	{
		[Token(Token = "0x17000379")]
		int vibrationMotorCount
		{
			[Token(Token = "0x6000C4A")]
			get;
		}

		[Token(Token = "0x6000C4B")]
		void SetVibration(int motorIndex, float motorLevel, float duration);

		[Token(Token = "0x6000C4C")]
		void SetVibration(int motorIndex, float motorLevel, float duration, bool stopOtherMotors);

		[Token(Token = "0x6000C4D")]
		void StopVibration();
	}
}
