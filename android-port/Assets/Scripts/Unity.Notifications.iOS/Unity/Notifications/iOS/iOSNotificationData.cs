using System;
using Il2CppDummyDll;

namespace Unity.Notifications.iOS
{
	[Token(Token = "0x200000A")]
	internal struct iOSNotificationData
	{
		[Token(Token = "0x4000027")]
		[FieldOffset(Offset = "0x0")]
		public string identifier;

		[Token(Token = "0x4000028")]
		[FieldOffset(Offset = "0x8")]
		public string title;

		[Token(Token = "0x4000029")]
		[FieldOffset(Offset = "0x10")]
		public string body;

		[Token(Token = "0x400002A")]
		[FieldOffset(Offset = "0x18")]
		public int badge;

		[Token(Token = "0x400002B")]
		[FieldOffset(Offset = "0x20")]
		public string subtitle;

		[Token(Token = "0x400002C")]
		[FieldOffset(Offset = "0x28")]
		public string categoryIdentifier;

		[Token(Token = "0x400002D")]
		[FieldOffset(Offset = "0x30")]
		public string threadIdentifier;

		[Token(Token = "0x400002E")]
		[FieldOffset(Offset = "0x38")]
		public int soundType;

		[Token(Token = "0x400002F")]
		[FieldOffset(Offset = "0x3C")]
		public float soundVolume;

		[Token(Token = "0x4000030")]
		[FieldOffset(Offset = "0x40")]
		public string soundName;

		[Token(Token = "0x4000031")]
		[FieldOffset(Offset = "0x48")]
		public IntPtr userInfo;

		[Token(Token = "0x4000032")]
		[FieldOffset(Offset = "0x50")]
		public IntPtr attachments;

		[Token(Token = "0x4000033")]
		[FieldOffset(Offset = "0x58")]
		public int triggerType;

		[Token(Token = "0x4000034")]
		[FieldOffset(Offset = "0x60")]
		public TriggerData trigger;
	}
}
