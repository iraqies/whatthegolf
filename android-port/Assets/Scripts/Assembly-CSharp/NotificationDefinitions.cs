using System.Collections.Generic;
using UnityEngine;

public class NotificationDefinitions : MonoBehaviour
{
	[SerializeField]
	private List<UserCriteria> DailyChallengeNotificationCriteria;

	private Dictionary<OverworldButton2D, List<OverworldButton2D>> nextDoorsDictionary;

	private WTGNotificationsManager manager;

	private WTGNotificationsManager Manager => null;

	private List<WTGNotification> Notifications => null;

	private bool TryGetNotifications(ref List<WTGNotification> notifications)
	{
		return false;
	}

	public bool CanEnableDailyNotifications()
	{
		return false;
	}

	public List<WTGNotification> GetAllLocalNotifications()
	{
		return null;
	}
}
