using System;
using Il2CppDummyDll;

namespace Unity.Notifications.iOS
{
	[Token(Token = "0x200000C")]
	[Flags]
	public enum iOSNotificationActionOptions
	{
		[Token(Token = "0x400003A")]
		None = 0,
		[Token(Token = "0x400003B")]
		Required = 1,
		[Token(Token = "0x400003C")]
		Destructive = 2,
		[Token(Token = "0x400003D")]
		Foreground = 4
	}
}
