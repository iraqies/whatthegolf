using Il2CppDummyDll;

namespace Unity.Notifications.iOS
{
	[Token(Token = "0x2000015")]
	public struct iOSNotificationSettings
	{
		[Token(Token = "0x4000059")]
		[FieldOffset(Offset = "0x0")]
		internal int authorizationStatus;

		[Token(Token = "0x400005A")]
		[FieldOffset(Offset = "0x4")]
		internal int notificationCenterSetting;

		[Token(Token = "0x400005B")]
		[FieldOffset(Offset = "0x8")]
		internal int lockScreenSetting;

		[Token(Token = "0x400005C")]
		[FieldOffset(Offset = "0xC")]
		internal int carPlaySetting;

		[Token(Token = "0x400005D")]
		[FieldOffset(Offset = "0x10")]
		internal int alertSetting;

		[Token(Token = "0x400005E")]
		[FieldOffset(Offset = "0x14")]
		internal int badgeSetting;

		[Token(Token = "0x400005F")]
		[FieldOffset(Offset = "0x18")]
		internal int soundSetting;

		[Token(Token = "0x4000060")]
		[FieldOffset(Offset = "0x1C")]
		internal int alertStyle;

		[Token(Token = "0x4000061")]
		[FieldOffset(Offset = "0x20")]
		internal int showPreviewsSetting;

		[Token(Token = "0x1700001A")]
		public AuthorizationStatus AuthorizationStatus
		{
			[Token(Token = "0x600003E")]
			[Address(RVA = "0x2A442C4", Offset = "0x2A442C4", VA = "0x2A442C4")]
			get
			{
				return default;
			}
		}
	}
}
