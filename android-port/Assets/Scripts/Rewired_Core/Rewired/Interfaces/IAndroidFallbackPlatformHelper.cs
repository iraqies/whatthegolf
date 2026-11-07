using System;
using Il2CppDummyDll;

namespace Rewired.Interfaces
{
	[Token(Token = "0x2000182")]
	internal interface IAndroidFallbackPlatformHelper
	{
		[Token(Token = "0x1700037A")]
		IAndroidFallbackDS4Helper ds4Helper
		{
			[Token(Token = "0x6000C5C")]
			get;
		}

		[Token(Token = "0x1400001D")]
		event Action DeviceChangedEvent;

		[Token(Token = "0x6000C5D")]
		string GetUniqueDeviceIdentifier(string unityJoystickName, int unityArrayIndex);
	}
}
