using UnityEngine;
using UnityEngine.Events;

public class NotificationPopupOnHit : MonoBehaviour
{
	public UnityEvent OnAskedForNotification;

	public void ShowNotificationPopup()
	{
		DisableInteraction();
		if (LevelNotificationManager.Instance != null)
		{
			LevelNotificationManager.Instance.ScheduleLevelNotification(EnableInteraction);
		}
		else
		{
			EnableInteraction(false);
		}
		OnAskedForNotification?.Invoke();
	}

	private void EnableInteraction(bool _)
	{
		if (OverworldManager2d.Instance != null)
			OverworldManager2d.Instance.EnableInteraction();
	}

	private void DisableInteraction()
	{
		if (OverworldManager2d.Instance != null)
			OverworldManager2d.Instance.DisableInteraction(false);
	}
}
