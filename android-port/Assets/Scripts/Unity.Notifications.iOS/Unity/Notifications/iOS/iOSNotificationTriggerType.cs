using Il2CppDummyDll;

namespace Unity.Notifications.iOS
{
	[Token(Token = "0x2000016")]
	public enum iOSNotificationTriggerType
	{
		[Token(Token = "0x4000063")]
		TimeInterval = 0,
		[Token(Token = "0x4000064")]
		Calendar = 10,
		[Token(Token = "0x4000065")]
		Location = 20,
		[Token(Token = "0x4000066")]
		Push = 3,
		[Token(Token = "0x4000067")]
		Unknown = -1
	}
}
