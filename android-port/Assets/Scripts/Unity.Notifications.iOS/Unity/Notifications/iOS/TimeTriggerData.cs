using Il2CppDummyDll;

namespace Unity.Notifications.iOS
{
	[Token(Token = "0x2000006")]
	internal struct TimeTriggerData
	{
		[Token(Token = "0x4000015")]
		[FieldOffset(Offset = "0x0")]
		public int interval;

		[Token(Token = "0x4000016")]
		[FieldOffset(Offset = "0x4")]
		public byte repeats;
	}
}
