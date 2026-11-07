using UnityEngine;

public static class EPlatformTypeExtensions
{
	public static EPlatformType GetCurrentRuntimePlatform()
	{
		switch (Application.platform)
		{
			case RuntimePlatform.Android:
				return EPlatformType.Android;
			case RuntimePlatform.IPhonePlayer:
				return (SystemInfo.deviceModel ?? string.Empty).ToLowerInvariant().Contains("ipad")
					? EPlatformType.iPad
					: EPlatformType.iPhone;
			case RuntimePlatform.tvOS:
				return EPlatformType.tvOS;
			case RuntimePlatform.Switch:
				return EPlatformType.Switch;
			case RuntimePlatform.PS4:
				return EPlatformType.PS4;
			case RuntimePlatform.PS5:
				return EPlatformType.PS5;
			case RuntimePlatform.XboxOne:
				return EPlatformType.XboxOne;
			case RuntimePlatform.OSXPlayer:
			case RuntimePlatform.OSXEditor:
				return EPlatformType.macOS;
			case RuntimePlatform.LinuxPlayer:
			case RuntimePlatform.LinuxEditor:
				return EPlatformType.Linux;
			default:
				return EPlatformType.Android;
		}
	}
}
