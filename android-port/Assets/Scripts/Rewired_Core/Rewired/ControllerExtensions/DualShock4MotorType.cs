using Il2CppDummyDll;

namespace Rewired.ControllerExtensions
{
	[Token(Token = "0x20002BB")]
	public enum DualShock4MotorType
	{
		[Token(Token = "0x4000E7A")]
		LeftMotor = 0,
		[Token(Token = "0x4000E7B")]
		StrongMotor = LeftMotor,
		[Token(Token = "0x4000E7C")]
		RightMotor = 1,
		[Token(Token = "0x4000E7D")]
		WeakMotor = RightMotor
	}
}
