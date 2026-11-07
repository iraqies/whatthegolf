using Il2CppDummyDll;

namespace Rewired.Interfaces
{
	[Token(Token = "0x2000181")]
	internal interface IAndroidFallbackDS4Helper
	{
		[Token(Token = "0x6000C58")]
		bool IsDS4KeyMapped(int unityJoystickArrayIndex);

		[Token(Token = "0x6000C59")]
		bool IsDS4(string name);
	}
}
