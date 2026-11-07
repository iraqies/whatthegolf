using System.Threading.Tasks;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class NotificationDataHandler : WTGSingleton<NotificationDataHandler>
{
	[SerializeField]
	private Button sendButton;

	[SerializeField]
	private Button closeButton;

	[SerializeField]
	private TMP_Text sendButtonText;

	private string lastUrl;

	public void OnOpenedFromNotification(string url)
	{
	}

	public Task OnOpenedFromNotification(WTGNotification notification, bool returnFromAppUpdate = false)
	{
		return null;
	}

	private Task HandleValidNotification(WTGNotification notification)
	{
		return null;
	}

	private void HandleInvalidNotification(WTGNotification notification, bool isOnBoardingComplete, bool returnFromAppUpdate)
	{
	}

	private Task PromptAppUpdate(string notificationId)
	{
		return null;
	}
}
