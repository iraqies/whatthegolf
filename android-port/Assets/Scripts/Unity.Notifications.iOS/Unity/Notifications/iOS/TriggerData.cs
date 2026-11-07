using System.Runtime.InteropServices;
using Il2CppDummyDll;

namespace Unity.Notifications.iOS
{
	[StructLayout((LayoutKind)2)]
	[Token(Token = "0x2000009")]
	internal struct TriggerData
	{
		[Token(Token = "0x4000024")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public TimeTriggerData timeInterval;

		[Token(Token = "0x4000025")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public CalendarTriggerData calendar;

		[Token(Token = "0x4000026")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public LocationTriggerData location;
	}
}
