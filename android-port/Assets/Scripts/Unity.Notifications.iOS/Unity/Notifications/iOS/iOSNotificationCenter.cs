using System;
using Il2CppDummyDll;

namespace Unity.Notifications.iOS
{
	[Token(Token = "0x2000011")]
	public class iOSNotificationCenter
	{
		[Token(Token = "0x2000012")]
		public delegate void NotificationReceivedCallback(iOSNotification notification);

		[Serializable]
		[Token(Token = "0x2000013")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x1B4EF8", Offset = "0x1B4EF8")]
		private sealed class _003C_003Ec
		{
			[Token(Token = "0x4000052")]
			[FieldOffset(Offset = "0x0")]
			public static readonly _003C_003Ec _003C_003E9;

			[Token(Token = "0x600003B")]
			[Address(RVA = "0x2A46678", Offset = "0x2A46678", VA = "0x2A46678")]
			public _003C_003Ec()
			{
			}

			[Token(Token = "0x600003C")]
			[Address(RVA = "0x2A46680", Offset = "0x2A46680", VA = "0x2A46680")]
			internal void _003C_002Ecctor_003Eb__38_0(iOSNotification _003Cp0_003E)
			{
			}

			[Token(Token = "0x600003D")]
			[Address(RVA = "0x2A46684", Offset = "0x2A46684", VA = "0x2A46684")]
			internal void _003C_002Ecctor_003Eb__38_1(iOSNotification _003Cp0_003E)
			{
			}
		}

		[Token(Token = "0x400004F")]
		[FieldOffset(Offset = "0x0")]
		private static bool s_Initialized;

		[Token(Token = "0x4000050")]
		[FieldOffset(Offset = "0x8")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x1B4FB8", Offset = "0x1B4FB8")]
		private static NotificationReceivedCallback s_OnNotificationReceived;

		[Token(Token = "0x4000051")]
		[FieldOffset(Offset = "0x10")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x1B4FC8", Offset = "0x1B4FC8")]
		private static NotificationReceivedCallback s_OnRemoteNotificationReceived;

		[Token(Token = "0x17000019")]
		public static int ApplicationBadge
		{
			[Token(Token = "0x600002B")]
			[Address(RVA = "0x2A43288", Offset = "0x2A43288", VA = "0x2A43288")]
			set
			{
			}
		}

		[Token(Token = "0x600002C")]
		[Address(RVA = "0x2A43290", Offset = "0x2A43290", VA = "0x2A43290")]
		private static bool Initialize()
		{
			return default;
		}

		[Token(Token = "0x600002D")]
		[Address(RVA = "0x2A433CC", Offset = "0x2A433CC", VA = "0x2A433CC")]
		public static void ScheduleNotification(iOSNotification notification)
		{
		}

		[Token(Token = "0x600002E")]
		[Address(RVA = "0x2A435C8", Offset = "0x2A435C8", VA = "0x2A435C8")]
		public static iOSNotification GetLastRespondedNotification()
		{
			return null;
		}

		[Token(Token = "0x600002F")]
		[Address(RVA = "0x2A4396C", Offset = "0x2A4396C", VA = "0x2A4396C")]
		public static void RemoveDeliveredNotification(string identifier)
		{
		}

		[Token(Token = "0x6000030")]
		[Address(RVA = "0x2A43A10", Offset = "0x2A43A10", VA = "0x2A43A10")]
		public static void RemoveAllScheduledNotifications()
		{
		}

		[Token(Token = "0x6000031")]
		[Address(RVA = "0x2A43A70", Offset = "0x2A43A70", VA = "0x2A43A70")]
		public static void RemoveAllDeliveredNotifications()
		{
		}

		[Token(Token = "0x6000032")]
		[Address(RVA = "0x2A43AD0", Offset = "0x2A43AD0", VA = "0x2A43AD0")]
		public static iOSNotificationSettings GetNotificationSettings()
		{
			return default;
		}

		[Token(Token = "0x6000033")]
		[Address(RVA = "0x2A43AD8", Offset = "0x2A43AD8", VA = "0x2A43AD8")]
		internal static void OnReceivedRemoteNotification(iOSNotificationWithUserInfo data)
		{
		}

		[Token(Token = "0x6000034")]
		[Address(RVA = "0x2A43FA0", Offset = "0x2A43FA0", VA = "0x2A43FA0")]
		internal static void OnSentNotification(iOSNotificationWithUserInfo data)
		{
		}
	}
}
