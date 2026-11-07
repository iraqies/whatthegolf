using Il2CppDummyDll;

namespace Unity.Notifications.iOS
{
	[Token(Token = "0x2000007")]
	internal struct CalendarTriggerData
	{
		[Token(Token = "0x4000017")]
		[FieldOffset(Offset = "0x0")]
		public int year;

		[Token(Token = "0x4000018")]
		[FieldOffset(Offset = "0x4")]
		public int month;

		[Token(Token = "0x4000019")]
		[FieldOffset(Offset = "0x8")]
		public int day;

		[Token(Token = "0x400001A")]
		[FieldOffset(Offset = "0xC")]
		public int hour;

		[Token(Token = "0x400001B")]
		[FieldOffset(Offset = "0x10")]
		public int minute;

		[Token(Token = "0x400001C")]
		[FieldOffset(Offset = "0x14")]
		public int second;

		[Token(Token = "0x400001D")]
		[FieldOffset(Offset = "0x18")]
		public byte repeats;
	}
}
