using System;

namespace Rewired.Interfaces
{
	internal interface IAndroidFallbackPlatformHelper
	{
		IAndroidFallbackDS4Helper ds4Helper { get; }

		event Action DeviceChangedEvent;

		string GetUniqueDeviceIdentifier(string unityJoystickName, int unityArrayIndex);
	}
}
