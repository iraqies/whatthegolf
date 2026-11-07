using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Il2CppDummyDll;
using Unity.Notifications.iOS;
using UnityEngine;
using UnityEngine.Events;

[Token(Token = "0x2000CBE")]
public class WTGNotificationsManager : WTGSingleton<WTGNotificationsManager>
{
	[Serializable]
	[Token(Token = "0x2000CBF")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x443D8", Offset = "0x443D8")]
	private sealed class _003C_003Ec
	{
		[Token(Token = "0x400455E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static readonly _003C_003Ec _003C_003E9;

		[Token(Token = "0x400455F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public static Func<bool> _003C_003E9__29_0;

		[Token(Token = "0x6003C53")]
		[Address(RVA = "0x18759C0", Offset = "0x18759C0", VA = "0x18759C0")]
		public _003C_003Ec()
		{
		}

		[Token(Token = "0x6003C54")]
		[Address(RVA = "0x18759C8", Offset = "0x18759C8", VA = "0x18759C8")]
		internal bool _003CResetAsync_003Eb__29_0()
		{
			return default;
		}
	}

	[Token(Token = "0x2000CC0")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x443E8", Offset = "0x443E8")]
	private sealed class _003CResetAsync_003Ed__29 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x4004560")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int _003C_003E1__state;

		[Token(Token = "0x4004561")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object _003C_003E2__current;

		[Token(Token = "0x4004562")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public int saveslot;

		[Token(Token = "0x1700062B")]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002ECurrent
		{
			[Token(Token = "0x6003C58")]
			[Address(RVA = "0x1875D2C", Offset = "0x1875D2C", VA = "0x1875D2C", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002Eget_Current();
			}
		}

		[Token(Token = "0x1700062C")]
		private object System_002ECollections_002EIEnumerator_002ECurrent
		{
			[Token(Token = "0x6003C5A")]
			[Address(RVA = "0x1875D74", Offset = "0x1875D74", VA = "0x1875D74", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return System_002ECollections_002EIEnumerator_002Eget_Current();
			}
		}

		[Token(Token = "0x6003C55")]
		[Address(RVA = "0x1875B34", Offset = "0x1875B34", VA = "0x1875B34")]
		[DebuggerHidden]
		public _003CResetAsync_003Ed__29(int _003C_003E1__state)
		{
		}

		[Token(Token = "0x6003C56")]
		[Address(RVA = "0x1875B60", Offset = "0x1875B60", VA = "0x1875B60", Slot = "5")]
		[DebuggerHidden]
		private void System_002EIDisposable_002EDispose()
		{
		}

		[Token(Token = "0x6003C57")]
		[Address(RVA = "0x1875B64", Offset = "0x1875B64", VA = "0x1875B64", Slot = "6")]
		private bool MoveNext()
		{
			return default;
		}

		[Token(Token = "0x6003C58")]
		[Address(RVA = "0x1875D2C", Offset = "0x1875D2C", VA = "0x1875D2C", Slot = "4")]
		[DebuggerHidden]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002Eget_Current()
		{
			return null;
		}

		[Token(Token = "0x6003C59")]
		[Address(RVA = "0x1875D34", Offset = "0x1875D34", VA = "0x1875D34", Slot = "8")]
		[DebuggerHidden]
		private void System_002ECollections_002EIEnumerator_002EReset()
		{
		}

		[Token(Token = "0x6003C5A")]
		[Address(RVA = "0x1875D74", Offset = "0x1875D74", VA = "0x1875D74", Slot = "7")]
		[DebuggerHidden]
		private object System_002ECollections_002EIEnumerator_002Eget_Current()
		{
			return null;
		}
	}

	[Token(Token = "0x2000CC1")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x443F8", Offset = "0x443F8")]
	private sealed class _003C_003Ec__DisplayClass42_0
	{
		[Token(Token = "0x4004563")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public bool shouldEnable;

		[Token(Token = "0x4004564")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x11")]
		public bool askingDone;

		[Token(Token = "0x6003C5B")]
		[Address(RVA = "0x1875A64", Offset = "0x1875A64", VA = "0x1875A64")]
		public _003C_003Ec__DisplayClass42_0()
		{
		}

		[Token(Token = "0x6003C5C")]
		[Address(RVA = "0x1875A6C", Offset = "0x1875A6C", VA = "0x1875A6C")]
		internal void _003CTryAskingAboutNotificationsCR_003Eb__0(bool granted)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Token(Token = "0x2000CC2")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x44408", Offset = "0x44408")]
	private struct _003CTryAskingAboutNotificationsCR_003Ed__42 : IAsyncStateMachine
	{
		[Token(Token = "0x4004565")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public int _003C_003E1__state;

		[Token(Token = "0x4004566")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public AsyncVoidMethodBuilder _003C_003Et__builder;

		[Token(Token = "0x4004567")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public WTGNotificationsManager _003C_003E4__this;

		[Token(Token = "0x4004568")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public bool landscape;

		[Token(Token = "0x4004569")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public string titleId;

		[Token(Token = "0x400456A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public string textId;

		[Token(Token = "0x400456B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private _003C_003Ec__DisplayClass42_0 _003C_003E8__1;

		[Token(Token = "0x400456C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		public UnityAction<bool> onDone;

		[Token(Token = "0x400456D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private bool _003ChasAskedNative_003E5__2;

		[Token(Token = "0x400456E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private TaskAwaiter _003C_003Eu__1;

		[Token(Token = "0x400456F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private TaskAwaiter<AuthorizationRequest> _003C_003Eu__2;

		[Token(Token = "0x6003C5D")]
		[Address(RVA = "0x1875D7C", Offset = "0x1875D7C", VA = "0x1875D7C", Slot = "4")]
		private void MoveNext()
		{
		}

		[Token(Token = "0x6003C5E")]
		[Address(RVA = "0x18764B0", Offset = "0x18764B0", VA = "0x18764B0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Token(Token = "0x2000CC3")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x44418", Offset = "0x44418")]
	private sealed class _003C_003Ec__DisplayClass49_0
	{
		[Token(Token = "0x4004570")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public UnityAction<bool> askingDone;

		[Token(Token = "0x6003C5F")]
		[Address(RVA = "0x1875A7C", Offset = "0x1875A7C", VA = "0x1875A7C")]
		public _003C_003Ec__DisplayClass49_0()
		{
		}

		[Token(Token = "0x6003C60")]
		[Address(RVA = "0x1875A84", Offset = "0x1875A84", VA = "0x1875A84")]
		internal void _003CShowCustomPopup_003Eb__0()
		{
		}

		[Token(Token = "0x6003C61")]
		[Address(RVA = "0x1875ADC", Offset = "0x1875ADC", VA = "0x1875ADC")]
		internal void _003CShowCustomPopup_003Eb__1()
		{
		}
	}

	[Token(Token = "0x4004551")]
	private const string HAS_SEEN_NATIVE_NOTIFICATIONS_POPUP = "NOTIFICATIONS_ENABLED";

	[Token(Token = "0x4004552")]
	private const string SESSION_COUNT = "NOTIFICATIONS_SESSION_COUNT";

	[Token(Token = "0x4004553")]
	private const int SCHEDULE_MINUTE_OFFSET = 0;

	[Token(Token = "0x4004554")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	[SerializeField]
	private int[] scheduleSequenceInDays;

	[Token(Token = "0x4004555")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	[AttributeAttribute(Name = "FormerlySerializedAsAttribute", RVA = "0x512F4", Offset = "0x512F4")]
	[SerializeField]
	public List<UserCriteria> userCriteriaNotCampaign;

	[Token(Token = "0x4004556")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	[SerializeField]
	public List<UserCriteria> userCriteriaCampaign;

	[Token(Token = "0x4004557")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	[AttributeAttribute(Name = "FormerlySerializedAsAttribute", RVA = "0x51350", Offset = "0x51350")]
	[SerializeField]
	private NotificationDefinitions notificationsDefs;

	[Token(Token = "0x4004558")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	private DateTime _lastOpenedTime;

	[Token(Token = "0x4004559")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	private string lastNotificationIdentifier;

	[Token(Token = "0x400455A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x5139C", Offset = "0x5139C")]
	private bool FromNotification__BackingField;

	[Token(Token = "0x400455B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x513AC", Offset = "0x513AC")]
	private string ActiveLink__BackingField;

	[Token(Token = "0x400455C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
	public string overrideLink;

	[Token(Token = "0x400455D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
	private bool dontCancelDebugNotifications;

	[Token(Token = "0x17000624")]
	public List<WTGNotification> AllNotifications
	{
		[Token(Token = "0x6003C32")]
		[Address(RVA = "0x174C0C4", Offset = "0x174C0C4", VA = "0x174C0C4")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000625")]
	public bool FromNotification
	{
		[Token(Token = "0x6003C33")]
		[Address(RVA = "0x174D0D0", Offset = "0x174D0D0", VA = "0x174D0D0")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6BA48", Offset = "0x6BA48")]
		get
		{
			return default;
		}
		[Token(Token = "0x6003C34")]
		[Address(RVA = "0x174D0D8", Offset = "0x174D0D8", VA = "0x174D0D8")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6BA58", Offset = "0x6BA58")]
		set
		{
		}
	}

	[Token(Token = "0x17000626")]
	public string ActiveLink
	{
		[Token(Token = "0x6003C35")]
		[Address(RVA = "0x174D0E0", Offset = "0x174D0E0", VA = "0x174D0E0")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6BA68", Offset = "0x6BA68")]
		get
		{
			return null;
		}
		[Token(Token = "0x6003C36")]
		[Address(RVA = "0x174D0E8", Offset = "0x174D0E8", VA = "0x174D0E8")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6BA78", Offset = "0x6BA78")]
		private set
		{
		}
	}

	[Token(Token = "0x17000627")]
	private AuthorizationStatus NotificationPermissionStatus
	{
		[Token(Token = "0x6003C37")]
		[Address(RVA = "0x174D0F0", Offset = "0x174D0F0", VA = "0x174D0F0")]
		get
		{
			return default;
		}
	}

	[Token(Token = "0x17000628")]
	public bool IsNotificationsEnabled
	{
		[Token(Token = "0x6003C38")]
		[Address(RVA = "0x174D160", Offset = "0x174D160", VA = "0x174D160")]
		get
		{
			return default;
		}
	}

	[Token(Token = "0x17000629")]
	public bool HasSeenNativeNotificationsPopup
	{
		[Token(Token = "0x6003C39")]
		[Address(RVA = "0x174D1D8", Offset = "0x174D1D8", VA = "0x174D1D8")]
		get
		{
			return default;
		}
		[Token(Token = "0x6003C3A")]
		[Address(RVA = "0x174D220", Offset = "0x174D220", VA = "0x174D220")]
		set
		{
		}
	}

	[Token(Token = "0x1700062A")]
	private static bool HasPermission
	{
		[Token(Token = "0x6003C4E")]
		[Address(RVA = "0x174ED20", Offset = "0x174ED20", VA = "0x174ED20")]
		get
		{
			return default;
		}
	}

	[Token(Token = "0x6003C3B")]
	[Address(RVA = "0x174D274", Offset = "0x174D274", VA = "0x174D274")]
	public void DisableNotifications()
	{
	}

	[Token(Token = "0x6003C3C")]
	[Address(RVA = "0x174D2C4", Offset = "0x174D2C4", VA = "0x174D2C4")]
	public void Reset()
	{
	}

	[Token(Token = "0x6003C3D")]
	[Address(RVA = "0x174D3B8", Offset = "0x174D3B8", VA = "0x174D3B8")]
	public void ResetAll()
	{
	}

	[Token(Token = "0x6003C3E")]
	[Address(RVA = "0x174D344", Offset = "0x174D344", VA = "0x174D344")]
	private IEnumerator ResetAsync(int saveslot = -1)
	{
		return null;
	}

	[Token(Token = "0x6003C3F")]
	[Address(RVA = "0x174D528", Offset = "0x174D528", VA = "0x174D528", Slot = "4")]
	protected override void OnInit()
	{
	}

	[Token(Token = "0x6003C40")]
	[Address(RVA = "0x174D7DC", Offset = "0x174D7DC", VA = "0x174D7DC")]
	private void RemoveBadges()
	{
	}

	[Token(Token = "0x6003C41")]
	[Address(RVA = "0x174D83C", Offset = "0x174D83C", VA = "0x174D83C")]
	private void OnApplicationQuit()
	{
	}

	[Token(Token = "0x6003C42")]
	[Address(RVA = "0x174D954", Offset = "0x174D954", VA = "0x174D954")]
	private void OnApplicationPause(bool paused)
	{
	}

	[Token(Token = "0x6003C43")]
	[Address(RVA = "0x174D8C8", Offset = "0x174D8C8", VA = "0x174D8C8")]
	private void OnQuit()
	{
	}

	[Token(Token = "0x6003C44")]
	[Address(RVA = "0x174D588", Offset = "0x174D588", VA = "0x174D588")]
	private void OnAppStart()
	{
	}

	[Token(Token = "0x6003C45")]
	[Address(RVA = "0x174E024", Offset = "0x174E024", VA = "0x174E024")]
	public bool HandleLastReceivedNotification()
	{
		return default;
	}

	[Token(Token = "0x6003C46")]
	[Address(RVA = "0x174E290", Offset = "0x174E290", VA = "0x174E290")]
	public static void TryAskForNotifications(bool landscapeMode, UnityAction onStart, UnityAction<bool> onDone, string title, string description)
	{
	}

	[Token(Token = "0x6003C47")]
	[Address(RVA = "0x174E4AC", Offset = "0x174E4AC", VA = "0x174E4AC")]
	[AttributeAttribute(Name = "ContextMenu", RVA = "0x6BA88", Offset = "0x6BA88")]
	private void DebugShow()
	{
	}

	[Token(Token = "0x6003C48")]
	[Address(RVA = "0x174E194", Offset = "0x174E194", VA = "0x174E194")]
	private bool TryGetLastRespondedNotification(out string link)
	{
		return default;
	}

	[Token(Token = "0x6003C49")]
	[Address(RVA = "0x174E0C0", Offset = "0x174E0C0", VA = "0x174E0C0")]
	private void CleanAllNotifications()
	{
	}

	[Token(Token = "0x6003C4A")]
	[Address(RVA = "0x174E3E0", Offset = "0x174E3E0", VA = "0x174E3E0")]
	private void TryAskingAboutNotificationsCR(bool landscape, UnityAction<bool> onDone, string titleId, string textId)
	{
	}

	[Token(Token = "0x6003C4B")]
	[Address(RVA = "0x174C36C", Offset = "0x174C36C", VA = "0x174C36C")]
	public static bool IsDebug()
	{
		return default;
	}

	[Token(Token = "0x6003C4C")]
	[Address(RVA = "0x174D9E8", Offset = "0x174D9E8", VA = "0x174D9E8")]
	[AttributeAttribute(Name = "ContextMenu", RVA = "0x6BAC0", Offset = "0x6BAC0")]
	public void PlanAllReminders()
	{
	}

	[Token(Token = "0x6003C4D")]
	[Address(RVA = "0x174E584", Offset = "0x174E584", VA = "0x174E584")]
	public bool ScheduleReminder(ScheduledNotification notification, bool debugNotifications = false)
	{
		return default;
	}

	[Token(Token = "0x6003C4F")]
	[Address(RVA = "0x174EDD0", Offset = "0x174EDD0", VA = "0x174EDD0")]
	private void ShowCustomPopup(bool landscape, string titleId, string textId, UnityAction<bool> askingDone)
	{
	}

	[Token(Token = "0x6003C50")]
	[Address(RVA = "0x174EF4C", Offset = "0x174EF4C", VA = "0x174EF4C")]
	public WTGNotificationsManager()
	{
	}

	[Token(Token = "0x6003C51")]
	[Address(RVA = "0x174F00C", Offset = "0x174F00C", VA = "0x174F00C")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6BAF8", Offset = "0x6BAF8")]
	private void _003COnAppStart_003Eb__35_0()
	{
	}
}
