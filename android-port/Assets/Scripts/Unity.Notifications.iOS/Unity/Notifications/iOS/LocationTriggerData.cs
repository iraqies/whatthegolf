using Il2CppDummyDll;

namespace Unity.Notifications.iOS
{
	[Token(Token = "0x2000008")]
	internal struct LocationTriggerData
	{
		[Token(Token = "0x400001E")]
		[FieldOffset(Offset = "0x0")]
		public double latitude;

		[Token(Token = "0x400001F")]
		[FieldOffset(Offset = "0x8")]
		public double longitude;

		[Token(Token = "0x4000020")]
		[FieldOffset(Offset = "0x10")]
		public float radius;

		[Token(Token = "0x4000021")]
		[FieldOffset(Offset = "0x14")]
		public byte notifyOnEntry;

		[Token(Token = "0x4000022")]
		[FieldOffset(Offset = "0x15")]
		public byte notifyOnExit;

		[Token(Token = "0x4000023")]
		[FieldOffset(Offset = "0x16")]
		public byte repeats;
	}
}
