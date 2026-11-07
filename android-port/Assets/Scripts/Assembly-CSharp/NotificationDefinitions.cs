using System;
using System.Collections.Generic;
using System.Linq;
using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x2000CB2")]
public class NotificationDefinitions : MonoBehaviour
{
	[Token(Token = "0x2000CB3")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x44378", Offset = "0x44378")]
	private sealed class _003C_003Ec__DisplayClass7_0
	{
		[Token(Token = "0x4004534")]
		[FieldOffset(Offset = "0x10")]
		public string notificationId;

		[Token(Token = "0x6003BF8")]
		[Address(RVA = "0x18086F4", Offset = "0x18086F4", VA = "0x18086F4")]
		public _003C_003Ec__DisplayClass7_0()
		{
		}

		[Token(Token = "0x6003BF9")]
		[Address(RVA = "0x18086FC", Offset = "0x18086FC", VA = "0x18086FC")]
		internal bool _003CTryGetNotifications_003Eb__0(WTGNotification l)
		{
			return default;
		}
	}

	[Token(Token = "0x2000CB4")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x44388", Offset = "0x44388")]
	private sealed class _003C_003Ec__DisplayClass7_1
	{
		[Token(Token = "0x4004535")]
		[FieldOffset(Offset = "0x10")]
		public WTGNotification notification;

		[Token(Token = "0x6003BFA")]
		[Address(RVA = "0x1808710", Offset = "0x1808710", VA = "0x1808710")]
		public _003C_003Ec__DisplayClass7_1()
		{
		}

		[Token(Token = "0x6003BFB")]
		[Address(RVA = "0x1808718", Offset = "0x1808718", VA = "0x1808718")]
		internal bool _003CTryGetNotifications_003Eb__1(WTGNotification n)
		{
			return default;
		}
	}

	[Serializable]
	[Token(Token = "0x2000CB5")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x44398", Offset = "0x44398")]
	private sealed class _003C_003Ec
	{
		[Token(Token = "0x4004536")]
		[FieldOffset(Offset = "0x0")]
		public static readonly _003C_003Ec _003C_003E9;

		[Token(Token = "0x4004537")]
		[FieldOffset(Offset = "0x8")]
		public static Func<UserCriteria, bool> _003C_003E9__8_0;

		[Token(Token = "0x4004538")]
		[FieldOffset(Offset = "0x10")]
		public static Func<UserCriteria, bool> _003C_003E9__8_1;

		[Token(Token = "0x4004539")]
		[FieldOffset(Offset = "0x18")]
		public static Func<WTGNotification, bool> _003C_003E9__9_0;

		[Token(Token = "0x400453A")]
		[FieldOffset(Offset = "0x20")]
		public static Func<WTGNotification, string> _003C_003E9__9_1;

		[Token(Token = "0x400453B")]
		[FieldOffset(Offset = "0x28")]
		public static Func<WTGNotification, WTGNotification> _003C_003E9__9_2;

		[Token(Token = "0x400453C")]
		[FieldOffset(Offset = "0x30")]
		public static Func<IGrouping<string, WTGNotification>, WTGNotification> _003C_003E9__9_3;

		[Token(Token = "0x6003BFD")]
		[Address(RVA = "0x180852C", Offset = "0x180852C", VA = "0x180852C")]
		public _003C_003Ec()
		{
		}

		[Token(Token = "0x6003BFE")]
		[Address(RVA = "0x1808534", Offset = "0x1808534", VA = "0x1808534")]
		internal bool _003CCanEnableDailyNotifications_003Eb__8_0(UserCriteria c)
		{
			return default;
		}

		[Token(Token = "0x6003BFF")]
		[Address(RVA = "0x18085A4", Offset = "0x18085A4", VA = "0x18085A4")]
		internal bool _003CCanEnableDailyNotifications_003Eb__8_1(UserCriteria c)
		{
			return default;
		}

		[Token(Token = "0x6003C00")]
		[Address(RVA = "0x180860C", Offset = "0x180860C", VA = "0x180860C")]
		internal bool _003CGetAllLocalNotifications_003Eb__9_0(WTGNotification x)
		{
			return default;
		}

		[Token(Token = "0x6003C01")]
		[Address(RVA = "0x180866C", Offset = "0x180866C", VA = "0x180866C")]
		internal string _003CGetAllLocalNotifications_003Eb__9_1(WTGNotification key)
		{
			return null;
		}

		[Token(Token = "0x6003C02")]
		[Address(RVA = "0x1808674", Offset = "0x1808674", VA = "0x1808674")]
		internal WTGNotification _003CGetAllLocalNotifications_003Eb__9_2(WTGNotification val)
		{
			return default;
		}

		[Token(Token = "0x6003C03")]
		[Address(RVA = "0x1808698", Offset = "0x1808698", VA = "0x1808698")]
		internal WTGNotification _003CGetAllLocalNotifications_003Eb__9_3(IGrouping<string, WTGNotification> x)
		{
			return default;
		}
	}

	[Token(Token = "0x4004531")]
	[FieldOffset(Offset = "0x18")]
	[SerializeField]
	private List<UserCriteria> DailyChallengeNotificationCriteria;

	[Token(Token = "0x4004532")]
	[FieldOffset(Offset = "0x20")]
	private Dictionary<OverworldButton2D, List<OverworldButton2D>> nextDoorsDictionary;

	[Token(Token = "0x4004533")]
	[FieldOffset(Offset = "0x28")]
	private WTGNotificationsManager manager;

	[Token(Token = "0x17000617")]
	private WTGNotificationsManager Manager
	{
		[Token(Token = "0x6003BF2")]
		[Address(RVA = "0x158E8EC", Offset = "0x158E8EC", VA = "0x158E8EC")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000618")]
	private List<WTGNotification> Notifications
	{
		[Token(Token = "0x6003BF3")]
		[Address(RVA = "0x158E96C", Offset = "0x158E96C", VA = "0x158E96C")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x6003BF4")]
	[Address(RVA = "0x158E9C0", Offset = "0x158E9C0", VA = "0x158E9C0")]
	private bool TryGetNotifications(ref List<WTGNotification> notifications)
	{
		return default;
	}

	[Token(Token = "0x6003BF5")]
	[Address(RVA = "0x158F1F4", Offset = "0x158F1F4", VA = "0x158F1F4")]
	public bool CanEnableDailyNotifications()
	{
		return default;
	}

	[Token(Token = "0x6003BF6")]
	[Address(RVA = "0x158F404", Offset = "0x158F404", VA = "0x158F404")]
	public List<WTGNotification> GetAllLocalNotifications()
	{
		return null;
	}

	[Token(Token = "0x6003BF7")]
	[Address(RVA = "0x158F860", Offset = "0x158F860", VA = "0x158F860")]
	public NotificationDefinitions()
	{
	}
}
