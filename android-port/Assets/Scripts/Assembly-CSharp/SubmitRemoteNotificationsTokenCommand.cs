using System.Threading.Tasks;
using UnityEngine;

public class SubmitRemoteNotificationsTokenCommand
{
	private readonly string _pushNotificationToken;

	private string _deviceId;

	public SubmitRemoteNotificationsTokenCommand(string pushNotificationToken)
	{
	}

	public void Execute()
	{
	}

	private void UploadToken()
	{
	}

	private Task SendWebRequest(WWWForm form)
	{
		return null;
	}
}
