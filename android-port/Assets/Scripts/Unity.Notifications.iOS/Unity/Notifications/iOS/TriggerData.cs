using System.Runtime.InteropServices;

namespace Unity.Notifications.iOS
{
	[StructLayout((LayoutKind)2)]
	internal struct TriggerData
	{
		[FieldOffset(0)]
		public TimeTriggerData timeInterval;

		[FieldOffset(0)]
		public CalendarTriggerData calendar;

		[FieldOffset(0)]
		public LocationTriggerData location;
	}
}
