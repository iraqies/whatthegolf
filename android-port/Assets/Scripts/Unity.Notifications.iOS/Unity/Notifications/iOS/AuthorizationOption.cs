using System;
using Il2CppDummyDll;

namespace Unity.Notifications.iOS
{
	[Token(Token = "0x2000002")]
	[Flags]
	public enum AuthorizationOption
	{
		[Token(Token = "0x4000002")]
		Badge = 1,
		[Token(Token = "0x4000003")]
		Sound = 2,
		[Token(Token = "0x4000004")]
		Alert = 4,
		[Token(Token = "0x4000005")]
		CarPlay = 8,
		[Token(Token = "0x4000006")]
		CriticalAlert = 0x10,
		[Token(Token = "0x4000007")]
		ProvidesAppNotificationSettings = 0x20,
		[Token(Token = "0x4000008")]
		Provisional = 0x40
	}
}
