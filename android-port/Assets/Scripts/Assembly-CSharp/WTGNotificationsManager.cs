using System;
using System.Collections;
using System.Collections.Generic;
using Unity.Notifications.iOS;
using UnityEngine;
using UnityEngine.Events;

public class WTGNotificationsManager : WTGSingleton<WTGNotificationsManager>
{
	private const string HAS_SEEN_NATIVE_NOTIFICATIONS_POPUP = "NOTIFICATIONS_ENABLED";

	private const string SESSION_COUNT = "NOTIFICATIONS_SESSION_COUNT";

	private const int SCHEDULE_MINUTE_OFFSET = 0;

	[SerializeField]
	private int[] scheduleSequenceInDays;

	[SerializeField]
	public List<UserCriteria> userCriteriaNotCampaign;

	[SerializeField]
	public List<UserCriteria> userCriteriaCampaign;

	[SerializeField]
	private NotificationDefinitions notificationsDefs;

	private DateTime _lastOpenedTime;

	private string lastNotificationIdentifier;

	public string overrideLink;

	private bool dontCancelDebugNotifications;

	public List<WTGNotification> AllNotifications => null;

	public bool FromNotification { get; set; }

	public string ActiveLink { get; private set; }

	private AuthorizationStatus NotificationPermissionStatus => AuthorizationStatus.NotDetermined;

	public bool IsNotificationsEnabled => false;

	public bool HasSeenNativeNotificationsPopup
	{
		get
		{
			return false;
		}
		set
		{
		}
	}

	private static bool HasPermission => false;

	public void DisableNotifications()
	{
	}

	public void Reset()
	{
	}

	public void ResetAll()
	{
	}

	private IEnumerator ResetAsync(int saveslot = -1)
	{
		return null;
	}

	protected override void OnInit()
	{
	}

	private void RemoveBadges()
	{
	}

	private void OnApplicationQuit()
	{
	}

	private void OnApplicationPause(bool paused)
	{
	}

	private void OnQuit()
	{
	}

	private void OnAppStart()
	{
	}

	public bool HandleLastReceivedNotification()
	{
		return false;
	}

	public static void TryAskForNotifications(bool landscapeMode, UnityAction onStart, UnityAction<bool> onDone, string title, string description)
	{
	}

	private void DebugShow()
	{
	}

	private bool TryGetLastRespondedNotification(out string link)
	{
		link = null;
		return false;
	}

	private void CleanAllNotifications()
	{
	}

	private void TryAskingAboutNotificationsCR(bool landscape, UnityAction<bool> onDone, string titleId, string textId)
	{
	}

	public static bool IsDebug()
	{
		return false;
	}

	public void PlanAllReminders()
	{
	}

	public bool ScheduleReminder(ScheduledNotification notification, bool debugNotifications = false)
	{
		return false;
	}

	private void ShowCustomPopup(bool landscape, string titleId, string textId, UnityAction<bool> askingDone)
	{
	}
}
