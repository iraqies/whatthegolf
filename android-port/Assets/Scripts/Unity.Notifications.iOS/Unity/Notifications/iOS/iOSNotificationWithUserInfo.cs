using System.Collections.Generic;
using Il2CppDummyDll;

namespace Unity.Notifications.iOS
{
	[Token(Token = "0x200001B")]
	internal struct iOSNotificationWithUserInfo
	{
		[Token(Token = "0x4000078")]
		[FieldOffset(Offset = "0x0")]
		internal iOSNotificationData data;

		[Token(Token = "0x4000079")]
		[FieldOffset(Offset = "0x80")]
		internal Dictionary<string, string> userInfo;

		[Token(Token = "0x400007A")]
		[FieldOffset(Offset = "0x88")]
		internal List<iOSNotificationAttachment> attachments;
	}
}
