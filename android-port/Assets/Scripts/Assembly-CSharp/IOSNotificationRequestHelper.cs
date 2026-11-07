using System.Threading.Tasks;
using Unity.Notifications.iOS;

public static class IOSNotificationRequestHelper
{
	public static Task<bool> IsAppleReachable()
	{
		return null;
	}

	private static void WaitForTimeOut(TaskCompletionSource<bool> tcs)
	{
	}

	private static void SendWebRequest(TaskCompletionSource<bool> tcs)
	{
	}

	public static Task<AuthorizationRequest> AwaitAuthRequest()
	{
		return null;
	}

	public static string DeviceUniqueIdentifier()
	{
		return null;
	}
}
