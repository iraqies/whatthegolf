using System;
using Il2CppDummyDll;

namespace Unity.Notifications.iOS
{
	[Token(Token = "0x200000F")]
	[Flags]
	public enum iOSNotificationCategoryOptions
	{
		[Token(Token = "0x4000044")]
		None = 0,
		[Token(Token = "0x4000045")]
		CustomDismissAction = 1,
		[Token(Token = "0x4000046")]
		AllowInCarPlay = 2,
		[Token(Token = "0x4000047")]
		HiddenPreviewsShowTitle = 4,
		[Token(Token = "0x4000048")]
		HiddenPreviewsShowSubtitle = 8
	}
}
