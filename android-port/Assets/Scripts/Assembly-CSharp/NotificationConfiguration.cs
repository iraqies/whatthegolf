using System.Collections.Generic;
using UnityEngine;

public class NotificationConfiguration : ScriptableObject
{
	[SerializeField]
	private List<WTGNotification> notifications;

	public List<WTGNotification> Notifications => null;
}
